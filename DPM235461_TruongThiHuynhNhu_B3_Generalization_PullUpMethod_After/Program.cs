using System;

namespace DPM235461_TruongThiHuynhNhu_B3_Generalization_PullUpMethod_After
{
    public class UnitAfter
    {
        public void Turn() => Console.WriteLine("Đơn vị vận chuyển chuyển hướng.");
    }

    public class TankAfter : UnitAfter { }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PULL UP METHOD: AFTER ===");
            TankAfter tank = new TankAfter();
            tank.Turn();
            Console.ReadLine();
        }
    }
}