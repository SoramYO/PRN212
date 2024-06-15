namespace FUerManager.Entities
{
    public class Lecturer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Yob { get; set; }
        public string Salary { get; set; }

        public override string ToString() => $"Id: {Id} | Name: {Name} | Faculty: {Yob} | Position: {Salary}";

        public void ShowProfile() => Console.WriteLine(ToString());
    }
}
