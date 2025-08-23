namespace OverloadingVsOverriding;

// In the case of the derived classes the CLR will create a new VMT and will copy the references from the base class VMT to the derived class VMT and will replace any overriden virtual members refernces with the new overriden refernces in the derived class VMT and will add any new virtual members refernces to the derived class VMT.
public class PdfReport : Report
{
    public override void Render()
    {
        Console.WriteLine("Render PDF Report");
    }
}