namespace ConstructorsAndChaining;

class Program
{
    static void Main(string[] args)
    {
        var courses = new List<string> { "Math", "English" };
        var student = new Student("Sobhi","Doe",20,courses);
        Console.WriteLine($"First Name => {student.FirstName}");
        Console.WriteLine($"Last Name => {student.LastName}");
        Console.WriteLine($"Age => {student.AgeName}");
        student.Courses.ForEach(x=>Console.WriteLine($"Course => {x}"));
    }
}

/*
 * Constructors & Chaining
 
Goal: constructor overloads + this(...).

Student has default, minimal, and full constructors; chain them.

Accept: all fields properly initialized (assert via tests or printed output).
 */