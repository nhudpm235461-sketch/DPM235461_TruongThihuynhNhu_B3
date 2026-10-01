using System;

namespace DPM235461_TruongThiHuynhNhu_B3_OrganizingData_EncapsulateField_After
{
    public class Customer
    {
        private string _customerName;

        public string CustomerName
        {
            get => _customerName;
            set => _customerName = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ENCAPSULATE FIELD: AFTER ===");
            Customer c = new Customer();
            c.CustomerName = "Đại lý An Giang";
            Console.WriteLine("Tên khách hàng: " + c.CustomerName);
            Console.ReadLine();
        }
    }
}