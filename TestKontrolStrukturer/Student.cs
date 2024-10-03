// See https://aka.ms/new-console-template for more information
public class Student
{
    public int Id { get; set; }
    public string SSN { get; set; }
    public string Name { get; set; }

    public Student(int id, string ssn, string name)
    {
        Id = id;
        SSN = ssn;
        Name = name;
    }

    public override string ToString()
    {
        return $"Id {Id} SSN {SSN} Name {Name}";
    }
}