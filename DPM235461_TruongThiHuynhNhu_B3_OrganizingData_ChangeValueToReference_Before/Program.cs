using System;

namespace DPM235461_TruongThiHuynhNhu_B3_OrganizingData_ChangeValueToReference_Before
{
    public class Customer
    {
        public string Name { get; set; }
        public Customer(string name) => Name = name;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CHANGE VALUE TO REFERENCE: BEFORE ===");
            Customer c1 = new Customer("Đại lý Long Xuyên");
            Customer c2 = new Customer("Đại lý Long Xuyên");
            Console.WriteLine("Cùng tham chiếu đối tượng? " + object.ReferenceEquals(c1, c2));
            Console.ReadLine();
        }
    }
}