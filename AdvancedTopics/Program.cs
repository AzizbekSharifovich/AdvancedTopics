using System;
using System.Threading;
using System.Threading.Tasks;

namespace AdvancedTopics;

public class Program
{
    static void Main(string[] args)
    {
        Task<string> boildWaterTask = Task.Run(() => BoilWater());

        Task makeTeaTask = boildWaterTask.ContinueWith(
            (water) => MakeTea(water.Result));

        FryEggs();

        makeTeaTask.Wait();
        Console.WriteLine("Bon appetit!");
    }

    public static void MakeTea( string water)
    {
        Console.WriteLine("Putting teabag into cup... ");
        Thread.Sleep(1000);
        Console.WriteLine($"Pouring {water}");
        Console.WriteLine("Tea is ready!");
    }

    public static string BoilWater()
    {
        Console.WriteLine("Bioling water!");
        Thread.Sleep(5000);
        Console.WriteLine("Water is boiled!");
        return "Water!";
    }

    public static void FryEggs()
    {
        Console.WriteLine("Frying eggs... .");
        Thread.Sleep(2000);
        Console.WriteLine("Eggs are ready!");
    }
}