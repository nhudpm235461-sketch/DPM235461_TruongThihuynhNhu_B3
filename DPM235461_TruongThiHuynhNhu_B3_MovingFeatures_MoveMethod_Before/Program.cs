using System;

namespace DPM235461_TruongThiHuynhNhu_B3_MovingFeatures_MoveMethod_Before
{
    public class BankAccount
    {
        public int DaysOverdrawn { get; set; } = 5;

        public double OverdraftCharge()
        {
            return DaysOverdrawn * 1.75;
        }

        public double BankCharge()
        {
            double result = 4.5;
            if (DaysOverdrawn > 0)
                result += OverdraftCharge();
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MOVE METHOD: BEFORE ===");
            BankAccount acc = new BankAccount();
            Console.WriteLine("Phí tài khoản: " + acc.BankCharge());
            Console.ReadLine();
        }
    }
}