using StudentManagerV7Encapsulation.Entities;

namespace StudentManagerV7Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PlayWithGetSet();
            PlayWithGetSetWithoutEncapsulation();
        }
        //khảo sát về get - lấy thông tin của 1 biến set - thay đổi thông tin của 1 biến
        //thức ra khi khai báo 1 biến là ta đã chơi trò get set rồi

        static void PlayWithGetSetWithoutEncapsulation()
        {
            Student s1 = new Student();
            //Get()
            Console.WriteLine("GET: ID " + s1.Id);
            Console.WriteLine("GET: Name " + s1.Name);
            Console.WriteLine("GET: Yob " + s1.Yob);

            //Set()
            s1.Yob = 2000; //thay đổi value của biến Yob
            Console.WriteLine("GET: Yob after setting " + s1.Yob);
        }
        static void PlayWithGetSet()
        {
            int yob = 2000; //biến local biến khai báo trong hàm dùng cú pháp camelCase không có _ như _field

            //tui muốn lấy giá trị của yob,  get
            //dùng tên biến là có value
            Console.WriteLine("GET yob " + yob);
            int age = 2024 - yob; //get giá trị của yib đem đi tính toán
            Console.WriteLine("GET Age " + age);

            //set tức là thay đổi điều gì đó
            yob = 2004; //hỏi - get yob đang là mấy again

            Console.WriteLine("GET yob after setting " + yob);
            //biến = value xxx nào đó chính là set tức là thay đổi giá trị của biến; biến được đổi qua =
        }
    }
}
//chốt hạ là tiên biến đại diện cho value get tên biến ta có được value
//tên biến tham gia vào biểu thức chính là get value của biến

//1. tên biến chính là value - chính là get - tức là lấy giá trị return giá trị
//2. biến = value chính là set - thay đổi giá trị của biến 

//tên biến đã mang theo 2 ý nghĩa get set rồi
//tên 