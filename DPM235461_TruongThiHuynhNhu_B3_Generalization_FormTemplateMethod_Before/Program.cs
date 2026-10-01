using System;

namespace DPM235461_TruongThiHuynhNhu_B3_Generalization_FormTemplateMethod_Before
{
    public class InventoryPrinter
    {
        public void Print()
        {
            Console.WriteLine("--- CÔNG TY NÔNG DƯỢC AN GIANG ---");
            Console.WriteLine("Báo cáo tồn kho: 500 chai thuốc trừ sâu A1.");
            Console.WriteLine("---------------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== FORM TEMPLATE METHOD: BEFORE ===");
            InventoryPrinter printer = new InventoryPrinter();
            printer.Print();
            Console.ReadLine();
        }
    }
}