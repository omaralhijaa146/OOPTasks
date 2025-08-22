namespace InterfacesvsAbstract_Classes.TaskRequirementsAsmentioned;

public class Circle : Shape
{
    public double Radius { get; init; }
    
    public Circle(double radius)
    {
        ValidateDimensions(radius);
        Radius = radius;
    }
    

    public override double CalculateArea()
    {
        var area = Math.Round(Math.PI * Math.Pow(Radius,2),4);
        return area;
    }
}