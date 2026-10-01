using System;

namespace DPM235461_TruongThiHuynhNhu_B3_SimplifyingConditionals_IntroduceNullObject_Before
{
    public class Customer { public string Name => "An Giang Co"; }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INTRODUCE NULL OBJECT: BEFORE ===");
            Customer c = null;
            string name = (c == null) ? "Khách lẻ" : c.Name;
            Console.WriteLine("Khách hàng: " + name);
            Console.ReadLine();
        }
    }
}