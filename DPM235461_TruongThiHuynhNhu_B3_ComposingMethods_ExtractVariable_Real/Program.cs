using System;

namespace DPM235461_TruongThiHuynhNhu_B3_ComposingMethods_ExtractVariable_Real
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EXTRACT VARIABLE: REAL (TÍNH GIÁ PHÂN BÓN) ===");
            double tongTien = TinhTienPhanBon(120, 250000);
            Console.WriteLine("Tổng giá trị lô hàng phân bón: " + tongTien.ToString("N0") + " VNĐ");
            Console.ReadLine();
        }

        public static double TinhTienPhanBon(int soBao, double giaBao)
        {
            bool isDaiLyVip = soBao >= 100;
            double tienGoc = soBao * giaBao;
            double chietKhauVip = isDaiLyVip ? tienGoc * 0.1 : 0;
            double phiVanChuyenXeTai = isDaiLyVip ? 0 : 200000;

            return tienGoc - chietKhauVip + phiVanChuyenXeTai;
        }
    }
}