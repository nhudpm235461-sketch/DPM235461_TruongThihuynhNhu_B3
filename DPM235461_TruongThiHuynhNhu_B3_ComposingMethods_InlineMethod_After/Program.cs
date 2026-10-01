using System;

namespace DPM235461_TruongThiHuynhNhu_B3_ComposingMethods_InlineMethod_After
{
    class Program
    {
        private static int numberOfLateDeliveries = 6;

        static void Main(string[] args)
        {
            Console.WriteLine("=== INLINE METHOD: AFTER ===");
            int rating = numberOfLateDeliveries > 5 ? 2 : 1;
            Console.WriteLine("Xếp loại giao hàng đại lý: " + rating);
            Console.ReadLine();
        }
    }
}