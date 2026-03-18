using System;
using System.Collections.Generic;
namespace BT_Generic_Collection
{
    public class Bai15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Họ và tên: Nguyễn Quang Vinh");
            Console.WriteLine("Mã sinh viên: 23115053122346");
            Console.WriteLine("Lớp học phần: Lập trình C#");
            Console.WriteLine("---------------------------------");
            
            Console.WriteLine("Bài 15: Sử dụng Dictionary");
            Dictionary<string, string> dictionary = new Dictionary<string, string>
            {
                { "hello", "xin chào" },
                { "world", "thế giới" },
                { "Nguyen", "Quang Vinh" },
                { "programming", "lập trình" }
            };
            Console.Write("Nhập từ tiếng Anh: ");
            string word = (Console.ReadLine() ?? string.Empty).ToLower();
            if (dictionary.ContainsKey(word))
            {
                Console.WriteLine($"Nghĩa: {dictionary[word]}");
            }
            else
            {
                Console.WriteLine("Không tìm thấy từ này trong từ điển.");
            }
        }
    }
}