using System;

namespace CS04
{
    class Program
    {
        static void Main(string[] args) {
            bool isOnline = true;
            isOnline = false;
            int a = 5, b = 6;
            isOnline = a == b;
            Console.WriteLine("a == b ==> {0}", isOnline); 
            Console.WriteLine($"a == b ==> {isOnline}"); // Cách viết khác của biểu thức trên
            Console.WriteLine($"a != b ==> {a != b}");
        }
    }
}