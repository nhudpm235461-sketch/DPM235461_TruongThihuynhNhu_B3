using System;

namespace DPM235461_TruongThiHuynhNhu_B3_Generalization_PullUpMethod_Before
{
    public class Tank
    {
        public void Turn() => Console.WriteLine("Đơn vị vận chuyển chuyển hướng.");
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PULL UP METHOD: BEFORE ===");
            Tank tank = new Tank();
            tank.Turn();
            Console.ReadLine();
        }
    }
}