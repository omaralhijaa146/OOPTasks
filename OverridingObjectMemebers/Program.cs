namespace OverridingObjectMemebers;

class Program
{
    static void Main(string[] args)
    {
        var guidId = Guid.NewGuid();
        var student1 = new Student
        {
            StudentId = guidId,
            FirstName = "John",
            LastName = "Doe"
        };
        var student2 = new Student
        {
            StudentId = guidId,
            FirstName = "John2",
            LastName = "Doe2"
        };
        var student3 = new Student
        {
            StudentId = Guid.NewGuid(),
            FirstName = "John3",
            LastName = "Doe3"
        };
        var student4 = student1;
        Console.WriteLine($"student1 == student2 ? {(student1.Equals(student2)?"Yes":"No")}");
        Console.WriteLine($"student1 == student3 ? {(student1.Equals(student3)?"Yes":"No")}");
        Console.WriteLine($"student2 == student3 ? {(student2.Equals(student3)?"Yes":"No")}");
        Console.WriteLine($"student1 == student4 ? {(student1.Equals(student4)?"Yes":"No")}. Same Reference? {(student1==student4?"Yes":"No")}");
    }
}

/*
 * Overriding object Members (Equality)
Goal: value semantics by key.

Add StudentId: Guid. Override ToString(), Equals(object), GetHashCode() based on StudentId.
Accept: two different objects with same StudentId yield set count = 1.
*/