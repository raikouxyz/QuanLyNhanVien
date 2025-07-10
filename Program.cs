using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanVien.Database;
using QuanLyNhanVien.Views;

namespace QuanLyNhanVien
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Kiểm tra tham số dòng lệnh để seed dữ liệu
            if (args.Length > 0 && args[0].ToLower() == "--seed")
            {
                SeedData();
                return;
            }

            Application.Run(new FormMain());
        }

        /// <summary>
        /// Seed dữ liệu mẫu cho database
        /// </summary>
        private static void SeedData()
        {
            try
            {
                Console.WriteLine("Bắt đầu seed dữ liệu mẫu...");
                
                using (var context = new AppDbContext())
                {
                    var seeder = new Seeder(context);
                    seeder.SeedAllData(100);
                }
                
                Console.WriteLine("Seed dữ liệu hoàn tất! Nhấn Enter để thoát...");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi seed dữ liệu: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Nhấn Enter để thoát...");
                Console.ReadLine();
            }
        }
    }
}
