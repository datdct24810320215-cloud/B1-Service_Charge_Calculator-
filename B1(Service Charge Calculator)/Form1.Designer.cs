namespace B1_Service_Charge_Calculator_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelPrice = new Label();
            textBoxPrice = new TextBox();
            labelQuantity = new Label();
            textBoxQuantity = new TextBox();
            labelDiscount = new Label();
            textBoxDiscount = new TextBox();
            buttonCalculate = new Button();
            buttonReset = new Button();
            labelTotalTitle = new Label();
            labelTotalValue = new Label();
            SuspendLayout();
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(24, 22);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(93, 15);
            labelPrice.TabIndex = 10;
            labelPrice.Text = "Đơn giá dịch vụ:";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(160, 19);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(150, 23);
            textBoxPrice.TabIndex = 0;
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Location = new Point(24, 62);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(92, 15);
            labelQuantity.TabIndex = 11;
            labelQuantity.Text = "Số lượng khách:";
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new Point(160, 59);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(150, 23);
            textBoxQuantity.TabIndex = 1;
            // 
            // labelDiscount
            // 
            labelDiscount.AutoSize = true;
            labelDiscount.Location = new Point(24, 102);
            labelDiscount.Name = "labelDiscount";
            labelDiscount.Size = new Size(97, 15);
            labelDiscount.TabIndex = 12;
            labelDiscount.Text = "Mã giảm giá (%):";
            // 
            // textBoxDiscount
            // 
            textBoxDiscount.Location = new Point(160, 99);
            textBoxDiscount.Name = "textBoxDiscount";
            textBoxDiscount.Size = new Size(150, 23);
            textBoxDiscount.TabIndex = 2;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(24, 145);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(120, 35);
            buttonCalculate.TabIndex = 3;
            buttonCalculate.Text = "Tính tiền";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(190, 145);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(120, 35);
            buttonReset.TabIndex = 4;
            buttonReset.Text = "Làm mới";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // labelTotalTitle
            // 
            labelTotalTitle.AutoSize = true;
            labelTotalTitle.Location = new Point(24, 200);
            labelTotalTitle.Name = "labelTotalTitle";
            labelTotalTitle.Size = new Size(121, 15);
            labelTotalTitle.TabIndex = 13;
            labelTotalTitle.Text = "Tổng tiền thanh toán:";
            // 
            // labelTotalValue
            // 
            labelTotalValue.AutoSize = true;
            labelTotalValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTotalValue.Location = new Point(200, 198);
            labelTotalValue.Name = "labelTotalValue";
            labelTotalValue.Size = new Size(37, 19);
            labelTotalValue.TabIndex = 14;
            labelTotalValue.Text = "0.00";
            // 
            // Form1
            // 
            AcceptButton = buttonCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 265);
            Controls.Add(labelPrice);
            Controls.Add(textBoxPrice);
            Controls.Add(labelQuantity);
            Controls.Add(textBoxQuantity);
            Controls.Add(labelDiscount);
            Controls.Add(textBoxDiscount);
            Controls.Add(buttonCalculate);
            Controls.Add(buttonReset);
            Controls.Add(labelTotalTitle);
            Controls.Add(labelTotalValue);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Service Charge Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelTotalTitle;
        private System.Windows.Forms.Label labelTotalValue;

        #endregion
    }
}
