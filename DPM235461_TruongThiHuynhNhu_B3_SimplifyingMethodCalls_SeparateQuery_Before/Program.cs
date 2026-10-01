using System;

namespace DPM235461_TruongThiHuynhNhu_B3_SimplifyingMethodCalls_SeparateQuery_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SEPARATE QUERY FROM MODIFIER: BEFORE ===");
            string[] users = { "NV01", "Admin" };
            CheckAndSetUser(users);
            Console.ReadLine();
        }

        public static string CheckAndSetUser(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == "Admin")
                {
                    Console.WriteLine("Cảnh báo: Phát hiện quyền Admin!"); // Vừa truy vấn vừa làm thay đổi trạng thái
                    return "Admin";
                }
            }
            return "";
        }
    }
}