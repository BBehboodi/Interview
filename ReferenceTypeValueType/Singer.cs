namespace Interview.ReferenceTypeValueType;

internal class Singer
{
    public Singer(string name, int yearOfBirth)
    {
        Name = name;
        YearOfBirth = yearOfBirth;
    }

    public string Name { get; set; }

    public int YearOfBirth { get; set; }

    public override string ToString()
    {
        return $"Singer => {nameof(Name)}: {Name}, {nameof(YearOfBirth)}: {YearOfBirth}";
    }
}