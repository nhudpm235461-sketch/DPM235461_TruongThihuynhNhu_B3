using System;

namespace DPM235461_TruongThiHuynhNhu_B3_MovingFeatures_MoveField_Before
{
    public class Account
    {
        public double InterestRate { get; set; } = 0.05;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MOVE FIELD: BEFORE ===");
            Account acc = new Account();
            Console.WriteLine("Lãi suất tài khoản: " + acc.InterestRate);
            Console.ReadLine();
        }
    }
}