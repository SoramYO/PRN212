using StudentManagerV3EmptyConstructor.Entities;

namespace StudentManagerV3EmptyConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nếu khuôn class không có phễu/Contructor 
            //ta vẫn luôn đúc được 1 object rỗng object chứa không khí bên trong
            //giống ta đi photo 1 cái form chưa điền, từ từ điền vào
            //java c# cung cấp cho bạn 1 cái constructor phễu không làm gì cả, không đầu vào , giúp mô tả hành động đúc 1 objetc mang giá trị default, object chứa không khí
            //phôt 1 cái form trống từ từ điền vào
            //phôt được new được không làm gì thêm từ từ

            //object rỗng, giống tờ giấy trắng
            //điền thông tin từ từ tương ứng hàm set
            //set() đến đâu xem đến đó hàm get()
            //object luôn được tạo ra
            //java c# tự tạo giùm constructor rỗng empty constructor, default constructor - ko dau vao khong lenh

            Student s1 = new Student(); //contructor tự sinh ra
            Console.WriteLine(s1.ToString());
            Console.WriteLine(s1); //gọi thầm tên em

            s1.ShowProfile();

            s1.SetId("A001");
            s1.SetName("An");
            s1.SetYob(2000);
            s1.SetYob(2002);
            Console.WriteLine("After set id, name, yob");
            s1.ShowProfile();

            //về nhà làm get set toString ShowProfile
        }
    }
}
