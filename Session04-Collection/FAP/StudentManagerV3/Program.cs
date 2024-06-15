using StudentManagerV2.Entities;
using StudentManagerV3.Services;

namespace StudentManagerV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithStudentAndLecturerCabinet();
        }
        static void PlayWithStudentAndLecturerCabinet()
        {
            CabinetFantasy<Student> studentCabinet = new CabinetFantasy<Student>(5);
            studentCabinet.AddAnItem(new Student() { Id = "SE1", Name = "An" });
            studentCabinet.AddAnItem(new Student() { Id = "SE2", Name = "Binh" });

            CabinetFantasy<Lecturer> lecturerCabinet = new CabinetFantasy<Lecturer>(5);
            lecturerCabinet.AddAnItem(new Lecturer() { Id = "L1", Name = "Cuc" });
            lecturerCabinet.AddAnItem(new Lecturer() { Id = "L2", Name = "Dung" });

            studentCabinet.PrintItems();
            lecturerCabinet.PrintItems();

            CabinetFantasy<double> tuDouble = new CabinetFantasy<double>(5);

            tuDouble.AddAnItem(1.1);
            tuDouble.AddAnItem(2.2);
            tuDouble.AddAnItem(3.3);

            tuDouble.PrintItems();

        }
        static void voidPlayIntCabinet()
        {

            CabinetFantasy<int> cabinet = new CabinetFantasy<int>(5);
            cabinet.AddAnItem(1);
            cabinet.AddAnItem(2);
            cabinet.AddAnItem(3);
            cabinet.AddAnItem(4);
            cabinet.AddAnItem(5);
            cabinet.PrintItems();
        }
    }
}
