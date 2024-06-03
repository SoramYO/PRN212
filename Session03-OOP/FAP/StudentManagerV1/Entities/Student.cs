using StudentManagerV1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;//Stream API ben Java (Lambda Expression)
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV1.Entities
{
    public class Student
    {
        
        private string _id; //ĐẶC ĐIỂM, FIELD, STATE, BIẾN ĐẶC BIỆT NẰM NGOÀI HÀM NHƯNG TRONG CLASS CỦA 1 OBJECT THEO QUY TẮC CON LẠC ĐÀ VÀ TỪ _ ĐẦU TIÊN
        private string _name;  
        private int _yob;
        private double _gpa;

        //LẤY CÂY BÚT ĐIỀN VÀO FORM KHI MÌNH NEW, CLONE, XIN 1 CÁI FORM ĐỂ LUU INFO KHI MÌNH CẦN LƯU INFO CỦA 1 SV MỚI BẤT KÌ
        //NÓI THEO CÁI KHUÔN ĐÚC THÌ NÓ CHÍNH LÀ CÁI PHỄU HỨNG VẬT LIỆU ĐỔ VÀO TRONG KHUÔN
        //HÀM CONSTRUCTOR[OR]
        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }
        //lập trình class/oop là lập trình xử lí trên các biên 1 cách chung - chung nhất lất hồi đổ info vào sẽ có giá trị cụ thể
        //y chang giải phương trình bậc 2 Ax^2 + Bx + C = 0
        //                                 Delta = B^2 - 4AC
        //                                 Delta > 0 => 2 nghiệm
        //MAI MỐT ĐƯA INFO CỤ THỂ VÀO THÌ CÓ INFO CỤ THỂ TRẢ VỀ XÂU XỬ LÍ
        //ĐƯA A B C VÀO THÌ CÓ X1 X2
        //ĐƯA ID NAME YOB GPA VÀO THÌ CÓ PROFILE, CÓ CÁI GÌ ĐÓ TRẢ VỀ CỤ THỂ: TUỔI = 2024 - YOB
        //                                                                    CURRENT YEAR - YOB

        //CÁC HÀM XỬ LÍ INFO RA VÔ OBJECT Y CHANH MÌNH GIAO TIẾP VỚI BÊN NGAOIF ĐỜI
        //HÀM HỎI - HỎI NHAU CÂU CHUYỆN - GET() GETTER()
        public string GetId() => _id;
        public string GetName() => _name;
        public int GetYob() => _yob;
        public double GetGpa() => _gpa;

  
        //HÀM THAY ĐỔI- THẤY BẠN CÓ GÌ MÌNH BẮT CHƯỚC SỬA MÌNH SET() SETTER()
        public void SetId(string id) => _id = id;
        public void SetName(string name) => _name = name;
        public void SetYob(int yob) => _yob = yob;
        public void SetGpa(double gpa) => _gpa = gpa;

        //HÀM FLEX THÔNG TIN NHIỀU INFO HƠN THAY VÌ TƯỜNG MIẾNG INFO GET LẺ
        //Y CHANG NHƯ SHOW PROFILE TRÊN MẠNG XÃ HỘI: FACEBOOK, INSTAGRAM
        public void ShowProfile()
        {
            Console.WriteLine("My profile");
            Console.WriteLine($"ID: " + _id);
            Console.WriteLine("Name: {0}", _name);
            Console.WriteLine($"YOB: {_yob}");
            Console.WriteLine(@$"GPA: {_gpa}");//dư @ vì mình k in gì đặc biệt
        }

        //hành động chuẩn hóa mọi object như hành động đem CCCD, CMND khi được hỏi show ra cho việc kiểm tra hành chính
        //với lập trình object show hetes info thân nhân gọi là toString() ToString()
        //hàm java: verb + Object theo con Lạc Đà
        //hàm c#: Verb + Object theo Pascal
        public override string ToString() => $"ID: {_id}, Name: {_name}, YOB: {_yob}, GPA: {_gpa}";

        //public override string ToString()
        //{
        //    return $"ID: {_id}, Name: {_name}, YOB: {_yob}, GPA: {_gpa}";
        //}


    }
}
//Class là tên gọi chung, 1 danh từ chung, là tên gọi chung cho sự phân nhóm phân loại/ classtify 1 đám object có điểm tương đồng nhau: về đặc điểm, hành vi, 
//An Bình Cường Dũng ....=> share chung nhiều đặc điểm hành vi
// -Đăc điểm: id, name, yob, place of birth, address, major, gpa
// -Hành vi: DoQuiz() DoExam() Study() Relax() Work() => Method
// Các bạn An Bình Cường Dũng...=> Student
//                                 ID:.....
//                                 Name:....
//                                 YOB:....
//                                 Place of birth:....
//                                 Major:....
//                                 GPA:....
//                                 PlayGame() -> rank ......
//Class ~ khuôn đúc - Mold - Template, Blueprint(bản thiết kế), Form - biểu mẫu nhập
//Chỉ cần chờ đổ info vào nữa là ra 1 cái gì đó cụ thể - Object
//Làm cái Form/Class Student - Nhóm sv có lợi ích gì
//Khi có 1 sv mới đăng kí nhập học ta chỉ cần clone(new) tọa form trống cho người mới đó đổ info vào ta đã lưu trữ được info của 1 object
//người khác đến : new clone form, fill info => object khác được lưu

//rõ ràng class là khuôn giúp đúc clone/ new được nhiều object 1 cách hiệu quả
//lập trình ôp  - object oriented programming/paradigm
//lối tư duy về cách lưu trữ, xử lý thông tin quanh ta qua nhận diện object -> tìm ra class -> clone object mới trở lại

//object, object, object -> class x

//object, object, object -> class y

//từ x y clone trở lại các object khác tương đương new lưu trữ info của các object khác phát sinh trong tương lai
//với 1 trường học new hoài student 
//với 1 công ty bán hàng new hoài order() payment() 
//với 1 cty quản lí tour du lịch new hoài bookTour() payment()
//với 1 bẹnh viên thì new bệnh nhân() new đơn thuốc lâu lâu new drug()

//với 1 object ở trên sẽ nhìn theo 2 khía cạnh
//1.  Đặc điểm (Tĩnh- State)
//       - id, name, yob, place of birth, address, major, gpa
//2.  Hành vi (Động - Behavior)
//       - DoQuiz() DoExam() Study() Relax() Work()
//       - ComputeBill {voucher, * / + - sản phẩm số lương đơn giá}
//2 thông tin trên được gọi chung là member của object member of a class

//******************************
//THIẾT KẾ OOP:
//1. NHẬN DIỆN OBJECT, VÍ DỤ 30 BẠN VÀ 1 MÌNH TUI
//2. CHIA NHÓM OBJECT TÌM NHÓM OBJECT - TÌM CLASS, THEO ĐẶC ĐIỂM, HÀNH VI CHUNG
//                     NHÓM STUDENT, NHÓM LECTURER
//3. TẠO DỰNG RA DÀN KHUNG CLASS, CÁI FORM VỚI NHỮNG CHỖ TRONG ĐỂ ĐIỀN VÀO SAO NÀY
//Student
//                                 ID:.....
//                                 Name:....
//                                 YOB:....
//                                 Place of birth:....
//                                 Major:....
//                                 GPA:....
//                                 PlayGame() -> rank ......
//4. CHUẨN BỊ VIỆC NHẬN INFO VÀO, ĐIỀN VÀO FORM, TẠO RA OBJECT
//NGOÀI ĐỜI LÀ XIN FORM LẤY BÚT ĐIỀN VÀO 
//TRONG CODE, ĐIỀN FORM LÀ FILL VÀO CÁC FIELD TRONG CLASS
//HÀNH ĐỘNG TRONG CODE LÀ HÀM - HÀM TẠO RA CÁI FORM ĐIỀN FORM ĐỂ TẠO RA OBJECT
//HÀM NÀY GIÚP TẠO RA OBJECT - GIỐNG LẤY BÚT ĐIỀN
//                         CONSTRUCTOR(VERB)
//HÀM NÀY SẼ GỌI LÀ CONSTRUCTOR - GIỐNG NHƯ LẤY CÂY BÚT ĐIỀN VÀO FORM
//5. OBJECT XONG, ĐIỀN BÚT VÀO Ô TRỐNG XONG
//NGÓ LẠI XEM ỔN KHÔNG                  -> NHÌN THẤY ĐÃ ĐIỀN GÌ SET()
//CÓ SAI THÌ LẤY TẨY CHÌNH SỬA          -> SỬA, ĐƯA LẠI INFO VÀO SET() THAY ĐỔI

//6. FLEX CÁI FORM CHO AI CẦN , FLEX HẾT MÌNH CÓ XEM HẾT (GẦN HẾT INFO)
//SHOWPROFILE() 
//TOSTRING() 

// 6 BƯỚC TRÊN GIÚP BẠN TẠO DỰNG RA ĐƯỢC CÁCH BẠN LƯU TRỮ, XỬ LÝ INFO CỦA CÁC OBJECT QUANH TA 
//THÔNG QUA MÁY TÍNH GIỐNG NGOÀI ĐỜI, LƯU TRỮ 1 ĐỐNG FORM ĐÃ ĐIỀN
//7 . ĐÚC OBJECT TRỞ LẠI TỪ CAI FORM
// CLONE CÁI FORM TRƯỚC ĐÃ ĐI PHOTO CÁI FORM NEW CÁI FORM MƯỢN CÁI KHUÔN
// ĐỔ VẬY LIỆU VÀO CÁI FORM ĐÃ NEW, ĐỔ VÀO CÁI PHỄU, ĐỔ MỰC VÀO FORM
// GỌI HÀM CONSTRUCTOR ĐƯA VALUE, ĐƯA VẬT LIỆU, MỰC VÀO PHỄU, KHUÔN, FORM
//CÓ ĐƯỢC OBJECT
//ĐẶT TÊN CHO OBJECT CHO DỄ GỌI
//MÌNH LÀ PERSON DO BA MÁ ĐÚC RA NEW RA

//PERSON TÈO = NEW PERSON("TÈO", 2000, "HÀ NỘI", "CNTT", 3.5)
//PERSON TÍ = NEW PERSON("TÍ", 2000, "HÀ NỘI", "CNTT", 3.5)
//CÓ TÈO TÍ CÓ OBJECT GIAO TIẾP HOY QUA GET SET HAY FLEX PROFILE
//TOÀN BỘ CÁC OBJECT TUÂN THEO THIẾT KẾ CỦA CÁC CLASS CÁI NHÓM MÀ OBJECT THUỘC VỀ
//TÈO TÍ XỔ RA CÁC HÀNH ĐỘNG THEO ĐÚNG NHÓM ĐÃ THIẾT KẾ

//LẬP TRÌNH OOP: CLONE OBJECT HÀNG LOẠT LẬP TRÌNH TRÊN TEMPLETATE CHO 1 NHÓM OBJECT