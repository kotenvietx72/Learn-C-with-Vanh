using System;
using System.Collections.Generic;

namespace CS26
{
    class Progrem
    {
        static void Main(string[] args)
        {
            List<int> ds1 = new List<int>(); // Kiểu List các phần tử có kiểu int
                ds1.Add(1); // Thêm 1 phần tử 1 vào danh sách
                ds1.AddRange(new int[] { 1, 2, 3 }); // Thêm 1 mảng phần tử vào các danh sách
            Console.WriteLine(ds1.Count); // Đưa ra số lượng phần tử
            Console.WriteLine(ds1[0]); // Đưa ra giá trị ở vị trí thứ 0
                ds1.Insert(0, 2); // Chèn vào vị trí thứ 0, giá trị là 2
                // ds1.InsertRange() Chèn 1 mảng các giá trị
            foreach (int i in ds1) // In ra các phần tử của danh sách
            {
                Console.WriteLine(i);
            }
                ds1.RemoveAt(2); // Xoá phần tử ở vị trí 2
                ds1.Remove(1); // Xoá phần tử có giá trị bằng 1, xoá phần tử đầu tiên
                var n = ds1.Find( (e) => { return e > 5; } ); // Trả về phần tử đầu tiên có giá trị > 5
                var rs = ds1.FindAll((e) => { return e > 5; }); // Trả về tất phần tử có giá trị > 5
            /* Kiểm tra với phần tử có kiểu lớp
                var p = products.Find(
                        (p) => {
                             return p.Conutry == "Japan"; }
            );
            if (p != null) => In ra

            Kiểm tra 1 phần tử, còn nhiều phần tử dùng FindAll
            */
            /*
                Sắp xếp các phần tử theo tăng dần
                ds1.Sort( (p1, p2) => {
                if (p1.Price == p2.Price) return 0;
                if (p1.Price > p2.Price) return 1; // Giảm dần thì thay > thành <
                return -1;
            } );
            */
        }
    }
    class Program
    {
        SortedList<int, Progrem> a = new SortedList<int, Progrem>(); // Truy cập danh sách theo key có kiểu int, biến có kiểu Progrem
        /*
         *   var p = products("sanpham2); p lưu giá trị của sanpham2
         *   var keys = products.Keys =>  Lấy ra danh sách key của các sản phẩm
         *   var values = products.Values  => Lấy ra danh sách các giá trị của sản phẩm
         * 
         * 
         * 
         * 
         * 
        */
    }
}