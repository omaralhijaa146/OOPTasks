namespace InterfacesvsAbstract_Classes;

class Program
{
    static void Main(string[] args)
    {
        
        var circle = new Circle(19.3);
        var rectangle = new Rectangle(10,10);
        var circle2= new Circle(19.3);
        var rectangle2= new Rectangle(10,10);
        
        Console.WriteLine($"circle == circle2  => {(circle==circle2?"Yes":"No")}");
        Console.WriteLine($"rectangle == rectangle2 => {(rectangle==rectangle2?"Yes":"No")}");
        
        Console.WriteLine($"Circle Area = {circle.CalculateArea()}");
        Console.WriteLine($"Rectangle Area = {rectangle.CalculateArea()}");
        
    }
}


/*
 * Interfaces vs. Abstract Classes

Goal: when to pick interface vs. abstract.

Define IShape { double Area(); }.

Create abstract Shape with shared validation (positive dimensions).

Implement Circle, Rectangle.

Accept: tests verify known areas (use tolerance for π).
 */