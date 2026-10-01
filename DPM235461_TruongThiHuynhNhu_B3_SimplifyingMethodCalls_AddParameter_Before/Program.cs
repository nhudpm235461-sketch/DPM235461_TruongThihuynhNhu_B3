using System;

namespace DPM235461_TruongThiHuynhNhu_B3_SimplifyingMethodCalls_AddParameter_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ADD PARAMETER: BEFORE ===");
            Console.WriteLine("Giá chuẩn: " + GetPrice());
            Console.ReadLine();
        }

        public static double GetPrice() => 100000;
    }
}