using System;

namespace DPM235461_TruongThiHuynhNhu_B3_SimplifyingMethodCalls_SeparateQuery_After
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SEPARATE QUERY FROM MODIFIER: AFTER ===");
            string[] users = { "NV01", "Admin" };

            if (FindUser(users) == "Admin")
            {
                SendAlert();
            }
            Console.ReadLine();
        }

        public static string FindUser(string[] names)
        {
            foreach (var name in names)
                if (name == "Admin") return "Admin";
            return "";
        }

        public static void SendAlert() => Console.WriteLine("Cảnh báo: Phát hiện quyền Admin!");
    }
}