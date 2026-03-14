using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BT_Generic_Collection
{
    public class Bai4
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

            // Bài 4. Đếm số chẵn
            Console.WriteLine("Bài 4: Đếm số chẵn");
            List<int> numbers = new List<int>();
            
            while(true)
            {
                Console.Write("Nhập một số nguyên (hoặc 'exit' để kết thúc): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    break;
                }

                if (int.TryParse(input, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Vui lòng nhập một số nguyên hợp lệ.");
                }
            }

            int count = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Số lượng số chẵn đã nhập: {count}");
        }
    }
}