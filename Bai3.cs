using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BT_Generic_Collection
{
    public class Bai3
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

            // Bài 3. Tìm số lớn nhất
            Console.WriteLine("Bài 3: Tìm số lớn nhất");
            List<int> numbers3 = new List<int>();
            Console.WriteLine("Nhập các số nguyên (nhập 'end' để dừng):");
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                if (int.TryParse(input, out int num))
                {
                    numbers3.Add(num);
                }
                else
                {
                    Console.WriteLine("Vui lòng nhập số nguyên hợp lệ.");
                }
            }
            if (numbers3.Count > 0)
            {
                int max = numbers3[0];
                foreach (int num in numbers3)
                {
                    if (num > max)
                    {
                        max = num;
                    }
                }
                Console.WriteLine($"Số lớn nhất: {max}");
            }
            else
            {
                Console.WriteLine("Không có số nào được nhập.");
            }
        }
    }
}