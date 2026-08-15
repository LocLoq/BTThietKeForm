namespace BTThietKeForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bài1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai1Form bai1Form = new Bai1Form();
            bai1Form.ShowDialog();
        }

        private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai2Form bai2Form = new Bai2Form();
            bai2Form.ShowDialog();
        }

        private void bài3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai3Form bai3Form = new Bai3Form();
            bai3Form.ShowDialog();
        }

        private void bài4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai4Form bai4Form = new Bai4Form();
            bai4Form.ShowDialog(); 
        }
    }
}
