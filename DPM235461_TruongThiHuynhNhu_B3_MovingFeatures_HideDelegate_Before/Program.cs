using System;

namespace DPM235461_TruongThiHuynhNhu_B3_MovingFeatures_HideDelegate_Before
{
    public class Department { public Person Manager { get; set; } }

    public class Person
    {
        public Department Department { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== HIDE DELEGATE: BEFORE ===");
            Person emp = new Person();
            emp.Department = new Department { Manager = new Person() };
            Console.WriteLine("Lấy Quản lý trực tiếp: " + (emp.Department.Manager != null));
            Console.ReadLine();
        }
    }
}