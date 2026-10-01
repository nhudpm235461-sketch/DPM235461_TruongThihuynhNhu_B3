using System;

namespace DPM235461_TruongThiHuynhNhu_B3_Generalization_PushDownMethod_After
{
    public class EmployeeAfter { }

    public class SalesmanAfter : EmployeeAfter
    {
        public void GetQuota() => Console.WriteLine("Chỉ tiêu doanh số bán hàng nông dược: 100.000.000 VNĐ");
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PUSH DOWN METHOD: AFTER ===");
            SalesmanAfter s = new SalesmanAfter();
            s.GetQuota();
            Console.ReadLine();
        }
    }
}