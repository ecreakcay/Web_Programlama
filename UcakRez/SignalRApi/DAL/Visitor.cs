namespace SignalRApi.DAL
{
    public enum ECity
    {
        Bursa=1,
        Kocaeli=2,
        Istanbul=3,
        Ankara=4,
        Izmir=5

    }
    public class Visitor
    {
        public int VisitorID { get; set; }
        public ECity City { get; set; }
        public int CityVisitCount { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
