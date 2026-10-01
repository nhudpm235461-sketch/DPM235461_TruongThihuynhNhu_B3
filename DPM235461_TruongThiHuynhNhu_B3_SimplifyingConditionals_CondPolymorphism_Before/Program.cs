using System;

namespace DPM235461_TruongThiHuynhNhu_B3_SimplifyingConditionals_CondPolymorphism_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CONDITIONAL WITH POLYMORPHISM: BEFORE ===");
            int type = 0;
            double speed = type == 0 ? 10 : 20;
            Console.WriteLine("Tốc độ vận chuyển: " + speed);
            Console.ReadLine();
        }
    }
}