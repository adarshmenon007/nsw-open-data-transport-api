using NSWOpenDataTransportLibrary;
using System;

namespace NSWOpenDataTransportApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            ApiHelper.InitializeClient();

            string userInput = UserInputDataCapture.Capture();

            bool iValidInput = UserInputDataValidator.Validate(userInput);

            if (iValidInput == false)
            {
                StandardMessages.EndApplication();
                return;
            }

            StandardMessages.EndApplication();            
        }
    }
}
