using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditional&SwitchPractice : MonoBehaviour
{
    static void Main(string[] args)
    {
        if (20 > 18)
        {
            Console.WriteLine("20 is greater than 18");
        }
    }
}

{
    static void Main(string[] args)
    {
        int x = 20;
        int y = 18;
        if (x > y)
        {
            Console.WriteLine("x is greater than y");
        }
    }
}

{
    static void Main(string[] args)
    {
        int time = 22;
        if (time < 10)
        {
            Console.WriteLine("Good Morning.");
        }
        else if (time < 20) ;
        {
            Console.WriteLine("Good Day.");
        }
        else
        {
            Console.WriteLine("Good Evening.");
        }
    }
}

{
    static void Main(string[] args)
    {
        int time = 20;
        if (time < 18)
        {
            Console.WriteLine("Good day.");
        }
        else
        {
            Console.WriteLine("Good evening.");
        }
    }
}

{
    static void Main(string[] args)
    {
        int time = 20;
        string result = (time < 18) ? "Good day." : "Good evening.";
        Console.WriteLine(result);
    }
}

{
    static void Main(string[] args)
    {
        int day = 4;
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
        }
    }
}

{
    static void Main(string[] args)
    {
        int day = 4;
        switch (day)
        {
            case 6:
                Console.WriteLine("Today is Saturday.");
                break;
            case 7:
                Console.WriteLine("Today is Sunday.");
                break;
            default:
                Console.WriteLine("Looking forward to the weekend.");
                break;
        }
    }
}

