using System;

namespace DPM235461_TruongThiHuynhNhu_B3_SimplifyingConditionals_GuardClauses_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== GUARD CLAUSES: BEFORE ===");
            Console.WriteLine("Lương: " + GetPayAmount(false, true));
            Console.ReadLine();
        }

        public static double GetPayAmount(bool isDead, bool isSeparated)
        {
            double result;
            if (isDead) result = 1000;
            else
            {
                if (isSeparated) result = 2000;
                else result = 4000;
            }
            return result;
        }
    }
}