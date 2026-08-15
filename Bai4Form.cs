using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BTThietKeForm
{
    public partial class Bai4Form : Form
    {
        public Bai4Form()
        {
            InitializeComponent();
        }
        private void Bai4Form_Load(object sender, EventArgs e)
        {
            // add 10 random numbers to the listbox
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(rand.Next(1, 100));
            }

        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            int searchValue;
            if (int.TryParse(textBox1.Text, out searchValue))
            {
                bool found = false;
                foreach (var item in listBox1.Items)
                {
                    if ((int)item == searchValue)
                    {
                        found = true;
                        break;
                    }
                }
                foundResultTB.Text = found ? "Tìm thấy" : "Không tìm thấy";
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }
    }
}
