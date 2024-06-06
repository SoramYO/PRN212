using ArrayStudent.Entities;

namespace ArrayStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithStudentArrayV5();
        }
        static void PlayWithStudentArrayV5()
        {
            Student s1 = new Student() { Id = "SE1", Name = "An" };
            //lưu hồ sơ của 30 sv
            Student[] arr = new Student[30];
            // má mi 30 biến Student a, b, c, d, e, f...khác
            //[0][1][2]...
            arr[0] = s1;
            arr[1] = new Student() { Id = "SE2", Name = "Binh" };
            arr[2] = new Student() { Id = "SE3", Name = "Cuc" };
            arr[3] = new Student() { Id = "SE4", Name = "Dung" };

            //em thích for hết, dù biết mảng chưa full, chứa null từa lưa cuối mảng, 26 biến Student đang = null
            //for hết là Exception
            Console.WriteLine("The student list");
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] != null) //chỉ in ra những biến khác null
                    arr[i].ShowProfile(); //tầng chấm 2
            Console.WriteLine("The student list print using foreach");
            foreach (Student s in arr)
                if (s != null)
                    s.ShowProfile(); //tầng chấm 2
        }
        static void PlayWithStudentArrayV4()
        {
            Student s1 = new Student() { Id = "SE1", Name = "An" };
            //lưu hồ sơ của 30 sv
            Student[] arr = new Student[30];
            // má mi 30 biến Student a, b, c, d, e, f...khác
            //[0][1][2]...
            arr[0] = s1;
            arr[1] = new Student() { Id = "SE2", Name = "Binh" };
            arr[2] = new Student() { Id = "SE3", Name = "Cuc" };
            arr[3] = new Student() { Id = "SE4", Name = "Dung" };

            Console.WriteLine("The student list print using for i");
            //for (int i = 0; i < arr.Length; i++)
            //CHẾT DO VÙNG BIẾN CÒN LẠI
            //TRỎ NULL, TRO NULL.SHOWPROFILEO EXCEPTIONarr[i]l.ShowProfile®;
            for (int i = 0; i < 4; i++)
                arr[i].ShowProfile();
            Console.WriteLine("The student list print using foreach");
            foreach (Student s in arr)
                s.ShowProfile();//chết luôn khi im
            //x = arr[i] i = 0..29
            //for each luôn chạy từ 0 đến hết mảng, nếu có null thì chết luôn
        }
        static void PlayWithStudentArrayV3()
        {
            Student s1 = new Student() { Id = "SE1", Name = "An" };
            //lưu hồ sơ của 30 sv
            Student[] arr = new Student[30];
            // má mi 30 biến Student a, b, c, d, e, f...khác
            //[0][1][2]...
            arr[0] = s1;
            arr[1] = new Student() { Id = "SE2", Name = "Binh" };
            arr[2] = new Student() { Id = "SE3", Name = "Cuc" };
            arr[3] = new Student() { Id = "SE4", Name = "Dung" };

            arr[4] = arr[1];
            arr[4].Id = "SE3333";

            arr[0].ShowProfile();
            arr[1].ShowProfile();
            arr[2].ShowProfile();
            arr[3].ShowProfile();
            //SE2 | SE333 | SE4 | SE5 | SE333


            //  MÌNH ĐOÁN ĐC KẾT QUẢ PHẢI LÀ MÃY CỦA CÁI HÀM
            //HOẶC CÓ THỂ ĐOÁN PHẢI IN RA SE2 | SE333 | SE4 | SE5 | SE333
            //NHỨNG THỰC TẾ CHẠY CÓ THỂ KHÁC: CODE CÙI/SAI/BUG, HOẶC MÌNH ĐOÁN SAI MÀ CODE THÌ ĐÚNG

            //KĨ THUẬT KIỀM THỬ, SO SÁNH THỰC TẾ HÀM TRẢ VỀ MÃY (ACTUAL VALUE)
            //VÀ CÁI MONG ĐỢI HÀM SẼ PHẢI TRẢ VỀ LÀ MẤY (EXPEÇTED VALUE)
            //KĨ THUẬT, HÌNH THỨC KIỀM THỬ NÀY GỌI LÀ UNIT TESTING - SWỊ

            //NGOÀI ĐỜI, KHI MÌNH CHECK ĐIỀM GHI RA GIẤY, 1 NGƯỜI ĐC GHI 2 LÂN
            //NGOÀI ĐỜI, SỐ VÉ PHIM ĐC BÁN CHO 1 PHIM, CÓ NGƯỜI XEM 2 3 LẦN
            //BÁN ĐC 5000 VÉ, KỌ CÓ NGHĨA 5000 NGƯỜI KHÁC NHAU XEM CÓ KHI CÓ 4980 NGƯỜI KHÁC NHAU XEM
            //VÌ 20 NGƯỜI XEM 2 3 LẦN

        }
        static void PlayWithStudentArrayV2()
        {
            //tạo 1 hồ sơ sv
            Student s1 = new Student();
            s1.Id = "SE1";
            s1.Name = "An"; //Đang gọi hàm SET(value = "An")

            Student s2 = new Student() { Id = "SE2", Name = "Binh", Yob = "2001", Gpa = 3.6 };
            Student s3, s4, s5, s6, s7, s8, s9, s10;

            Student[] arr = {
            new Student() { Id = "SE3" , Name = "Cuc", Yob = "2002", Gpa = 3.5 },
            new Student() { Id = "SE4" , Name = "Dung", Yob = "2003", Gpa = 3.4 },
            };
            Console.WriteLine("The student list");

            arr[0].ShowProfile();
            arr[1].ShowProfile();
        }
        static void PlayWithStudentArrayV1()
        {
            //tạo 1 hồ sơ sv
            Student s1 = new Student();
            s1.Id = "SE1";
            s1.Name = "An"; //Đang gọi hàm SET(value = "An")

            Student s2 = new Student() { Id = "SE2", Name = "Binh", Yob = "2001", Gpa = 3.6 };
            Student s3, s4, s5, s6, s7, s8, s9, s10;

            Student[] arr = { s1, s2 };
            Console.WriteLine("1. Check [0] of arr");
            arr[0].ShowProfile();
            arr[0].Gpa = 8.6;
            Console.WriteLine("1. Check s1");
            s1.ShowProfile();

            //arr[0] = s1 = trỏ cùng SE1 An ở trên 
        }
    }
}

// HANG UDUGLI LA MANG CUA CAL DIEN UDUCCI LA MANG CON TRU 1/2 TẦNG CON TRỎ
// TẦNG #1: TÊN MẢNG - MÁ MÌ - CON TRỎ CAI QUẢN 1 ĐỐNG BIẾN KHÁC, ĐỒNG BIEN NAY LA BIEN CON TRO STUDENT, LECTURER, DOG, CAT...
//TÂNG #2: TỪNG BIẾN STUDENT, TỪNG BIÊN OBJECT, NHIỀU BIẾN SÁT NHAU
// [0][1][2]
//CHÚNG ĐANG CHỜ TRÓ VÙNG NEW STUDENTO NEW OBJECT THÂT SƯ

//TỐN 3 TẦNG RAM, 2 TẦNG TRỎ, 1 TẦNG NEW OBJECT CÓ INFO THẬT SỰ CẦN
// MÃNG OBJECT, TÊN MÁ MÌ CHẤM CX XỔ RA LENGTH [I] CHÍNH LÀ BIẾN OBJECT TRỎ VÙNG NEW THẬT [I] CHẤM XỔ RA HÀM OBJECT
// [I] . SHOWPROFILEO)// MÃNG OBJECT, TÊN MÁ MÌ CHẤM CX XỔ RA LENGTH
//[I] CHÍNH LÀ BIẾN OBJECT TRỎ VÙNG NEW THẬT
//[I] CHẤM XỔ RA HÀM OBJECT
//[I] . SHOWPROFILEO)

//MẢNG PRIMITIVE TỐN 2 TẦNG RAM, 1 TẦNG MÁ MÌ, 1 TẦNG TOÀN VALUE THẬT
//
//CHỐT HẠ QUAN TRỌNG
//CHƠI VỚI MẢNG, NẾU BIẾT MẢNG CHƯA FULL, CHƯA ĐỔ ĐẦY VALUE THÌ KO NÊN FOR HẾT
//VÌ FOR HẾT ĐẾN CUỐI, CUỐI CHƯA GÁN VALUE, == NULL
//CHECK KHÁC NULL MỚI GỌI HÀM, CPU CHECK PHÍ, TÔN CÔNG CHECK MÀ KO IN ĐC |

// CHỈ NÊN FOR ĐẾN SỐ PHẦN TỬ ĐANG CÓ, NẾU CHƯA ĐẦY, KO PHÍ CPU CHECK NULL " NẾU ĐẦY, CHÍNH LÀ FOR HẾT
//VẬY CHỐT HẠ: CHƠI VỚI MẢNG CẦN KIỂM SOÁT MẢNG ĐẦY HAY CHƯA??? ĐỂ FOR ĐẾN CHỖ ĐANG CÓ VALUE, ĐÃ GÁN VALUE
//CHƠI VỚI MẢNG TA CẦN THÊM 1 BIẾN COUNT = 0 LÚC KHỞI ĐẦU
//CỨ THÊM 1 VALUE, GÁN 1 VALUE, TA VIỀT [COUNT] = VALUE; //5 10 15 20 new Student
//COUNT++; //1 2 3 4
//VIẾT GỘP [COUNT++] = VALUE; //5 10 15, NEW STUDENT()
//CHƠI MẢNG CẦN 1 BIẾN PHỤ COUNT ĐỂ FOR CHO ĐÚNG
//MẢNG CÓ 2 HẠN CHẾ:
//KÍCH THƯỚC CỐ ĐỊNH
//DÙNG COUNT ĐỀ ĐẾM

//»>>>>>>>>>>>> NÂNG CẤP MẢNG THÀNH MẢNG CO GIÃN - NỒI CƠM THẠCH SANH, TÚI BA GANG
//mảng ban đầu 0 có gì THÊM VÀO MẢNG, NỞ RA THÊM 1 CHỖ
//thêm mảng nở thêm chỗ = mảng luôn full và nở ra thêm nếu cần

//BÀI TẬP VỀ NHÀ:
//1. HOÀN THIỆN NỐT BÀI QUẢN LÍ SINH VIÊN
//IN RA MENU
//1. ADD STUDENT
// 2. PRINT STUDENTS - SORT THEO TĂNG DẦN VỀ ĐIỂM
// 3. PRINT STUDENTS - SORT THEO TĂNG DẦN VỀ TÊN
//4.XOÁ, SỬA, SEARCH, KO ÉP PHẢI LÀM
//5. QUIT!
//SORT VÀ IN RA: VÔ SỐ TIÊU CHÍ SORT KHÁC NHAU
//

//1. ADD STUDENT - NHẬP TỪ BÀN PHÍM: CONSOLE. READLINE() -> TRẢ VỀ CHUỖI
//-> CẦN SỐ THÌ PHẢI CONVERT, INTERGER. PARSEINTO
//-> BEN NAY TƯƠNG TỰ, CHATGPT

//TÊN, NĂM SINH, ĐIỂM, CÙNG TÊN ĐIỂM GIẢM DẪN, GOM NHÓM THEO TỈNH...
//AI VIẾT DỜ/NEWBIE: MỖI TIÊU CHÍ SORT LÀ 1 HẢM
//MAI MỐT THÊM KIỂU SORT KHÁC LÀ PHẢI SỬA CODE
//VIÊT NGON: CHỈ 1 HÀM SORT, MÀ TIÊN ĐOÁN ĐC TƯƠNG LAI, KO SỬA CODE MỚI
//NGON, KĨ THUẬT DEPENDENCY INJECTION (DI)
//> YOUTUBE GIÁO. LÀNG, MÔN SOFTWARE TESTING CÓ DI CODE DEMO, CỰC ĐÃ
//> DUNG LAMBDA EXPRESSION ||
//
////2. LÀM CLASS LECTURER, TỦ ĐỰNG HỒ SƠ GIẢNG VIÊN I ADD() PRINTO
// THÔNG TIN GIÀNG VIÊN GỖM: ID, NAME, VOB, SALARY
//CHUẨN BỊ CHO BÀI GENERIC <> List<Student>
//
//
//
//NỘP BAI LEN LMS
//Y CHANG NỘP BÀI THI PE
//GIẢM KÍCH THƯỚC THƯ MỤC SOLUTION (VÌ CHỨA LIBRARY - DEPENDENCY TẢI MẠNG VỀ)
//MENU BUILD | CLEAN SOLUTION > NHỎ NGAY > NÉN .ZIP .RAR UPLOAD
