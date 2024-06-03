using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV10PropertyHotkey.Entities
{
    internal class Student
    {
        private string _id; //Backfield 
        private string _name; //Field chống lưng cho property tương ứng
        private int _yob;// Property cứ là gì get set tao lưu value vào field
        private double _gpa;//return value 
        //quên cú pháp gõ property
        //1. Tạo các _field như bình thường
        //2. Gõ propfull + tab + tab

        public string Id               //Property lễ tân tiếp tân receptionist  bồi bàn
                                       //Interface giao tiếp ra ngoài .Id .Id=
                                       //_Backing field là nhà bếp chống đỡ giúp
        {
            get => _id;
            set => _id = value;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public int Yob
        {
            get => _yob;
            set => _yob = value;
        }
        public double Gpa
        {
            get => _gpa;
            set => _gpa = value;
        }
        public override string ToString() => $"Id: {_id}, Name: {Name}, Yob: {Yob}, Gpa: {Gpa}";

        //propertyfull hay : tạo liên kết giữa backing field và property che bên ngoài 
        //viết tự nhiê theo style chạm biến, biến = .Gpa 
        //nên nó mới gọi là property của object - không nhầm lẫn vi phạm encapsulation 
        //nó vẫn gọi hàm pblic get set nhưng lại xài như biến tự nhiên gọi 

        //nhưng nó vẫn lại bị boilerplate 
        //tự nhiên xài biến ở
    }
}
