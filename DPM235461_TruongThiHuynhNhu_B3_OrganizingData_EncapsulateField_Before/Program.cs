using System;

namespace DPM235461_TruongThiHuynhNhu_B3_OrganizingData_EncapsulateField_Before
{
    public class Customer
    {
        public string CustomerName;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ENCAPSULATE FIELD: BEFORE ===");
            Customer c = new Customer();
            c.CustomerName = "Đại lý An Giang";
            Console.WriteLine("Tên khách hàng: " + c.CustomerName);
            Console.ReadLine();
        }
    }
}