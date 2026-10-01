using System;

namespace DPM235461_TruongThiHuynhNhu_B3_SimplifyingConditionals_IntroduceNullObject_Real
{
    public interface IDiaChiGiaoHang { string LayDiaChi(); }

    public class DiaChiXacNhan : IDiaChiGiaoHang { public string LayDiaChi() => "Thành phố Long Xuyên, An Giang"; }
    public class DiaChiNull : IDiaChiGiaoHang { public string LayDiaChi() => "Nhận trực tiếp tại kho An Giang"; }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INTRODUCE NULL OBJECT: REAL (ĐỊA CHỈ MẶC ĐỊNH KHI KHÔNG CÓ) ===");
            IDiaChiGiaoHang dc = new DiaChiNull();
            Console.WriteLine("Địa chỉ giao hàng: " + dc.LayDiaChi());
            Console.ReadLine();
        }
    }
}