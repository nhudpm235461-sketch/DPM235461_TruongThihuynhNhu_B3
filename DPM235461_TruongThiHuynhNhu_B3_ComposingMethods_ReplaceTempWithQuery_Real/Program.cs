using System;

namespace DPM235461_TruongThiHuynhNhu_B3_ComposingMethods_ReplaceTempWithQuery_Real
{
    class Program
    {
        private static int _soThungThuoc = 20;
        private static double _giaThung = 1200000;

        static void Main(string[] args)
        {
            Console.WriteLine("=== REPLACE TEMP WITH QUERY: REAL (TÍNH TỔNG TIỀN ĐƠN SỈ) ===");
            Console.WriteLine("Tổng chi phí xuất kho sỉ: " + TinhTongTienXuatSii().ToString("N0") + " VNĐ");
            Console.ReadLine();
        }

        public static double TinhTongTienXuatSii() => TinhTienGoc() - TinhTienChietKhau();
        private static double TinhTienGoc() => _soThungThuoc * _giaThung;
        private static double TinhTienChietKhau() => TinhTienGoc() >= 20000000 ? TinhTienGoc() * 0.08 : TinhTienGoc() * 0.03;
    }
}