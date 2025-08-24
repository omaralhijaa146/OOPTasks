namespace OverridingObjectMemebers;

public class Student
{
    public Guid StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public override int GetHashCode()
    {
        return StudentId.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        var student = (obj as Student);
        if(student is null) return false;
        if(ReferenceEquals(obj,this)) return true;
        return student.GetHashCode() == GetHashCode();
    }

    public override string ToString()
    {
        return $"Student Id => {StudentId}. First Name => {FirstName}  Last Name => {LastName}";
    }
}