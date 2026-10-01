using System;

namespace DPM235461_TruongThiHuynhNhu_B3_SimplifyingMethodCalls_RenameMethod_Before
{
    public class Customer
    {
        public string GetG() => "02963841234"; // Tên hàm GetG không rõ ý nghĩa
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== RENAME METHOD: BEFORE ===");
            Customer c = new Customer();
            Console.WriteLine("SĐT liên hệ: " + c.GetG());
            Console.ReadLine();
        }
    }
}