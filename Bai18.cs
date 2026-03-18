using System;
using System.Collections.Generic;
using System.Linq;

namespace BT_Generic_Collection
{
    public class Bai18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Họ và tên: Nguyễn Quang Vinh");
            Console.WriteLine("Mã sinh viên: 23115053122346");
            Console.WriteLine("Lớp học phần: Lập trình C#");
            Console.WriteLine("---------------------------------");

            Console.WriteLine("Bài 18: Tìm sinh viên có điểm cao nhất");
            List<Student> students = new List<Student>();

            Console.Write("Nhập số lượng sinh viên: ");
            string? input = Console.ReadLine();
            if (!int.TryParse(input, out int n) || n <= 0)
            {
                Console.WriteLine("Số lượng sinh viên không hợp lệ.");
                return;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập thông tin sinh viên {i + 1}:");

                int id;
                while (true)
                {
                    Console.Write("ID: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out id))
                    {
                        Console.WriteLine("ID không hợp lệ. Vui lòng nhập lại.");
                        continue;
                    }
                    break;
                }

                string name;
                while (true)
                {
                    Console.Write("Name: ");
                    name = Console.ReadLine() ?? string.Empty;
                    if (string.IsNullOrWhiteSpace(name))
                    {
                        Console.WriteLine("Tên không được để trống. Vui lòng nhập lại.");
                        continue;
                    }
                    break;
                }

                double score;
                while (true)
                {
                    Console.Write("Score: ");
                    input = Console.ReadLine();
                    if (!double.TryParse(input, out score))
                    {
                        Console.WriteLine("Điểm không hợp lệ. Vui lòng nhập lại.");
                        continue;
                    }
                    break;
                }

                students.Add(new Student { Id = id, Name = name, Score = score });
            }

            // Tìm sinh viên có điểm cao nhất (không dùng LINQ)
            if (students.Count == 0)
            {
                Console.WriteLine("Danh sách sinh viên rỗng.");
                return;
            }

            Student topStudent = students[0];
            for (int i = 1; i < students.Count; i++)
            {
                if (students[i].Score > topStudent.Score)
                {
                    topStudent = students[i];
                }
            }

            Console.WriteLine("Sinh viên có điểm cao nhất:");
            Console.WriteLine($"ID: {topStudent.Id}, Name: {topStudent.Name}, Score: {topStudent.Score}");
        }
    }
}