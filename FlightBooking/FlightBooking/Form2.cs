using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FlightBooking
{
    public partial class Form2 : Form
    {

        string connectionString = "server=localhost;user=igu;database=reservasyon;port=3306;password=igu";
        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string surname = textBox2.Text;
            string email = textBox3.Text;
            string password = textBox4.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO kullanici (isim, soyisim, email, sifre) VALUES (@isim, @soyisim, @email, @sifre)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@isim", name);
                    command.Parameters.AddWithValue("@soyisim", surname);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@sifre", password);

                    try
                    {
                        connection.Open();

                        command.ExecuteNonQuery();

                        MessageBox.Show("Kullanıcı başarıyla eklendi.");

                        this.Close();

                        Form1 form1 = new Form1();
                        form1.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata oluştu: " + ex.Message);
                    }
                }
            }
        }
    }
}
