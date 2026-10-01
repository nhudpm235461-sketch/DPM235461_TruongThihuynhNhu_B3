using System;

namespace DPM235461_TruongThiHuynhNhu_B3_Generalization_FormTemplateMethod_Real
{
    public abstract class QuyTrinhXuatKho
    {
        public void XuatKho()
        {
            Console.WriteLine("1. Kiểm tra mã tồn kho.");
            ChonLoHang();
            Console.WriteLine("3. In phiếu giao hàng.");
        }

        protected abstract void ChonLoHang();
    }

    public class XuatKhoFIFO : QuyTrinhXuatKho
    {
        protected override void ChonLoHang() => Console.WriteLine("2. [Tự động FIFO] Chọn lô hết hạn trước.");
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== FORM TEMPLATE METHOD: REAL (QUY TRÌNH XUẤT KHO) ===");
            QuyTrinhXuatKho qtk = new XuatKhoFIFO();
            qtk.XuatKho();
            Console.ReadLine();
        }
    }
}