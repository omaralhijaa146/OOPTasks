namespace InterfacesvsAbstract_Classes;

public abstract class Shape:IShape
{
    private double _area;
    public double Area
    {
        get => _area;
        protected set => SetArea(value);
    }
    
    public abstract double CalculateArea();
    
    private void SetArea(double area)
    {
        _area = area > 0 
            ? area 
            : throw new ArgumentException("Area cannot be negative check your calculations.");
    }
    
    protected void ValidateDimensions(params double[] dimensions)
    {
        foreach (var dimension in dimensions)
            if (dimension < 0)
                throw new ArgumentException("Dimensions cannot be negative");
    }

    public static bool operator == (Shape? left, Shape? right)
    {
        if (left is null)
        {
            
            if(right is null)
                return true;
            return false;
        }
        
        return left.Equals(right);
    }

    public static bool operator != (Shape? left, Shape? right)
    {
        return !(left == right);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(GetType(),Math.Round(Area,4));
    }

    public override bool Equals(object? obj)
    {
        var shape = (obj as Shape);
        
        if (shape is null)
            return false;
        
        if (ReferenceEquals(this, obj)) return true;
        return Math.Abs(Area-shape.Area) < ShapeCalculationConstants.Tolerance;
    }
}