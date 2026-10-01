using System;

namespace DPM235461_TruongThiHuynhNhu_B3_SimplifyingConditionals_ConsolidateCond_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CONSOLIDATE CONDITIONAL: BEFORE ===");
            Console.WriteLine("Mức trợ cấp: " + DisabilityAmount(5, 3, false));
            Console.ReadLine();
        }

        public static double DisabilityAmount(int seniority, int monthsDisabled, bool isPartTime)
        {
            if (seniority < 2) return 0;
            if (monthsDisabled > 12) return 0;
            if (isPartTime) return 0;
            return 100;
        }
    }
}