using System;

namespace DPM235461_TruongThiHuynhNhu_B3_SimplifyingConditionals_DecomposeConditional_After
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DECOMPOSE CONDITIONAL: AFTER ===");
            DateTime today = DateTime.Now;
            double charge = IsWinter(today) ? WinterCharge(100) : SummerCharge(100);
            Console.WriteLine("Cước phí: " + charge);
            Console.ReadLine();
        }

        private static bool IsWinter(DateTime date) => date.Month < 6 || date.Month > 8;
        private static double WinterCharge(double qty) => qty * 12;
        private static double SummerCharge(double qty) => qty * 10;
    }
}