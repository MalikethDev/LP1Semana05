using System;
using Spectre.Console;
using Bogus;

namespace WorkerTable
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Set the random seed
            Randomizer.Seed = new Random(8675309);
            var faker = new Faker("pt_PT");

            // Create a table
            var table = new Table();

            // Add name columns
            table.AddColumn("10");
            table.AddColumn(new TableColumn("Name").Centered());
            table.AddColumn(new TableColumn("Job").Centered());

            // The number of rows is indicated by the user
            int rows = int.Parse(args[0]);

            // Add rows
            for (int i = 0; i < rows; i++)
            {
                table.AddRow($"{i + 1}", faker.Name.FullName(), faker.Name.JobTitle());
            }

            // Render the table
            AnsiConsole.Write(table);

        }
    }
}
