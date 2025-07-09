using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QuanLyNhanVien.Models;
using System.ComponentModel;
using QuanLyNhanVien.Database;
using QuanLyNhanVien.Services;

namespace QuanLyNhanVien.Views
{
    public partial class FormDangKy : Form
    {
        private readonly AppDbContext _context;
        private int? selectedUserId = null; // ID của user được chọn để sửa

        public FormDangKy()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        /// <summary>
        /// Khởi tạo form và load dữ liệu ban đầu
        /// </summary>
        private async void FormDangKy_Load(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra và sửa chữa tài khoản admin nếu cần
                await FixAdminAccountIfNeeded();
                
                // Khởi tạo ComboBox vai trò
                InitializeRoleComboBox();
                
                // Load danh sách người dùng
                await LoadUsers();
                
                // Đặt trạng thái ban đầu
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi khởi tạo form: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Kiểm tra và sửa chữa tài khoản admin nếu có vấn đề
        /// </summary>
        private async Task FixAdminAccountIfNeeded()
        {
            try
            {
                var adminUser = await _context.Users.FirstOrDefaultAsync(u => u.Username == "admin");
                if (adminUser != null)
                {
                    bool needUpdate = false;
                    
                    // Đảm bảo admin có role Admin
                    if (adminUser.Role != UserRole.Admin)
                    {
                        adminUser.Role = UserRole.Admin;
                        needUpdate = true;
                    }
                    
                    // Đảm bảo admin được kích hoạt
                    if (!adminUser.IsActive)
                    {
                        adminUser.IsActive = true;
                        needUpdate = true;
                    }
                    
                    if (needUpdate)
                    {
                        await _context.SaveChangesAsync();
                        MessageBox.Show("Đã sửa chữa tài khoản admin về trạng thái chính xác!", "Thông báo", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi kiểm tra tài khoản admin: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Khởi tạo ComboBox vai trò với các lựa chọn
        /// </summary>
        private void InitializeRoleComboBox()
        {
            var roles = new List<object>
            {
                new { Value = "Admin", Text = "Quản trị viên" },
                new { Value = "HR", Text = "Nhân sự" },
                new { Value = "ViewOnly", Text = "Chỉ xem dữ liệu" }
            };

            cmbRole.DisplayMember = "Text";
            cmbRole.ValueMember = "Value";
            cmbRole.DataSource = roles;
            cmbRole.SelectedIndex = 0; // Mặc định chọn Admin
        }

        /// <summary>
        /// Load danh sách người dùng từ database
        /// </summary>
        private async Task LoadUsers()
        {
            try
            {
                // Lấy danh sách user từ database, sắp xếp theo tên đăng nhập
                var users = await _context.Users
                    .OrderBy(u => u.Username)
                    .Select(u => new
                    {
                        u.Id,
                        u.Username,
                        u.FullName,
                        u.Email,
                        u.Role,
                        IsActive = u.IsActive ? "Hoạt động" : "Không hoạt động",
                        CreatedDate = u.CreatedDate.ToString("dd/MM/yyyy")
                    })
                    .ToListAsync();

                // Gán dữ liệu vào DataGridView
                dgvUsers.DataSource = users;

                // Tùy chỉnh hiển thị cột
                if (dgvUsers.Columns.Count > 0)
                {
                    dgvUsers.Columns["Id"].Visible = false; // Ẩn cột ID
                    dgvUsers.Columns["Username"].HeaderText = "Tên đăng nhập";
                    dgvUsers.Columns["FullName"].HeaderText = "Họ tên";
                    dgvUsers.Columns["Email"].HeaderText = "Email";
                    dgvUsers.Columns["Role"].HeaderText = "Vai trò";
                    dgvUsers.Columns["IsActive"].HeaderText = "Trạng thái";
                    dgvUsers.Columns["CreatedDate"].HeaderText = "Ngày tạo";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách người dùng: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Đặt lại form về trạng thái ban đầu
        /// </summary>
        private void ResetForm()
        {
            selectedUserId = null;
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtFullName.Clear();
            txtEmail.Clear();
            cmbRole.SelectedIndex = 0;
            chkIsActive.Checked = true;
            
            // Bật lại textbox username
            txtUsername.Enabled = true;
            
            // Bỏ chọn dòng trong DataGridView
            dgvUsers.ClearSelection();
        }

        /// <summary>
        /// Xử lý sự kiện click nút Thêm mới
        /// </summary>
        private async void btnThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate dữ liệu đầu vào
                if (!ValidateInput())
                    return;

                // Tạo người dùng mới
                var result = await CreateNewUser();
                if (result)
                {
                    // Reset form và reload dữ liệu
                    ResetForm();
                    await LoadUsers();

                    MessageBox.Show("Thêm người dùng thành công!", 
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Xử lý sự kiện click nút Làm mới (đổi tên từ Hủy)
        /// </summary>
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        /// <summary>
        /// Xử lý sự kiện thay đổi selection trong DataGridView
        /// </summary>
        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                var selectedRow = dgvUsers.SelectedRows[0];
                selectedUserId = (int)selectedRow.Cells["Id"].Value;

                // Load thông tin user vào form
                LoadUserToForm(selectedUserId.Value);
            }
        }

        /// <summary>
        /// Load thông tin user vào form để chỉnh sửa
        /// </summary>
        private async void LoadUserToForm(int userId)
        {
            try
            {
                var user = await _context.Users.FindAsync(userId);
                if (user != null)
                {
                    txtUsername.Text = user.Username;
                    txtUsername.Enabled = false; // Không cho phép sửa username
                    txtPassword.Clear(); // Không hiển thị mật khẩu
                    txtConfirmPassword.Clear();
                    txtFullName.Text = user.FullName;
                    txtEmail.Text = user.Email;
                    
                    // Chọn role tương ứng
                    for (int i = 0; i < cmbRole.Items.Count; i++)
                    {
                        var item = cmbRole.Items[i];
                        var roleValue = ((dynamic)item).Value;
                        if (roleValue == user.Role.ToString())
                        {
                            cmbRole.SelectedIndex = i;
                            break;
                        }
                    }
                    
                    chkIsActive.Checked = user.IsActive;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load thông tin người dùng: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Xử lý sự kiện click nút Sửa (trong danh sách)
        /// </summary>
        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn người dùng cần sửa!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Validate dữ liệu đầu vào
                if (!ValidateInput())
                    return;

                // Cập nhật thông tin người dùng
                var result = await UpdateUser();
                if (result)
                {
                    // Reset form và reload dữ liệu
                    ResetForm();
                    await LoadUsers();

                    MessageBox.Show("Cập nhật người dùng thành công!", 
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Validate dữ liệu đầu vào
        /// </summary>
        private bool ValidateInput()
        {
            // Kiểm tra các trường bắt buộc
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            // Chỉ kiểm tra mật khẩu bắt buộc khi tạo mới (selectedUserId == null)
            if (string.IsNullOrWhiteSpace(txtPassword.Text) && selectedUserId == null)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            // Kiểm tra mật khẩu xác nhận chỉ khi có nhập mật khẩu
            if (!string.IsNullOrWhiteSpace(txtPassword.Text) && txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return false;
            }

            // Validate email
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Kiểm tra email hợp lệ
        /// </summary>
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Tạo người dùng mới
        /// </summary>
        private async Task<bool> CreateNewUser()
        {
            // Kiểm tra username đã tồn tại chưa
            var existingUser = await _context.Users
                .FirstOrDefaultAsync(u => u.Username == txtUsername.Text.Trim());

            if (existingUser != null)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Tạo user mới
            var newUser = new User
            {
                Username = txtUsername.Text.Trim(),
                Password = AuthService.HashPassword(txtPassword.Text),
                FullName = txtFullName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Role = (UserRole)Enum.Parse(typeof(UserRole), cmbRole.SelectedValue.ToString()),
                IsActive = chkIsActive.Checked,
                CreatedDate = DateTime.Now
            };

            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Cập nhật thông tin người dùng
        /// </summary>
        private async Task<bool> UpdateUser()
        {
            var user = await _context.Users.FindAsync(selectedUserId);
            if (user == null)
            {
                MessageBox.Show("Không tìm thấy người dùng!", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra đặc biệt cho tài khoản admin mặc định
            if (user.Username == "admin")
            {
                // Không cho phép thay đổi role của admin mặc định
                if (cmbRole.SelectedValue.ToString() != "Admin")
                {
                    MessageBox.Show("Không thể thay đổi vai trò của tài khoản admin mặc định!", "Cảnh báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                
                // Không cho phép vô hiệu hóa tài khoản admin mặc định
                if (!chkIsActive.Checked)
                {
                    MessageBox.Show("Không thể vô hiệu hóa tài khoản admin mặc định!", "Cảnh báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            // Cập nhật thông tin
            user.FullName = txtFullName.Text.Trim();
            user.Email = txtEmail.Text.Trim();
            user.Role = (UserRole)Enum.Parse(typeof(UserRole), cmbRole.SelectedValue.ToString());
            user.IsActive = chkIsActive.Checked;

            // Cập nhật mật khẩu nếu có thay đổi
            if (!string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                user.Password = AuthService.HashPassword(txtPassword.Text);
            }

            await _context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Xử lý sự kiện click nút Xóa
        /// </summary>
        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn người dùng cần xóa!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvUsers.SelectedRows[0];
            var userId = (int)selectedRow.Cells["Id"].Value;
            var username = selectedRow.Cells["Username"].Value.ToString();

            // Không cho phép xóa tài khoản admin mặc định
            if (username == "admin")
            {
                MessageBox.Show("Không thể xóa tài khoản admin mặc định!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận xóa
            var result = MessageBox.Show($"Bạn có chắc chắn muốn xóa người dùng '{username}'?", 
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var user = await _context.Users.FindAsync(userId);
                    if (user != null)
                    {
                        _context.Users.Remove(user);
                        await _context.SaveChangesAsync();

                        MessageBox.Show("Xóa người dùng thành công!", "Thông báo", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ResetForm();
                        await LoadUsers();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa người dùng: {ex.Message}", "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
} 