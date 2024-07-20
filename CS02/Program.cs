using System;

namespace CS02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kiểu dữ liệu
            int a;
            string name;
            string x = "Nguyen Viet Anh";
            object y = x;
            var b = 1; // Chỉ cần nhập dữ liệu máy tự ngầm định kiểu dữ liệu
            const double PI = 3.14; // Biến là hằng số, k thể thay đổi
            // Xuất dữ liệu
                Console.Title = "CS02"; // Viết tiêu đề
                Console.Clear(); // Xoá màn hình
                Console.Write("Chào nè"); // In ra k xuống dòng
                Console.WriteLine(y);
                Console.ForegroundColor = ConsoleColor.Green; // Đổi màu chữ
                Console.WriteLine("Chào nè");
                Console.ResetColor(); // Reset màu chữ về mặc định
            // Nhập dữ liệu
                //Console.ReadKey(); // Chờ người dùng bấm phím bất kì để chạy tiếp
                name = Console.ReadLine(); // Nhập một chuỗi kí tự, bấm enter thì dừng
                //Console.WriteLine(name);
                Console.WriteLine("Xin chào {0}", name); // {0} Thay thế cho biến được nhâp

            string input = Console.ReadLine(); // Nhập số
            a = Convert.ToInt32(input); // Ép kiểu từ string sang int
            //a = int.Parse(input); Ép kiểu
            Console.WriteLine("Xin chào {0}", a);

        }
    }

}
