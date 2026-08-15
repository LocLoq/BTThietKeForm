namespace BTThietKeForm
{
    partial class Bai3Form
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
            label1 = new Label();
            label2 = new Label();
            wordTB = new TextBox();
            meaningTB = new TextBox();
            listBox1 = new ListBox();
            label3 = new Label();
            meaningTB2 = new TextBox();
            label4 = new Label();
            addNewDefButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 35);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Từ mới:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 142);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 0;
            label2.Text = "DANH SÁCH TỪ MỚI";
            // 
            // wordTB
            // 
            wordTB.Location = new Point(133, 27);
            wordTB.Name = "wordTB";
            wordTB.Size = new Size(445, 23);
            wordTB.TabIndex = 1;
            // 
            // meaningTB
            // 
            meaningTB.Location = new Point(133, 59);
            meaningTB.Name = "meaningTB";
            meaningTB.Size = new Size(445, 23);
            meaningTB.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(36, 166);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(188, 154);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 67);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 0;
            label3.Text = "Nghĩa của từ:";
            // 
            // meaningTB2
            // 
            meaningTB2.Location = new Point(359, 166);
            meaningTB2.Multiline = true;
            meaningTB2.Name = "meaningTB2";
            meaningTB2.ReadOnly = true;
            meaningTB2.Size = new Size(191, 154);
            meaningTB2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(405, 142);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 0;
            label4.Text = "NGHĨA CỦA TỪ";
            // 
            // addNewDefButton
            // 
            addNewDefButton.Location = new Point(288, 88);
            addNewDefButton.Name = "addNewDefButton";
            addNewDefButton.Size = new Size(115, 35);
            addNewDefButton.TabIndex = 4;
            addNewDefButton.Text = "Thêm từ mới";
            addNewDefButton.UseVisualStyleBackColor = true;
            addNewDefButton.Click += addNewDefButton_Click;
            // 
            // Bai3Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 351);
            Controls.Add(addNewDefButton);
            Controls.Add(meaningTB2);
            Controls.Add(listBox1);
            Controls.Add(meaningTB);
            Controls.Add(wordTB);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Bai3Form";
            Text = "Bai3";
            Load += Bai3Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox wordTB;
        private TextBox meaningTB;
        private ListBox listBox1;
        private Label label3;
        private TextBox meaningTB2;
        private Label label4;
        private Button addNewDefButton;
    }
}