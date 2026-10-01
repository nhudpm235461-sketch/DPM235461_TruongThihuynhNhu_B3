using System;

namespace DPM235461_TruongThiHuynhNhu_B3_Generalization_ExtractInterface_Before
{
    public class Employee
    {
        public double GetRate() => 100;
        public bool HasSpecialSkill() => true;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EXTRACT INTERFACE: BEFORE ===");
            Employee e = new Employee();
            Console.WriteLine("Đơn giá giờ công: " + e.GetRate());
            Console.ReadLine();
        }
    }
}