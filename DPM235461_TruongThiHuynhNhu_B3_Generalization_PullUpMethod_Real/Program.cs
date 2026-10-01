using System;

namespace DPM235461_TruongThiHuynhNhu_B3_Generalization_PullUpMethod_Real
{
    public abstract class SanPhamNongDuoc
    {
        public string TenSanPham { get; set; }
        public double GiaGoc { get; set; }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Sản phẩm: {TenSanPham} | Giá gốc: {GiaGoc:N0} VNĐ");
        }
    }

    public class ThuocTruSau : SanPhamNongDuoc { }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PULL UP METHOD: REAL (HIỂN THỊ THÔNG TIN NÔNG DƯỢC) ===");
            ThuocTruSau thuoc = new ThuocTruSau { TenSanPham = "Thuốc Trừ Rầy B2", GiaGoc = 120000 };
            thuoc.HienThiThongTin();
            Console.ReadLine();
        }
    }
}