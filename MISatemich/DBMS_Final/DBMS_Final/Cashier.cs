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
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cashier cashier = new Cashier();
            Travel pass = new Travel();
            cashier.Close();
            pass.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Cashier cashier = new Cashier();
            Reservation res = new Reservation();
            cashier.Close();
            res.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Cashier cashier = new Cashier();
            Cancellation canc = new Cancellation();
            cashier.Close();
            canc.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cashier: Travel and Reservation Instructions\n \n" +
                "Travel - add, edit, and/or reset train destination and travel cost.\n" +
                "Reservation - add passenger's reservation.\n\n" +
                "• Add - input necessary information being asked, then click Add button.\n" +
                "• Edit - input the ID number first on the textbox before changing the information, then click Edit button once done.\n" +
                "• Reset - clears all input in textbox.");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
