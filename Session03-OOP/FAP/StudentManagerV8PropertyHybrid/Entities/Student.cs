using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV8PropertyHybrid.Entities
{
    internal class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        public string Id //public ra ngoài mà là đặc trung đặc diểm của 1 object - đặc điểm dịch là property
                         //sv có đặc điểm mô tả là Id, Name, Yob, Gpa
                         //tự nhiên vô cùng khi đề cập truy xuất đặc tính của 1 dối tượng không như java getyob setyob
                         //lúc runtime hàm get set như nhau 
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        } //nói về Id chính là nói về _id
          //.Id là Get() và Set() của _id
          //.Id = "SV001" là Set() của _id

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Yob
        {
            get { return _yob; }
            set { _yob = value; }
        }
        public double Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }
        public override string ToString() => $"Id: {_id}, Name: {Name}, Yob: {Yob}, Gpa: {Gpa}";
    }
}
