using System;

namespace Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Square");
            Console.WriteLine("2 - Rectangle");
            Console.WriteLine("0 - Quit");
            Square s1 = new Square(5);
            Rectangle r1 = new Rectangle(4, 8);

            int key = 0;
            do
            {
                Console.WriteLine("Enter the number");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("------------------------");
                        if (s1.Side > 0)
                        {
                            Console.WriteLine($"Square area: {s1.CalcArea()}");
                        }
                        else
                        {
                            Console.WriteLine("Wrong value");
                        }
                        Console.WriteLine("------------------------");
                        break;
                    case 2:
                        Console.WriteLine("------------------------");
                        if (r1.Width > 0 && r1.Length > 0)
                        {
                            Console.WriteLine($"Rectangle area: {r1.CalcArea()}");
                        }
                        else
                        {
                            Console.WriteLine("Wrong value");
                        }
                        Console.WriteLine("------------------------");
                        break;
                    case 0:
                        Console.WriteLine("------------------------");
                        Console.WriteLine("The program ended");
                        Console.WriteLine("------------------------");
                        break;
                    default:
                        Console.WriteLine("------------------------");
                        Console.WriteLine("There is no such method");
                        Console.WriteLine("------------------------");
                        break;
                }
            }
            while (key != 0);
        }
    }
    abstract class Figure
    {
        public abstract double CalcArea();
    }
    class Square : Figure
    {
        public double Side { get; set; }
        public Square(double side)
        {
            Side = side;
        }

        public override double CalcArea()
        {
            return Side * Side;
        }
    }
    class Rectangle : Figure
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }
        public override double CalcArea()
        {
            return Width * Length;
        }
    }
}

