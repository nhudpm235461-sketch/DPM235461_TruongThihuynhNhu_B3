using System;

namespace DPM235461_TruongThiHuynhNhu_B3_SimplifyingConditionals_CondPolymorphism_Real
{
    public abstract class PhuongThucTinhGia
    {
        public abstract double TinhGiaXuatKho(double giaGoc);
    }

    public class GiaFIFO : PhuongThucTinhGia
    {
        public override double TinhGiaXuatKho(double giaGoc) => giaGoc; // Giữ giá gốc nhập đầu
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CONDITIONAL WITH POLYMORPHISM: REAL (TÍNH GIÁ ĐA HÌNH) ===");
            PhuongThucTinhGia pttg = new GiaFIFO();
            Console.WriteLine("Thành tiền xuất kho (FIFO): " + pttg.TinhGiaXuatKho(150000).ToString("N0") + " VNĐ");
            Console.ReadLine();
        }
    }
}