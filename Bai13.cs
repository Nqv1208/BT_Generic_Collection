using System;
using System.Collections.Generic;

namespace BT_Generic_Collection
{
    public class Bai13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Họ và tên: Nguyễn Quang Vinh");
            Console.WriteLine("Mã sinh viên: 23115053122346");
            Console.WriteLine("Lớp học phần: Lập trình C#");
            Console.WriteLine("---------------------------------");
            
            Console.WriteLine("Bài 13: Đếm số sinh viên");
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Nguyen Quang Vinh" },
                new Student { Id = 2, Name = "Nguyen Huu Dinh" },
                new Student { Id = 3, Name = "Nguyen Minh Tue" }
            };
            Console.WriteLine($"Tổng số sinh viên: {students.Count}");
        }
    }
}