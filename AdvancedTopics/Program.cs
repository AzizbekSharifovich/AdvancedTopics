 using System;
using System.Threading;

namespace AdvancedTopics;

public class Program
{
    static void Main(string[] args)
    {
        ThreadPool.QueueUserWorkItem(MakeTea, 4);

        FryEggs();

        Console.WriteLine("Bon appetit!");
    }

    public static void MakeTea(object state)
    {
        Console.WriteLine("Bioling water!");
        Thread.Sleep(5000);
        Console.WriteLine("Water is boiled. Pouring into cup... .");
        Console.WriteLine("Tea is ready!");
    }

    public static void FryEggs()
    {
        Console.WriteLine("Frying eggs... .");
        Thread.Sleep(1000);
        Console.WriteLine("Eggs are ready!");
    }
}