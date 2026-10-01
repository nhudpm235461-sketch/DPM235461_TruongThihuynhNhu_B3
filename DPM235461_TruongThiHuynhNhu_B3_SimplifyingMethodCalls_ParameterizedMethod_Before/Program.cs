using System;

namespace DPM235461_TruongThiHuynhNhu_B3_SimplifyingMethodCalls_ParameterizedMethod_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PARAMETERIZED METHOD: BEFORE ===");
            double salary = 10000000;
            RaiseFivePercent(ref salary);
            Console.WriteLine("Lương sau tăng 5%: " + salary.ToString("N0") + " VNĐ");
            Console.ReadLine();
        }

        public static void RaiseFivePercent(ref double salary) => salary *= 1.05;
    }
}