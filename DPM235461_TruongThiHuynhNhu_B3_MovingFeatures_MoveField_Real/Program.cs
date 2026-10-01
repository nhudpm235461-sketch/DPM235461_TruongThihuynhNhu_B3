using System;

namespace DPM235461_TruongThiHuynhNhu_B3_MovingFeatures_MoveField_Real
{
    public class LoaiLoHang
    {
        public double RatePhuPhiBaoQuan { get; set; } = 0.02; // Phụ phí bảo quản thuộc loại lô
    }

    public class LoHangNongDuoc
    {
        public LoaiLoHang Loai { get; set; } = new LoaiLoHang();
        public double GetPhuPhi() => Loai.RatePhuPhiBaoQuan;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MOVE FIELD: REAL (CHUYỂN PHỤ PHÍ BẢO QUẢN SANG LẮP LOẠI LÔ HÀNG) ===");
            LoHangNongDuoc lo = new LoHangNongDuoc();
            Console.WriteLine("Tỷ lệ phụ phí bảo quản lô: " + lo.GetPhuPhi());
            Console.ReadLine();
        }
    }
}