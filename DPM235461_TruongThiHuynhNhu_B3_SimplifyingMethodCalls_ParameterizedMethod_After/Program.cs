using System;

namespace DPM235461_TruongThiHuynhNhu_B3_SimplifyingMethodCalls_ParameterizedMethod_After
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PARAMETERIZED METHOD: AFTER ===");
            double salary = 10000000;
            RaiseSalary(ref salary, 0.08);
            Console.WriteLine("Lương sau tăng 8%: " + salary.ToString("N0") + " VNĐ");
            Console.ReadLine();
        }

        public static void RaiseSalary(ref double salary, double percentage) => salary *= (1 + percentage);
    }
}