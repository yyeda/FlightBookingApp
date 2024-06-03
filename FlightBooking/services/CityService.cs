using FlightBooking.database;
using FlightBooking.models;
using MySql.Data.MySqlClient;

namespace FlightBooking.services
{
    public class CityService
    {

         public List<City> GetCities()
        {
            List<City> cities = new List<City>();
            Connection conn = new Connection();
            try
            {
                conn.Open();

                string sql = "SELECT * FROM cities";
                MySqlCommand cmd = new MySqlCommand(sql, conn.connect);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        cities.Add(new City(rdr.GetInt32("id"), rdr.GetString("name")));
                    }
                    rdr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
            return cities;
        }
    }
}
