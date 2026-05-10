class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
                new Student { Name = "Dhanush", Age = 20, Grade = 88.5 },
                new Student { Name = "Bob", Age = 22, Grade = 72.0 },
                new Student { Name = "Charlie", Age = 19, Grade = 95.0 },
                new Student { Name = "Diana", Age = 21, Grade = 82.5 },
                new Student { Name = "Ethan", Age = 20, Grade = 65.0 }
        };

        var filteredstudents = students.Where(s=>s.Grade>80);
        Console.WriteLine("top students are");
        foreach(var res in filteredstudents)
        {
            Console.WriteLine($"{res}");
        }
        var sortedlist = filteredstudents.OrderBy(s=>s.Name).ThenBy(s=>s.Grade);
        Console.WriteLine("sorted results");
        foreach(var res in sortedlist)
        {
            Console.WriteLine($"{res}");
        }
    }
}