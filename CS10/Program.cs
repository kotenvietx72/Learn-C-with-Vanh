using System;

namespace CS10
{
    class Program
    {
        static void Main(string[] args)
        {
            Vukhi sungluc = new Vukhi(); // Khởi tạo đối tượng trong bộ nhớ heap, không tham số
            Vukhi sungmay = new Vukhi("Sung may"); // Khởi tạo đối tượng có tham số

            sungmay = null; // Thu hồi bộ nhớ, hàm huỷ được gọi, nhưng chưa biết huỷ lúc nào
            // Khi thiếu bộ nhớ hàm huỷ sẽ được gọi, ít đối tượng thì chưa được gọi

        }
    }
}