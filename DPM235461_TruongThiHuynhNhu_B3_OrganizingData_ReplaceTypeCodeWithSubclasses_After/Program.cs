using System;

namespace DPM235461_TruongThiHuynhNhu_B3_OrganizingData_ReplaceTypeCodeWithSubclasses_After
{
    public abstract class EmployeeType
    {
        public abstract int GetTypeCode();
    }

    public class EngineerType : EmployeeType
    {
        public override int GetTypeCode() => 0;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== REPLACE TYPE CODE WITH SUBCLASSES: AFTER ===");
            EmployeeType type = new EngineerType();
            Console.WriteLine("Mã loại nhân viên: " + type.GetTypeCode());
            Console.ReadLine();
        }
    }
}