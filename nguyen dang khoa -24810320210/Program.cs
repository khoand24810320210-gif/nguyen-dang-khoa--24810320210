using System;

namespace nguyen_dang_khoa__24810320210
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            quanlyphuongtien ql = new quanlyphuongtien();

            Console.WriteLine("=================== KẾT QUẢ KIỂM THỬ (TEST CASES) ===================\n");

            // --- TC01: Kiểm tra Validation Năm sản xuất (Năm 1850 -> Kỳ vọng ném ngoại lệ) ---
            Console.WriteLine("--- TC01: Kiểm tra Validation NamSanXuat = 1850 ---");
            try
            {
                oto xeLoi = new oto("OT_ERR", "Test", 1850, 500000000m, 5, 2.0);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"[BẮT LỖI THÀNH CÔNG]: {ex.Message}");
            }

            Console.WriteLine("\n-------------------------------------------------------------------\n");

            // --- TC02, TC03, TC04: Thêm dữ liệu theo đúng Test Case ---
            try
            {
                // TC02: Ô tô 5 chỗ, Giá gốc 1 Tỷ (Giá lăn bánh kỳ vọng: 1.42 Tỷ)
                oto oto5Cho = new oto("OT001", "Toyota", 2022, 1000000000m, 5, 2.0);

                // TC03: Xe máy 150cc, Giá gốc 50 Triệu (Giá lăn bánh kỳ vọng: 51 Triệu)
                xemay xeMay150 = new xemay("XM001", "Honda", 2023, 50000000m, 150);

                // Xe máy bổ sung & Ô tô khách
                xemay xeMay300 = new xemay("XM002", "Yamaha", 2022, 90000000m, 300);
                oto oto16Cho = new oto("OT002", "Ford Transit", 2021, 950000000m, 16, 2.2);

                
                ql.AddPhuongTien(oto5Cho);
                ql.AddPhuongTien(xeMay150);
                ql.AddPhuongTien(xeMay300);
                ql.AddPhuongTien(oto16Cho);

                // Hiển thị danh sách
                ql.DisplayAll();

                Console.WriteLine("\n-------------------------------------------------------------------\n");

                
                Console.WriteLine("--- TC05: Tìm Phương Tiện Có Giá Lăn Bánh Cao Nhất ---");
                var xeMax = ql.FindMaxGiaLanBanh();
                if (xeMax != null)
                {
                    Console.WriteLine(xeMax.GetInfo());
                }

                Console.WriteLine("\n-------------------------------------------------------------------\n");

                
                string tuKhoa = "Honda";
                Console.WriteLine($"--- TÌM KIẾM THEO HÃNG '{tuKhoa}' ---");
                var ketQua = ql.SearchByName(tuKhoa);
                foreach (var pt in ketQua)
                {
                    Console.WriteLine(pt.GetInfo());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi hệ thống: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}