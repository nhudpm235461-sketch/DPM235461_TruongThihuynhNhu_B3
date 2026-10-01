using System;

namespace DPM235461_TruongThiHuynhNhu_B3_SimplifyingMethodCalls_RemoveParameter_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== REMOVE PARAMETER: BEFORE ===");
            Console.WriteLine("Giá sau giảm: " + GetDiscount(500000, true));
            Console.ReadLine();
        }

        public static double GetDiscount(double price, bool unusedParam) => price * 0.9;
    }
}