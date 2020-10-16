using NSWOpenDataTransportLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSWOpenDataTransportLibrary.Model.LiveTrafficCameras
{
    public class LiveTrafficCamerasResponse 
    {
        public string Type { get; set; }
        public IRightsItem Rights { get; set; } = new LiveTrafficCamerasRightsItem();
        public LiveTrafficCamerasFeatureItem[] Features { get; set; } 
    }
}
