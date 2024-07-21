using System;
using System.Linq; // Khai báo thư viện sử dụng mảng

namespace CS08
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ds = new string[3]; // Khai báo mảng ds có 3 phần tử, có kiểu là string
            ds[0] = "Nguyen Viet Anh";
            ds[1] = "Tran Van Huy";
            ds[2] = "Hihihi";
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(ds[i]);
            }

            int[] ds2 = new int[2] { 1, 2 };
            int[] number = { 1, 2, 3, 4, 5, 6 };
            int a = number.Length; // Lấy ra số lượng phần tử của mảng

            foreach(var i in number) // Vòng for ngắn gọn hơn 
            {
                Console.WriteLine(i);
            }
            int b = number.Rank; // Lấy ra số chiều của mảng
            int c = number.Min(); // Lấy ra giá trị nhỏ nhất
            int d = number.Max(); // Lấy ra giá trị lớn nhất
            int e = number.Sum(); // Lấy ra tổng các giá trị của mảng
            Array.Sort(number); // Sắp xếp các giá trị của mảng tăng dần

            double[,] ds3 = new double[3, 3]; // Mảng 2 chiều
            ds3[1, 1] = 5;
        }
    }
}
