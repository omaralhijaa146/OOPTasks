namespace InterfacesvsAbstract_Classes;

public class Rectangle : Shape
{
    private readonly double _width;
    private readonly double _height;
    
    public Rectangle(double width, double height)
    {
        ValidateDimensions(width, height);
        _width = width;
        _height = height;
    }
    
    public override double CalculateArea()
    {
        Area = Math.Round(_width * _height,4);
        return Area;
    }
}