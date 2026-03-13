namespace BT_Generic_Collection
{
    public class Bai8
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

            // Bài 8. Đảo ngược danh sách
            Console.WriteLine("Bài 8: Đảo ngược danh sách");
            List<int> numbers8 = new List<int>();
            Console.WriteLine("Nhập các số nguyên (nhập 'end' để dừng):");
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                if (int.TryParse(input, out int num))
                {
                    numbers8.Add(num);
                }
                else
                {
                    Console.WriteLine("Vui lòng nhập số nguyên hợp lệ.");
                }
            }
            
            numbers8.Reverse();
            Console.WriteLine("Danh sách sau khi đảo ngược:");
            foreach (int number in numbers8)
            {
                Console.WriteLine(number);
            }
        }
    }
}