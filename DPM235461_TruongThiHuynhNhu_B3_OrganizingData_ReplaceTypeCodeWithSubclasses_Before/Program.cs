using System;

namespace DPM235461_TruongThiHuynhNhu_B3_OrganizingData_ReplaceTypeCodeWithSubclasses_Before
{
    public class Employee
    {
        public const int ENGINEER = 0;
        public int Type { get; set; } = ENGINEER;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== REPLACE TYPE CODE WITH SUBCLASSES: BEFORE ===");
            Employee emp = new Employee();
            Console.WriteLine("Mã loại nhân viên: " + emp.Type);
            Console.ReadLine();
        }
    }
}