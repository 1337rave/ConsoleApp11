using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

// Base class Passport
class Passport
{
    public string FullName { get; set; }
    public string Nationality { get; set; }
    public string PassportNumber { get; set; }
    public DateTime DateOfBirth { get; set; }

    public void DisplayInformation()
    {
        Console.WriteLine($"Full Name: {FullName}");
        Console.WriteLine($"Nationality: {Nationality}");
        Console.WriteLine($"Passport Number: {PassportNumber}");
        Console.WriteLine($"Date of Birth: {DateOfBirth.ToShortDateString()}");
    }
}

// Derived class ForeignPassport, inherits from Passport
class ForeignPassport : Passport
{
    public string VisaInformation { get; set; }
    public string PassportCountry { get; set; }

    public void DisplayForeignPassportInformation()
    {
        Console.WriteLine("Foreign Passport Information:");
        DisplayInformation();
        Console.WriteLine($"Passport Country: {PassportCountry}");
        Console.WriteLine($"Visa Information: {VisaInformation}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ForeignPassport foreignPassport = new ForeignPassport
        {
            FullName = "John Doe",
            Nationality = "American",
            PassportNumber = "AB123456",
            DateOfBirth = new DateTime(1990, 5, 15),
            PassportCountry = "United States",
            VisaInformation = "Multiple entry visa - valid until 2025"
        };

        foreignPassport.DisplayForeignPassportInformation();
    }
}
