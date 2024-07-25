using System;

namespace CS19
{
    interface IProduct
    {
        public void A();

        public void B();
    }
    abstract class Product
    {
        protected double Price { get; set; }
        public void Infor() => Console.WriteLine($"Gia san pham: {Price}");

        public void Test() =>Infor();

        //public virtual void In() => Console.WriteLine("Day la Product"); Dùng virtual 

        public abstract void In(); // Dùng abstract không có phần thân
    }
    class Iphone : Product
    {
        public Iphone() => Price = 500;

        public override void In() => Console.WriteLine("Day la Iphone"); // override: Được định nghĩa lại
    }

    class SamSung : IProduct
    {
        public void A() => Console.WriteLine("Day la A");

        public void B() => Console.WriteLine("Day la B");
    }
    class Program
    {
        static void Main(string[] args) { 
            Iphone a = new Iphone();
            a.Test();
            a.In();
        }
    }
}