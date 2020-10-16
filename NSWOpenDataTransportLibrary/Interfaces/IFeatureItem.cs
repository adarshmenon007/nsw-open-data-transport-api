using NSWOpenDataTransportLibrary.Model;
using NSWOpenDataTransportLibrary.Model.LiveTrafficCameras;

namespace NSWOpenDataTransportLibrary.Interfaces
{
    public interface IFeatureItem
    {
        string Type { get; set; }
        string Id { get; set; }
        IGeometryItem Geometry { get; set; }
        IPropertyItem Properties { get; set; }        
    }
}