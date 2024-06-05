using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerVFinalFantansy.Entities
{
    public class Student
    {
        //quên cách gõ propfull tab tab ra backing field và Get Set

        //ngắn gọn tự động generate ra backing field loại bỏ boilerplate
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }
        public override string ToString() => $"Id: {Id}, Name: {Name}, Yob: {Yob}, Gpa: {Gpa}";
        //kĩ thuật này gọi là auto implemented property
        //về kĩ thuật code cực kì ngắn gọn

        //dù xài full property hay auto-implemented ta cùng new style
        //new Student()  {   } OBJECT INITIALIZER

        //bên java ko có trò get set viết theo kiểu này mà phải viết full get set truyền thống k tự nhiên rất boiler plate

        //nhugnw ae java đã có bộ thư viện riêng - Dependency
        //gọi tên là lombok cách code giống c# 
    }
}
//chốt hạ: chiến lược cách thiết kế class
//bạn có thể lựa chọn những cách thức sau để thiết kế class
//(member bên trong class: _field + method/hàm)
//tùy bài toanas , tùy mục đích của class bạn dùng nó ở đâu

//1. Cách 1:
//Tạo 1 class bình thường, với các backing field
//                         với các hàm xử lí trên backing field tự do
//                         thậm chí k ép cần có hàm GET() SET() cho các field
//ví dụ: class service: tập tring vaog xử lí data trong ram, xử lí các nghiệp vụ bài toán(tính khuyến mãi, cập nhật đơn hàng bắt các bussiness rule: slot k quá 3 bệnh nhân)

//2. Cách 2:
//Tạo class với các:
//_backing field
//hàm xử lí info ,có thêm các hàm GET() SET() cho các field
//theo style java có hàm Getx() và SetY()

//3. Cách 3: TẠO CLASS VỚI CÁC
//_backing field
//HÀM XỬ LÍ INFO GET() SET() cho các field
//VIẾT THEO FULL PROPERTY
//KEYWORD GỢI Ý NẾU QUÊN CÚ PHÁP : PROPFULL TAB TAB => RA ĐƯỢC GỢI Ý CODE GET SET STYLE MỚI

//4. Cách 4: Tạo class với các
//DÙNG PROPERTY KIỂU STYLE NGẮN GỌN TIẾT KIỆM SỨC
//VIẾT CODE TRÁNH BOILER PLATE
//GỌI LÀ AUTO GENERATED PROPERTY
//KĨ THUẬT NÀY CÓ HÀM GET() SET() NGẮN GỌN MÀ KHÔNG THẤY XUẤT HIỆN BACKING FIELD
//KEYWORD GỢI Ý NẾU QUÊN CÚ PHÁP : PROP TAB TAB => RA ĐƯỢC GỢI Ý CODE GET SET STYLE NGẮN GỌN

//CÁCH 3 4 GIỐNG NHAU, ĐỀU XÀI PROPERTY (K CÓ TRONG JAVA)
//HAY DÙNG KHI THIẾT KẾ CLASS MÀ MAP XUỐNG TABLE - ENTITY CLASS

//LƯU Ý KHI XÀI CLASS MÀ CÓ ÁP DỤNG PROPERTY - TA CÓ THÊM 1 CÁCH NEW MỚI ĐỐI TƯỢNG

//NEW VÀ ĐỒNG THỜI FILL DATA VÀO BACKING FIELD QUA HÀM GET() SET() BÌNH PHONG/TIẾP TÂN/LỄ TÂN
//var x = new Student(){...}
//var s = new Student(){Id = "1", Name = "A", Yob = 2000, Gpa = 3.0};
//kĩ thuật: object initializer
//KHÔNG NHẦM LẪN VỚI NEW THEO STYLE NAME AGUMENTED (DÙNG CHO CONSTRUCTOR)

//kĩ thuật property không có trong java java dùng hàng dộ bên ngoài  thư viện lombok khiến cho ta thao tác tự nhiên hơn
//s1.Id   s2.Name   s3.Yob   s4.Gpa = 8.6;

//=>gọi hàm mà như gọi biến như sờ chạm đặc tính của 1 object 

