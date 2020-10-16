using NSWOpenDataTransportLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSWOpenDataTransportLibrary.Model.LiveTrafficCameras
{
    public class LiveTrafficCamerasGeometryItem : IGeometryItem
    {
        public double[] Coordinates { get; set; }
        public string Type { get; set; }
    }
}
