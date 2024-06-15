using ListBasic.Entities;
using System.Collections;

namespace ListBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithListGenericV2();
        }

        static void PlayWithListGenericV2()
        {
            List<Student> arr = new();
            arr.Add(new Student { Id = "SE1", Name = "John" });
            arr.Add(new Student { Id = "SE2", Name = "Marry", Yob = 2001, Gpa = 3.6 });
            arr.Add(new Student { Id = "SE3", Name = "Peter", Yob = 2002, Gpa = 3.7 });
            Console.WriteLine("The list of the student");
            foreach (var s in arr) //for tới luôn vùng new() mảng co giãn
                s.ShowProfile();
        }
        static void PlayWithListGenericV1()
        {

            List<int> arr = new List<int>();//khác bên java bên java là interface
                                            //list trong c# là arraylist trong java
                                            //array trong c# k giống arraylist<> trong java
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);

            int sum = 0;
            foreach (var i in arr)
                sum += i;
            Console.WriteLine($"Sum of the list is: {sum}");



        }
        static void PlayWithIntegerList()
        {
            ArrayList arr = new ArrayList(); //là thùng chứa tựa mảng co giãn và k generic,k generic thì

            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(new Student { Id = "SE1", Name = "John", Yob = 2000, Gpa = 3.5 });


            for (int i = 0; i < arr.Count; i++)
                Console.WriteLine(arr[i]);
            Console.WriteLine("The array list is printed by foreach loop:");
            foreach (var i in arr)
                Console.WriteLine(i);

        }
    }
}
