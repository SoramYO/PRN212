using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV5MutipleContructor.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;
        //1 Class có bao nhiêu contructor là đủ
        //ko có câu trả lời tùy cách bạn đổ info vào các field
        //form đăng kí trên mạng y chang: có field (*) required, có field optional
        //1. NẾU BẠN K TẠO CONTRUCTOR RỖNG VÀ CLASS KHÔNG CÓ CONTRUCTOR THÌ RUNTIME TỰ SINH GIÙM (IMPLICIT CONTRUCTOR)
        //ĐỂ TA NEW ĐƯỢC 1 OBJECT CHỨA DEFAULT _FIELD SAU ĐÓ DÙNG SETTER ĐỂ GÁN GIÁ TRỊ CHO TỪNG FIELD
        //2. BẠN CÓ THỂ CHỦ ĐỘNG TẠO CONTRUCTOR RỖNG (EXPLICIT CONTRUCTOR) 
        //TỪ KHÓA CTOR + TAB + TAB THÌ RUNTIME ĐÂU CẦN TẠO NỮA

        //3. NẾU CLASS CÓ 1 CONTRUCTOR CÓ THAM SỐ BẤT KÌ (VÍ DỤ ĐỔ DUY NHAT 1 ID)
        //THÌ RUNTIME TUYỆT ĐỐI KHÔNG TẠO RA CONTRUCTOR RỖNG lí do : ĐÃ CÓ 1 CÁCH ĐÚC VỪA NÓI RỒI CẦN GÌ CONTRUCTOR KHÁC NỮA

        //mẹo tạo contructor có tham số bất kì

        //ctrl + .

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


        public Student(string id)
        {
            _id = id;
        }
        public Student()
        {
        }


        public string GetInfo()
        {
            return $"ID: {_id}, Name: {_name}, YOB: {_yob}, GPA: {_gpa}";
        }

    }
}
