using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace ShapeHierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                
                Console.WriteLine("_________________________________________MENU_______________________________");
                Console.WriteLine("To Calculate Area and perimeter of Circle");
                Console.WriteLine("To Calculate Area and perimeter of Rectangle ");
                Console.WriteLine("To Calculate Area and perimeter of Triangle");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the Radius of the Circle :");
                        int radius = Convert.ToInt32(Console.ReadLine());
                        Circle circles = new Circle(radius);
                        Console.WriteLine("Area of Circle is : " +circles.CalculateArea());
                        Console.WriteLine("Perimeter of Circle is :" +circles.Calculateperimeter());
                        break;
                    case 2:
                        Console.WriteLine("Enter the length of the rectangle");
                        int length = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the breadth of the rectangle");
                        int breadth = Convert.ToInt32(Console.ReadLine());
                        Rectangle rectangle = new Rectangle(length, breadth);
                        Console.WriteLine("Area of rectangle is :" +rectangle.CalculateArea());
                        Console.WriteLine("Perimeter of Triangle is : " +rectangle.Calculateperimeter());
                        break;
                    case 3:
                        Console.WriteLine("Enter the Side 1 of triangle");
                        int side1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the side 2 of triangle");
                        int side2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the side 3 of the triangle");
                        int side3 = Convert.ToInt32(Console.ReadLine());
                        Triangle triangle = new Triangle(side1, side2, side3);
                        Console.WriteLine("Area of Triangle is :" +triangle.CalculateArea());
                        Console.WriteLine("perimeter of triangle is " +triangle.Calculateperimeter());
                        break;
                       
                    default:
                        
                        break;
                }
            }while (true);
        }
    }
}
           

        

            
        
    


