using NSWOpenDataTransportLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSWOpenDataTransportLibrary.Model.LiveTrafficCameras
{
    public class LiveTrafficCamerasPropertyItem : IPropertyItem
    {
        public string Direction { get; set; }
        public string Href { get; set; }
        public string Region { get; set; }
        public string Title { get; set; }
        public string View { get; set; }
    }
}
