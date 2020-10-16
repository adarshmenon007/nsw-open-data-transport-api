namespace NSWOpenDataTransportLibrary.Interfaces
{
    public interface IGeometryItem
    {
        double[] Coordinates { get; set; }
        string Type { get; set; }
    }
}