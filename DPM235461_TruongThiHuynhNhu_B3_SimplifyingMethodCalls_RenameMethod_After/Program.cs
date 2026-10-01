using System;

namespace DPM235461_TruongThiHuynhNhu_B3_SimplifyingMethodCalls_RenameMethod_After
{
    public class CustomerAfter
    {
        public string GetTelephoneNumber() => "02963841234";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== RENAME METHOD: AFTER ===");
            CustomerAfter c = new CustomerAfter();
            Console.WriteLine("SĐT liên hệ: " + c.GetTelephoneNumber());
            Console.ReadLine();
        }
    }
}