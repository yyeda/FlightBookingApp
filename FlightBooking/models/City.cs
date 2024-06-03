namespace FlightBooking.models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public City() { }

        public City(int id, string name) 
        { 
            this.Id = id;
            this.Name = name;
        }

    }
}
