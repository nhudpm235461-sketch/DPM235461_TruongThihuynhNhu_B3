using System;

namespace DPM235461_TruongThiHuynhNhu_B3_MovingFeatures_ExtractClass_Before
{
    public class Person
    {
        public string Name { get; set; }
        public string OfficeAreaCode { get; set; }
        public string OfficeNumber { get; set; }

        public string GetPhoneNumber() => $"({OfficeAreaCode}) {OfficeNumber}";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EXTRACT CLASS: BEFORE ===");
            Person p = new Person { Name = "Đại lý An Giang", OfficeAreaCode = "0296", OfficeNumber = "3841234" };
            Console.WriteLine("SĐT Liên hệ: " + p.GetPhoneNumber());
            Console.ReadLine();
        }
    }
}