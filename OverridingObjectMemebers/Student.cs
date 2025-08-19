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
        if(obj is null) return false;
        if(obj is not Student student) return false;
        if(ReferenceEquals(obj,this)) return true;
        return obj.GetHashCode() == GetHashCode();
    }

    public override string ToString()
    {
        return $"Student Id => {StudentId}. First Name => {FirstName}  Last Name => {LastName}";
    }
}