using System.Windows.Forms;
using System.Xml.Linq;
using FlightBooking.models;
using FlightBooking.services;
using static FlightBooking.frmFlight;

namespace FlightBooking
{
    public partial class frmBook : Form
    {
        public frmBook()
        {
            InitializeComponent();
        }

        private void rdYon2_CheckedChanged(object sender, EventArgs e)
        {
            dtReturn.Enabled = true;
        }

        private void rdYon_CheckedChanged(object sender, EventArgs e)
        {
            dtReturn.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillCityCombo();
        }

        private void fillCityCombo()
        {
            cmbFromCity.Items.Clear();
            cmbFromCity.DisplayMember = "Text";
            cmbFromCity.ValueMember = "Value";

            cmbToCity.Items.Clear();
            cmbToCity.DisplayMember = "Text";
            cmbToCity.ValueMember = "Value";

            CityService service = new CityService();
            List<City> categories = service.GetCities();

            foreach (City item in categories)
            {
                cmbFromCity.Items.Add(new { Value = item.Id, Text = item.Name });
                cmbToCity.Items.Add(new { Value = item.Id, Text = item.Name });
            }
        }

        private void btnDeparture_Click(object sender, EventArgs e)
        {
            if (txtPassengerNum.Text == "" || txtPassengerNum.Text == "0" || cmbFromCity.SelectedIndex == -1 || cmbToCity.SelectedIndex == -1)
            {
                MessageBox.Show("Rezervasyon bilgilerini girin");
            }
            else if (cmbFromCity.SelectedIndex == cmbToCity.SelectedIndex)
            {
                MessageBox.Show("Aynı şehri seçemezsiniz");
                cmbToCity.Focus();
            }
            else if (dtDeparture.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Geçmiş tarih seçilemez");
                dtDeparture.Focus();
            }
            else if (rdBookType1.Checked && dtReturn.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Geçmiş tarih seçilemez");
                dtReturn.Focus();
            }
            else if (rdBookType1.Checked && dtReturn.Value.Date < dtDeparture.Value.Date)
            {
                MessageBox.Show("Dönüş tarihi küçük olamaz");
                dtReturn.Focus();
            }
            else
            {
                BookInfo bookInfo = new BookInfo(Convert.ToUInt16(txtPassengerNum.Value), (cmbFromCity.SelectedItem as dynamic).Value, (cmbToCity.SelectedItem as dynamic).Value, dtDeparture.Value, dtReturn.Value, rdBookType0.Checked ? BOOK_TYPE.Departure : BOOK_TYPE.Departure_Return);
                frmFlight departureForm = new frmFlight();
                departureForm.BookInfo = bookInfo;
                departureForm.PageMode = PAGE_MODE.Departure;
                departureForm.ShowDialog();
            }
        }

        private void frmBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}