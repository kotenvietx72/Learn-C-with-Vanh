using System;

namespace CS11
{
    class Program
    {
        static void Main(string[] args) {
            string ten = "Nguyen Viet Anh";
            string thongbao = "Chao ban " + ten; // Nối chuối
            thongbao += "!"; // Chuỗi thông báo thêm !
            string name = @" Hi ha  \     

            Mai iu";     // In ra chuỗi ở nhiều dòng, với các kí tự đặc biệt
            name = $"Xin chao {ten,-20}, cau nha"; // {} Dành ra 20 khoảng trống cho tên, căn lề bên phải, có - căn lề bên trái
            Console.WriteLine(thongbao);
        }
    }
}