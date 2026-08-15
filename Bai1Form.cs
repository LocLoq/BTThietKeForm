using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BTThietKeForm
{
    public partial class Bai1Form : Form
    {
        private int _sum = 0;
        public Bai1Form()
        {
            InitializeComponent();
        }

        private void blueRB_CheckedChanged(object sender, EventArgs e)
        {
            // Set the price and amount based on the selected color
            if (blueRB.Checked)
            {
                priceTB.Text = "22000";
                amountTB.Text = "1";
                carPB.Image = Properties.Resources.blue_car; // Assuming you have an image resource named blue_car
            }
        }

        private void redRB_CheckedChanged(object sender, EventArgs e)
        {
            // Set the price and amount based on the selected color
            if (redRB.Checked)
            {
                priceTB.Text = "21000";
                amountTB.Text = "1";
                carPB.Image = Properties.Resources.red_car; // Assuming you have an image resource named red_car
            }
        }

        private void whiteRB_CheckedChanged(object sender, EventArgs e)
        {
            // Set the price and amount based on the selected color
            if (whiteRB.Checked)
            {
                priceTB.Text = "20000";
                amountTB.Text = "1";
                carPB.Image = Properties.Resources.white_car; // Assuming you have an image resource named white_car
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Calculate the total price based on the selected color and amount
            int price = int.Parse(priceTB.Text);
            int amount = int.Parse(amountTB.Text);
            _sum += price * amount;
            // Update the sum label with the total price
            sumLabel.Text = $"{_sum}$";
        }
    }
}
