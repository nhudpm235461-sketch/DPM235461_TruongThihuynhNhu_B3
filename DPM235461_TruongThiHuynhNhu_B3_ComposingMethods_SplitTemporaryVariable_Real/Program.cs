using System;

namespace DPM235461_TruongThiHuynhNhu_B3_ComposingMethods_SplitTemporaryVariable_Real
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SPLIT TEMPORARY VARIABLE: REAL (TÍNH PHÍ VẬN CHUYỂN & DỊCH VỤ) ===");
            double giaTriDonHang = 10000000;

            double phiVanChuyenQuocLo = giaTriDonHang * 0.02;
            Console.WriteLine("Phí vận chuyển: " + phiVanChuyenQuocLo.ToString("N0") + " VNĐ");

            double phiBaoHiemHangHoa = giaTriDonHang * 0.005;
            Console.WriteLine("Phí bảo hiểm hàng hóa: " + phiBaoHiemHangHoa.ToString("N0") + " VNĐ");

            Console.ReadLine();
        }
    }
}