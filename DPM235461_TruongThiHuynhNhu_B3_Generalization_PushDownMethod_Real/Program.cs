using System;

namespace DPM235461_TruongThiHuynhNhu_B3_MovingFeatures_ExtractClass_After
{
    public class TelephoneNumber
    {
        public string AreaCode { get; set; }
        public string Number { get; set; }
        public string GetPhoneNumber() => $"({AreaCode}) {Number}";
    }

    public class PersonAfter
    {
        public string Name { get; set; }
        public TelephoneNumber Telephone { get; set; } = new TelephoneNumber();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EXTRACT CLASS: AFTER ===");
            PersonAfter p = new PersonAfter { Name = "Đại lý An Giang" };
            p.Telephone.AreaCode = "0296";
            p.Telephone.Number = "3841234";
            Console.WriteLine("SĐT Liên hệ: " + p.Telephone.GetPhoneNumber());
            Console.ReadLine();
        }
    }
}