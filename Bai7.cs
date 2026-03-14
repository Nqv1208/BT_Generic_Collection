namespace BT_Generic_Collection
{
    public class Bai7
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

            // Bài 7. Sắp xếp danh sách
            Console.WriteLine("Bài 7: Sắp xếp danh sách");
            List<int> numbers7 = new List<int>();
            Console.WriteLine("Nhập các số nguyên (nhập 'end' để dừng):");
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                if (int.TryParse(input, out int num))
                {
                    numbers7.Add(num);
                }
                else
                {
                    Console.WriteLine("Vui lòng nhập số nguyên hợp lệ.");
                }
            }

            numbers7.Sort();
            Console.WriteLine("Danh sách sau khi sắp xếp:");
            foreach (int number in numbers7)
            {
                Console.WriteLine(number);
            }
        }
    }
}