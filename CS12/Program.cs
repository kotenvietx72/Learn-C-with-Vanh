using System;

namespace CS12
{
    class Program
    {
        public struct Product
        {
            public string name;
            public double price;
            public string Get_Price()
            {
                return "Gia san pham la: " + price;
            }
            public string Infor()
            {
                return $"Ten san pham: {name}, gia san pham la: {price}";   
            }
            public Product(string name, double price)
            {
                this.name = name;
                this.price = price;
            }
        }
        static void Main(string[] args) {
            Product sanpham1;
            sanpham1.price = 500;
            sanpham1.name = "Haha";
            Console.WriteLine(sanpham1.Get_Price());

            Product sanpham2 = new Product("May tinh", 1000);
            Console.WriteLine(sanpham2.Infor());

            HocLuc hocsinh1 = HocLuc.Gioi;
            var so = (int)hocsinh1; // Lấy giá trị của hocsinh1 {40}

        }
        // Kiểu liệt kê: Enum
        enum HocLuc { 
            Kem = 10, TrungBinh = 20, Kha = 30, Gioi = 40}
    }
}
