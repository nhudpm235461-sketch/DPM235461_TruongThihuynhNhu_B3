using System;

namespace DPM235461_TruongThiHuynhNhu_B3_SimplifyingMethodCalls_RemoveParameter_After
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== REMOVE PARAMETER: AFTER ===");
            Console.WriteLine("Giá sau giảm: " + GetDiscount(500000));
            Console.ReadLine();
        }

        public static double GetDiscount(double price) => price * 0.9;
    }
}