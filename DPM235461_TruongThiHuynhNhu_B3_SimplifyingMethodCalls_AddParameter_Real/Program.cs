using System;

namespace DPM235461_TruongThiHuynhNhu_B3_SimplifyingMethodCalls_AddParameter_Real
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ADD PARAMETER: REAL (THÊM PHÍ VẬN CHUYỂN VÀO HÀM TÍNH TỔNG) ===");
            double tong = TinhTongHoaDon(2000000, 50000);
            Console.WriteLine("Tổng thanh toán: " + tong.ToString("N0") + " VNĐ");
            Console.ReadLine();
        }

        public static double TinhTongHoaDon(double tienHang, double phiVanChuyen)
        {
            return tienHang + phiVanChuyen;
        }
    }
}