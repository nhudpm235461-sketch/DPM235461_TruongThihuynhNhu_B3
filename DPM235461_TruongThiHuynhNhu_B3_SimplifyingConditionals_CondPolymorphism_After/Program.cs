using System;

namespace DPM235461_TruongThiHuynhNhu_B3_SimplifyingConditionals_CondPolymorphism_After
{
    public abstract class Bird
    {
        public abstract double GetSpeed();
    }

    public class European : Bird
    {
        public override double GetSpeed() => 10;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CONDITIONAL WITH POLYMORPHISM: AFTER ===");
            Bird b = new European();
            Console.WriteLine("Tốc độ vận chuyển: " + b.GetSpeed());
            Console.ReadLine();
        }
    }
}