using System;

namespace DPM235461_TruongThiHuynhNhu_B3_ComposingMethods_ExtractMethod_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EXTRACT METHOD: BEFORE ===");
            PrintInvoice("Đại lý Nông dược An Giang", 15000000);
            Console.ReadLine();
        }

        public static void PrintInvoice(string customerName, double amount)
        {
            Console.WriteLine("***********************");
            Console.WriteLine("**** HOADON NONGDUOC **");
            Console.WriteLine("***********************");
            Console.WriteLine("Khach hang: " + customerName);
            Console.WriteLine("Tong tien: " + amount);
        }
    }
}