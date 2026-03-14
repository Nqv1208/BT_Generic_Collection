using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BT_Generic_Collection
{
    public class Bai2
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

            // Bài 2. Tính tổng các phần tử
            Console.WriteLine("Bài 2: Tính tổng các phần tử");
            List<int> numbers2 = new List<int>();
            Console.WriteLine("Nhập các số nguyên (nhập 'end' để dừng):");
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                if (int.TryParse(input, out int num))
                {
                    numbers2.Add(num);
                }
                else
                {
                    Console.WriteLine("Vui lòng nhập số nguyên hợp lệ.");
                }
            }
            int sum = 0;
            foreach (int num in numbers2)
            {
                sum += num;
            }
            Console.WriteLine($"Tổng: {sum}");
        }
    }
}