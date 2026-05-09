using System;
using System.Collections.Generic;

public class DataStore<K,T> where T : class
{
    private Dictionary<K,T> storage = new Dictionary<K, T>();//k->int,string and T -> values of type class
    public void Add(K key,T item)//add user
    {
        storage.Add(key,item);
        Console.WriteLine($"added the item {typeof(T).Name}");
    }
    public T? Get(K key)
    {
        if(storage.ContainsKey(key)) return storage[key];
        return null;
    }
    public void Remove(K key)
    {
        storage.Remove(key);
    }
}