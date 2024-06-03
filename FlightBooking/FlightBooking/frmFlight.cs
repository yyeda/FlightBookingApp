using FlightBooking.models;
using FlightBooking.services;
using System.Data;

namespace FlightBooking
{
    public partial class frmFlight : Form
    {
        public frmFlight()
        {
            InitializeComponent();
        }

        public enum PAGE_MODE
        {
            Departure = 0,
            Return = 1,
        }

        private List<Passenger> passengers;
        public BookInfo BookInfo { get; set; }
        public PAGE_MODE PageMode { get; set; }

        private void Form2_Load(object sender, EventArgs e)
        {
            ChangeLabel();

            grdSeat.Columns.Add("No1", "Koltuk No");
            grdSeat.Columns.Add("No2", "Koltuk No");
            grdSeat.Columns.Add("No3", "Koltuk No");
            grdSeat.Columns.Add("No4", "Koltuk No");


            fillSeats();
        }

        private void AddPassenger(int rowNo, int cellNo, int seatNo, string name)
        {
            DataGridViewButtonCell btn1 = new DataGridViewButtonCell();
            btn1.Value = seatNo;
            grdSeat.Rows[rowNo].Cells[cellNo] = btn1;
            grdSeat.Rows[rowNo].Cells[cellNo].Tag = seatNo;
            ChangeColor(rowNo, cellNo, Color.White);

            passengers.Add(new Passenger(seatNo, name, false));
        }

        private void grdSeat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex >= 0 && txtName.Text != "")
            {
                Passenger? passenger = (from m in passengers
                                        where m.SeatNo == Convert.ToUInt16(senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag) && m.Name == ""
                                        select m).FirstOrDefault();
                if (passenger != null)
                {
                    DeletePassenger();

                    int pc = (from m in passengers
                              where m.NewPassenger == true
                              select m).Count();

                    if (BookInfo.PassengerNum <= pc)
                    {
                        MessageBox.Show("Yolcu sayısı kadar koltuk seçebilisiniz");
                    }
                    else
                    {
                        passenger.Name = txtName.Text;
                        passenger.NewPassenger = true;
                        senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag + "-" + txtName.Text;
                        ChangeColor(e.RowIndex, e.ColumnIndex, Color.Chocolate);
                    }
                }
            }
        }

        private void DeletePassenger()
        {
            Passenger? passenger = (from m in passengers
                                    where m.Name == txtName.Text && m.NewPassenger == true
                                    select m).FirstOrDefault();
            if (passenger != null)
            {
                passenger.Name = "";
                passenger.NewPassenger = false;
                grdSeat.Rows[getRowNo(passenger.SeatNo)].Cells[getColNo(passenger.SeatNo)].Value = grdSeat.Rows[getRowNo(passenger.SeatNo)].Cells[getColNo(passenger.SeatNo)].Tag;
                ChangeColor(getRowNo(passenger.SeatNo), getColNo(passenger.SeatNo), Color.White);
            }
        }

        private int getRowNo(int seatNo)
        {
            int rowNo = seatNo % 10;

            return (rowNo == 0 ? 10 : rowNo) - 1;
        }

        private int getColNo(int seatNo)
        {
            int colNo = seatNo / 10;

            return seatNo % 10 == 0 ? colNo -1 : colNo;
        }

        private void ChangeColor(int rowNo, int cellNo, Color color)
        {
            DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)grdSeat.Rows[rowNo].Cells[cellNo];
            buttonCell.FlatStyle = FlatStyle.Popup;
            buttonCell.Style.BackColor = color;
        }

        private void btnSeatCancel_Click(object sender, EventArgs e)
        {
            DeletePassenger();
        }

        private void fillSeats()
        {
            passengers = new List<Passenger>();
            grdSeat.Rows.Clear();   

            for (int i = 0; i < 10; i++)
            {
                grdSeat.Rows.Add(new object[] { 0, 1, 2, 3 });

                AddPassenger(i, 0, i + 1, "");
                AddPassenger(i, 1, i + 11, "");
                AddPassenger(i, 2, i + 21, "");
                AddPassenger(i, 3, i + 31, "");
            }

            DateTime flightDate = (PageMode == PAGE_MODE.Departure) ? BookInfo.DepartureDate : BookInfo.ReturnDate;
            string flightTime = dtTime.Value.ToString("hh:mm");
            int fromCity = (PageMode == PAGE_MODE.Departure) ? BookInfo.FromCity : BookInfo.ToCity;
            int toCity = (PageMode == PAGE_MODE.Departure) ? BookInfo.ToCity : BookInfo.FromCity;

            BookService service = new BookService();
            List<Flight> list = service.GetFlights(flightDate, flightTime, fromCity, toCity);

            foreach (Flight item in list)
            {
                Passenger? passenger = (from m in passengers
                                        where m.SeatNo == item.SeatNo
                                        select m).FirstOrDefault();
                if (passenger != null)
                {
                    passenger.Name = item.Name;
                    passenger.NewPassenger = false;
                    grdSeat.Rows[getRowNo(passenger.SeatNo)].Cells[getColNo(passenger.SeatNo)].Value = grdSeat.Rows[getRowNo(passenger.SeatNo)].Cells[getColNo(passenger.SeatNo)].Tag + "-" + item.Name;
                    ChangeColor(getRowNo(passenger.SeatNo), getColNo(passenger.SeatNo), Color.DarkOrange);
                }
            }
        }

        private void ChangeLabel()
        {
            if (PageMode == PAGE_MODE.Departure)
            {
                this.Text = "Gidiş Reservasyon";
                lblTime.Text = "Gidiş Saati";

                if (BookInfo.BookType == BOOK_TYPE.Departure)
                {
                    btnAction.Text = "Bilet Al";
                }
                else
                {
                    btnAction.Text = "Dönüş Bilgileri";
                }
            }
            else
            {
                this.Text = "Dönüş Reservasyon";
                lblTime.Text = "Dönüş Saati";
                btnAction.Text = "Bilet Al";
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {

            int passenger = (from m in passengers
                             where m.NewPassenger == true
                             select m).Count();

            if (BookInfo.PassengerNum != passenger)
            {
                MessageBox.Show("Yolcu sayısı kadar koltuk seçmelisiniz");
            }
            else
            {
                if (PageMode == PAGE_MODE.Departure)
                {
                    BookInfo.DeparturePassengers = (from m in passengers
                                                    where m.NewPassenger == true
                                                    select m).ToList();
                    BookInfo.DepartureTime = dtTime.Value.ToString("hh:mm");
                }
                else
                {
                    BookInfo.ReturnPassengers = (from m in passengers
                                                 where m.NewPassenger == true
                                                 select m).ToList();
                    BookInfo.ReturnTime = dtTime.Value.ToString("hh:mm");
                }

                if (BookInfo.BookType == BOOK_TYPE.Departure || PageMode == PAGE_MODE.Return)
                {
                    BookService service = new BookService();
                    service.AddFlight(BookInfo);
                    this.Close();
                }
                else
                {
                    frmFlight returnform = new frmFlight();
                    returnform.BookInfo = BookInfo;
                    returnform.PageMode = PAGE_MODE.Return;
                    returnform.ShowDialog();
                    this.Close();
                }
            }
        }

        private void dtTime_ValueChanged(object sender, EventArgs e)
        {
            fillSeats();
        }
    }
}
