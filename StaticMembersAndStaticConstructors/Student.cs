namespace StaticMembersAndStaticConstructors;

public class Student
{
    public static int Count { get; set;}

    static Student()
    {
        Count = 0;
    }
    
    public Student()
    {
        Count++;
    }
}