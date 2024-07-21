using System;
using System.ComponentModel.DataAnnotations;

namespace CS05
{
    class Program
    {
        static void Main(string[] args) {
            Console.Write("Nhap vao so nguyen a: ");
            int a = int.Parse(Console.ReadLine());
            if(a % 2 == 0) 
                Console.WriteLine("{0} la so chan", a);
            else
                Console.WriteLine("{0} la so le", a);
            // Toán tử ba ngôi
            int x = 5, b = 9;
            int max = (x > b) ? x : b;
            Console.WriteLine($"So lon nhat la: {max}");
            int t = 8, y = 2, z = 3;
            int min = (t < y)? ((y < z) ? y : z) : ((y < t) ? y : t);
            Console.WriteLine($"So nho nhat la: {min}");
        }

 
    }
}