using System;

namespace DPM235461_TruongThiHuynhNhu_B3_ComposingMethods_InlineTemp_Real
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INLINE TEMP: REAL (KIỂM TRA THỎA ĐIỀU KIỆN FREESHIP) ===");
            Console.WriteLine("Hóa đơn được Miễn phí vận chuyển? " + (LayGiaTriHoaDon() >= 5000000));
            Console.ReadLine();
        }

        public static double LayGiaTriHoaDon() => 6500000;
    }
}