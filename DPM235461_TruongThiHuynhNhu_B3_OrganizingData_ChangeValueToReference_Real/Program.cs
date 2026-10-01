using System;
using System.Collections.Generic;

namespace DPM235461_TruongThiHuynhNhu_B3_OrganizingData_ChangeValueToReference_Real
{
    public class NhaSanXuatNongDuoc
    {
        public string TenNSX { get; private set; }
        private static Dictionary<string, NhaSanXuatNongDuoc> _khoNsx = new Dictionary<string, NhaSanXuatNongDuoc>();

        private NhaSanXuatNongDuoc(string ten) => TenNSX = ten;

        public static NhaSanXuatNongDuoc LayDoiTuong(string ten)
        {
            if (!_khoNsx.ContainsKey(ten))
                _khoNsx[ten] = new NhaSanXuatNongDuoc(ten);
            return _khoNsx[ten];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CHANGE VALUE TO REFERENCE: REAL (QUẢN LÝ THAM CHIẾU NHÀ SẢN XUẤT) ===");
            NhaSanXuatNongDuoc nsx1 = NhaSanXuatNongDuoc.LayDoiTuong("Syngenta An Giang");
            NhaSanXuatNongDuoc nsx2 = NhaSanXuatNongDuoc.LayDoiTuong("Syngenta An Giang");
            Console.WriteLine("Dùng chung đối tượng duy nhất? " + object.ReferenceEquals(nsx1, nsx2));
            Console.ReadLine();
        }
    }
}