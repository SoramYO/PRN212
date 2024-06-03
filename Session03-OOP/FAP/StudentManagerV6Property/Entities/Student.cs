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
