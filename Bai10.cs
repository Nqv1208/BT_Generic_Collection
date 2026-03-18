using System;
using System.Collections.Generic;

namespace BT_Generic_Collection
{
    public class Bai10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Họ và tên: Nguyễn Quang Vinh");
            Console.WriteLine("Mã sinh viên: 23115053122346");
            Console.WriteLine("Lớp học phần: Lập trình C#");
            Console.WriteLine("---------------------------------");
            
            Console.WriteLine("Bài 10: Tìm phần tử nhỏ nhất");
            Console.Write("Nhập số lượng phần tử: ");
            int n = int.Parse(Console.ReadLine()!);
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử {i + 1}: ");
                list.Add(int.Parse(Console.ReadLine()!));
            }
            if (list.Count > 0)
            {
                int min = list[0];
                foreach (int item in list)
                {
                    if (item < min)
                    {
                        min = item;
                    }
                }
                Console.WriteLine($"Giá trị nhỏ nhất: {min}");
            }
            else
            {
                Console.WriteLine("Danh sách rỗng.");
            }
        }
    }
}