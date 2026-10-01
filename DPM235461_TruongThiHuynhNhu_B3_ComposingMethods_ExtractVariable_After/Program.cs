using System;

namespace DPM235461_TruongThiHuynhNhu_B3_ComposingMethods_ExtractVariable_After
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EXTRACT VARIABLE: AFTER ===");
            double total = CalculateTotal(600, 50000);
            Console.WriteLine("Tổng chi phí: " + total.ToString("N0") + " VNĐ");
            Console.ReadLine();
        }

        public static double CalculateTotal(int quantity, double itemPrice)
        {
            double basePrice = quantity * itemPrice;
            double quantityDiscount = Math.Max(0, quantity - 500) * itemPrice * 0.05;
            double shippingFee = Math.Min(basePrice * 0.1, 100000.0);

            return basePrice - quantityDiscount + shippingFee;
        }
    }
}