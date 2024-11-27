using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PDP_Deliveries
{
    public partial class OrderScreen : Form
    {
        //All of the lists
        List<string> Weight = new List<string>();
        List<string> ParcelVol = new List<string>();
        List<string> ShipTime = new List<string>();
        List<string> RegDelivery = new List<string>();
        List<string> Recorded = new List<string>();
        List<string> Tracked = new List<string>();
        List <Booking> booking = new List<Booking>();


        public OrderScreen()
        {
            //all the values are read from the csv file
            InitializeComponent();
            StreamReader reader = File.OpenText("DeliveryCharge.csv");
            while (!reader.EndOfStream)
            {
                String line = reader.ReadLine();
                String[] values = line.Split(',');
                Weight.Add(values[0]);
                ShipTime.Add(values[1]);
                RegDelivery.Add(values[2]);
                Recorded.Add(values[3]);
                Tracked.Add(values[4]);
                ParcelVol.Add(values[5]);
            }

            //removes the headers of each coloum so they dont get stuck in the calculation
            Weight.RemoveAt(0);
            ShipTime.RemoveAt(0);
            RegDelivery.RemoveAt(0);
            Recorded.RemoveAt(0);
            ParcelVol.RemoveAt(0);
            Tracked.RemoveAt(0);
        }

        private void btnExit_Click(object sender, EventArgs e)
            //exit button for the program
        {
            if (MessageBox.Show("Are Sure You Want To Quit?", "Exit PDP?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //opens the admin menu
            var Admin = new Admin();
            Admin.Show();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        public void validation()
            //vailidation that checks if all of the boxes have been filled with data
        {
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("inalid entry - First Name must be entered");
                txtFirstName.Clear();
                txtFirstName.Focus();
            }
            else
            {
                if (txtLastName.Text == "")
                {
                    MessageBox.Show("inalid entry - Last Name must be entered");
                    txtLastName.Clear();
                    txtLastName.Focus();
                }
                else
                {
                    if (txtAddress.Text == "")
                    {
                        MessageBox.Show("inalid entry - Address must be entered");
                        txtAddress.Clear();
                        txtAddress.Focus();
                    }
                    else
                    {
                        if (txtRetrunAdd.Text == "")
                        {
                            MessageBox.Show("inalid entry - Postcode must be entered");
                            txtRetrunAdd.Clear();
                            txtRetrunAdd.Focus();
                        }
                        else
                        {
                            if (txtNumOfPackages.Text == "")
                            {
                                MessageBox.Show("inalid entry - Number Of Packages must be entered");
                                txtNumOfPackages.Clear();
                                txtNumOfPackages.Focus();
                            }
                            else
                            {
                                if (cmbWeight.Text == string.Empty)
                                {
                                    MessageBox.Show("inalid entry - Weight must be entered");
                                    cmbWeight.Focus();
                                }
                                else
                                {
                                    if (cmbParcelVol.Text == string.Empty)
                                    {
                                        MessageBox.Show("inalid entry - Parcel Volume must be entered");
                                        cmbParcelVol.Focus();
                                    }
                                    else
                                    {
                                        if (cmbShipTime.Text == string.Empty)
                                        {
                                            MessageBox.Show("inalid entry - Shipping Time must be entered");
                                            cmbShipTime.Focus();
                                        }
                                        else
                                        {
                                            if (cmbTracking.Text == string.Empty)
                                            {
                                                MessageBox.Show("inalid entry - Tracking Type must be entered");
                                                cmbTracking.Focus();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string discountCode = txtDiscountCode.Text.ToUpper();

            if (double.TryParse(txtTotal.Text, out double total))
            {
                double discountAmount = 0.0;
                double discountedTotal = 0.0;

                if (discountCode == "BUSINESSDIS")
                {
                    if (total > 100.0)
                    {
                        //This Applies a 10% discount
                        discountAmount = total * 0.1;
                    }
                    else if (total > 50.0)
                    {
                        //This Applies a 5% discount
                        discountAmount = total * 0.05;
                    }

                    if (discountAmount > 0)
                    {
                        //Calculates the discounted total
                        discountedTotal = total - discountAmount;

                        //Updates the displayed total
                        txtTotal.Text = discountedTotal.ToString("C2");

                        //Disables the discount button after applying the discount
                        btnDiscount.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Discount Code or Total amount is not over £50");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Discount Code");
                }
            }
            else
            {
                MessageBox.Show("Invalid Total Amount.");
            }
        }

        private double caluclulatePrice(int position, int noofpackages)
            //this is the method which returns the cost
        {
            double price, cost,costNoTax,taxTotal;
            double tax = 0.2;

            if (cmbTracking.SelectedIndex == 0)
            {
                price = Convert.ToDouble(RegDelivery[position]);
            }
            else if (cmbTracking.SelectedIndex == 1)
            {
                price = Convert.ToDouble(Recorded[position]);
            }
            else
            {
                price = Convert.ToDouble(Tracked[position]);
            }
            costNoTax = price * noofpackages;
            taxTotal = costNoTax * tax;
            cost = costNoTax + taxTotal;
            
            txtTax.Text = taxTotal.ToString();

            double insurance = 2.0;

            if (chkInsurance.Checked)
            {
                cost = (insurance * noofpackages) + cost;
                txtTotal.Text = cost.ToString("C2");
            }

            return cost;
        }

        private void btnClac_Click(object sender, EventArgs e)
        {
            validation();

            btnOrder.Enabled = true;

            string firstname, lastname, address, returnaddress, shippingtime, parcelvol, weight, tracking, customernumber;
            int position,noofpackages;
            double cost;

            position = cmbWeight.SelectedIndex * 2;

            //creates a random number for the customer number
            Random random = new Random();
            int cnum = random.Next(10000000, 99999999);

            //Turns the lastname to all Caps
            string capitalName = txtLastName.Text.ToUpper();

            //Takes only the first 4 letters
            string initials = capitalName.Substring(0, Math.Min(4,capitalName.Length));

            firstname = txtFirstName.Text;
            lastname = txtLastName.Text;
            address = txtAddress.Text;
            returnaddress = txtRetrunAdd.Text;
            shippingtime = cmbShipTime.SelectedItem.ToString();
            parcelvol = cmbParcelVol.SelectedItem.ToString();
            weight = cmbWeight.SelectedItem.ToString();
            tracking = cmbTracking.SelectedItem.ToString();
            noofpackages = int.Parse(txtNumOfPackages.Text);
            cost = caluclulatePrice(position + 1, noofpackages);
            customernumber = initials + cnum;


            position = cmbWeight.SelectedIndex*2;

            if (position != -1)
            {
                if (!(int.TryParse(txtNumOfPackages.Text, out noofpackages)))
                {
                    MessageBox.Show("invailid Number of Packages entered");
                    txtNumOfPackages.Text = "";
                    txtNumOfPackages.Focus();
                }
                else

                {
                    if (cmbShipTime.SelectedIndex == 0)
                    {
                        cost = caluclulatePrice(position, noofpackages);
                        txtTotal.Text = cost.ToString();
                    }
                    else
                    {
                      
                        cost = caluclulatePrice(position + 1, noofpackages);
                        txtTotal.Text = cost.ToString();


                    }
                }
            }

            //shows the user the customer number for the order to the user
            MessageBox.Show("Your Customer Number Is... " + customernumber);

            //Adds all of the customer details
            Booking booked = new Booking(firstname, lastname, address, returnaddress, noofpackages, shippingtime, parcelvol, weight, tracking, cost, customernumber);
            //adds the booking
            booking.Add(booked);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        //here is where the order is exported once the price has been calcualted
        {
            validation();

            string date = DateTime.Today.ToString("dd-MM-yyyy"); //get today's date
            string filePath = "bookings_" + date + ".csv";  //create a name of the new csv file (including the date)

            string delimiter = ","; //comma to seperate data in new csv file

            //creates the order in the csv
            StringBuilder sb = new StringBuilder();
            foreach (Booking order in booking)
            {
                sb.AppendLine(order.FirstName + delimiter + order.LastName + delimiter + order.Address + delimiter + order.ReturnAddress + delimiter + order.NoOfPackages + delimiter + order.ShippingTime + delimiter + order.ParcelVol + delimiter + order.Weight + delimiter + order.Tracking + delimiter + order.Cost + delimiter + order.CustomerNumber);//uild up a String containing all the data in the List
            }

            File.AppendAllText(filePath, sb.ToString());
            MessageBox.Show("Orders saved to file");
            MessageBox.Show("Number of bookings: " + booking.Count());

        }

        private void cmbWeight_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OrderScreen_Load(object sender, EventArgs e)
        {
            //disables the buttons on load
            btnClac.Enabled = false;
            btnOrder.Enabled = false;
        }

        private void cmbTracking_SelectedIndexChanged(object sender, EventArgs e)
        {
            //only enables the calc button once the correct information has been input
            if (cmbTracking.SelectedItem != null && !string.IsNullOrEmpty(cmbTracking.SelectedItem.ToString()))
            {
                btnClac.Enabled = true;
            }
            else
            {
                btnClac.Enabled = false;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtDiscountCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}