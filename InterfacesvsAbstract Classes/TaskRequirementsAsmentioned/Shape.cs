namespace InterfacesvsAbstract_Classes.TaskRequirementsAsmentioned;

public abstract class Shape:IShape
{
    
    public abstract double CalculateArea();
    protected void ValidateDimensions(params double[] dimensions)
    {
        foreach (var dimension in dimensions)
            if (dimension < 0)
                throw new ArgumentException("Dimensions cannot be negative");
    }

}