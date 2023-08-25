using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Final
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Travel pass = new Travel();
            main.Close();
            pass.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Train train = new Train();
            main.Close();
            train.Show();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Passenger pass = new Passenger();
            main.Close();
            pass.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Reservation res = new Reservation();
            main.Close();
            res.Show();
        }

        /* Removed by Michelle

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Cancellation canc = new Cancellation();
            main.Close();
            canc.Show();
        }*

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Admin: Train and Passenger List Instructions\n \n" +
                "Train - add, edit, and/or delete trains, set their capacity and status.\n" +
                "Passenger - add, edit, and/or delete passenger information that reserved a ticket.\n\n" +
                "• Add - input necessary information on the textboxes, then click Add button.\n" + 
                "• Edit - input the ID number first on the textbox before changing the information, then click Edit button once done.\n" + 
                "• Delete - input the ID number first, then click Delete button.");

        }*/

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Admin: Train and Passenger Instructions\n \n" +
                "Train - add, edit, and/or delete trains, set their capacity and status.\n" +
                "Passenger - add, edit, and/or delete passenger information that reserved a ticket.\n\n" +
                "• Add - input necessary information on the textboxes, then click Add button.\n" +
                "• Edit - input the ID number first on the textbox before changing the information, then click Edit button once done.\n" +
                "• Delete - input the ID number first, then click Delete button.");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
