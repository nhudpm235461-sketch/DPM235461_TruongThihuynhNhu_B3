using System;

namespace DPM235461_TruongThiHuynhNhu_B3_ComposingMethods_InlineMethod_Real
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INLINE METHOD: REAL (KIỂM TRA CẢNH BÁO TỒN KHO) ===");
            int soLuongTonKho = 15;

            bool isCanhBaoNhapHang = soLuongTonKho < 20;
            Console.WriteLine("Cần nhập thêm hàng gấp? " + isCanhBaoNhapHang);

            Console.ReadLine();
        }
    }
}