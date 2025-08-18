namespace PropertiesAutoVsCiomputed;

class Program
{
    static void Main(string[] args)
    {
        var student = new Student
        {
            FirstName = "John",
            LastName = "Doe",
            AgeName = 20
        };
        Console.WriteLine(student.FullName);
    }
}


public class Student
{
    private string _firstName;
    private string _lastName;
    private int _age;
    
    
    public string FullName => $"{_firstName} {_lastName}";

    public string FirstName { 
        get=>_firstName;
        set => SetName(value, x => _firstName = x);
    }
    
    public string LastName
    {
        get => _lastName;
        set => SetName(value, x => _lastName = x);
    }
    
    public int AgeName
    {
        get=>_age;
        set
        {
            if(!IsValidAge(value)) 
                throw new ArgumentOutOfRangeException("Age cannot be negative");

            _age = value;
        }
    }

    private bool IsValidName(string name)
    {
        return string.IsNullOrEmpty(name)&&string.IsNullOrWhiteSpace(name);
           
    }
    
    private bool IsValidAge(int age)=> age >= 0;

    private void SetName(string name, Action<string> func)
    {
        if(IsValidName(name))
            throw new ArgumentException("Name cannot be empty");
        func(name);
    }
}