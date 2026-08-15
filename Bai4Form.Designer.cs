namespace BTThietKeForm
{
    partial class Bai4Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            searchButton = new Button();
            label3 = new Label();
            label4 = new Label();
            foundResultTB = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 23);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(218, 184);
            listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(334, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(344, 95);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 3;
            searchButton.Text = "Tìm kiếm";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += this.searchButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 69);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 1;
            label3.Text = "Nhập số:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(236, 179);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 1;
            label4.Text = "Kết quả:";
            // 
            // foundResultTB
            // 
            foundResultTB.AutoSize = true;
            foundResultTB.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            foundResultTB.ForeColor = Color.Red;
            foundResultTB.Location = new Point(334, 179);
            foundResultTB.Name = "foundResultTB";
            foundResultTB.Size = new Size(51, 20);
            foundResultTB.TabIndex = 1;
            foundResultTB.Text = "label1";
            // 
            // Bai4Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 230);
            Controls.Add(searchButton);
            Controls.Add(textBox1);
            Controls.Add(foundResultTB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Name = "Bai4Form";
            Text = "Tìm số trong danh sách";
            Load += Bai4Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private ListBox listBox1;
        private TextBox textBox1;
        private Button searchButton;
        private Label label3;
        private Label label4;
        private Label foundResultTB;
    }
}