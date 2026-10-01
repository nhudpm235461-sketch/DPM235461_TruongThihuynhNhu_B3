using System;

namespace DPM235461_TruongThiHuynhNhu_B3_MovingFeatures_InlineClass_After
{
    public class PersonAfter
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INLINE CLASS: AFTER ===");
            PersonAfter p = new PersonAfter { Name = "Thủ kho B", PhoneNumber = "0912345678" };
            Console.WriteLine($"Thủ kho: {p.Name} | SĐT: {p.PhoneNumber}");
            Console.ReadLine();
        }
    }
}