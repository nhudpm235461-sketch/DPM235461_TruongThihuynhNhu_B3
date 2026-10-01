using System;

namespace DPM235461_TruongThiHuynhNhu_B3_OrganizingData_ReplaceMagicNum_Real
{
    class Program
    {
        public const double THUE_VAT_NONG_DUOC = 0.1; // Thay thế Magic Number bằng Hằng số có tên

        static void Main(string[] args)
        {
            Console.WriteLine("=== REPLACE MAGIC NUMBER: REAL (TÍNH THUẾ VAT NÔNG DƯỢC) ===");
            double giaTriDonHang = 5000000;
            double tienThue = giaTriDonHang * THUE_VAT_NONG_DUOC;
            Console.WriteLine("Tiền thuế VAT (10%): " + tienThue.ToString("N0") + " VNĐ");
            Console.ReadLine();
        }
    }
}