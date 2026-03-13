using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BT_Generic_Collection
{
    public class Bai1
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

            // Bài 1. Tạo danh sách số nguyên
            Console.WriteLine("Bài 1: Tạo danh sách số nguyên");
            List<int> numbers1 = new List<int>();
            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                numbers1.Add(rand.Next(1, 100));
            }

            foreach (int num in numbers1)
            {
                Console.WriteLine(num);
            }
        }   
    }
}