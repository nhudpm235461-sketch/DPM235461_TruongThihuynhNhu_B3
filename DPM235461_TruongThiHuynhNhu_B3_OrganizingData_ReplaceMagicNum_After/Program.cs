using System;

namespace DPM235461_TruongThiHuynhNhu_B3_OrganizingData_ReplaceMagicNum_After
{
    class Program
    {
        public const double GRAVITATIONAL_CONSTANT = 9.81;

        static void Main(string[] args)
        {
            Console.WriteLine("=== REPLACE MAGIC NUMBER: AFTER ===");
            double mass = 100, height = 5;
            double energy = mass * GRAVITATIONAL_CONSTANT * height;
            Console.WriteLine("Thế năng: " + energy);
            Console.ReadLine();
        }
    }
}