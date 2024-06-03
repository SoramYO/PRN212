using StudentManagerV1.Entities;

namespace StudentManagerV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //đúc object clone cái phễu cái khuôn class template fill info vào nhiều việc cùng lúc goi new phễu constructor kèm value vật liệu mực bút đổ vào
            //giống đưa hệ số cho chương trình bậc 2 để có 1 pt cụ thể
            
            Student student = new Student("SE1", "Nguyễn Văn An", 2000, 3.0);
            //data type biến obj         obj tốn ram bự chà bá
            //                           public và priavte gì đó ở object
            Console.WriteLine("Show s1: ");
            student.ShowProfile();
            Console.WriteLine();
            //Tạo 1 sinh viên khác
            Student student2 = new Student("SE2", "Nguyễn Văn Bình", 2001, 3.5);
            Console.WriteLine("Show s2: ");
            Console.WriteLine(student2.ToString());
            Console.WriteLine(student2); //gọi thầm tên em ToString()
            Console.WriteLine();
            //và nếu không có ToString() thì JAVA sẽ hash vùng ram thành thành hexa
            //còn C# làm biếng nó báo, vùng new này là vùng Student
            //muốn không bị khó hiểu kết quả hay muốn in toàn bộ info bên trong object đã đổ vào in toàn bộ info của vùng new bạn nên chủ đọng tạo hàm ToString và khi gọi hàm này không cần .ToString C# và Java tự gọi giùm
            //khi dùng biến object ở các lệnh kiểu chuỗi cw(biến object)
            Student s3 = new ("SE3", "Nguyễn Văn Cường", 2002, 3.2);
            //không cần new Student vì đã có cú pháp mới do đã có Student ở vế trái rồi
            Console.WriteLine("Show s3: ");
            s3.ShowProfile();
            Console.WriteLine();

            var s4 = new Student("SE4", "Nguyễn Văn Dũng", 2003, 3.7);
            //type inference var: tự nhận biết kiểu dữ liệu - có manh mối cho mình suy ra vùng ram
            s4.ShowProfile();

            Console.WriteLine();

            //var s5 = new Student(2004,"SE5", "Nguyễn Văn Anh", 3.9); //eror vì sai kiểu data truyền vào hàm hàm yêu cầu tuân thủ thứ tự khai báo và truyền

            //nhưng
            var s5 = new Student(name: "Nguyễn Văn Em", id: "SE5", gpa: 3.9, yob: 2004);
            //name agument dùng tên tham số để đảo thứ tự đầu vào theo ý thích

            s5.ShowProfile();

            Console.WriteLine();


            Student s6 = s5;
            //2 chàng trỏ 1 nàng
            //void F(Student x)
            //{
            //    x  thay đổi cái gì đó thì nơi gọi ngoài hàm bị thay đổi theo
            //}

            //F(s5); x thay đổi vùng ram vì đang trỏ cùng S5
            //thì S6 cũng thay đổi theo
            //Biến object là truyền tham chiếu trong hàm thay đổi vùng new ngoài hàm thay đổi theo mà không cần ref và out

            //gọi hàm nhận vào 1 object, biến object
            Console.WriteLine("Check s5 before calling method"); //3.9
            Console.WriteLine(s5);
            PassAStudent(s5);
            Console.WriteLine("Check s5 after calling method");//9.99
            Console.WriteLine(s5);
        }

        //Thử nghiệm về truyền object bản chất là truyền địa chỉ tham chiếu mà k cần rè vầ out
        static void PassAStudent(Student x)  //x là biến object 
                                             //nó sẽ lưu tọa độ 1 vùng new
        {
            x.SetGpa(9.99);//2 chàng trỏ 1 nàng x và biến đưa vào
                           //cùng trỏ vào 1 vùng new
                           //x sửa gì vùng new qua x.SetGpa() thì biến đưa vào cũng sửa theo
                           //nên TRUYỀN BIẾN OBJECT LÀ TRUYỀN THAM CHIẾU RỒI MÀ KHÔNG CẦN REF OUT
                           //TRONG HÀM MÀ SỬA NGOÀI HÀM HỐT ĐỦ
                           //TRONG HÀM ẢNH HƯỞNG BÊN NGOÀI XA XA - CHIẾU RỌI - REFERENCE
        }
    }
}
