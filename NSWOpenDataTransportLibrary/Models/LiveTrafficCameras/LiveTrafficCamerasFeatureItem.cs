using NSWOpenDataTransportLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSWOpenDataTransportLibrary.Model.LiveTrafficCameras
{
    public class LiveTrafficCamerasFeatureItem : IFeatureItem
    {
        public string Type { get; set; }
        public string Id { get; set; }
        public IGeometryItem Geometry { get; set; } = new LiveTrafficCamerasGeometryItem();
        public IPropertyItem Properties { get; set; } = new LiveTrafficCamerasPropertyItem();
    }
}
