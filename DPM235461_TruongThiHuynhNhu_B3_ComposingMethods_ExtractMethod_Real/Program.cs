using System;

namespace DPM235461_TruongThiHuynhNhu_B3_ComposingMethods_ExtractMethod_Real
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EXTRACT METHOD: REAL (XUẤT HÓA ĐƠN NÔNG DƯỢC) ===");
            XuatHoaDon("Thuốc trừ sâu A1", 500, 45000);
            Console.ReadLine();
        }

        public static void XuatHoaDon(string tenThuoc, int soLuong, double donGia)
        {
            InTieuDe();
            double tongTien = TinhTongTien(soLuong, donGia);
            InChiTiet(tenThuoc, soLuong, tongTien);
        }

        private static void InTieuDe()
        {
            Console.WriteLine("=== CÔNG TY NÔNG DƯỢC AN GIANG ===");
        }

        private static double TinhTongTien(int sl, double gia) => sl * gia;

        private static void InChiTiet(string ten, int sl, double tong)
        {
            Console.WriteLine($"Mặt hàng: {ten} | SL: {sl} | Thành tiền: {tong:N0} VNĐ");
        }
    }
}