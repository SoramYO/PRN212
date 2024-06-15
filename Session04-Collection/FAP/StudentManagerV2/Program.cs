using StudentManagerV2.Entities;
using StudentManagerV2.Services;

namespace StudentManagerV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentCabinet tuSEStudent = new StudentCabinet(30);

            tuSEStudent.AddAStudent(new Student() { Id = "SE1", Name = "An" }); //object initializer
            Student s = new Student() { Id = "SE2", Name = "Binh" };

            tuSEStudent.AddAStudent(s);//2 chàng 1 nàng
            s.Gpa = 8.6;
            tuSEStudent.PrintStudents();

            Console.WriteLine();

            LecturerCabinet tuSELecturer = new(30);

            tuSELecturer.AddALecturer(new Lecturer() { Id = "LE1", Name = "An" });

            tuSELecturer.AddALecturer(new Lecturer() { Id = "LE2", Name = "Binh", Salary = 25_000_000 });

            Lecturer l = new Lecturer() { Id = "LE2", Name = "Binh", Salary = 25_000_000 };

            tuSELecturer.AddALecturer(l);

            tuSELecturer.PrintLecturers();

        }
    }
}
//bàn về sụe linh hoạt trong viết code đa mục đích trong viết code
////tham số của hàm - Parameter nghĩa là gi
//là đại diện cho 1 đám value nào đó được truyền vào trong hàm hàm nhận nhiều tham số là hàm nhận đa dạng value khác nhau
// int x đa dạng value x
//double y da dạng value y
//string z da dạng chuỗi câu chữ đưa vào
//1 đoạn code để xử lí thông tin đoạn code này được đặt 1 cái tên gọi

//void F1() { ..} //code bên trong hàm sẽ xử lí data sẵn có trong hàm
//chưa lịh hoặt lắm phải có data phải có sẵn trong hàm

//void F2(int x) {...}
//hàm linh hoạt vì data được đưa vào qua x   x lúc này có thể là bất kì số nào đó

//x được gọi là tham số của hàm
//giúp hàm có thể linh hoạt xử lí nhiều value khác nhau

//linh hoạt nhưng vẫn còn hạn chế

//void f1(int x) //linh hoạt data/value được truyền vào x = 5
//void f2(double y) //linh hoạt data/value được truyền vào y = 5.5
//void f3(string z) //linh hoạt kí tự/chuỗi được truyền vào z = "hello"

//nhưng vẫn chưa linh hoạt lắm vì chỉ có thể truyền vào 1 datatype cố định

//Linh hoạt đỉnh cao - ước mơ

//void fFantacy(dynamic d) //linh hoạt data type/value được truyền vào d = 5
//                    muốn hàm chơi với int thì đưa int vào
//                    muốn hàm chơi với double thì đưa double vào
//                    muốn hàm chơi với string thì đưa string vào

//hàm 2 tầng linh hoạt, 2 mức linh hoạt
//levell 1: bạn muốn chơi với data type nào,chọn đi đưa cho hàm
//fFantacy(string x)
//fFantacy(int x)
//fFantacy(double x)

//lần đầu tiền datatype int long float double string, Student, Lecturer
//được đưa vào 1 hàm 1 class được xem là tham số

//level 2: truyền thống: Data , value của datatype đó là gì

//fFantacy(string x) //string x = "hello"
//fFantacy(int x) //int x = 5, x = 10

//linh hoạt datatype và linh hoạt với value của datatype
//quen từ c java  viết hàm mới có tham số
//mới có sau này của oop
//java c# giống 100%

//hàm mà chơi linh hoạt 2 level là: xác định datatype muốn choi sau đó mới xác định value của datatype đó

//kĩ thuật mà hàm class chơi với đa dạng datatype và đa dạng value của datatype đó được gọi là Generics - chơi tổng quát chung chung với các datatype

//dùng kí hiệu <T> để biểu diễn Generics để nói rằng hàm hay class này chơi với đa dạng datatype và đa dạng value của datatype đó

//lần đầu tiên xàu hàm mà nó ko đưa value vội mà phải đưa pass datatype vào trước

//gọi hàm gọi class mà phải xd ngay trước tiên datatype muốn chơi

//truyền data type như truyền tham số generic

//quen List<Student>
//     ArrrayList<Student> bên java
//bên c y chang

//QUAY LẠI BÀI CABINET
//CHƠI GENERIC, CABINET CHƠI VỚI ĐỦ DẠNG MẢNG KHÁC NHAU BÊN TRONG NÓ! ! !

//Có: CABINET<STUDENT>
//CABINET<LECTURER>
//CABINET < TIGER >

//THAM SỐ HÓÁ CÁI VALUE CỦA HÀM -> ĐÃ QUEN TỪ C, JAVA KHI CHƠI HÀM
//void F(int x)

//THAM SỐ HÓÁ CÁI DATA TYPE ĐƯA VÀO HÀM,' DATA TYPE CX LÀ THAM SỐ LUÔN
//void F(??? x)
//??? có thể là int, double, Student, Lecturer...

// THIẾT KẾ 1 CLASS, HÀM CÓ THỂ CHƠI VỚI ĐA DẠNG DATA TYPE (DĨ NHIÊN ĐA DẠNG VALUE CỦA DATA TYPE)
//GENERIC (CHUNG CHUNG KO ĐỀ CẬP ĐẾN 1 DATA TYPE CỤ THỂ)