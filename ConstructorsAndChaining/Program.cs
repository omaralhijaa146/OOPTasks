namespace ConstructorsAndChaining;

class Program
{
    static void Main(string[] args)
    {
        var courses = new List<string> { "Math", "English" };
        var student = new Student("Sobhi","Doe",20,courses);
        Console.WriteLine($"First Name => {student.FirstName}");
        Console.WriteLine($"Last Name => {student.LastName}");
        Console.WriteLine($"Age => {student.AgeName}");
        student.Courses.ForEach(x=>Console.WriteLine($"Course => {x}"));
    }
}

public class Student
{
    private string _firstName;
    private string _lastName;
    private int _age;
    private List<string> _courses;

    public Student(string firstName,string lastName,int age)
    {
     FirstName = firstName;
     LastName = lastName;
     AgeName = age;
    }
    public Student(string firstName, string lastName, int age, List<string> courses):this(firstName,lastName,age)
    {
        Courses = courses;
    }
    
    public List<string> Courses
    {
        get => _courses.ToList();
        init
        {
            if(!IsValidCoursesList(value))
                throw new ArgumentException("Courses cannot be null");
            _courses = value;
        }
    }
    
    public string FirstName { 
        get=>_firstName;
        init => SetName(value, x => _firstName = x);
    }
    
    public string LastName
    {
        get => _lastName;
        init => SetName(value, x => _lastName = x);
    }
    
    public int AgeName
    {
        get=>_age;
        init
        {
            if(!IsValidAge(value)) 
                throw new ArgumentOutOfRangeException("Age cannot be negative");

            _age = value;
        }
    }

    private bool IsValidName(string name)=> string.IsNullOrEmpty(name)&&string.IsNullOrWhiteSpace(name);
           
    
    
    private bool IsValidAge(int age)=> age >= 0;

    private bool IsValidCoursesList(List<string>? courses) => courses is not null;
    
    private void SetName(string name, Action<string> func)
    {
        if(IsValidName(name))
            throw new ArgumentException("Name cannot be empty");
        func(name);
    }
    
}

/*
 * Constructors & Chaining
 
Goal: constructor overloads + this(...).

Student has default, minimal, and full constructors; chain them.

Accept: all fields properly initialized (assert via tests or printed output).
 */