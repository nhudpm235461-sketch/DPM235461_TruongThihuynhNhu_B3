using System;

namespace DPM235461_TruongThiHuynhNhu_B3_SimplifyingConditionals_ConsolidateCond_After
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CONSOLIDATE CONDITIONAL: AFTER ===");
            Console.WriteLine("Mức trợ cấp: " + DisabilityAmount(5, 3, false));
            Console.ReadLine();
        }

        public static double DisabilityAmount(int seniority, int monthsDisabled, bool isPartTime)
        {
            if (IsNotEligible(seniority, monthsDisabled, isPartTime)) return 0;
            return 100;
        }

        private static bool IsNotEligible(int seniority, int monthsDisabled, bool isPartTime)
        {
            return seniority < 2 || monthsDisabled > 12 || isPartTime;
        }
    }
}