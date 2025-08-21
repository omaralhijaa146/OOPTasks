namespace InterfacesvsAbstract_Classes;

public class Circle : Shape
{
    private readonly double _radius;
    
    public Circle(double radius)
    {
        ValidateDimensions(radius);
        _radius = radius;
    }
    

    public override double CalculateArea()
    {
        Area = Math.Round(Math.PI * Math.Pow(_radius,2),4);
        return Area;
    }
}