using System;

namespace DPM235461_TruongThiHuynhNhu_B3_SimplifyingMethodCalls_SeparateQuery_Real
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SEPARATE QUERY FROM MODIFIER: REAL (TÁCH HÀM TRUY VẤN TỒN KHO) ===");
            int soLuongTon = 15;

            // 1. Hàm Query chỉ đọc dữ liệu
            if (IsKiemTraSapHetHang(soLuongTon))
            {
                // 2. Thao tác Modifier làm thay đổi dữ liệu/gửi thông báo riêng
                GuiThongBaoChoBoPhanMuaHang();
            }

            Console.ReadLine();
        }

        public static bool IsKiemTraSapHetHang(int tonKho)
        {
            return tonKho < 20;
        }

        public static void GuiThongBaoChoBoPhanMuaHang()
        {
            Console.WriteLine("[Hệ thống] Đã gửi thông báo nhập hàng đến Trưởng phòng Mua hàng An Giang.");
        }
    }
}