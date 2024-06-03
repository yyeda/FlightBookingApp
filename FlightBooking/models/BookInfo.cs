namespace FlightBooking.models
{
    public enum BOOK_TYPE
    {
        Departure = 0,
        Departure_Return = 1,
    }

    public class BookInfo
    {
        public int PassengerNum { get; set; }
        public int FromCity { get; set; }
        public int ToCity { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string DepartureTime { get; set; }
        public string ReturnTime { get; set; }

        public BOOK_TYPE BookType { get; set; }
        public List<Passenger> DeparturePassengers { get; set; }
        public List<Passenger> ReturnPassengers { get; set; }

        public BookInfo() { }

        public BookInfo(int passengerNum, int fromCity, int toCity, DateTime departureDate, DateTime returnDate, BOOK_TYPE bookType)
        {
            this.PassengerNum = passengerNum;
            this.FromCity= fromCity;
            this.ToCity = toCity;
            this.DepartureDate = departureDate;
            this.ReturnDate = returnDate;
            this.BookType = bookType;
        }
    }
}
