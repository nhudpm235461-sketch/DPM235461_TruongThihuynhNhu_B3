using System;

namespace DPM235461_TruongThiHuynhNhu_B3_ComposingMethods_ReplaceTempWithQuery_Before
{
    class Program
    {
        private static int _quantity = 100;
        private static double _itemPrice = 45000;

        static void Main(string[] args)
        {
            Console.WriteLine("=== REPLACE TEMP WITH QUERY: BEFORE ===");
            double basePrice = _quantity * _itemPrice;
            double discountFactor;
            if (basePrice > 1000000) discountFactor = 0.95;
            else discountFactor = 0.98;

            double totalPrice = basePrice * discountFactor;
            Console.WriteLine("Giá hóa đơn: " + totalPrice.ToString("N0") + " VNĐ");
            Console.ReadLine();
        }
    }
}