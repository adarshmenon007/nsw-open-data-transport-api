using NSWOpenDataTransportLibrary.Model;
using NSWOpenDataTransportLibrary.Model.LiveTrafficCameras;

namespace NSWOpenDataTransportLibrary.Interfaces
{
    public interface INswOpenDataTransportResponse
    {             
        string Type { get; set; }
        IRightsItem Rights { get; set; }
    }
}