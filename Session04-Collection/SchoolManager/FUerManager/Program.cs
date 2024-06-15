using FUerManager.Entities;
using FUerManager.Services;

namespace FUerManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithLecturerCabinet();
        }

        static void PlayWithLecturerCabinet()
        {
            Cabinet<Lecturer> cabinet = new();
            cabinet.Add(new Lecturer { Id = "LE1", Name = "Dr. John" });
            cabinet.Add(new Lecturer { Id = "LE2", Name = "Dr. Marry", Yob = "Math", Salary = "1000" });
            cabinet.Add(new Lecturer { Id = "LE3", Name = "Dr. Peter" });
            cabinet.PrintItems();
        }

        static void PlayWithStudentCabinet()
        {

            Cabinet<Student> cabinet = new();
            cabinet.Add(new Student { Id = "SE1", Name = "John" });
            cabinet.Add(new Student { Id = "SE2", Name = "Marry", Yob = 2001, Gpa = 3.6 });
            cabinet.Add(new Student { Id = "SE3", Name = "Peter", Yob = 2002, Gpa = 3.7 });
            cabinet.PrintItems();
        }

        static void PlayWithIntegerCabinet()
        {
            Cabinet<int> cabinet = new();
            cabinet.Add(1);
            cabinet.Add(2);
            cabinet.Add(3);
            cabinet.PrintItems();
        }
    }
}
