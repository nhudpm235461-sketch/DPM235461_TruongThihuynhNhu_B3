using System;

namespace DPM235461_TruongThiHuynhNhu_B3_OrganizingData_ReplaceMagicNum_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== REPLACE MAGIC NUMBER: BEFORE ===");
            double mass = 100, height = 5;
            double energy = mass * 9.81 * height; // 9.81 là con số bí ẩn
            Console.WriteLine("Thế năng: " + energy);
            Console.ReadLine();
        }
    }
}