namespace StaticMembersAndStaticConstructors;

class Program
{
    static void Main(string[] args)
    {
     // initialize static member 
     Console.WriteLine(Student.Count);

     Student.Count = 3;
     Console.WriteLine(Student.Count);
    }
}

/*
 * Static Members & Static Constructor
 
Goal: track instances.

Add public static int Count and a static ctor to init state.

Accept: Student.Count == 3.
 */