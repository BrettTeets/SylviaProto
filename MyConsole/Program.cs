using System.Security.Cryptography.X509Certificates;
using SylviaLib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Sylvia!");

        Plant plant = new("Onion Plant");

        plant.Debug();
    }
}