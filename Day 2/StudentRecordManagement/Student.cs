using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    internal class Student
    {
        string name;
        int age;
        string gender;
        List<string> CourseEnrollment;
        List<char>course_grade;
        float gpa;
       public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; } set { age = value; }
        }
        public string Gender
        {
            get { return gender; } set { gender = value; }
        }
        public List<string> courseEnrollment
        {
            get { return CourseEnrollment; }
            set { CourseEnrollment = value; }
        }

        public List<char> CourseGrade
        {
            get { return course_grade; } set { course_grade = value; }
        }
        public float Gpa
        {
            get { return Gpa; }
        }
        
        public Student() { }
        public Student(string Name, int Age ,string Gender , List<string>CourseEnrollment , List<char>CourseGrade) { 
            this.name = Name; 
            this.age = Age;
            this.gender = Gender;
            this.CourseEnrollment = CourseEnrollment;
            this.course_grade = CourseGrade;
        }
        
        

        
    }
}
