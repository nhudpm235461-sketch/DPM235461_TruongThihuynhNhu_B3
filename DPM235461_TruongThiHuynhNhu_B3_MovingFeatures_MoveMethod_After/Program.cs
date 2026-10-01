using System;

namespace DPM235461_TruongThiHuynhNhu_B3_MovingFeatures_MoveMethod_After
{
    public class AccountTypeAfter
    {
        public double OverdraftCharge(int days)
        {
            return days * 1.75;
        }
    }

    public class BankAccountAfter
    {
        public AccountTypeAfter Type { get; set; } = new AccountTypeAfter();
        public int DaysOverdrawn { get; set; } = 5;

        public double BankCharge()
        {
            double result = 4.5;
            if (DaysOverdrawn > 0)
                result += Type.OverdraftCharge(DaysOverdrawn);
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MOVE METHOD: AFTER ===");
            BankAccountAfter acc = new BankAccountAfter();
            Console.WriteLine("Phí tài khoản: " + acc.BankCharge());
            Console.ReadLine();
        }
    }
}