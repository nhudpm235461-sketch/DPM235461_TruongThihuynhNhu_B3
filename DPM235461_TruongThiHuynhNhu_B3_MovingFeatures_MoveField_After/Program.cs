using System;

namespace DPM235461_TruongThiHuynhNhu_B3_MovingFeatures_MoveField_After
{
    public class AccountTypeAfter
    {
        public double InterestRate { get; set; } = 0.05;
    }

    public class AccountAfter
    {
        public AccountTypeAfter Type { get; set; } = new AccountTypeAfter();

        public double InterestRate
        {
            get => Type.InterestRate;
            set => Type.InterestRate = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MOVE FIELD: AFTER ===");
            AccountAfter acc = new AccountAfter();
            Console.WriteLine("Lãi suất tài khoản: " + acc.InterestRate);
            Console.ReadLine();
        }
    }
}