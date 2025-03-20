using System;

class Program
{
    private static void Main(string[] args)
    {
        string imagePath = args[0]; // First argument: Image file path
        int width = int.Parse(args[1]); // Second argument: Width in characters

        // Display the image file path and width
        Console.WriteLine($"Image file: {imagePath}");
        Console.WriteLine($"Width in characters: {width}");
    }
}