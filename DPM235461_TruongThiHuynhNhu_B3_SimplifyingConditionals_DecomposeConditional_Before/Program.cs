using System;

namespace DPM235461_TruongThiHuynhNhu_B3_SimplifyingConditionals_DecomposeConditional_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DECOMPOSE CONDITIONAL: BEFORE ===");
            DateTime date = DateTime.Now;
            double charge;
            if (date.Month < 6 || date.Month > 8)
                charge = 100 * 12;
            else
                charge = 100 * 10;

            Console.WriteLine("Cước phí: " + charge);
            Console.ReadLine();
        }
    }
}