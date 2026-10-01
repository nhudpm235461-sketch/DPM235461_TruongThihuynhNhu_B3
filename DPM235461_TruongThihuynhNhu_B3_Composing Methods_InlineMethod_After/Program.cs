using System;

namespace DPM235461_TruongThiHuynhNhu_B3_ComposingMethods_ExtractMethod_After
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EXTRACT METHOD: AFTER ===");
            PrintInvoice("Đại lý Nông dược An Giang", 15000000);
            Console.ReadLine();
        }

        public static void PrintInvoice(string customerName, double amount)
        {
            PrintBanner();
            PrintDetails(customerName, amount);
        }

        private static void PrintBanner()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("**** HOADON NONGDUOC **");
            Console.WriteLine("***********************");
        }

        private static void PrintDetails(string customerName, double amount)
        {
            Console.WriteLine("Khach hang: " + customerName);
            Console.WriteLine("Tong tien: " + amount.ToString("N0") + " VNĐ");
        }
    }
}