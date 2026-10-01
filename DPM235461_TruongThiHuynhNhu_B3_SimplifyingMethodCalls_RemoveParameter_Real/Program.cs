using System;

namespace DPM235461_TruongThiHuynhNhu_B3_SimplifyingMethodCalls_RemoveParameter_Real
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== REMOVE PARAMETER: REAL (BỎ THAM SỐ THỪA TRONG HÀM XUẤT KHO) ===");
            double tongTien = TinhTienXuatKho(100, 45000);
            Console.WriteLine("Tổng tiền xuất kho: " + tongTien.ToString("N0") + " VNĐ");
            Console.ReadLine();
        }

        // Bỏ tham số mã kho dư thừa không sử dụng trong logic tính toán
        public static double TinhTienXuatKho(int soLuong, double donGia)
        {
            return soLuong * donGia;
        }
    }
}