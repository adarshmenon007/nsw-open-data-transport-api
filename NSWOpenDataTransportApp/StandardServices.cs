using NSWOpenDataTransportLibrary;
using NSWOpenDataTransportLibrary.Interfaces;
using NSWOpenDataTransportLibrary.Model.LiveTrafficCameras;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSWOpenDataTransportApp
{
    internal class StandardServices
    {
        internal async Task DisplayData()
        {
            LiveTrafficCamerasResponse result = await LiveTrafficCamerasProcessor.LoadData();

            Console.WriteLine("\n");
            Console.WriteLine("Type:" + " " + result.Type);
            Console.WriteLine("Copyright:" + " " + result.Rights.Copyright);
            Console.WriteLine("License:" + " " + result.Rights.Licence);
            Console.WriteLine($"Features: Total number = {result.Features.Count()}.");

            foreach (LiveTrafficCamerasFeatureItem item in result.Features)
            {
                Console.WriteLine("ID: " + item.Id + " Latitude: " + item.Geometry.Coordinates[0] + " Longitude: " + item.Geometry.Coordinates[1] + " Region: " + item.Properties.Region);
            }

            Console.WriteLine("\n");            
        }

        internal async Task DownloadData()
        {
            string filePath = @"C:\output.csv";
            var csv = new StringBuilder();
            LiveTrafficCamerasResponse result = await LiveTrafficCamerasProcessor.LoadData();

            csv.AppendLine($"type,{result.Type}");
            csv.AppendLine($"copyright,{result.Rights.Copyright}");
            csv.AppendLine($"license,{result.Rights.Licence}");
            csv.AppendLine($"features,{result.Features.Count()}");
            csv.AppendLine($"id,latitude,longitude,region");

            foreach (LiveTrafficCamerasFeatureItem item in result.Features)
            {
                var newLine = $"{item.Id},{item.Geometry.Coordinates[0]},{item.Geometry.Coordinates[1]},{item.Properties.Region}";
                csv.AppendLine(newLine);                
            }

            try
            {
                File.AppendAllText(filePath, csv.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Please Run Visual Studio as an Administrator to avoid this exception.");
                throw e;
            }

            Console.WriteLine($"The file has been downloaded to your C: drive. Please open file output.csv to view data.");
        }
    }
}
