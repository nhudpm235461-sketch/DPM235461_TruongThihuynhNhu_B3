using System;

namespace DPM235461_TruongThiHuynhNhu_B3_ComposingMethods_InlineMethod_Before
{
    class Program
    {
        private static int numberOfLateDeliveries = 6;

        static void Main(string[] args)
        {
            Console.WriteLine("=== INLINE METHOD: BEFORE ===");
            Console.WriteLine("Xếp loại giao hàng đại lý: " + GetRating());
            Console.ReadLine();
        }

        public static int GetRating()
        {
            return MoreThanFiveLateDeliveries() ? 2 : 1;
        }

        private static bool MoreThanFiveLateDeliveries()
        {
            return numberOfLateDeliveries > 5;
        }
    }
}