using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV11PropertyAutoBackingField.Entities
{
    internal class Student
    {
        public string Id { get; set; } //tự lúc runtime sẽ sinh ra giùm _id
        public string Name { get; set; }//tự lúc runtime sẽ sinh ra giùm backing field
        public int Yob { get; set; }
        public double Gpa { get; set; }
        public override string ToString() => $"Id: {Id}, Name: {Name}, Yob: {Yob}, Gpa: {Gpa}";
    }
}
