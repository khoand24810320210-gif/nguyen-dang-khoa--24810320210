using System;

namespace nguyen_dang_khoa__24810320210
{
    public class xemay : phuongtien
    {
        private int _dungTichXylanh;

        public int DungTichXylanh
        {
            get => _dungTichXylanh;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Dung tích xi-lanh phải lớn hơn 0!");
                _dungTichXylanh = value;
            }
        }

        public xemay(string maPT, string tenHang, int namSanXuat, decimal giaGoc, int dungTichXylanh)
            : base(maPT, tenHang, namSanXuat, giaGoc)
        {
            DungTichXylanh = dungTichXylanh;
        }

        public override decimal TinhGiaLanBanh()
        {
            if (DungTichXylanh < 175)
            {
                return GiaGoc + (GiaGoc * 0.02m);
            }
            else
            {
                return GiaGoc + (GiaGoc * 0.05m);
            }
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $" | Dung tích xilanh: {DungTichXylanh}cc | Giá lăn bánh: {TinhGiaLanBanh():N0} VNĐ";
        }
    }
}