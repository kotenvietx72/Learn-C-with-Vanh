using System;

namespace CS09
{
    class Program
    {
        static void Main(string[] args) {
            xinchao(); // cùng một class có thể gọi như này
            CS09.Program.xinchao(); // Cách gọi hàm xin chào ở namespace khác
        }

        static void xinchao() { // Thêm static để các hàm static khác có thể gọi được
            Console.WriteLine("Chao cau nha");
        }
        // Cấu trúc của 1 hàm
        /*
            (public/private/protected) (static) void/int/string/double <Tên hàm> (Tham số truyền vào){ }
            VD: public static void he() { }
                int vanh(int a, int b) {}
        
        */

        int x = Tinhtoan.Sum(1, 2); // Gọi hàm của class khác
        int y = Tinhtoan.Sum(b:4, a:5); // Truyền tham số khác vị trí

    }

    class Tinhtoan
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static string name(string ho, string ten = "Van") // Truyền tham số mặc định cho tên là Van, nếu truyền tên khác thì thay Van thành tên khác
        {
            return ho + ten;
        }
        static void hi(ref int x, out int kq) // Truyền tham chiếu vào x, trong hàm x bị thay đổi thì gtri ngoài cũng bị thay đổi, kq cũng vậy nhưng thay thành out
        {
            kq = x * x;
        }
    }
}

