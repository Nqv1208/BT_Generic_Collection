using System;
using System.Collections.Generic;

namespace BT_Generic_Collection
{
    public class Bai12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Họ và tên: Nguyễn Quang Vinh");
            Console.WriteLine("Mã sinh viên: 23115053122346");
            Console.WriteLine("Lớp học phần: Lập trình C#");
            Console.WriteLine("---------------------------------");
            
            Console.WriteLine("Bài 12: Tìm sinh viên theo tên");
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

            Console.Write("Nhập tên sinh viên cần tìm: ");
            string? query = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(query))
            {
                Console.WriteLine("Tên tìm kiếm không hợp lệ.");
                return;
            }

            string normalizedQuery = query.Trim().ToLower();
            List<Student> foundStudents = new List<Student>();
            foreach (Student s in students)
            {
                if ((s.Name ?? string.Empty).ToLower().Contains(normalizedQuery))
                {
                    foundStudents.Add(s);
                }
            }
            if (foundStudents.Count > 0)
            {
                Console.WriteLine("Sinh viên tìm thấy:");
                foreach (Student student in foundStudents)
                {
                    Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên với tên này.");
            }
        }
    }
}