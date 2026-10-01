using System;

namespace DPM235461_TruongThiHuynhNhu_B3_SimplifyingConditionals_DecomposeConditional_Real
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DECOMPOSE CONDITIONAL: REAL (TÁCH BIỂU THỨC CHIẾT KHẤU MÙA VỤ) ===");
            DateTime ngayLap = DateTime.Now;
            double giaBan = IsMuaCaoDiem(ngayLap) ? TinhGiaMuaCaoDiem(100000) : TinhGiaMuaThuong(100000);
            Console.WriteLine("Giá bán nông dược thời điểm hiện tại: " + giaBan.ToString("N0") + " VNĐ");
            Console.ReadLine();
        }

        private static bool IsMuaCaoDiem(DateTime date) => date.Month >= 4 && date.Month <= 8;
        private static double TinhGiaMuaCaoDiem(double gia) => gia * 1.05;
        private static double TinhGiaMuaThuong(double gia) => gia * 0.95;
    }
}