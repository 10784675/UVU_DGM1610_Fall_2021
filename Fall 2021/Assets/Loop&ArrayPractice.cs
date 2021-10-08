using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop&ArrayPractice : MonoBehaviour
{
    static void Main(string[] args)
    {
        int i = 0;
        while (i < 5)
        {
            Console.WriteLine(i);
            i++;
        }
    }
}

{
    static void Main(string[] args)
    {
        int i = 0;
        do
        {
            Console.WriteLine(i);
            i++;
        }
        while (i < 5);
    }
}

{
    static void Main(string[] args)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }
    }
}

{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 10; i = i + 2)
        {
            Console.WriteLine(i);
        }
    }
}

{
    static void Main(string[] args)
    {
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        foreach (string i in cars)
        {
            Console.WriteLine(i);
        }
    }
}

{
    static void Main(string[] args)
    {
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        Console.WriteLine(cars[0]);
    }
}

{
    static void Main(string[] args)
    {
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        Console.WriteLine(cars.Length);
    }
}

{
    static void Main(string[] args)
    {
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }
    }
}

{
    static void Main(string[] args)
    {
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        foreach (string i in cars)
        {
            Console.WriteLine(i);
        }
    }
}

