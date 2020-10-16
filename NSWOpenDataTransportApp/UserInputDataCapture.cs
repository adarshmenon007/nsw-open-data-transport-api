using System;
using System.Collections.Generic;
using System.Text;

namespace NSWOpenDataTransportApp
{
    internal class UserInputDataCapture
    {
        internal static string Capture()
        {
            string output = string.Empty;

            Console.WriteLine("Please enter 1 to view data for Live Traffic Cameras.");
            Console.WriteLine("Please enter 2 to download data for Live Traffic Cameras.");
            Console.WriteLine("\n");

            output = Console.ReadLine();

            return output;
        }
        
    }
}
