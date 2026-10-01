using System;

namespace DPM235461_TruongThiHuynhNhu_B3_SimplifyingConditionals_IntroduceNullObject_After
{
    public interface ICustomer { string GetName(); }

    public class RealCustomer : ICustomer { public string GetName() => "An Giang Co"; }
    public class NullCustomer : ICustomer { public string GetName() => "Khách lẻ"; }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INTRODUCE NULL OBJECT: AFTER ===");
            ICustomer c = new NullCustomer();
            Console.WriteLine("Khách hàng: " + c.GetName());
            Console.ReadLine();
        }
    }
}