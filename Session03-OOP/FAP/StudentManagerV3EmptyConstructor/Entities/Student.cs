using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV3EmptyConstructor.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;
        //get set toString ShowProfile

        public string GetId() => _id;
        public string GetName() => _name;
        public int GetYob() => _yob;
        public double GetGpa() => _gpa;

        public void SetId(string id) => _id = id; //set Set() tức là thay đổi giá trị bên trong
        public void SetName(string value) => _name = value;  //nhận vào 1 giá trị value và thay đổi bên trong
        public void SetYob(int yob) => _yob = yob; //thống nhất dùng chữ value để gọi biến đầu vào cho hàm set cần 1 giá trị đưa vào cho hàm set
        public void SetGpa(double gpa) => _gpa = gpa;
        public void ShowProfile() => Console.WriteLine(ToString());
        public override string ToString() => $"ID: {_id} | Name: {_name} | YOB: {_yob} | GPA: {_gpa}";

    }
}
