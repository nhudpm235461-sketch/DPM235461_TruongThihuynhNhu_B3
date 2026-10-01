using System;

namespace DPM235461_TruongThiHuynhNhu_B3_MovingFeatures_HideDelegate_After
{
    public class DepartmentAfter { public PersonAfter Manager { get; set; } }

    public class PersonAfter
    {
        public DepartmentAfter Department { get; set; }
        public PersonAfter GetManager() => Department.Manager;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== HIDE DELEGATE: AFTER ===");
            PersonAfter emp = new PersonAfter();
            emp.Department = new DepartmentAfter { Manager = new PersonAfter() };
            Console.WriteLine("Lấy Quản lý gián tiếp thành công? " + (emp.GetManager() != null));
            Console.ReadLine();
        }
    }
}