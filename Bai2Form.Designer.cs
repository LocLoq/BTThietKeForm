namespace BTThietKeForm
{
    partial class Bai2Form
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
            itemsLB = new ListBox();
            panel1 = new Panel();
            selectButton = new Button();
            panel2 = new Panel();
            sumLabel = new Label();
            label1 = new Label();
            calculateButton = new Button();
            removeButton = new Button();
            selectedLB = new ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // itemsLB
            // 
            itemsLB.FormattingEnabled = true;
            itemsLB.Items.AddRange(new object[] { "Chuột", "Bàn phím", "Máy in", "USB kingmax" });
            itemsLB.Location = new Point(14, 33);
            itemsLB.Name = "itemsLB";
            itemsLB.Size = new Size(120, 94);
            itemsLB.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(selectButton);
            panel1.Controls.Add(itemsLB);
            panel1.Location = new Point(22, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 174);
            panel1.TabIndex = 1;
            // 
            // selectButton
            // 
            selectButton.Location = new Point(156, 51);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(96, 22);
            selectButton.TabIndex = 1;
            selectButton.Text = "Chọn hàng >";
            selectButton.UseVisualStyleBackColor = true;
            selectButton.Click += selectButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(sumLabel);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(calculateButton);
            panel2.Controls.Add(removeButton);
            panel2.Controls.Add(selectedLB);
            panel2.Location = new Point(316, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(325, 174);
            panel2.TabIndex = 1;
            // 
            // sumLabel
            // 
            sumLabel.AutoSize = true;
            sumLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sumLabel.ForeColor = Color.FromArgb(255, 128, 255);
            sumLabel.Location = new Point(182, 141);
            sumLabel.Name = "sumLabel";
            sumLabel.Size = new Size(58, 20);
            sumLabel.TabIndex = 2;
            sumLabel.Text = "0 đồng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 141);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 2;
            label1.Text = "Tổng tiền thanh toán:";
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(122, 112);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 23);
            calculateButton.TabIndex = 1;
            calculateButton.Text = "Tinh tiền";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(15, 51);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(75, 23);
            removeButton.TabIndex = 1;
            removeButton.Text = "< Bỏ hàng";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // selectedLB
            // 
            selectedLB.FormattingEnabled = true;
            selectedLB.Location = new Point(105, 12);
            selectedLB.Name = "selectedLB";
            selectedLB.Size = new Size(120, 94);
            selectedLB.TabIndex = 0;
            // 
            // Bai2Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 200);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Bai2Form";
            Text = "Bán hàng";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox itemsLB;
        private Panel panel1;
        private Panel panel2;
        private ListBox selectedLB;
        private Button selectButton;
        private Button removeButton;
        private Label label1;
        private Label sumLabel;
        private Button calculateButton;
    }
}