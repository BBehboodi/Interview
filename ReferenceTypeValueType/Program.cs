using Interview.ReferenceTypeValueType;

var singer = new Singer(name: "David Gilmour", yearOfBirth: 1946);
Console.WriteLine($"Singer variable created. {singer}");

Console.WriteLine($"Calling {nameof(ChangeSinger)} method");
ChangeSinger(singer);
Console.WriteLine($"{nameof(ChangeSinger)} method called. {singer}");

Console.WriteLine($"Calling {nameof(ChangeYearOfBirth)} method");
ChangeYearOfBirth(singer.YearOfBirth);
Console.WriteLine($"{nameof(ChangeYearOfBirth)} method called. {singer}");

Console.ReadLine();

static void ChangeSinger(Singer singer)
{
    singer.Name = "Roger Waters";
    singer.YearOfBirth = 1943;
}

static void ChangeYearOfBirth(int yearOfBirth)
{
    yearOfBirth = 1900;
}