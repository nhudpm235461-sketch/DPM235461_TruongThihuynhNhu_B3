using System;

namespace DPM235461_TruongThiHuynhNhu_B3_ComposingMethods_InlineTemp_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INLINE TEMP: BEFORE ===");
            double basePrice = GetBasePrice();
            bool isOver = basePrice > 1000;
            Console.WriteLine("Đơn hàng > 1000k? " + isOver);
            Console.ReadLine();
        }

        public static double GetBasePrice() => 1200;
    }
}