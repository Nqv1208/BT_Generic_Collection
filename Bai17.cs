using System;
using System.Collections.Generic;

namespace BT_Generic_Collection
{
    public class Bai17
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Họ và tên: Nguyễn Quang Vinh");
            Console.WriteLine("Mã sinh viên: 23115053122346");
            Console.WriteLine("Lớp học phần: Lập trình C#");
            Console.WriteLine("---------------------------------");
            
            Console.WriteLine("Bài 17: Tìm phần tử xuất hiện nhiều nhất");
            Console.Write("Nhập số lượng phần tử: ");
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử {i + 1}: ");
                list.Add(int.Parse(Console.ReadLine()));
            }
            Dictionary<int, int> countDict = new Dictionary<int, int>();
            foreach (int item in list)
            {
                if (countDict.ContainsKey(item))
                {
                    countDict[item]++;
                }
                else
                {
                    countDict[item] = 1;
                }
            }
            int maxCount = 0;
            int mostFrequent = list[0];
            foreach (var pair in countDict)
            {
                if (pair.Value > maxCount)
                {
                    maxCount = pair.Value;
                    mostFrequent = pair.Key;
                }
            }
            Console.WriteLine($"Số xuất hiện nhiều nhất: {mostFrequent} (xuất hiện {maxCount} lần)");
        }
    }
}