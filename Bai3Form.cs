using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BTThietKeForm
{
    public partial class Bai3Form : Form
    {
        private List<Dictionary<string, string>> _wordDefPairs = new List<Dictionary<string, string>>();
        public Bai3Form()
        {
            InitializeComponent();
        }

        private void Bai3Form_Load(object sender, EventArgs e)
        {

        }

        private void addNewDefButton_Click(object sender, EventArgs e)
        {
            _wordDefPairs.Add(new Dictionary<string, string>
            {
                { "word", wordTB.Text },
                { "definition", meaningTB.Text }
            });
            listBox1.Items.Add(wordTB.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                var selectedWord = listBox1.SelectedItem.ToString();
                var wordDefPair = _wordDefPairs.Find(pair => pair["word"] == selectedWord);
                if (wordDefPair != null)
                {
                    meaningTB2.Text = wordDefPair["definition"];
                }
            }
        }
    }
}
