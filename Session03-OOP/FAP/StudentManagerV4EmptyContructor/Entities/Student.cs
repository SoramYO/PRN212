using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV4EmptyContructor.Entities
{
    internal class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;
        //MẶC ĐỊNH NẾU CLASS KHÔNG CÓ CONTRUCTOR KHI RUNTIME RUNTIME SDK HOẶC MÁY ẢO SẼ TỰ TẠO RA 1 CONTRUCTOR RỖNG/DEFAULT KHÔNG ĐẦU VÀO, KHÔNG ĐỔ DATA - IMPLICIT CONTRUCTOR(NGẦM KHÔNG TƯỜNG MINH)

        //BẠN CÓ QUYỀN CHỦ ĐỘNG TẠO CONTRUCTOR DEFAULT NẾU BẠN THÍCH - EXPLICIT CONTRUCTOR(TƯỜNG MINH)

        //mẹo nhỏ: khi tạo contructor CTOR + TAB + TAB

        public Student()
        {

        }
    }
}
