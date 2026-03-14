using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BT_Generic_Collection
{
    public class Bai6
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

            // Bài 6. Kiểm tra phần tử tồn tại
            Console.WriteLine("Bài 6: Kiểm tra phần tử tồn tại");
            List<string> strings = new List<string>();
            Console.WriteLine("Nhập các chuỗi (nhập 'end' để dừng):");
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                strings.Add(input);
            }
            Console.WriteLine("Nhập chuỗi cần kiểm tra:");
            string checkString = Console.ReadLine();
            if (strings.Contains(checkString))
            {
                Console.WriteLine($"Chuỗi '{checkString}' tồn tại trong danh sách.");
            }
            else
            {
                Console.WriteLine($"Chuỗi '{checkString}' không tồn tại trong danh sách.");
            }
        }
    }
}