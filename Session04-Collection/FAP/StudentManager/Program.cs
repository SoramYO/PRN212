﻿using StudentManager.Entities;
using StudentManager.Services;

namespace StudentManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cabinet cabin = new Cabinet();
            //Cabinet tuSE = new Cabinet();
            ////30 chỗ

            //Cabinet tuBiz = new Cabinet();

            //tuBiz.AddAStudent(new Student() { Id = "SS1", Name = "An", Yob = 2000, Gpa = 3.0 });
            //tuBiz.AddAStudent(new Student() { Id = "SS2", Name = "Binh", Yob = 2001, Gpa = 3.1 });

            //tuSE.AddAStudent(new Student() { Id = "SE1", Name = "Binh", Yob = 2001, Gpa = 3.1 });
            //tuSE.AddAStudent(new Student() { Id = "SE2", Name = "Cuc", Yob = 2002, Gpa = 3.2 });
            //tuSE.AddAStudent(new Student() { Id = "SE3", Name = "Dung", Yob = 2003, Gpa = 3.3 });

            //tuSE.PrintStudentList();
            //tuBiz.PrintStudentList();


            int choice;
            do
            {
                Menu();
                string input = Console.ReadLine();
                if (int.TryParse(input, out choice))
                {

                    switch (choice)
                    {
                        case 1:
                            cabin.AddStudentMenu();
                            break;
                        case 2:
                            //sort by gpa
                            cabin.SortStudentByGpa();
                            break;
                        case 3:
                            cabin.SortStudentByName();
                            break;
                        case 4:
                            cabin.SearchStudent();
                            break;
                        case 5:
                            cabin.UpdateStudent();
                            break;
                        case 6:
                            cabin.DeleteStudent();
                            break;
                        case 7:
                            Console.WriteLine("Goodbye");
                            return;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                }

            } while (choice != 7);

        }

        static void Menu()
        {
            Console.WriteLine("Student Managerment");
            Console.WriteLine("1. Add a student");
            Console.WriteLine("2. Sort student by gpa");
            Console.WriteLine("3. Sort student by name");
            Console.WriteLine("4. Search student");
            Console.WriteLine("5. Update student");
            Console.WriteLine("6. Delete student");
            Console.WriteLine("7. Quit");
            Console.WriteLine("Select your choice:");
        }
    }
}
