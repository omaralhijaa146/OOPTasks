namespace StaticMembersAndStaticConstructors;

class Program
{
    static void Main(string[] args)
    {
     // initialize static member 
     // Console.WriteLine(Student.Count);

     new Student();
     new Student();
     new Student();
     
     Console.WriteLine(Student.Count);
     Console.WriteLine(Student.Count==3);
    }
}

/*
 * Static Members & Static Constructor
 
Goal: track instances.

Add public static int Count and a static ctor to init state.

Accept: Student.Count == 3.
 */