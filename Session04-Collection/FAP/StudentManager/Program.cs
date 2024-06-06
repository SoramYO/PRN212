using StudentManager.Entities;
using StudentManager.Services;

namespace StudentManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cabinet tuSE = new Cabinet();
            //30 chỗ

            Cabinet tuBiz = new Cabinet();

            tuBiz.AddAStudent(new Student() { Id = "SS1", Name = "An", Yob = 2000, Gpa = 3.0 });
            tuBiz.AddAStudent(new Student() { Id = "SS2", Name = "Binh", Yob = 2001, Gpa = 3.1 });

            tuSE.AddAStudent(new Student() { Id = "SE1", Name = "Binh", Yob = 2001, Gpa = 3.1 });
            tuSE.AddAStudent(new Student() { Id = "SE2", Name = "Cuc", Yob = 2002, Gpa = 3.2 });
            tuSE.AddAStudent(new Student() { Id = "SE3", Name = "Dung", Yob = 2003, Gpa = 3.3 });

            tuSE.PrintStudentList();
            tuBiz.PrintStudentList();
        }
    }
}
