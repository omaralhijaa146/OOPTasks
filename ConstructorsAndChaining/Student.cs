namespace ConstructorsAndChaining;

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