using System;

namespace CS16
{
    class Product<T> // Template của hàm
    {
        T ID;
        public void setID(T ID)
        {
            this.ID = ID;
        }
        public void Print()
        {
            Console.WriteLine($"ID: {ID}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 38;
            Console.WriteLine($"So a: {a}, So b: {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"So a: {a}, So b: {b}");

            float x = 5.7f, y = 4.6f;
            Console.WriteLine($"So x: {x}, So y: {y}");
            Swap(ref x, ref y);
            Console.WriteLine($"So x: {x}, So y: {y}");

            Product<int> sp1 = new Product<int>(); // Hàm có kiểu int
            sp1.setID(1245);
            sp1.Print();

            Product<string> sp2 = new Product<string>(); // Class có kiểu string
            sp2.setID("Hello cau");
            sp2.Print();

            List<int> list1 = new List<int>(); // Danh sách phần tử có kiểu số nguyên, có sử dụng generic
            List<string> list2 = new List<string>();

            Stack<int> stack = new Stack<int>();   // Giải thuật vào sau ra trước
            Queue<int> q = new Queue<int>(); // Giải thuật vào trước ra trước

        }
        static void Swap<T>(ref T a, ref T b ) // Tương tự template
        {
            T x = a;
            a = b;
            b = x;
        }
    }
}
