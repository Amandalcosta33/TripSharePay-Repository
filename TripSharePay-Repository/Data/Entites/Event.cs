namespace TripSharePay_Repository.Data.Entites
{
    public class Event
        {
        public int  event_id { get; set; }
        public string event_name { get; set; }
        public string status { get; set; }
        public DateTime event_date { get; set; }
    }
}