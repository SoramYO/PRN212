namespace ArrayStudent.Entities
{
    public class Student
    {
        //_backing field; Get() Set() kiểu Java { get {...} set {...}} profull tab tab -full property
        // bỏ _backing field {get; set;} prop tab tab - auto implemented property
        public string Id { get; set; }
        public string Name { get; set; }

        public string Yob { get; set; }

        public double Gpa { get; set; }

        public override string ToString() => $"Id: {Id} | Name: {Name} | Yob: {Yob} | Gpa: {Gpa}";
        public void ShowProfile() => Console.WriteLine(ToString());

        // ta làm biếng làm constructor, kể cả có tham số và kọ tham số (default, empty) -> LÁT HỒI NEW = CÁCH DÙNG CTOR NGẤM, CTOR TỰ SINH, ctor default,  empty & đi kèm với việc gán property
        //NEW VÀ GÁN PROPERTY CÙNG LÚC => OBJECT INITIALIZER

    }
}
