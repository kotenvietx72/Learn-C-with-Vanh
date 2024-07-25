using System;
using System.IO;

namespace CS28
{ 
    public class A
    {
        private FileStream fs = new FileStream("test.txt", FileMode.OpenOrCreate); // Tạo ra fs để đọc ghi file
        // FileMode.Append: Ghi tiếp dữ liệu vào file được ghi, k đè dữ liệu
        public void Write()
        {
            StreamWriter wr = new StreamWriter(fs); // Tạo ra wr để ghi file
            for(int i = 0; i < 10; i++)
            {
                Console.Write($"Nhap vao dong {i + 1}: ");
                string s = Console.ReadLine();
                wr.WriteLine(s); // ghi chuỗi s vào file theo dòng
            }    
            wr.Flush();
            wr.Close();
            fs.Close();
        }
        public void Read()
        {
            StreamReader wr = new StreamReader(fs);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.Write();
        }
    }
}