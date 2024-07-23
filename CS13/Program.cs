using System;

namespace CS13
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine($"Hang so PI: {Math.PI}, hang so E: {Math.E}"); // Đưa ra 2 số PI và E
            Console.WriteLine($"Max: {Math.Max(4, 8)}, Min: {Math.Min(2, 9)}"); // Đưa ra min, max
            // Sign trả về dấu của con số, abs lấy giá trị tuyệt đối
            // Lượng giác
            Console.WriteLine($"Sin 90: {Math.Sin(Math.PI/2)}");
            // Sqrt, Pow(a, b), Log(a), Log10(a)
            // Làm tròn: 
                // Math.Round(a); 5,6 -> 6; 5,4 -> 5 : Làm tròn theo quy tắc
                // Math.Ceiling(a): 5,1; 5,5; 5,6 -> 6 : Làm tròn lên nếu có dấu phẩy
                // Math.Floor(b): 5,1; 5,5; 5,6 -> 5 : Làm tròn xuống k quan tâm sau dấu phẩy
                // Math.Truncate(a): 5,4 ->5 : Cắt bỏ phần thập phân
        }
    }
}