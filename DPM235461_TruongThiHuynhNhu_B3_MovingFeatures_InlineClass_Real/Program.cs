using System;

namespace DPM235461_TruongThiHuynhNhu_B3_MovingFeatures_InlineClass_Real
{
    public class KhachHangNongDuoc
    {
        public string TenKhachHang { get; set; } = "Đại lý An Giang";
        public string MaSoThue { get; set; } = "1600123456";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INLINE CLASS: REAL (GỘP THÔNG TIN MÃ SỐ THUẾ KHÁCH HÀNG) ===");
            KhachHangNongDuoc kh = new KhachHangNongDuoc();
            Console.WriteLine($"Khách hàng: {kh.TenKhachHang} | MST: {kh.MaSoThue}");
            Console.ReadLine();
        }
    }
}