namespace OverloadingVsOverriding;

// runtime dispatch => inheritance polymorphism. 
// the CLR will create a structure called virtual method table for each class that has virtual members and it will add a hidden reference to the VMT in the objects created from the class with virtual members.
public class Report
{
    public virtual void Render()
    {
        Console.WriteLine("Render");
    }
}