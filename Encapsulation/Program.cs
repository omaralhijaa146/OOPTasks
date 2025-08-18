namespace Encapsulation;

class Program
{
    static void Main(string[] args)
    {
        var student = new Student();
        student.FirstName = "John";
        student.LastName = "Doe";
        student.AgeName = -1;
    }
}


/*
 * Encapsulation & Accessors
Goal: practice access modifiers and validation.

Build a Student class with private fields and public properties: FirstName, LastName, Age.

Validate: Age >= 0, non-empty names. Throw ArgumentOutOfRangeException/ArgumentException.

Accept: setting Age = -1 throws; empty name throws; valid inputs succeed.
 */