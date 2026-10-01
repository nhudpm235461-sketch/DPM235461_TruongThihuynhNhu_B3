using System;

namespace DPM235461_TruongThiHuynhNhu_B3_OrganizingData_ReplaceTypeCodeWithSubclasses_Real
{
    public abstract class LoaiPhanBoTonKho
    {
        public abstract string LayTenQuyTrinh();
    }

    public class QuyTrinhXuatSii : LoaiPhanBoTonKho
    {
        public override string LayTenQuyTrinh() => "Phân bổ lô hàng Bán Sỉ";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== REPLACE TYPE CODE WITH SUBCLASSES: REAL (THAY MÃ LOẠI PHẦN BỔ) ===");
            LoaiPhanBoTonKho qtr = new QuyTrinhXuatSii();
            Console.WriteLine("Quy trình thực thi: " + qtr.LayTenQuyTrinh());
            Console.ReadLine();
        }
    }
}