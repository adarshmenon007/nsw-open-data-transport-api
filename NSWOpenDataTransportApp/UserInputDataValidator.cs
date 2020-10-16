using NSWOpenDataTransportLibrary;
using NSWOpenDataTransportLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NSWOpenDataTransportApp
{
    internal class UserInputDataValidator
    {
        internal static bool Validate(string userInput)
        {
            if (string.IsNullOrWhiteSpace(userInput))
            {
                StandardMessages.DisplayValidationError(userInput);
                return false;
            }

            if (!string.IsNullOrWhiteSpace(userInput))
            {
                int convertedInput = Convert.ToInt32(userInput);

                if (convertedInput > 2)
                {
                    StandardMessages.DisplayValidationError(userInput);
                    return false;
                }
            }

            if (userInput.Equals("1"))
            {
                StandardServices services = new StandardServices();

                Task displayDataTask = services.DisplayData();

                // Wait for all tasks running to complete their execution
                Task.WaitAll(displayDataTask);

                return true;
            }
                      
            if (userInput.Equals("2"))
            {
                StandardServices services = new StandardServices();

                Task downloadDataTask = services.DownloadData();

                // Wait for all tasks running to complete their execution
                Task.WaitAll(downloadDataTask);

                return true;
            }            

            return true;
        }
    }
}
