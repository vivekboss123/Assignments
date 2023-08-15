using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeHierarchy
{
    internal interface IShapes
    {
        double CalculateArea();
        double Calculateperimeter();

    }
    class Circle : IShapes
    {
        int radius;
        List<IShapes> shapes = new List<IShapes>();
        public Circle(int Radius)
        {
            this.radius = Radius;
        }
        public double CalculateArea()
        {
            return 3.14 * radius * radius;
        }
        public double Calculateperimeter() {
            return 2 * 3.14 * radius;
        }
        
    }
    class Rectangle : IShapes
    {
        public int length;
        public int breadth;
        public Rectangle(int Length, int Breadth)
        {
            this.length = Length;
            this.breadth = Breadth;
        }
        public double CalculateArea()
        {
            
            return length * breadth;
        }
        public double Calculateperimeter()
        {
            return 2 * (length + breadth);
        }
    }
        class Triangle : IShapes
        {
            int base1;
            int height;
            int base2;
            int base3;
            public Triangle(int Base1 , int Base2 , int Base3)
            {
                this.base1 = Base1;
                this.base2 = Base2;
                
                this.base3 = Base3;
            }
            
            public double CalculateArea()
            {
            int s = (base1 + base2 + base3) / 2;
            return Math.Sqrt(s*(s-base1)*(s-base2)*(s-base3));
            }
            public double Calculateperimeter()
            {
                return base1+base2+base3;
            }


        }

    }

