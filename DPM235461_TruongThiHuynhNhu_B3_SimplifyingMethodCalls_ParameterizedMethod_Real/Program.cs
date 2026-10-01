using System;

namespace DPM235461_TruongThiHuynhNhu_B3_SimplifyingMethodCalls_ParameterizedMethod_Real
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PARAMETERIZED METHOD: REAL (GỘP HÀM TÍNH CHIẾT KHẤU THEO MỨC) ===");
            double giaXuat = TinhTienChietKhau(1000000, 0.15); // Nhận tỷ lệ chiết khấu linh hoạt
            Console.WriteLine("Thành tiền: " + giaXuat.ToString("N0") + " VNĐ");
            Console.ReadLine();
        }

        public static double TinhTienChietKhau(double giaGoc, double tyLe)
        {
            return giaGoc * (1 - tyLe);
        }
    }
}