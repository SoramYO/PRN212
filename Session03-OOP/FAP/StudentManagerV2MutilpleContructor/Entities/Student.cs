using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV2MutilpleContructor.Entities
{
    public class Student
    {
        private string _id;  //_________ (*)
        private string _name;//_________ (*)
        private int _yob;    //_________
        private double _gpa; //_________

        //1 form có nhiều cách điền 1 account có những info phải điền trước, info khác điền sau, linh hoạt trong cách điền info. Vậy ta cx có nhiều constructor ứng với nhiều cách điền info khác nhau đúc tượng với chất liệu khác nhau liều lượng khác nhau
        //1 class có nhiều constructor ứng với nhiều cách tạo object từ 1 cái class/khuôn

        //CONTRUCTOR LÀ HÀM LUÔN GỌI KÈM TOÁN TỬ NEW
        //NEW NGHĨA LÀ XIN VÙNG RAM NGHĨA LÀ ĐI CLONE PHOTO TỜ GIẤY FORM ĐỂ ĐIỀN INFO. tÊN NÓ VÌ VẬY 100% GIỐNG TÊN CLASS MANG Ý NGHĨA CLONE 1 STUDENT, NEW STUDENT, NEW 1 CÁI FORM ĐỂ ĐIỀN INFO. THAM SỐ CHÍNH LÀ CÁCH ĐỔ MỰC ĐIỀN VÀO CÁC INFO CHỪA CHỖ. LÀ CÁCH ĐỔ VẬT LIỆU VÀO CÁC NGÓC NGÁCH TRONG KHUÔN
        //CTRL + . để tạo constructor


        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        public Student(string id, string name)
        {
            _id = id;
            _name = name;

        }
        //nếu 1 object lúc được new mà không đổ hết value vào trong thì các đặc điểm/field/state của object đó sẽ được gán giá trị mặc định/Dedault Value
        //khác biến cục bộ là mang rác

        //số default là 0
        //chuỗi default là null
        //boolean default là false

        //không sợ bị cảnh báo sai code vì dùng rác, do new đã dọn dẹp rác ram sẵn rồi
        //chứng minh bằng cách new object

        public string GetId() => _id;
        public string GetName() => _name;
        public int GetYob() => _yob;
        public double GetGpa() => _gpa;

        //hàm set nhận value bên ngoài đưa vào đặt tên biến là gì cũng được miễn là có ý x~
        public void SetId(string id) => _id = id;
        public void SetName(string value) => _name = value;
        public void SetYob(int yob) => _yob = yob;
        public void SetGpa(double gpa) => _gpa = gpa;

        //public void ShowProfile()
        //{
        //    Console.WriteLine("My profile");
        //    Console.WriteLine($"ID:   " + _id);
        //    Console.WriteLine("Name:  {0}", _name);
        //    Console.WriteLine($"YOB:  {_yob}");
        //    Console.WriteLine(@$"GPA: {_gpa}");
        //}
        public void ShowProfile() => Console.WriteLine(ToString());
        public override string ToString() => $"ID: {_id} | Name: {_name} | YOB: {_yob} | GPA: {_gpa}";

    }
}
