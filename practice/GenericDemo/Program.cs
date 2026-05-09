using System.Data.Common;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        var userstore = new DataStore<int,User>();
        userstore.Add(1,new User{Id=1,Name="dhanush"});

        var productstore = new DataStore<int,Product>();
        productstore.Add(1,new Product{Id=101,Title="this is a product title 1"});

        Console.WriteLine(userstore.Get(1));
        Console.WriteLine(productstore.Get(101));
    }
}

