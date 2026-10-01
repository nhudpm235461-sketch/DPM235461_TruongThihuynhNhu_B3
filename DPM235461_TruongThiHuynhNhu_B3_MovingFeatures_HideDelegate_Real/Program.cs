using System;

namespace DPM235461_TruongThiHuynhNhu_B3_MovingFeatures_HideDelegate_Real
{
    public class CuaHangThuoc
    {
        public string TenQuanLy { get; set; } = "Nguyễn Văn Quản Lý";
    }

    public class NhanVienBanHang
    {
        public CuaHangThuoc CuaHang { get; set; } = new CuaHangThuoc();

        public string LayTenQuanLyCuaHang()
        {
            return CuaHang.TenQuanLy;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== HIDE DELEGATE: REAL (ỦY QUYỀN LẤY TÊN QUẢN LÝ CỬA HÀNG) ===");
            NhanVienBanHang nv = new NhanVienBanHang();
            Console.WriteLine("Tên Quản lý phụ trách: " + nv.LayTenQuanLyCuaHang());
            Console.ReadLine();
        }
    }
}