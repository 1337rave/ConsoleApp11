using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

// Base class Human
class Human
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }

    public void Introduce()
    {
        Console.WriteLine($"Hello, my name is {Name}, I am {Age} years old, and I am {Gender}.");
    }
}

// Subclass Builder, inheriting from Human
class Builder : Human
{
    public string ConstructionSpecialty { get; set; }

    public void Build()
    {
        Console.WriteLine($"{Name} is a builder specialized in {ConstructionSpecialty}.");
    }
}

// Subclass Sailor, inheriting from Human
class Sailor : Human
{
    public string ShipType { get; set; }

    public void Sail()
    {
        Console.WriteLine($"{Name} is a sailor on a {ShipType} ship.");
    }
}

// Subclass Pilot, inheriting from Human
class Pilot : Human
{
    public string AircraftType { get; set; }

    public void Fly()
    {
        Console.WriteLine($"{Name} is a pilot flying a {AircraftType} aircraft.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Example usage of the classes
        Builder bob = new Builder { Name = "Bob", Age = 35, Gender = "male", ConstructionSpecialty = "general construction" };
        bob.Introduce();
        bob.Build();

        Sailor alice = new Sailor { Name = "Alice", Age = 28, Gender = "female", ShipType = "cargo" };
        alice.Introduce();
        alice.Sail();

        Pilot john = new Pilot { Name = "John", Age = 40, Gender = "male", AircraftType = "passenger" };
        john.Introduce();
        john.Fly();
    }
}


