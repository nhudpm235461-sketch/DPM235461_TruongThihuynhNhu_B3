using System;

namespace DPM235461_TruongThiHuynhNhu_B3_SimplifyingMethodCalls_AddParameter_After
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ADD PARAMETER: AFTER ===");
            Console.WriteLine("Giá sau thuế 10%: " + GetPrice(0.1));
            Console.ReadLine();
        }

        public static double GetPrice(double taxRate) => 100000 * (1 + taxRate);
    }
}