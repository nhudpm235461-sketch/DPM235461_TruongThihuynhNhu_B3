using System;

namespace DPM235461_TruongThiHuynhNhu_B3_Generalization_FormTemplateMethod_After
{
    public abstract class BasePrinter
    {
        public void Print()
        {
            PrintHeader();
            PrintContent();
            PrintFooter();
        }

        protected void PrintHeader() => Console.WriteLine("--- CÔNG TY NÔNG DƯỢC AN GIANG ---");
        protected abstract void PrintContent();
        protected void PrintFooter() => Console.WriteLine("---------------------------------");
    }

    public class InventoryPrinter : BasePrinter
    {
        protected override void PrintContent() => Console.WriteLine("Báo cáo tồn kho: 500 chai thuốc trừ sâu A1.");
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== FORM TEMPLATE METHOD: AFTER ===");
            BasePrinter printer = new InventoryPrinter();
            printer.Print();
            Console.ReadLine();
        }
    }
}