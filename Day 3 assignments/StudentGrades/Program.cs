namespace StudentGrades
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Student student = new Student();
            
            Console.WriteLine("Enter the name of student");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the number of subjects");
            int size = Convert.ToInt32(Console.ReadLine());
            student.size = size;
            int[] Grades = new int[size];
            for (int i = 0; i <size; i++)
            {
                Console.WriteLine($"Enter Subject{i+1} Grade");
                Grades[i]=Convert.ToInt32(Console.ReadLine());
            }

            //Console.WriteLine($"Average : {Grades.Sum()/size}");
            
            
            student = new Student(name,Grades);
            student.StudentGrade();
            

        }
    }
}