using System;

namespace DPM235461_TruongThiHuynhNhu_B3_SimplifyingConditionals_ConsolidateCond_Real
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CONSOLIDATE CONDITIONAL: REAL (GỘP ĐIỀU KIỆN TỪ CHỐI XUẤT KHO) ===");
            bool isTuChoi = KiemTraKhoeTuChoiXuatKho(0, true);
            Console.WriteLine("Từ chối xuất kho? " + isTuChoi);
            Console.ReadLine();
        }

        public static bool KiemTraKhoeTuChoiXuatKho(int soLuongTon, bool isLoHetHan)
        {
            return soLuongTon <= 0 || isLoHetHan; // Gộp các điều kiện từ chối xuất hàng
        }
    }
}