using StudentManagerV8PropertyHybrid.Entities;

namespace StudentManagerV8PropertyHybrid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(); //new default khuôn rông
            //set từng cái
            //cách cũ giống java: s1.SetId("SV001");
            s1.Id = "SV001";
            s1.Name = "Nguyen Van A";
            s1.Yob = 2000;
            s1.Gpa = 3.5;

            Console.WriteLine("Thong tin sinh vien: ");
            Console.WriteLine(s1); //gọi thầm tên em

            //cách mới để new object, không có trong java
            //vừa new vừa gán giá trị vừa new vừa set luôn trên cùng 1 dòng

            Student s2 = new Student { Id = "SV002", Name = "Nguyen Van B", Yob = 2001, Gpa = 3.6 }; //thoải mái đưa vào bất kỳ thứ tự nào 
            Console.WriteLine("Thong tin sinh vien: ");
            Console.WriteLine(s2);

            Student s3 = new Student
            {
                Id = "SV003",
                Name = "Nguyen Van C",
                Gpa = 3.7,
                Yob = 2002
            };
            Console.WriteLine("Thong tin sinh vien: ");
            Console.WriteLine(s3);
            //style viết chuẩn - new object kèm set value cho property
            //kĩ thuật new qua set property được gọi là 
            //object initializer -tạo object và khỏi động luôn các đặc tính

        }
    }
}
