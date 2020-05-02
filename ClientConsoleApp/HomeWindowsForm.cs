using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;
using System.Json;
using System.Dynamic;
using Newtonsoft.Json;
using System.ServiceModel.Configuration;
using System.Linq;

namespace ClientConsoleApp
{
    public partial class HomeWindowsForm : Form
    {


        HotelBookingServiceReference.HotelBookingServiceSoapClient hotelService= new HotelBookingServiceReference.HotelBookingServiceSoapClient();

        HotelBookingServiceReference.Hotel[] hotels;
        int numberOfClick = 1;
        HotelBookingServiceReference.Room[] rooms;

        ClientBookingInformation client;

        public HomeWindowsForm()
        {

            InitializeComponent();

            //During initialisation only the 2 primary buttons are visible (find hotel and find all hotel)
            notification.Visible = true;
            tableHotelInformation.Visible = false;
            listHotelGrid.Visible = false;
            ClientInformationLayoutPanel.Visible = false;
            roomDataGridView.Visible = false;
            notification.Text = "Notification Here!";

            hotels = hotelService.getHotel();
            client = new ClientBookingInformation();

        }

        //this corresponds to find all hotel button event //C# doesnot want to rename it
        private  void button1_Click(object sender, EventArgs e)
        {
            notification.Visible = true;
            listHotelGrid.Visible = true;
            tableHotelInformation.Visible = false;
            ClientInformationLayoutPanel.Visible = false;
            roomDataGridView.Visible = false;

            notification.Text = "All Hotel Found!";

            hotels = hotelService.getHotel();

            listHotelGrid.DataSource = null;
            listHotelGrid.Rows.Clear();
            

            foreach (HotelBookingServiceReference.Hotel h in hotels)
            {

                //contains the number of rows           
                int row = listHotelGrid.Rows.Add();
               
                //load values from service
                listHotelGrid["name", row].Value = h.Name;
                listHotelGrid["numberofstars", row].Value= h.Rating.ToString();
                listHotelGrid["numberofbed", row].Value = h.NumberOfBed.ToString();
                listHotelGrid["address", row].Value = h.Address.ToString();
                listHotelGrid["phonenumber", row].Value = h.PhoneNumber.ToString();
                listHotelGrid["town", row].Value = h.Town.ToString();
                listHotelGrid["country", row].Value = h.Country.ToString();
                //console.writeline("hotel rating!");
                //console.writeline(h.Rating);

                List<int> prices = new List<int>();

                //compute price
                foreach (HotelBookingServiceReference.Room r in h.Rooms)
                {

                    prices.Add(r.Price);

                }

                var minPrice = prices.Min();
                var maxPrice = prices.Max();

                String priceRange = minPrice.ToString() + "-" + maxPrice.ToString();

                listHotelGrid["priceRange", row].Value = priceRange;

            }

            numberOfClick++;
        }

        //click to list hide all fields (when title is clicked)
        private void title_Click(object sender, EventArgs e)
        {
            notification.Visible = true;
            tableHotelInformation.Visible = false;
            listHotelGrid.Visible = false;
            ClientInformationLayoutPanel.Visible = false;
            roomDataGridView.Visible = false;
            notification.Text = "Click a Button!";
        }

        //click to find an hotel
        private void findHotelButton_Click(object sender, EventArgs e)
        {
            notification.Visible = true;
            tableHotelInformation.Visible = true;

            listHotelGrid.Visible = false;
            roomDataGridView.Visible = false;
            ClientInformationLayoutPanel.Visible = false;
            notification.Text = "Enter Your Search criteria!";

        }

        private void tableHotelInformation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void clientFirstName_Click(object sender, EventArgs e)
        {

        }

        private void clientLastName_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //button to submit client information 
        private void button1_Click_1(object sender, EventArgs e)
        {
            //check if fill isnot empty
            if (String.IsNullOrEmpty(clientFirstNameTextBox.Text) || String.IsNullOrEmpty(clientLastNameTextBox.Text) || String.IsNullOrEmpty(clientCardInformationTextBox.Text))
            {
                notification.Text = "Some Field are Empty!";
                return;


            } else {
                //do nothing
            }


            //make a booking
            hotelService.getBookingInformaton(1, 1, 1, client.ClientFirstName, client.ClientLastName, client.ClientCardInfo);

            notification.Visible = true;
            notification.Text = "Booking Successful, Thanks";
            //hide notification panel
            var timer = new Timer();
            timer.Interval = 3000;

            timer.Tick += (s, d) => {
                notification.Visible = false;
                timer.Stop();
            };

            timer.Start();


            tableHotelInformation.Visible = false;
            listHotelGrid.Visible = false;
            ClientInformationLayoutPanel.Visible = false;
            roomDataGridView.Visible = false;

        }

        private void HomeWindowsForm_Load(object sender, EventArgs e)
        {

        }

        private void ClientInformationLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void minimumPriceLabel_Click(object sender, EventArgs e)
        {

        }
        //when hotel grid is clicked
        private void listHotelGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //set room pane to foreground
            roomDataGridView.Visible = true;
            //hide the other panels
            tableHotelInformation.Visible = false;
            listHotelGrid.Visible = false;
            tableHotelInformation.Visible = false;
            ClientInformationLayoutPanel.Visible = false;
            notification.Visible = false;

            
            if (e.ColumnIndex == 8)
            {
                //load the rooms
                if (listHotelGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    listHotelGrid.CurrentRow.Selected = true;
                    //Console.WriteLine(listHotelGrid.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString());
                    //get the hotel name
                    client.HotelName = listHotelGrid.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
                    rooms = hotelService.getRoomFromHotel(client.HotelName); //get the room from the service

                    //clear grid
                    roomDataGridView.DataSource = null;
                    roomDataGridView.Rows.Clear();

                    // the rooms to roomgrid
                    foreach (HotelBookingServiceReference.Room room in rooms)
                    {
                        int row = roomDataGridView.Rows.Add()
 ;
                        roomDataGridView["roomId", row].Value = room.Id;
                        roomDataGridView["roomPrice", row].Value = room.Price;
                        roomDataGridView["roomNumberOfBed", row].Value = room.NumberOfBed;
                        roomDataGridView["roomCapacity", row].Value = room.Capacity;
                        roomDataGridView["roomStatus", row].Value = room.State;
                    }
                }

                //set notification visible
                notification.Visible = true;
                notification.Text = "Choose a Room!";
            }
        }

        //submnit search button (hotel information)
        private void submitButton_Click(object sender, EventArgs e)
        {
            notification.Visible = true;
            listHotelGrid.Visible = true; 
            tableHotelInformation.Visible = false;
            ClientInformationLayoutPanel.Visible = false;
            roomDataGridView.Visible = false;

            notification.Text = "Hotel Found!";
            //check for empty field
            if (String.IsNullOrEmpty(townTextBox.Text) || String.IsNullOrEmpty(ArrivalDateTextBox.Text) || String.IsNullOrEmpty(depatureDateTextBox.Text) || String.IsNullOrEmpty(minimumPriceTextBox.Text) || String.IsNullOrEmpty(maximumPriceTextBox.Text) || String.IsNullOrEmpty(numberOfStarsTextBox.Text) ||String.IsNullOrEmpty(numberOfPersonToHostTextBox.Text) )
            {
                notification.Text = "Some Field are empty!";

                listHotelGrid.Visible = false;
                tableHotelInformation.Visible = true;

            }
            else
            {
                client.HotelTown = townTextBox.Text;
                client.ArrivalDate = ArrivalDateTextBox.Text;
                client.DepartureDate = depatureDateTextBox.Text;
                client.MinPrice = Int32.Parse(minimumPriceTextBox.Text);
                client.MaxPrice = Int32.Parse(maximumPriceTextBox.Text);
                client.NumberOfStars = Int32.Parse(numberOfStarsTextBox.Text);
                client.NumberOfPersonToHost = Int32.Parse(numberOfPersonToHostTextBox.Text);
                client.NumberOfStars = Int32.Parse(numberOfStarsTextBox.Text);

                //for simplicity consider we consider only townName,min price , max price and number of stars
                hotels = hotelService.searchhotel(client.HotelTown.ToLower(), client.MinPrice, client.MaxPrice, client.NumberOfStars);

                foreach (HotelBookingServiceReference.Hotel item in hotels) Console.WriteLine(item);

                //clear the grid
                listHotelGrid.DataSource = null;
                listHotelGrid.Rows.Clear();

                //populate grid with hotels found
                foreach (HotelBookingServiceReference.Hotel h in hotels)
                {
                    //contains the number of rows
                    int row = listHotelGrid.Rows.Add();

                    //load values from service
                    listHotelGrid["name", row].Value = h.Name;
                    listHotelGrid["numberOfStars", row].Value = h.Rating.ToString();
                    listHotelGrid["numberOfBed", row].Value = h.NumberOfBed.ToString();
                    listHotelGrid["address", row].Value = h.Address.ToString();
                    listHotelGrid["phoneNumber", row].Value = h.PhoneNumber.ToString();
                    listHotelGrid["town", row].Value = h.Town.ToString();
                    listHotelGrid["country", row].Value = h.Country.ToString();
                    listHotelGrid["chooseHotel", row].Value = submitButton;

                    List<int> prices = new List<int>();

                    //compute price
                    foreach (HotelBookingServiceReference.Room r in h.Rooms) {

                        prices.Add(r.Price);
            
                    }

                    var minPrice = prices.Min();
                    var maxPrice = prices.Max();

                    String priceRange = minPrice.ToString() + "-" + maxPrice.ToString();

                    listHotelGrid["priceRange",row].Value = priceRange;


                }
            }

            

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void numberOfPersonToHostLabel_Click(object sender, EventArgs e)
        {

        }

        private void roomDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 5)
            {
                if (roomDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    roomDataGridView.CurrentRow.Selected = true;
                    //get the room id
                    //client.RoomId = Int32.Parse(roomDataGridView.Rows[e.RowIndex].Cells["roomId"].FormattedValue.ToString());
                }
            }
            else {
                notification.Text = "Click a Button";
            }
            
            roomDataGridView.Visible = false;
            ClientInformationLayoutPanel.Visible = true;
            notification.Text = "Enter your Credential To Book Room";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
