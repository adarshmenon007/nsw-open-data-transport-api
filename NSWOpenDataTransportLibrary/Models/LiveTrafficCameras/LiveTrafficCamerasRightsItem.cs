using NSWOpenDataTransportLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSWOpenDataTransportLibrary.Model.LiveTrafficCameras
{
    public class LiveTrafficCamerasRightsItem : IRightsItem
    {
        public string Copyright { get; set; }
        public string Licence { get; set; }
    }
}
