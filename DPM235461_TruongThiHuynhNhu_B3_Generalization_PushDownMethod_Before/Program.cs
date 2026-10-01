using System;

namespace DPM235461_TruongThiHuynhNhu_B3_Generalization_PushDownMethod_Before
{
    public class Employee
    {
        public void GetQuota() => Console.WriteLine("Chỉ tiêu doanh số bán hàng nông dược: 100.000.000 VNĐ");
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PUSH DOWN METHOD: BEFORE ===");
            Employee e = new Employee();
            e.GetQuota();
            Console.ReadLine();
        }
    }
}