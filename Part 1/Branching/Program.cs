using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Requirement 1: Display the initial welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user for the package weight
            Console.WriteLine("Please enter the package weight:");
            double weight = Convert.ToDouble(Console.ReadLine());

            // Check if the weight is greater than 50
            if (weight > 50)
            {
                // Display error message and terminate the program
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; 
            }

            // Prompt the user for the package width
            Console.WriteLine("Please enter the package width:");
            double width = Convert.ToDouble(Console.ReadLine());

            // Prompt the user for the package height
            Console.WriteLine("Please enter the package height:");
            double height = Convert.ToDouble(Console.ReadLine());

            // Prompt the user for the package length
            Console.WriteLine("Please enter the package length:");
            double length = Convert.ToDouble(Console.ReadLine());

            // Calculate total dimensions (width + height + length)
            double dimensionTotal = width + height + length;

            // Check if the dimension total is greater than 50
            if (dimensionTotal > 50)
            {
                // Display error message and terminate the program
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; 
            }

            // Calculate the shipping quote: (width * height * length * weight) / 100
            double productOfDimensions = width * height * length;
            double rawQuote = (productOfDimensions * weight) / 100;

            // Display the final quote formatted as currency, followed by a thank you message
            Console.WriteLine($"Your estimated total for shipping this package is: ${rawQuote:F2}");
            Console.WriteLine("Thank you!");
        }
    }
}
