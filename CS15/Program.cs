using System;
using static System.Console; // K cần Console.Writeline mà cần WriteLine thôi
using static System.Math;
using HI; // Gọi hàm k cần dùng HI
using xYz = HI.Hello; // Thay cả cụm HI.Hello bằng xYz

namespace CS15
{
    class Program
    {
        static void Main(string[] args) {
            Hello.Xinchao();
            WriteLine(Sqrt(4));
        }
    }
}

namespace HI
{
    public partial class Hello // Từ khoá partial giúp chia nhỏ class thành nhiều file, file khác gọi lại namespace và class, r định nghĩa lại
    {
        public static void Xinchao()
        {
            Console.WriteLine("Xin chao tu class Hello");
        }
    }
}