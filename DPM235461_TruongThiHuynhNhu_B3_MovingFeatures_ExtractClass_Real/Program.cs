using System;

namespace DPM235461_TruongThiHuynhNhu_B3_MovingFeatures_ExtractClass_Real
{
    public class DiaChiGiaoHang
    {
        public string TinhThanh { get; set; } = "An Giang";
        public string DiaChiChiTiet { get; set; } = "Thành phố Long Xuyên";
        public string LayDiaChiDayDu() => $"{DiaChiChiTiet}, {TinhThanh}";
    }

    public class DonHangNongDuoc
    {
        public string MaDonHang { get; set; } = "DH_2026_001";
        public DiaChiGiaoHang DiaChi { get; set; } = new DiaChiGiaoHang();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EXTRACT CLASS: REAL (ĐỊA CHỈ GIAO HÀNG ĐƠN NÔNG DƯỢC) ===");
            DonHangNongDuoc dh = new DonHangNongDuoc();
            Console.WriteLine($"Mã đơn: {dh.MaDonHang} | ĐC Giao: {dh.DiaChi.LayDiaChiDayDu()}");
            Console.ReadLine();
        }
    }
}