namespace OverloadingVsOverriding;

// compile-time dispatch => static polymorphism.
// overload is resolved staticaly or at compile time (before running the app).
// when using overloading the most specific signature is chosen.
// the compiler will pick the method and at compile time the IL will have or reference the compiler picked method.
public class Printer
{
    public void Print(int number)
    {
        Console.WriteLine($"Printing Numbers {number}");
    }
    
    public void Print(string text)
    {
        Console.WriteLine($"Printing Text {text}");
    }
}