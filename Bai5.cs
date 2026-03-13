using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BT_Generic_Collection
{
    public class Bai5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Thông tin sinh viên:");
            Console.WriteLine("Họ tên: Nguyen Quang Vinh");
            Console.WriteLine("MSV: 23115053122346");
            Console.WriteLine("Lớp: 23T3");
            Console.WriteLine("Lớp học phần: Lập trình C#");
            Console.WriteLine("------------------------------");

            // Bài 5. Xoá phần tử khỏi List
            List<string> names = new List<string>();
            while (true)
            {
                Console.Write("Nhập tên (hoặc 'exit' để thoát): ");
                string name = Console.ReadLine();
                if (name.ToLower() == "exit")
                {
                    break;
                }
                names.Add(name);
            }

            Console.WriteLine("\nDanh sách tên đã nhập:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.Write("\nNhập tên cần xoá: ");
            string nameToRemove = Console.ReadLine();
            if (names.Remove(nameToRemove))
            {
                Console.WriteLine($"Đã xoá tên: {nameToRemove}");
                Console.WriteLine("\nDanh sách tên sau khi xoá:");
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
                    
            }
            else
            {
                Console.WriteLine($"Không tìm thấy tên: {nameToRemove}");
            }

        }
    }
}