using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    // Task - create inheritance system with abstract class 
    public abstract class Figure
    {
        // property
        public string Name { get; set; }

        // constructors
        public Figure() { }
        public Figure(string name)
        {
            Name = name;
        }

        // abstract methods
        public abstract void GetArea();

        public abstract void GetPerimeter();
    }

    public class Rectangle : Figure
    {
        // properties
        public int BasicSide { get; set; }
        public int HeightSide { get; set; }

        // constructor
        public Rectangle() { }
        public Rectangle(string name, int width, int height) : base(name)
        {
            HeightSide = height;
            BasicSide = width;
        }

        // override methods
        public override void GetArea()
        {
            double area = HeightSide * BasicSide;
            Console.WriteLine($"Calculated square for RECTANGLE is: {area}");
        }

        public override void GetPerimeter()
        {
            double perimeter = HeightSide + BasicSide + HeightSide + BasicSide;
            Console.WriteLine($"Calculated perimeter for RECTANGLE is: {perimeter}");
        }
    }

    class Trapezium : Figure
    {
        // properties
        public int Height { get; set; }
        public int BasicSide { get; set; }
        public int HeightSide { get; set; }
        public int LeftSide { get; set; }
        public int RightSide { get; set; }


        // constructors
        public Trapezium() { }
        public Trapezium(string name, int width, int height, int h, int left, int right) : base(name)
        {
            Height = h;
            BasicSide = width;
            HeightSide = height;
            LeftSide = left;
            RightSide = right;
            
        }

        // override methods
        public override void GetArea()
        {
            double area = (BasicSide + HeightSide) * 2 * Height;
            Console.WriteLine($"Calculated square for TRAPEZIUM is: {area} ");
        }

        public override void GetPerimeter()
        {
            double perimeter = BasicSide + HeightSide + LeftSide + RightSide;
            Console.WriteLine($"Calculated perimeter for TRAPEZIUM is: {perimeter}");
        }

    }

    // create CompositeFigure class with list of figures
    public class CompositeFigure : Figure
    {
        // property with list
        public List<Figure> Figures { get; set; }

        // constructor and methods
        public CompositeFigure(string name) : base(name)
        {
            Name = name;
        }
        public CompositeFigure() // initializing list
        {
            Figures = new List<Figure>() { new Rectangle(), new Trapezium()};
        }

        public void Show()
        {
            Console.WriteLine("Figures in this list: ");
            foreach (var i in Figures)
            {
                Console.WriteLine("- - - - - - ");
                Figures.ToArray();
            }
        }

        public override void GetArea()
        {
            Console.WriteLine("Area for this type of figure is not available!");
        }

        public override void GetPerimeter()
        {
            Console.WriteLine("Perimeter for this type of figure is not available!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle("Rectangle", 20, 18) { };
            rectangle.GetArea();
            rectangle.GetPerimeter();

            Trapezium trapezium = new Trapezium("Trapezium", 14, 17, 9, 19, 12) { };
            trapezium.GetArea();
            trapezium.GetPerimeter();

            CompositeFigure composed = new CompositeFigure("Combined Figure");
            composed.Show();
        }
    }
}
