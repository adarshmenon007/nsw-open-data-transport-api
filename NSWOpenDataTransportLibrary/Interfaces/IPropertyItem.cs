namespace NSWOpenDataTransportLibrary.Interfaces
{
    public interface IPropertyItem
    {
        string Direction { get; set; }
        string Href { get; set; }
        string Region { get; set; }
        string Title { get; set; }
        string View { get; set; }
    }
}