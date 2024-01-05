using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using SylviaLib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Sylvia!");

        Garden myGarden = SylviaLogic.MakeGardenForTesting("Testificate");

        myGarden.CreatePlot("Orchard");
        myGarden.CreatePlot("Berry Patch");
        myGarden.CreatePlot("Garden");

        myGarden.CreatePlant("Potato", "Garden");
        myGarden.CreatePlant("Potato", "Garden");
        myGarden.CreatePlant("Brocoli", "Garden");
        myGarden.CreatePlant("Brocoli", "Garden");
        myGarden.CreatePlant("Corn", "Garden");
        myGarden.CreatePlant("Corn", "Garden");
        myGarden.CreatePlant("Plum Tree", "Orchard");
        myGarden.CreatePlant("Plum Tree", "Orchard");
        myGarden.CreatePlant("Blackberry", "Berry Patch");
        myGarden.CreatePlant("Blueberry", "Berry Patch");

        string[] strings = myGarden.GetAllPlotNames();

        Console.WriteLine("All the Plots in this Garden");
        foreach(var s in strings){
            Console.WriteLine($"\t{s}");
        }
        Console.WriteLine("fin. \n\n");

        strings = myGarden.GetAllPlantNames();

        Console.WriteLine("All the Plots in this Garden");
        foreach(var s in strings){
            Console.WriteLine($"\t{s}");
        }
        Console.WriteLine("fin. \n\n");

        strings = myGarden.GetAllPlantsInPlot("Garden");

        Console.WriteLine("All the Plots in this Garden");
        foreach(var s in strings){
            Console.WriteLine($"\t{s}");
        }
        Console.WriteLine("fin. \n\n");

    }
}