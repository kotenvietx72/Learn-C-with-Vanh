using System;

namespace CS14
{
    class Program
    {
        public class Animal {
            public int Legs { set; get; }
            public float Weight { set; get; }
            public void ShowLegs()
            {
                Console.WriteLine($"Legs: {Legs}");
            }
            protected void ShowWeight()
            {
                Console.WriteLine($"Weight: {Weight}");
            }
        }
        sealed public class Cat : Animal { // Các lớp khác k thể kế thừa class Cat (sealed)
            public string Food;
            public Cat() : base() // Gọi lại hàm khởi tạo của lớp cơ sở, nếu hàm khởi tạo có tham số thì truyền tham số
            {
                Legs = 4; Weight = 1;
                Food = "Com";
            }
            public new void ShowLegs() // Khai báo lại thêm new, để định nghĩa lại
            {
                Console.WriteLine($"So chan cua loai meo: {Legs}");
                base.ShowLegs(); // Gọi hàm ShowLegs() của hàm cơ sở
            }
        }
        static void Main(string[] args) {
            Cat a = new Cat();
            a.ShowLegs();
            Animal b = new Cat();
        }
    }
}
