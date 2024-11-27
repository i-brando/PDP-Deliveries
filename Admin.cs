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
    public partial class Admin : Form
    {
        List<string> Password = new List<string>();
        public Admin()
        {
            InitializeComponent();
            login();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if the password is correct it will open the admin screen
            if (txtPassword.Text == Password[0])
            {
                var AdminScreen = new AdminScreen();
                AdminScreen.Show();
            }
        }

        public void login()
        {
            try
            {
                //reads the password from the csv and adds it to the lsit
                StreamReader reader = File.OpenText("Password.csv");
                while (!reader.EndOfStream)
                {
                    String line = reader.ReadLine();
                    String[] values = line.Split(',');
                    Password.Add(values[0]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("error");
            }
        }
    }
}
