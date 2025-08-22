namespace InterfacesvsAbstract_Classes.TaskRequirementsAsmentioned;

public class Rectangle : Shape
{

    public double Width { get; init; }
    public double Height { get; init; }
    
    public Rectangle(double width, double height)
    {
        ValidateDimensions(width, height);
        Width = width;
        Height = height;
    }
    
    public override double CalculateArea()
    {
        var area = Math.Round(Width * Height,4);
        return area;
    }
}