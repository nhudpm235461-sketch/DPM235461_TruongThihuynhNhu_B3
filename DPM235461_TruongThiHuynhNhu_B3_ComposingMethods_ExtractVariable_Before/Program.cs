using System;

namespace DPM235461_TruongThiHuynhNhu_B3_ComposingMethods_ExtractVariable_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EXTRACT VARIABLE: BEFORE ===");
            double total = CalculateTotal(600, 50000);
            Console.WriteLine("Tổng chi phí: " + total.ToString("N0") + " VNĐ");
            Console.ReadLine();
        }

        public static double CalculateTotal(int quantity, double itemPrice)
        {
            return quantity * itemPrice - Math.Max(0, quantity - 500) * itemPrice * 0.05 + Math.Min(quantity * itemPrice * 0.1, 100000.0);
        }
    }
}