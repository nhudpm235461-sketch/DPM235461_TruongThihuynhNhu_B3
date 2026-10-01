using System;

namespace DPM235461_TruongThiHuynhNhu_B3_SimplifyingConditionals_GuardClauses_Real
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== GUARD CLAUSES: REAL (TẢI SỚM BẮT LỖI TỒN KHO) ===");
            double tongTien = TinhTienXuatKho(0, 50000);
            Console.WriteLine("Tổng tiền: " + tongTien.ToString("N0") + " VNĐ");
            Console.ReadLine();
        }

        public static double TinhTienXuatKho(int soLuong, double donGia)
        {
            if (soLuong <= 0) return 0; // Trả về sớm nếu không có hàng xuất
            return soLuong * donGia;
        }
    }
}