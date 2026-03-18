using System;
using System.Collections.Generic;

namespace BT_Generic_Collection
{
    public class Bai14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Họ và tên: Nguyễn Quang Vinh");
            Console.WriteLine("Mã sinh viên: 23115053122346");
            Console.WriteLine("Lớp học phần: Lập trình C#");
            Console.WriteLine("---------------------------------");

            Console.WriteLine("Bài 14: Xóa sinh viên theo ID");
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Nguyen Quang Vinh" },
                new Student { Id = 2, Name = "Nguyen Huu Dinh" },
                new Student { Id = 3, Name = "Nguyen Minh Tue" }
            };
            Console.Write("Nhập ID sinh viên cần xóa: ");
            int id = int.Parse(Console.ReadLine()!);
            Student? studentToRemove = students.Find(s => s.Id == id);
            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);
                Console.WriteLine("Đã xóa sinh viên.");
                Console.WriteLine("Danh sách sinh viên còn lại:");
                foreach (Student student in students)
                {
                    Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên với ID này.");
            }
        }
    }
}