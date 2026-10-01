using System;

namespace DPM235461_TruongThiHuynhNhu_B3_SimplifyingMethodCalls_RenameMethod_Real
{
    public class QuanLyHoaDon
    {
        // Đổi tên phương thức 'Proc()' thành 'TinhTongTienHoaDonVaThue()' cho rõ ý nghĩa nghiệp vụ
        public double TinhTongTienHoaDonVaThue(double tienHang, double thueVat)
        {
            return tienHang + (tienHang * thueVat);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== RENAME METHOD: REAL (ĐỔI TÊN HÀM RÕ NGHĨA NGHIỆP VỤ HÓA ĐƠN) ===");
            QuanLyHoaDon ql = new QuanLyHoaDon();
            double tong = ql.TinhTongTienHoaDonVaThue(5000000, 0.1);
            Console.WriteLine("Tổng hóa đơn thanh toán: " + tong.ToString("N0") + " VNĐ");
            Console.ReadLine();
        }
    }
}