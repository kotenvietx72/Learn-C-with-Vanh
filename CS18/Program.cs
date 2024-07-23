using System;

namespace CS18
{
    class A
    {
        public void Xinchao() => Console.WriteLine("Xin chao"); // Hàm có 1 câu lệnh dùng cái này
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a?.Xinchao(); // Thay cho dòng if (A != null) a.Xinchao();

            int? age = null; // Biến age có thể nhận giá trị null
            // age.HaxValue: Trả về true thì có giá trị, còn lại là k có giá trị
        }
    }
}