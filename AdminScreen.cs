using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDP_Deliveries
{
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtBookings.Clear();

            //get date and convert to string format
            string date = dateTimeRentalsMade.Value.ToString("dd-MM-yyyy");
            string line, line2;

            try
            {
                // Stream reader that opens a csv file with the date selected by user
                StreamReader reader = File.OpenText("bookings_" + date + ".csv");

                //add headings to the textBox
                txtBookings.AppendText("First Name\tLast Name\tAddress\t\tRe Address\tNum Of Packages\tShipping Time\t\tVolume\t\t\tWeight\t\tTracking\t\t\tCost\t\tCustomer Number" + "\r\n");

                // While loop to load data from csv into an array and remove the commas 
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();//read line of data from csv file
                    line2 = ""; //initialise an empty string which will hold the line of data TO BE OUTPUT on the form

                    string[] values = line.Split(',');//array holds each item from the current row in csv file


                    foreach (string s in values)
                    {
                        //use the array data to create one string with spacing between each value
                        line2 = line2 + s + "\t\t";
                    }
                    // Displaying the row from csv file in a new line in the textBox
                    txtBookings.AppendText(line2 + "\r\n");
                }

                reader.Close();

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No Orders have been made on that day\nSelect a different date");
            }
        }

        private void dateTimeRentalsMade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
