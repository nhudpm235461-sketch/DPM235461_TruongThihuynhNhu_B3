using System;

namespace DPM235461_TruongThiHuynhNhu_B3_ComposingMethods_ReplaceTempWithQuery_After
{
    class Program
    {
        private static int _quantity = 100;
        private static double _itemPrice = 45000;

        static void Main(string[] args)
        {
            Console.WriteLine("=== REPLACE TEMP WITH QUERY: AFTER ===");
            Console.WriteLine("Giá hóa đơn: " + GetPrice().ToString("N0") + " VNĐ");
            Console.ReadLine();
        }

        public static double GetPrice() => BasePrice() * DiscountFactor();
        private static double BasePrice() => _quantity * _itemPrice;
        private static double DiscountFactor() => BasePrice() > 1000000 ? 0.95 : 0.98;
    }
}