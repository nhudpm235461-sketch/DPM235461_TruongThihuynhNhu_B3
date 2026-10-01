using System;

namespace DPM235461_TruongThiHuynhNhu_B3_ComposingMethods_InlineTemp_After
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INLINE TEMP: AFTER ===");
            Console.WriteLine("Đơn hàng > 1000k? " + (GetBasePrice() > 1000));
            Console.ReadLine();
        }

        public static double GetBasePrice() => 1200;
    }
}