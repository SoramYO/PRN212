using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Nullable
{

    //trong khuôn viên namespace bạn có thể tạo nhiều
    //class
    //interface
    //delegate (bản chất là 1 class class rất đặc biệt đặc biệt hơn interface)


    //các class/interface có thể tạo lẻ tạo file riêng rẽ nhưng khai báo cùng 
    //namespace ở đầu trang => okie luôn cùng 1 khái niệm
    //namespace là 1 đại gia đình
    //mỗi đứa con là 1 class
    //sống chung như bài này
    //hoặc sống riêng mỗi đứa 1 căn nhà, 1 class riêng lẻ
    internal class Student
    {
        //quy tắt đặt tên field danh từ + con lạc đà từ đầu tiên chữ thường kèm SHift gạch _ dấu cách
        private string _id; //biến khai báo trong class 
        private string _name;//thì được gọi là field, attribute
        private int _yob;//instance variable(nếu không có chữ static đi kèm)
        public double _gpa;//class level variable(nếu có chữ static đi kèm)
                            //hàm(gọi là medthod) là đoạn code được đặt tên xử lí các biến
                            //hàm + field được gọi chung là member of a class 
                            //thành phần, thành viên của một class
                            //biến khai báo ở tham số hàm có thể xài thêm IN OUT REF và khai báo trong hàm => gọi chung là
                            //local variable biến cục bộ
        //constructor + method xử lí biến/field ở trên
        public Student(string id, string name, int yob, double gpa)
        {
            //biến local theo cú pháp con Lạc Đà
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa; //this. dư thừa không có nhầm lẫn info bên ngoài và cái tôi cá nhân bên trong

            //show profile
            
        }
        public void showProfile()
        {
            Console.WriteLine($"{ _id} | { _name} | { _yob} | { _gpa}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithNullV6();

        }

        //NULLABLE - EM CÓ THỂ MANG GIÁ TRỊ NULL
        //VỚI BIÊN OBJECT MỌI BIẾN OBJECT 1 CÁCH TỰ NHIÊN ĐỀU ĐÃ ĐƯỢC QUYỀN LƯU NULL
        //VỚI Ý NGĨA BIẾN CHƯA ĐỀ CẬP ĐẾN 1 OBJECT CỤ THỂ NÀO ĐÓ TỪ TỪ SẼ CÓ
        //OBJECT CỤ THỂ!!!
        //BIẾN OBJECT = NULL; CHUYỆN BÌNH THƯỜNG, SAU ĐÓ CÓ THỂ TRỎ VÙNG NEW() -- NÀO ĐÓ

        //CUỘC CHƠI PHỨC TẠP HƠN 1 CHÚT KHI TA CHƠI VỚI CSDL
        static void PlayWithNullV6()
        {
            //học thêm toán tử 3 ngôi ? mà bên c, java cũng có
            //phía sau chính là if else
            //dựa vào năm sinh thì in ra message: Gen Z, Too Old
            int yob = 2004;
            string msg;
            if (yob > 2000)
                msg = "Gen Z";
            else
                msg = "Too Old";

            msg = yob > 2000 ? "Gen Z" : "Too Old";
            Console.WriteLine(msg);

            Student s1 = new Student("SE1", "Nguyen Van A", 2004, 8.1);
            Student s2 = s1 == null ? s1 : new Student("SE1", "Nguyen Van A", 2004, 8.6);
            //Student s2 = s1 != null ? s1 : new Student("SE1", "Nguyen Van A", 2004, 8.6);
            s2.showProfile();

            //CONDITIONAL TERNANRY OPERATOR - TOÁN TỬ 3 NGÔI - CHUYỆN TÌNH TAY 3 BÊN
            //? ÁP DỤNG CHUNG CHO CẢ BIẾN OBJECT VÀ BIẾN PRIMITIVE - VALUE TYPET

        }
        static void PlayWithNullV5()
        {
            Student s1 = null;

            Student s2 = s1 ?? new Student("SE1", "Nguyen Van A", 2004, 8.6);

            s2.showProfile();
            s1 = new Student("SE2", "Nguyen Van B", 2005, 9.6);
            Student s3 = s1 ?? new Student("SE1", "Nguyen Van A", 2004, 8.6);
            s3.showProfile();

            if(s1 != null)
                s3 = s1;
            else
                s3 = new Student("SE1", "Nguyen Van A", 2004, 8.6);

            //?? toán tử kết nối - coalescing operator
            //kiểm tra biến object có null không rồi bán mình đem mình đi gán
            //thay vì đi gọi hàm như ? null conditional operator

        }


        static void PlayWithNullV4()
        {
            //GÁN GIÁ TRỊ DEFAULT CHO BIẾN OBJECT
            Student s1 = null;
            Student s2 = s1;//s2 cx là null ngay từ đầu cùng trỏ đáy ram như s1 
            s2?.showProfile(); //if(s2 != null) s2.showProfile();

            s2 = s1 ?? new Student("SE1", "Nguyen Van A", 2004, 8.6);
            Console.WriteLine("S2 first");
            s2.showProfile();

            if (s1 != null)
                s2 = s1; //check 1 biến object có trỏ đến null hay không, không null gán biến
            else
                s2 = new Student("SE1", "Nguyen Van A", 2004, 8.6);
            //đảm bảo biến s2 luôn trỏ object tử tế không trỏ null
            Console.WriteLine("S2 later");
            s2.showProfile();


        }
         static void PlayWithNullV2()
        {
            Student s2 = null;
            //s2.showProfile(); //LỖI NGAY LÚC RUNTIME
            if(s2 is null)
                Console.WriteLine("s2 points to null. Please creating an object before using it");
            else
                s2.showProfile();

            if (s2 == null)
                Console.WriteLine("s2 points to null. Please creating an object before using it");
            else
                s2.showProfile();
            //kĩ thuật mới của C#
            Console.WriteLine("The new way to check null a variable before using it");
            s2?.showProfile();
            //câu lệnh hỏi chấm đi kèm tên biến object giúp kiểm tra xem biến object đó có trỏ đến null hay không nếu không bull tức là biến đã trỏ vùng new thì cứ tự nhiên 
            //gọi hàm ko sợ bị báo lỗi runtime reference. Thực ra là lệnh gộp của if else ở trên
            //?  ĐI KÈM LỜI GỌI HÀM CỦA OBJECT, GỘP KIỂM TRA NULL TRƯỚC KHI GỌI HÀM
            //? ĐƯỢC GỌI LÀ: NULL CONDITIONAL OPERATOR - TOÁN TỬ KIỂM TRA NULL CỦA OBJECT
            //THAY VÌ DÙNG IS NULL HOẶC == NULL TA CÓ THỂ DÙNG ? KHI GỌI HÀM CỦA OBJECT
        }
        static void PlayWithNullV3()
        {
            //GÁN CÁC BIẾN OBJECT KHÁC NHAU 
            int a = 10;
            int b = a; //vung ram b mang giá trị y chanha nhưng là 2 vùng ram riêng biệt bên này không ảnh hưởng bên kia
            Console.WriteLine("b = " + b);
            b= 2024;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Student s3 = new Student("SE1", "Nguyen Van A", 2004, 8.6);
            Student s4 = s3; //hai chàng trỏ chung 1 nàng, 2 biến object trỏ chung 1 vùng ram đã new với full info 
            Console.WriteLine("Check if s4 points to the same s3 points to ...");
            s4.showProfile();

            //chứng minh trỏ chung 1 tọa độ
            s4._gpa = 999;
            Console.WriteLine("After changing s4._gpa = 999");
            s3.showProfile();

            //nếu truyền biến object qua tham số hàm F(Student s)
            //KHI GỌI F(s3) F(s4) THÌ s, s3, s4 trỏ cung 1 chỗ new luôn
            //void F(Student s)
            //{
            // s. cái gì đó thì sẽ thay đỏi s3, s4 ở ngoài Mặc nhiên biến
            //}    object truyền vào hàm là tham chiếu, không cần REF, OUT ĐÃ HỌC
            Console.WriteLine("cHECK PROFILE AFTER ASSING TO NULL");
            //S3 VÀ S4 ĐANG CÙNG TRỈ VÙNG NEW 999 ĐÓA HỒNG, SE1 NGUYEN VAN A 2004
            s3 = null;
            s3?.showProfile(); //NULL CONDITIONAL OPERATOR
            s4.showProfile();

        }

        static void PlayWithNullV1()
        {
            Student s1; //XIN RAM
            //s1.showProfile(); //BIẾN MỚI KHAI BÁO THÌ CHỈ LÀ XIN RAM CHỨ CHƯA CÓ VALUE, NÓI THẲNG VALUE RÁC CỦA APP TRƯỚC ĐÓ ĐỂ LẠI
            //JAVA VÀ C#: KHAI BÁO BIẾN XONG, PHẢI GÁN VALUE NÀO ĐÓ SAU ĐÓ MỚI ĐƯỢC DÙNG BIẾN
            //C THOẢI MÁI XIN BIẾN XONG DÙNG LUÔN  KHÔNG GÁN GIÁ TRỊ SAI RÁNG CHỊU

            Student s2 = null; //CÓ XIN RAM, GÁN LUÔN GIÁ TRỊ CHO VÙNG RAM VÙNG RAM CÓ ĐƯỢC DỌN DẸP RỒI, LÚC NÀY BIẾN LƯU TỌA ĐỘ CỦA TẦNG TRỆT - TRỎ TẦNG 0 CỦA CAO ỐC RAM, TOÀN SỐ 0
            s2.showProfile(); //không bị cảnh cáo viết code xài rác!!!
            //LỖI LÚC RUNTIME: s2 = null => BIẾN S2 TRỎ ĐÁY RAM, BYTE NULL
            //Ở ĐÁY KHÔNG CÓ CODE CỦA HÀM SHOWPROFILE() NÊN LỖI THAM CHIẾU LỘN CHỖ KHÔNG CÓ CODE
            //Khái niệm null đưa ra để giai quyết nhiều chuyện, chuyện phổ biến
            //nhất là: Dùng cchos hàm search 1 OBJECT 1 student
            //NẾU KHÔNG TÌM THẤY THÌ TRẢ VỀ OBJECT/SV NÀO ĐÓ
            //NẾU KHÔNG TÌM THẤY THÌ TRẢ VỀ NULL 
            //TRỎ NULL LÀ TRỎ VÙNG KHÔNG CÓ RANG IN THONG BÁO LỖI
        }
        static void CreateAStudentObject()
        {
            //tạo tử tế vì còn tình huống bất thường học sau

            Student         s3 =             new Student("SE1", "Nguyen Van A", 2004, 8.6);
            //data type     biến object      value/object/vùng ram to
            //int            yob               = 2004;
            //cho x là con số nguyên mang giá trị 2004
            //    x         int              2004
            s3.showProfile();
        }
    }
}
