using System;

namespace nguyen_dang_khoa__24810320210
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            quanlyphuongtien ql = new quanlyphuongtien();

            try
            {
                ql.AddPhuongTien(new oto("OT001", "Toyota", 2022, 800000000m, 5, 2.0));
                ql.AddPhuongTien(new oto("OT002", "Ford Transit", 2021, 950000000m, 16, 2.2));
                ql.AddPhuongTien(new xemay("XM001", "Honda", 2023, 40000000m, 125));
                ql.AddPhuongTien(new xemay("XM002", "Yamaha", 2022, 90000000m, 300));

                ql.DisplayAll();

                var xeMax = ql.FindMaxGiaLanBanh();
                if (xeMax != null)
                {
                    Console.WriteLine("\n=== PHƯƠNG TIỆN CÓ GIÁ LĂN BÁNH CAO NHẤT ===");
                    Console.WriteLine(xeMax.GetInfo());
                }

                string tuKhoa = "Honda";
                Console.WriteLine($"\n=== KẾT QUẢ TÌM KIẾM HÃNG '{tuKhoa}' ===");
                var ketQua = ql.SearchByName(tuKhoa);
                foreach (var pt in ketQua)
                {
                    Console.WriteLine(pt.GetInfo());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}