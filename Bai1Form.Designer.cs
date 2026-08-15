namespace BTThietKeForm
{
    partial class Bai1Form
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
            selectColorGB = new GroupBox();
            whiteRB = new RadioButton();
            redRB = new RadioButton();
            blueRB = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            priceTB = new TextBox();
            amountTB = new TextBox();
            addButton = new Button();
            carPB = new PictureBox();
            label3 = new Label();
            sumLabel = new Label();
            selectColorGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)carPB).BeginInit();
            SuspendLayout();
            // 
            // selectColorGB
            // 
            selectColorGB.Controls.Add(whiteRB);
            selectColorGB.Controls.Add(redRB);
            selectColorGB.Controls.Add(blueRB);
            selectColorGB.Location = new Point(352, 40);
            selectColorGB.Name = "selectColorGB";
            selectColorGB.Size = new Size(199, 118);
            selectColorGB.TabIndex = 0;
            selectColorGB.TabStop = false;
            selectColorGB.Text = "Chọn màu xe";
            // 
            // whiteRB
            // 
            whiteRB.AutoSize = true;
            whiteRB.Location = new Point(15, 75);
            whiteRB.Name = "whiteRB";
            whiteRB.Size = new Size(55, 19);
            whiteRB.TabIndex = 0;
            whiteRB.TabStop = true;
            whiteRB.Text = "Trắng";
            whiteRB.UseVisualStyleBackColor = true;
            whiteRB.CheckedChanged += whiteRB_CheckedChanged;
            // 
            // redRB
            // 
            redRB.AutoSize = true;
            redRB.Location = new Point(15, 50);
            redRB.Name = "redRB";
            redRB.Size = new Size(40, 19);
            redRB.TabIndex = 0;
            redRB.TabStop = true;
            redRB.Text = "Đỏ";
            redRB.UseVisualStyleBackColor = true;
            redRB.CheckedChanged += redRB_CheckedChanged;
            // 
            // blueRB
            // 
            blueRB.AutoSize = true;
            blueRB.Location = new Point(15, 25);
            blueRB.Name = "blueRB";
            blueRB.Size = new Size(52, 19);
            blueRB.TabIndex = 0;
            blueRB.TabStop = true;
            blueRB.Text = "Xanh";
            blueRB.UseVisualStyleBackColor = true;
            blueRB.CheckedChanged += blueRB_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(352, 176);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Đơn giá: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(352, 215);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Số lượng:";
            // 
            // priceTB
            // 
            priceTB.Location = new Point(422, 173);
            priceTB.Name = "priceTB";
            priceTB.ReadOnly = true;
            priceTB.Size = new Size(129, 23);
            priceTB.TabIndex = 2;
            // 
            // amountTB
            // 
            amountTB.Location = new Point(422, 212);
            amountTB.Name = "amountTB";
            amountTB.Size = new Size(129, 23);
            amountTB.TabIndex = 2;
            // 
            // addButton
            // 
            addButton.Location = new Point(434, 255);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 3;
            addButton.Text = "Tính tiền";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // carPB
            // 
            carPB.Image = Properties.Resources.white_car;
            carPB.Location = new Point(12, 26);
            carPB.Name = "carPB";
            carPB.Size = new Size(311, 209);
            carPB.SizeMode = PictureBoxSizeMode.StretchImage;
            carPB.TabIndex = 4;
            carPB.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(192, 297);
            label3.Name = "label3";
            label3.Size = new Size(175, 21);
            label3.TabIndex = 5;
            label3.Text = "Tổng tiền thanh toán:";
            // 
            // sumLabel
            // 
            sumLabel.AutoSize = true;
            sumLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sumLabel.Location = new Point(450, 297);
            sumLabel.Name = "sumLabel";
            sumLabel.Size = new Size(28, 21);
            sumLabel.TabIndex = 5;
            sumLabel.Text = "0$";
            // 
            // Bai1Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 375);
            Controls.Add(sumLabel);
            Controls.Add(label3);
            Controls.Add(carPB);
            Controls.Add(addButton);
            Controls.Add(amountTB);
            Controls.Add(priceTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(selectColorGB);
            Name = "Bai1Form";
            Text = "Mua bán xe";
            selectColorGB.ResumeLayout(false);
            selectColorGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)carPB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox selectColorGB;
        private RadioButton whiteRB;
        private RadioButton redRB;
        private RadioButton blueRB;
        private Label label1;
        private Label label2;
        private TextBox priceTB;
        private TextBox amountTB;
        private Button addButton;
        private PictureBox carPB;
        private Label label3;
        private Label sumLabel;
    }
}