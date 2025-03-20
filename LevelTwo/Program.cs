using System;
using Spectre.Console;

class Program
{
    private static void Main(string[] args)
    {
        if (args.Length == 0)
        {
        // Load the image
        CanvasImage image = new CanvasImage("tux.jpg");

        // Set the max width of the image
        image.MaxWidth(20);

        // Render the image to the console
        AnsiConsole.Write(image);
        }
        
        else
        {
        string imagePath = args[0]; // First argument: Image file path
        int width = int.Parse(args[1]); // Second argument: Width in characters
 
        // Display the image file path and width
        Console.WriteLine($"Image file: {imagePath}");
        Console.WriteLine($"Width in characters: {width}");
        }
    }
}