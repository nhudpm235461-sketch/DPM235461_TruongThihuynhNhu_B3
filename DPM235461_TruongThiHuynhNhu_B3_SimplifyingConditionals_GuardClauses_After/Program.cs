using System;

namespace DPM235461_TruongThiHuynhNhu_B3_SimplifyingConditionals_GuardClauses_After
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== GUARD CLAUSES: AFTER ===");
            Console.WriteLine("Lương: " + GetPayAmount(false, true));
            Console.ReadLine();
        }

        public static double GetPayAmount(bool isDead, bool isSeparated)
        {
            if (isDead) return 1000;
            if (isSeparated) return 2000;
            return 4000;
        }
    }
}