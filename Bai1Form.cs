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
        private bool[] _easterEggBits = new bool[3];
        private bool _isEasterEggActivated = false;
        private int _keyPressCount = 0;
        public Bai1Form()
        {
            InitializeComponent();
            ResetEasterEggBit();
        }

        private void blueRB_CheckedChanged(object sender, EventArgs e)
        {
            // Set the price and amount based on the selected color
            if (blueRB.Checked)
            {
                priceTB.Text = "22000";
                amountTB.Text = "1";
                carPB.Image = _isEasterEggActivated? Properties.Resources.sunna : Properties.Resources.blue_car; // Assuming you have an image resource named blue_car
            }
        }

        private void redRB_CheckedChanged(object sender, EventArgs e)
        {
            // Set the price and amount based on the selected color
            if (redRB.Checked)
            {
                priceTB.Text = "21000";
                amountTB.Text = "1";
                carPB.Image = _isEasterEggActivated? Properties.Resources.aria : Properties.Resources.red_car; // Assuming you have an image resource named red_car
            }
        }

        private void whiteRB_CheckedChanged(object sender, EventArgs e)
        {
            // Set the price and amount based on the selected color
            if (whiteRB.Checked)
            {
                priceTB.Text = "20000";
                amountTB.Text = "1";
                carPB.Image = _isEasterEggActivated? Properties.Resources.nangong : Properties.Resources.white_car; // Assuming you have an image resource named white_car
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

        private void Bai1Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'a')
            {
                _easterEggBits[0] = true;
            }
            else if (e.KeyChar == 'o' && _easterEggBits[0])
            {
                _easterEggBits[1] = true;
            }
            else if (e.KeyChar == 'd' && _easterEggBits[0] && _easterEggBits[1])
            {
                _easterEggBits[2] = true;
            }
            if (_easterEggBits[0] && _easterEggBits[1] && _easterEggBits[2] && !_isEasterEggActivated)
            {
                _isEasterEggActivated = true;
                ResetEasterEggBit();
                blueRB.Text = "Sunna";
                redRB.Text = "Aria";
                whiteRB.Text = "Nangong";
                selectColorGB.Text = "Chọn thiên thần";
            }
            _keyPressCount++;
            if (_keyPressCount == 4)
            {
                _keyPressCount = 0;
                ResetEasterEggBit();
            }
        }
        private void ResetEasterEggBit()
        {
            for (int i = 0; i < 3; i++)
            {
                _easterEggBits[i] = false;
            }
        }
    }
}
