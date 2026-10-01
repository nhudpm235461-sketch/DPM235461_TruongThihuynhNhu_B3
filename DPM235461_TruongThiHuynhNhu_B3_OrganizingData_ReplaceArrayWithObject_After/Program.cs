using System;

namespace DPM235461_TruongThiHuynhNhu_B3_OrganizingData_ReplaceArrayWithObject_After
{
    public class PerformanceData
    {
        public string Name { get; set; }
        public int Wins { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== REPLACE ARRAY WITH OBJECT: AFTER ===");
            PerformanceData row = new PerformanceData { Name = "An Giang", Wins = 15 };
            Console.WriteLine($"Tỉnh: {row.Name} | Số chi nhánh: {row.Wins}");
            Console.ReadLine();
        }
    }
}