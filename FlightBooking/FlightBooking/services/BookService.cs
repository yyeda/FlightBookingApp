using FlightBooking.database;
using FlightBooking.models;
using MySql.Data.MySqlClient;

namespace FlightBooking.services
{
    public class BookService
    {

        public List<Flight> GetFlights(DateTime flightDate, string flightTime, int fromCity, int toCity)
        {
            List<Flight> flights = new List<Flight>();
            Connection conn = new Connection();
            try
            {
                conn.Open();

                string sql = "SELECT * FROM flights WHERE flight_date='" + flightDate.ToString("yyyy-MM-dd") + "' AND flight_time='" + flightTime + "' AND from_city=" + fromCity + " AND to_city=" + toCity;
                MySqlCommand cmd = new MySqlCommand(sql, conn.connect);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        flights.Add(new Flight(rdr.GetInt32("id"), rdr.GetInt32("book_id"), rdr.GetString("name"), rdr.GetInt32("from_city"), rdr.GetInt32("to_city"), rdr.GetDateTime("flight_date"), rdr.GetString("flight_time"), rdr.GetInt32("seat_no")));
                    }
                    rdr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
            return flights;
        }

        public bool AddFlight(BookInfo bookInfo)
        {
            bool status = false;
            int bookId = 0;

            Connection conn = new Connection();
            try
            {
                conn.Open();

                string sql = "INSERT INTO books(book_type, book_date) VALUES(" + (int)bookInfo.BookType + ",NOW())";
                MySqlCommand cmd = new MySqlCommand(sql, conn.connect);
                cmd.ExecuteNonQuery();
                bookId = (int)cmd.LastInsertedId;

                foreach (Passenger item in bookInfo.DeparturePassengers)
                {
                    sql = "INSERT INTO flights(book_id,name,flight_date,flight_time,seat_no, from_city,to_city,flight_type) VALUES(" + bookId + ",'" + item.Name + "','" + bookInfo.DepartureDate.ToString("yyyy-MM-dd") + "','" + bookInfo.DepartureTime + "'," + item.SeatNo + "," + bookInfo.FromCity  + "," + bookInfo.ToCity +  ",0)";
                    cmd = new MySqlCommand(sql, conn.connect);
                    cmd.ExecuteNonQuery();
                }

                if (bookInfo.BookType == BOOK_TYPE.Departure_Return)
                {
                    foreach (Passenger item in bookInfo.ReturnPassengers)
                    {
                        sql = "INSERT INTO flights(book_id,name,flight_date,flight_time,seat_no, from_city,to_city,flight_type) VALUES(" + bookId + ",'" + item.Name + "','" + bookInfo.ReturnDate.ToString("yyyy-MM-dd") + "','" + bookInfo.ReturnTime + "'," + item.SeatNo + "," + bookInfo.ToCity + "," + bookInfo.FromCity + ",1)";
                        cmd = new MySqlCommand(sql, conn.connect);
                        cmd.ExecuteNonQuery();
                    }
                }

                status = true;

                MessageBox.Show("Uçuş reservasyon tamamlandı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
            return status;
        }
    }
}
