using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades
{
    internal class Student
    {
        public int size { get; set; }
        string name;

        int[] Grades;
        int sum = 0;
        public Student() { }
        public Student(string Name , int[]grades) { 
            this.name = Name;
            this.Grades = grades;
            Grades = new int[size];
        }
        public void StudentGrade()
        {

            for(int i = 0; i < size; i++)
            {
                sum+= Grades[i];
            }
            Console.WriteLine("Your Grade Average is : "+sum/size);
        }
        
    }
}
