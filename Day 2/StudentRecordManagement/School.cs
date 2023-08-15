using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    internal class School
    {
        static List<Student> s = new List<Student>();


        public void CreateStudent(string Name, int Age, string Gender, List<string>CourseEnrolled , List<char> CourseGrade)
        {
            Student student = new Student(Name,Age,Gender,CourseEnrolled,CourseGrade);
            s.Add(student);
            
        }
        public void Display()
        {
            foreach (Student students in s)
            {
                
                Console.WriteLine(students.Name);
                
                
                
            }
            return;



        }
        public double Calculate_GPA()
        {
            double Agg_Grade = 0;
            double  count = 0;
            foreach (Student student in s)
            {
                
                foreach (char grades in student.CourseGrade) {
                    count++;
                    switch (grades)
                    {
                        case 'A':
                            Agg_Grade += 4;
                            break;
                        case 'B':
                            Agg_Grade += 3;
                            break;
                        case 'C':
                            Agg_Grade += 2;
                            break;
                        case 'D':
                            Agg_Grade += 1;
                            break;
                        case 'E':
                            Agg_Grade += 0;
                            break;
                    }
                }
            }
            return (Agg_Grade/count);
        }


    }
}
