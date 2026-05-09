using System.Security.Cryptography.X509Certificates;

class Program
{
    static List<string> usernames = new List<string>();
    
    static void StoreDetails()
    {
        Console.WriteLine("Enter the usernames");

        while (true)
        {
            Console.WriteLine("Input name or (stop) to exit:");
            string name = Console.ReadLine();
            if (name.Trim().ToLower() == "stop")
            {
                break;
            }
            if (!string.IsNullOrWhiteSpace(name))
            {
                string formattedName = name.Trim().ToUpper();
                usernames.Add(formattedName);
                
                Console.WriteLine($"Stored: {formattedName}");
            }

        }
    }
    static void displaynames()
    {
        foreach(string name in usernames)
        {
            Console.WriteLine($"{name}");
        }
    }
    static void Main(string[] args)
    {
        StoreDetails();
        Console.WriteLine("stored names are");
        displaynames();
    }
}
