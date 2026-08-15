using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BTThietKeForm
{
    public partial class Bai2Form : Form
    {
        private int _sum = 0;
        public Bai2Form()
        {
            InitializeComponent();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            // add selcted from listBox1 to listBox2
            if (itemsLB.SelectedItem != null)
            {
                selectedLB.Items.Add(itemsLB.SelectedItem);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (selectedLB.SelectedItem != null)
            {
                selectedLB.Items.Remove(selectedLB.SelectedItem);
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            _sum = 0;
            foreach (var item in selectedLB.Items)
            {
                switch (item) {
                    case "Chuột":
                        _sum += 100000;
                        break;
                    case "Bàn phím":
                        _sum += 150000;
                        break;
                    case "Máy in":
                        _sum += 2000000;
                        break;
                    case "USB kingmax":
                        _sum += 200000;
                        break;
                }
            }
            sumLabel.Text = $"{_sum} đồng";   
        }
    }
}
