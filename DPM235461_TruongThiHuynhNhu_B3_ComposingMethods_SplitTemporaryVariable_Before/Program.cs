using System;

namespace DPM235461_TruongThiHuynhNhu_B3_ComposingMethods_SplitTemporaryVariable_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SPLIT TEMPORARY VARIABLE: BEFORE ===");
            double height = 10, width = 20;

            double temp = 2 * (height + width);
            Console.WriteLine("Chu vi kho: " + temp);

            temp = height * width;
            Console.WriteLine("Diện tích kho: " + temp);
            Console.ReadLine();
        }
    }
}