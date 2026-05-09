public class Person
{
    string name{get;set;}
    int age{get;set;}
    public Person(string name,int age)
    {
        this.name=name;
        this.age = age;

    }
    public void introduce()
    {
        Console.WriteLine($"Hi, my name is {name} and I am {age} years old.");
    }
}