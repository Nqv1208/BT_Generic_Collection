using System;
using System.Collections.Generic;

namespace BT_Generic_Collection
{
    public class Bai16
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Họ và tên: Nguyễn Quang Vinh");
            Console.WriteLine("Mã sinh viên: 23115053122346");
            Console.WriteLine("Lớp học phần: Lập trình C#");
            Console.WriteLine("---------------------------------");
            
            Console.WriteLine("Bài 16: Đếm số lần xuất hiện");
            Console.Write("Nhập một chuỗi: ");
            string input = Console.ReadLine() ?? string.Empty;
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (char c in input)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }
            Console.WriteLine("Kết quả:");
            foreach (var pair in charCount)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }
        }
    }
}