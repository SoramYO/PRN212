namespace NullableV2
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double? _gpa;

        public Student(string id, string name, int yob, double? gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        public void ShowProfile()
        {
            Console.WriteLine($"ID: {_id} | Name: {_name} | YOB: {_yob} | GPA: {_gpa}");
        }
    }
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //    //    double gpa = null;
    //    //    Console.WriteLine("gpa" +gpa);//sẽ bị chửi nếu không khởi tạo giá trị trước khi sử dụng
    //    double? gpa = null;
    //        Console.WriteLine("gpa" + gpa);

    //        Student s1 = null;
    //        Student? s2 = null;
            
    //        //dấu ? đi kèm tên kiểu dữ liệu áp dụng cho biến object hoặc biến primitive/ value type đều được mang ý nghĩa biến có thể chưa giá trị NULL - vô thường, chưa xđ giá trị
    //        //với biến primitive value type (lưu value thuần - dùng luôn)
    //        //ngoài việc lưu value như truyền thống còn thêm việc lưu giá trị NULL mang ý nghĩa ko gì cả
    //        //int? long? double? float? decimal? bool? char? byte? short? sbyte?
    //        //vẫn lưu value thường, và thêm giá trị null
    //        //DATA TYPE LÚC NÀY ĐƯỢC GỌI LÀ NULLABLE DATA TYPE

    //        //BIẾN OBJECT Student s; Student? s;
        
        
        
    //    }
    //}
    internal class Program {        
        static void Main(string[] args)
        {
            Student s1 = new Student("1", "A", 2000, 3.5);
            s1.ShowProfile();
            Student s2 = new Student("2", "B", 2001, null);
            s2.ShowProfile();
            Student s3 = new Student("3", "C", 2002, 4.0);
            s3.ShowProfile();
            Student s4 = null;
            Console.WriteLine("s4 is null");
            s4?.ShowProfile();//coi chừng bị runtime error
            Student? s5 = null;
            Console.WriteLine("s5 is null");
            s5?.ShowProfile();
        }
    }
}
