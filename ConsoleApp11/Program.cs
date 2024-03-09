using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

// Абстрактний базовий клас Figure
abstract class Figure
{
    // Абстрактний метод для підрахунку площі
    public abstract double CalculateArea();
}

// Похідний клас Rectangle, успадковує клас Figure
class Rectangle : Figure
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

// Похідний клас Circle, успадковує клас Figure
class Circle : Figure
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

// Похідний клас RightTriangle, успадковує клас Figure
class RightTriangle : Figure
{
    public double Base { get; set; }
    public double Height { get; set; }

    public RightTriangle(double @base, double height)
    {
        Base = @base;
        Height = height;
    }

    public override double CalculateArea()
    {
        return 0.5 * Base * Height;
    }
}

// Похідний клас Trapezoid, успадковує клас Figure
class Trapezoid : Figure
{
    public double TopBase { get; set; }
    public double BottomBase { get; set; }
    public double Height { get; set; }

    public Trapezoid(double topBase, double bottomBase, double height)
    {
        TopBase = topBase;
        BottomBase = bottomBase;
        Height = height;
    }

    public override double CalculateArea()
    {
        return 0.5 * (TopBase + BottomBase) * Height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення масиву посилань на абстрактний клас Figure
        Figure[] figures = new Figure[4];

        // Ініціалізація об'єктів різних класів-нащадків та присвоєння посилань на них у масиві
        figures[0] = new Rectangle(5, 7);
        figures[1] = new Circle(3);
        figures[2] = new RightTriangle(4, 6);
        figures[3] = new Trapezoid(6, 8, 5);

        // Виведення площі кожної фігури
        foreach (var figure in figures)
        {
            Console.WriteLine($"Area: {figure.CalculateArea()}");
        }
    }
}
