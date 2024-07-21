using System;

namespace CS07
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Anh yeu em");
            }
            int j;
            for(j = 1, Console.WriteLine("Khoi tao"); j < 10; j++) // Với j = 1 in ra Khoi tao, còn lại k in
            {
                Console.WriteLine("Hi");
            }    
        }
    }
}