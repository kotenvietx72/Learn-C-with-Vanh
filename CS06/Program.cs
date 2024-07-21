using System;

namespace CS06
{
    class Program
    {
        static void Main(string[] args)
        {
            L1: int a = int.Parse(Console.ReadLine());
            switch(a)
            {
                case 0:
                    Console.WriteLine("Ban da nhap 0");
                    break;
                case 1:
                    Console.WriteLine("Ban da nhap 1");
                    break;
                case 2:
                    Console.WriteLine("Ban da nhap 2");
                    break;
                default:
                    Console.WriteLine("Ban nhap so khac");
                    goto L1; //Đi đến điểm có nhãn L1
                    break;
            }    
        }
    }
}