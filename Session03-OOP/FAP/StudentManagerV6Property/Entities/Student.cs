using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV6Property.Entities  //package bên java
{
    internal class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        //bỏ qua contructor gọi default() sau đó gọi get và set

        public string GetId() => _id;

        public void SetId(string value) => _id = value;

        public string GetName() => _name;

        public void SetName(string value) => _name = value;

        public int GetYob() => _yob;

        public double GetGgpa() => _gpa;

        public void SetYob(int value) => _yob = value;

        public double Getgpa() => _gpa;

        //COPY AND PASTE VÀ SỬA LẠI CHO PHÙ HỢP
        //NHÀM CHÁN NHƯNG BẮT BUỘC PHẢI LÀM, ĐỂ PUBLIC VÀ ĐIỀU CHỈNH THÔNG TIN 1 OBJECT - BẮT BUỘC PHẢI LÀM, VÀ NHÀM CHÁN - BOILER PLATE CODE
        //CÓ CÁCH NÀO KHÁC ĐỂ GIẢM NHÀM CHÁN KHÔNG?

    }
}
//chốt hạ - không có bên java
//ta muốn có 1 giải pháp thiết kế class tốt ở:
//đảm bảo tính đóng gói của info của object tức là private _field
//che giấu info gọn gàn bên trong object - encapsulation

//2. không có boiler plate code - không nhàm chán

//3. không được public các private field - không an toàn

//4. Get() và Set() tự nhiên đễ dàng như xài biến public - ở bên encapsulation project, Get() và Set() gọn gàn như xài biến bình thuognwf
//tên biến là get , name = là set

//"DỄ NHƯ PUBLIC - CÓ SẴN GET SET MÀ LẠI KHÔNG ĐƯỢC XÀI PUBLIC - TRUNG THÀNH PRIVATE ENCAPSULATION"

//C# QUYẾT ĐỊNH GIẢI QUYẾT VẤN ĐỀ NÀY BẰNG CÁCH SỬ DỤNG PROPERTY
//KHÁI NIỆM MỚI: PROPERTY
//PROPERTY LÀ GÌ??
//           LÀ KĨ THUẬT VIẾT CODE GET() SET() MÀ NHƯ XÀI BIẾN PUBLIC
//           CODE VIẾT GỌN GÀNG KHÔNG NHÀM CHÁN
//           VẪN ĐẢM BẢO GET SET NHƯNG KHÔNG PUBLIC FIELD

//NÓ LÀ HYBRID : - LAI GIỮA HÀM VÀ BIẾN CƠ CHẾ HỖ TRỢ SẴN TRONG C#
//                - LÚC RUNTIME THÌ RUNTIME TỰ CONVERT PROPERTY THÀNH HÀM GET SET. HAY Ở CHỖ : ĐƠN GIẢN CHO DÂN DEV, PHỨC TẠP TỰ RUNTIME LO

//PROPERTY ĐƯA RA: 1 KHAI BÁO - LAI GIỮA BIẾN PUBLIC VÀ HÀM GET SET
//                            - BẠN SẼ THẤY BIẾN PUBLIC - GIỐNG ĐẾN 99% KHAI BÁO BIẾN
//                            - PHẦN CÒN LẠI LÀ HÀM HÉP VỚI GET SET

//CÚ PHÁP:
//          public string Name { get; set; }
//          public string Name { get dính return _name
//                               sety dính đến _name = value đưa vào}
//          code vẫn get set trên field
//nhưng gọi get set xài get set xài như biến public
//          public string Name { get; set; } = "John Doe"; //default value
//khiến cho app sử dụng tự nhiên hơn