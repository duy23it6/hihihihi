using System;
using System.Collections.Generic;

public class MyStack<T>
{
    private List<T> items;

    public MyStack()
    {
        items = new List<T>();
    }

    public void Push(T item)
    {
        items.Add(item);
    }

    public T Pop()
    {
        if (items.Count == 0)
            throw new InvalidOperationException("The stack is empty.");

        T item = items[items.Count - 1];
        items.RemoveAt(items.Count - 1);
        return item;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Test with integers
        MyStack<int> intStack = new MyStack<int>();
        intStack.Push(1);
        intStack.Push(2);
        intStack.Push(3);
        Console.WriteLine("Popped from int stack: " + intStack.Pop()); // Output: Popped from int stack: 3

        // Test with strings
        MyStack<string> stringStack = new MyStack<string>();
        stringStack.Push("apple");
        stringStack.Push("banana");
        stringStack.Push("cherry");
        Console.WriteLine("Popped from string stack: " + stringStack.Pop()); // Output: Popped from string stack: cherry
    }
}