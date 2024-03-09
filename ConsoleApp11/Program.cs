using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

// Базовий клас Animal
class Animal
{
    public string Name { get; private set; }

    // Конструктор з параметром для надання імені тварині
    public Animal(string name)
    {
        Name = name;
    }

    public virtual void Introduce()
    {
        Console.WriteLine($"I am {Name}, a generic animal.");
    }
}

// Підклас Tiger, успадковує клас Animal
class Tiger : Animal
{
    public int StripesCount { get; set; }

    // Конструктор з параметром для надання імені та характеристик тигру
    public Tiger(string name, int stripesCount) : base(name)
    {
        StripesCount = stripesCount;
    }

    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine($"I am a tiger with {StripesCount} stripes.");
    }
}

// Підклас Crocodile, успадковує клас Animal
class Crocodile : Animal
{
    public bool IsDangerous { get; set; }

    // Конструктор з параметром для надання імені та характеристик крокодилу
    public Crocodile(string name, bool isDangerous) : base(name)
    {
        IsDangerous = isDangerous;
    }

    public override void Introduce()
    {
        base.Introduce();
        string dangerStatus = IsDangerous ? "dangerous" : "not dangerous";
        Console.WriteLine($"I am a crocodile and I am {dangerStatus}.");
    }
}

// Підклас Kangaroo, успадковує клас Animal
class Kangaroo : Animal
{
    public double JumpHeight { get; set; }

    // Конструктор з параметром для надання імені та характеристик кенгуру
    public Kangaroo(string name, double jumpHeight) : base(name)
    {
        JumpHeight = jumpHeight;
    }

    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine($"I am a kangaroo and I can jump up to {JumpHeight} meters high.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення екземплярів кожного класу тварини з наданням імені та характеристик
        Tiger tiger = new Tiger("Stripes", 50);
        tiger.Introduce();

        Crocodile crocodile = new Crocodile("Snappy", true);
        crocodile.Introduce();

        Kangaroo kangaroo = new Kangaroo("Hoppy", 3.5);
        kangaroo.Introduce();
    }
}
