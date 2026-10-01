using System;

namespace DPM235461_TruongThiHuynhNhu_B3_ComposingMethods_SplitTemporaryVariable_After
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SPLIT TEMPORARY VARIABLE: AFTER ===");
            double height = 10, width = 20;

            double perimeter = 2 * (height + width);
            Console.WriteLine("Chu vi kho: " + perimeter);

            double area = height * width;
            Console.WriteLine("Diện tích kho: " + area);
            Console.ReadLine();
        }
    }
}