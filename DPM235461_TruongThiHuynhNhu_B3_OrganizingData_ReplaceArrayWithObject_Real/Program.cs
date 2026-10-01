using System;

namespace DPM235461_TruongThiHuynhNhu_B3_OrganizingData_ReplaceArrayWithObject_Real
{
    public class ThongTinLoThuoc
    {
        public string TenThuoc { get; set; }
        public int SoLuongTon { get; set; }
        public double DonGia { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== REPLACE ARRAY WITH OBJECT: REAL (ĐỐI TƯỢNG HÓA THÔNG TIN LÔ THUỐC) ===");
            ThongTinLoThuoc lo = new ThongTinLoThuoc
            {
                TenThuoc = "Thuốc trừ sâu A1",
                SoLuongTon = 250,
                DonGia = 45000
            };

            Console.WriteLine($"Mặt hàng: {lo.TenThuoc} | Tồn: {lo.SoLuongTon} chai | Giá: {lo.DonGia:N0} VNĐ");
            Console.ReadLine();
        }
    }
}