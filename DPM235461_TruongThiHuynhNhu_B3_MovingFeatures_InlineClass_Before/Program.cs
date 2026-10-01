using System;

namespace DPM235461_TruongThiHuynhNhu_B3_MovingFeatures_InlineClass_Before
{
    public class TelephoneNumber
    {
        public string Number { get; set; }
    }

    public class Person
    {
        public string Name { get; set; }
        public TelephoneNumber Phone { get; set; } = new TelephoneNumber();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INLINE CLASS: BEFORE ===");
            Person p = new Person { Name = "Thủ kho B" };
            p.Phone.Number = "0912345678";
            Console.WriteLine($"Thủ kho: {p.Name} | SĐT: {p.Phone.Number}");
            Console.ReadLine();
        }
    }
}