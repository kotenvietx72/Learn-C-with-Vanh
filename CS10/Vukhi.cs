using System;

namespace CS10
{
    class Vukhi  //Internal: Cùng chương trình mới dùng được, k có gì mặc định là internal
    {
        // Khai báo trường dữ liệu
        string name; // Mặc định là private
        public int tuoi;
        internal int namsinh;
        int satthuong, dosatthuong = 0;

        public Vukhi() { // Hàm khởi tạo không tham số
            Console.WriteLine("Hello vanh");
        }
        public Vukhi(string name)
        {
            Console.WriteLine($"Ten ban la {name}");
        }
        // Phương thức
        public int Satthuong(int satthuong)
        {
            this.satthuong = satthuong;
            return satthuong;
        }
        // Hàm setter/getter
        public int Dosatthuong()
        {
            set: {
                Console.WriteLine("Set");
                //dosatthuong = value;  In ra giá trị được gán
            }
            get: {
                return dosatthuong;
            }
        }
        public string Noisanxuat { set; get; }
        // Hàm huỷ giải phóng dữ liệu mà hàm đó đang giữ
        ~Vukhi()
        {
            Console.WriteLine("Huy"); // Khi gọi hàm huỷ thì hàm này được chạy
        }


    }
}
