using System;
using System.Collections.Generic;

namespace BT_Generic_Collection
{
    public class Bai9
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Họ và tên: Nguyễn Quang Vinh");
            Console.WriteLine("Mã sinh viên: 23115053122346");
            Console.WriteLine("Lớp học phần: Lập trình C#");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Bài 9: Loại bỏ phần tử trùng lặp");
            Console.Write("Nhập số lượng phần tử: ");
            int n = int.Parse(Console.ReadLine()!);
            List<int> list = new List<int>();
            
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử {i + 1}: ");
                list.Add(int.Parse(Console.ReadLine()!));
            }
            List<int> uniqueList = new List<int>();
            foreach (int item in list)
            {
                if (!uniqueList.Contains(item))
                {
                    uniqueList.Add(item);
                }
            }
            Console.WriteLine("Danh sách mới không chứa phần tử trùng:");
            foreach (int item in uniqueList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}