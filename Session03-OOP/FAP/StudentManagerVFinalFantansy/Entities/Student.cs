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
