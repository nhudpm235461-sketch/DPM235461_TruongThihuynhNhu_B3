using System;

namespace DPM235461_TruongThiHuynhNhu_B3_OrganizingData_EncapsulateField_Real
{
    public class LoHangNongDuoc
    {
        private double _donGiaXuat;

        public double DonGiaXuat
        {
            get => _donGiaXuat;
            set => _donGiaXuat = value < 0 ? 0 : value; // Đóng gói field và kiểm tra ràng buộc giá
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ENCAPSULATE FIELD: REAL (ĐÓNG GÓI ĐƠN GIÁ XUẤT KHO) ===");
            LoHangNongDuoc lo = new LoHangNongDuoc();
            lo.DonGiaXuat = 120000;
            Console.WriteLine("Đơn giá xuất kho: " + lo.DonGiaXuat.ToString("N0") + " VNĐ");
            Console.ReadLine();
        }
    }
}