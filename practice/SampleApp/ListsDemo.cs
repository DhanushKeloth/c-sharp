using System.Collections.Generic;
using System.Reflection.Metadata;
class ListsDemo
{
    Dictionary<int,string> users = new Dictionary<int, string>();
    public void addusers()
    {
        users.Add(101,"dhanush");
        users.Add(102,"adhi");
    }
    public void display()
    {
        Console.Write(users[101]);
    }
}