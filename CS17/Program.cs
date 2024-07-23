using System;
using System.Linq;

namespace CS16
{
    class SinhVien
    {
        public string Hoten { get; set; }
        public int NamSinh { get; set; }
        public string NoiSinh { get; set; }
    }
    class Program
    {
        // Kiểu dữ liệu vô danh
        // Đối tượng chứa thuộc tính chỉ đọc
        // Khai báo: new {thuoctinh = giatri, thuoctinh2 = giatri2 }
        public static void Main(string[] args)
        {
            var sanpham = new { // Đối tượng kiểu vô danh
                Ten = "Iphone 8",
                Gia = 1000,
                NamSx = 2018
            };
            Console.WriteLine($"Ten: {sanpham.Ten}");

            List<SinhVien> DS = new List<SinhVien>() {
                new SinhVien() {Hoten = "Nam", NamSinh = 2000, NoiSinh = "Ha Noi"},
                new SinhVien() {Hoten = "Huy", NamSinh = 2004, NoiSinh = "Ha Noi"},
                new SinhVien() {Hoten = "Vanh", NamSinh = 1999, NoiSinh = "Binh Duong"},
                new SinhVien() {Hoten = "Tu", NamSinh = 2002, NoiSinh = "Thai Binh"},
            };

            // Kiểu dữ liệu động
            dynamic ten1; // Giống var, không cần khởi tạo giá trị đầu
            var ten2 = 123; // Cần cung cấp 1 giá trị ban đầu
        }
    }
}