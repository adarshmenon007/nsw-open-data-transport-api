using System;
using System.Collections.Generic;
using System.Text;

namespace NSWOpenDataTransportApp
{
    internal class StandardMessages
    {
        internal static void WelcomeMessage()
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Welcome to NSW Open Data Transport Application!");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("\n");
        }

        internal static void EndApplication()
        {
            Console.Write("Press enter to close...");
            Console.ReadLine();
        }

        internal static void DisplayValidationError(string userInput)
        {
            Console.WriteLine($"'{ userInput }' is not a valid input!");
        }
    }
}
