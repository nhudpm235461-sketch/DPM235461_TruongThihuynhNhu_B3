using System;
using System.Collections.Generic;

namespace DPM235461_TruongThiHuynhNhu_B3_OrganizingData_ChangeValueToReference_After
{
    public class CustomerAfter
    {
        public string Name { get; private set; }
        private static Dictionary<string, CustomerAfter> _instances = new Dictionary<string, CustomerAfter>();

        private CustomerAfter(string name) => Name = name;

        public static CustomerAfter GetNamed(string name)
        {
            if (!_instances.ContainsKey(name))
                _instances[name] = new CustomerAfter(name);
            return _instances[name];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CHANGE VALUE TO REFERENCE: AFTER ===");
            CustomerAfter c1 = CustomerAfter.GetNamed("Đại lý Long Xuyên");
            CustomerAfter c2 = CustomerAfter.GetNamed("Đại lý Long Xuyên");
            Console.WriteLine("Cùng tham chiếu đối tượng? " + object.ReferenceEquals(c1, c2));
            Console.ReadLine();
        }
    }
}