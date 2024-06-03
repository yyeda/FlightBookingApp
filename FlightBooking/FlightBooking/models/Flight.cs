
namespace FlightBooking.models
{
    public class Flight
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string Name { get; set; }
        public DateTime FlightDate { get; set; }
        public string FlightTime { get; set; }
        public int FromCity { get; set; }
        public int ToCity { get; set; }
        public int SeatNo { get; set; }

        public Flight() { }

        public Flight(int id, int bookId, string name, int fromCity, int toCity, DateTime flightDate, string flightTime, int seatNo)
        {
            this.Id = id;
            this.BookId = bookId;
            this.Name = name;
            this.FromCity= fromCity;
            this.ToCity = toCity;
            this.FlightDate = flightDate;
            this.FlightTime = flightTime;
            this.SeatNo = seatNo;
        }
    }
}
