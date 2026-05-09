class Program
{

    static List<string> citynames = new List<string>();
    static void basics()
    {
        // Console.WriteLine("hello worlds");
        // string name;
        // name = Console.ReadLine();
        // Console.Write("my name is "+name);
        // int age = int.Parse(Console.ReadLine());
        // Console.Write(age);
        
    }
 static void Main(String[] args)
    {
        // citynames.Add("hyderabad");
        // citynames.Add("chennai");
        // citynames.Add("delhi");
        // foreach(var item in citynames)
        // {
        //     Console.WriteLine(item);
        // }

        // ListsDemo l = new ListsDemo();
        // l.addusers();
        // l.display();
        GenericBox<int> num = new GenericBox<int>();
        num.content=100;
        Console.WriteLine(num.content);
        GenericBox<string> names = new GenericBox<string>();
        names.content="dhanush keloth";
        Console.WriteLine(names.content);
        num.DisplayData(101);
        names.DisplayData("dhanush keloth");
    }   
}
public class GenericBox<T>
{
    public T content{get;set;}
    public void DisplayData<T>(T data)
    {
        Console.WriteLine($"Data type :{typeof(T)}");
    }
   
}