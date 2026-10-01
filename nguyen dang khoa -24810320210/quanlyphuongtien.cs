using System;
using System.Collections.Generic;
using System.Linq;

namespace nguyen_dang_khoa__24810320210
{
    public class quanlyphuongtien
    {
        private List<phuongtien> _danhSach = new List<phuongtien>();

        public void AddPhuongTien(phuongtien pt)
        {
            _danhSach.Add(pt);
        }

        public void DisplayAll()
        {
            Console.WriteLine("\n=== DANH SÁCH TOÀN BỘ PHƯƠNG TIỆN ===");
            foreach (var pt in _danhSach)
            {
                Console.WriteLine(pt.GetInfo());
            }
        }

        public phuongtien FindMaxGiaLanBanh()
        {
            if (_danhSach.Count == 0) return null;
            return _danhSach.OrderByDescending(pt => pt.TinhGiaLanBanh()).FirstOrDefault();
        }

        public List<phuongtien> SearchByName(string keyword)
        {
            return _danhSach
                .Where(pt => pt.TenHang.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}