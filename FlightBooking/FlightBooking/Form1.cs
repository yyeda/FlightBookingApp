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

namespace FlightBooking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

            string connectionString = "server=localhost;user=igu;database=reservasyon;port=3306;password=igu";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM kullanici WHERE email = @email AND sifre = @sifre";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@sifre", password);

                    try
                    {
                        connection.Open();

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count > 0)
                        {
                            frmIntro introForm = new frmIntro();
                            introForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Hatalı email veya şifre!");
                        }
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
