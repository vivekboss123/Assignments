using System.ComponentModel;

namespace Day2Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("____________________MENU_____________________________________________________");
                Console.WriteLine("PRESS 1 TO ADD A STUDENT");
                Console.WriteLine("PRESS 2 TO DISPLAY THE STUDENT DETAIL");
                Console.WriteLine("PRESS 3 TO GET GPA ");

                choice = Convert.ToInt32(Console.ReadLine());

                School school = new School();
            
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the Name of the student ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter age of the student");
                        int age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the gender of the student");
                        string gender = Console.ReadLine();
                        Console.WriteLine("Enter total number of Courses Enrolled");
                        int num = Convert.ToInt32(Console.ReadLine());
                        string courses;
                        char Grades;
                        List<char> coursesList = new List<char>();
                        List<string> list = new List<string>();
                        for (int i = 1; i <= num; i++)
                        {
                            Console.WriteLine($"Enter the Course{i} name");
                            courses = Console.ReadLine();
                            Console.WriteLine($"Enter the Grade of Course {i} A/B/C/D/E");
                            Grades = Convert.ToChar(Console.ReadLine());
                            list.Add(courses);
                            coursesList.Add(Grades);
                        }
                        school.CreateStudent(name, age, gender, list, coursesList);
                        break;

                    case 2:




                        school.Display();
                        break;
                    case 3:
                        Console.WriteLine("The GPA for the Student is :");
                        Console.WriteLine(school.Calculate_GPA());
                        break;
                    default:
                        Console.WriteLine("Entered wrong key");
                        break;



                }

            } while (choice != 0);
        }
    }
}