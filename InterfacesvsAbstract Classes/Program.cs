using SecondApproach = InterfacesvsAbstract_Classes.TaskRequirementsAsmentioned;

namespace InterfacesvsAbstract_Classes;

class Program
{
    static void Main(string[] args)
    {
        
        var circle = new Circle(19.3);
        var rectangle = new Rectangle(10,10);
        var circle2= new Circle(19.3);
        var rectangle2= new Rectangle(10,10);
        
        Console.WriteLine($"circle == circle2  => {(circle== circle2?"Yes":"No")}");
        Console.WriteLine($"rectangle == rectangle2 => {(rectangle==rectangle2?"Yes":"No")}");
        
        Console.WriteLine($"Circle Area = {circle.CalculateArea()}");
        Console.WriteLine($"Rectangle Area = {rectangle.CalculateArea()}");

        
        // Second Approach using the interface and abstract class.

        /*var circle3 = new SecondApproach.Circle(20);
        var circle4 = new SecondApproach.Circle(20);
        Console.WriteLine($"circle3 == circle4 with tolerance in place  => {(TestHasSameArea(circle3,circle4)?"Yes":"No")}");
        Console.WriteLine($"circle3 == circle4 without tolerance in place  => {(circle3==circle4?"Yes":"No")}");*/
    }
    
    public static bool TestHasSameArea(SecondApproach.IShape shape1, SecondApproach.IShape shape2)
    {
        return (shape1.CalculateArea() - shape2.CalculateArea())<ShapeCalculationConstants.Tolerance;
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