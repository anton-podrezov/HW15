var classes = new[]
{
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
};

var allStudents = GetAllStudents(classes);

Console.WriteLine(string.Join(" ", allStudents));


static string[] GetAllStudents(Classroom[] classes)
{
    var allStudentss = classes.SelectMany(x => x.Students).ToArray();

    return allStudentss;
}

public class Classroom
{
    public List<string> Students = new List<string>();
}