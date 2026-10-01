using System;

namespace DPM235461_TruongThiHuynhNhu_B3_Generalization_ExtractInterface_Real
{
    public interface ITinhChietKhau
    {
        double TinhGiaGiam(double giaGoc);
    }

    public class DaiLyCap1 : ITinhChietKhau
    {
        public double TinhGiaGiam(double giaGoc) => giaGoc * 0.85; // Giảm 15%
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EXTRACT INTERFACE: REAL (TÍNH CHIẾT KHẤU ĐẠI LÝ) ===");
            ITinhChietKhau daiLy = new DaiLyCap1();
            Console.WriteLine("Giá thanh toán sau chiết khấu: " + daiLy.TinhGiaGiam(1000000).ToString("N0") + " VNĐ");
            Console.ReadLine();
        }
    }
}