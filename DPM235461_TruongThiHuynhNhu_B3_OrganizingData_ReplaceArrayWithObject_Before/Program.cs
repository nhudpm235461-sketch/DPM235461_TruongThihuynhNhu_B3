using System;

namespace DPM235461_TruongThiHuynhNhu_B3_OrganizingData_ReplaceArrayWithObject_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== REPLACE ARRAY WITH OBJECT: BEFORE ===");
            string[] row = new string[2];
            row[0] = "An Giang";
            row[1] = "15";
            Console.WriteLine($"Tỉnh: {row[0]} | Số chi nhánh: {row[1]}");
            Console.ReadLine();
        }
    }
}