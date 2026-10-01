using System;

namespace DPM235461_TruongThiHuynhNhu_B3_Generalization_ExtractInterface_After
{
    public interface IBillable
    {
        double GetRate();
        bool HasSpecialSkill();
    }

    public class EmployeeAfter : IBillable
    {
        public double GetRate() => 100;
        public bool HasSpecialSkill() => true;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EXTRACT INTERFACE: AFTER ===");
            IBillable b = new EmployeeAfter();
            Console.WriteLine("Đơn giá giờ công: " + b.GetRate());
            Console.ReadLine();
        }
    }
}