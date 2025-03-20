using System;
using Spectre.Console;

class Program
{
    private static void Main(string[] args)
    {
        // Load the image
        CanvasImage image = new CanvasImage("tux.jpg");

        // Set the max width of the image
        image.MaxWidth(20);

        // Render the image to the console
        AnsiConsole.Write(image);
    }
}