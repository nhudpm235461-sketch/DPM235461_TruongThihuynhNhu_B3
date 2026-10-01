using System;

namespace DPM235461_TruongThiHuynhNhu_B3_MovingFeatures_MoveMethod_Real
{
    public class LoaiKhachHang
    {
        public double TinhTienMienGiam(int soNamGanBo)
        {
            return soNamGanBo * 50000; // Mức miễn giảm phụ thuộc vào loại khách hàng
        }
    }

    public class KhachHang
    {
        public LoaiKhachHang Loai { get; set; } = new LoaiKhachHang();
        public int SoNamGanBo { get; set; } = 3;

        public double LayTienMienGiam()
        {
            return Loai.TinhTienMienGiam(SoNamGanBo);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MOVE METHOD: REAL (CHUYỂN HÀM TÍNH MIỄN GIẢM VỀ LOẠI KHÁCH HÀNG) ===");
            KhachHang kh = new KhachHang();
            Console.WriteLine("Số tiền miễn giảm: " + kh.LayTienMienGiam().ToString("N0") + " VNĐ");
            Console.ReadLine();
        }
    }
}