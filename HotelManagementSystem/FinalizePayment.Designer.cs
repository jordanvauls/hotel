namespace HotelManagementSystem
{
    partial class FinalizePayment
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
            this.foodBillAmount = new MetroFramework.Controls.MetroLabel();
            this.foodBillLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.cardTypeView = new MetroFramework.Controls.MetroLabel();
            this.cvcComboBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.yearComboBox = new MetroFramework.Controls.MetroComboBox();
            this.monthComboBox = new MetroFramework.Controls.MetroComboBox();
            this.totalAmount = new MetroFramework.Controls.MetroLabel();
            this.totalLabel = new MetroFramework.Controls.MetroLabel();
            this.taxAmount = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.currentBill = new MetroFramework.Controls.MetroLabel();
            this.paymentComboBox = new MetroFramework.Controls.MetroComboBox();
            this.priceLabel = new MetroFramework.Controls.MetroLabel();
            this.currentBillAmount = new MetroFramework.Controls.MetroLabel();
            this.phoneNComboBox = new MetroFramework.Controls.MetroTextBox();
            this.reservation = new MetroFramework.Controls.MetroLabel();
            this.paymentLabel = new MetroFramework.Controls.MetroLabel();
            this.nextButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // foodBillAmount
            // 
            this.foodBillAmount.AutoSize = true;
            this.foodBillAmount.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.foodBillAmount.Location = new System.Drawing.Point(365, 119);
            this.foodBillAmount.Name = "foodBillAmount";
            this.foodBillAmount.Size = new System.Drawing.Size(17, 19);
            this.foodBillAmount.TabIndex = 61;
            this.foodBillAmount.Text = "£";
            this.foodBillAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // foodBillLabel
            // 
            this.foodBillLabel.AutoSize = true;
            this.foodBillLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.foodBillLabel.Location = new System.Drawing.Point(23, 119);
            this.foodBillLabel.Name = "foodBillLabel";
            this.foodBillLabel.Size = new System.Drawing.Size(61, 19);
            this.foodBillLabel.TabIndex = 60;
            this.foodBillLabel.Text = "Food bill";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(224, 254);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(76, 19);
            this.metroLabel12.TabIndex = 59;
            this.metroLabel12.Text = "Card type :";
            // 
            // cardTypeView
            // 
            this.cardTypeView.AutoSize = true;
            this.cardTypeView.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.cardTypeView.Location = new System.Drawing.Point(305, 255);
            this.cardTypeView.Name = "cardTypeView";
            this.cardTypeView.Size = new System.Drawing.Size(68, 19);
            this.cardTypeView.TabIndex = 58;
            this.cardTypeView.Text = "Unknown";
            // 
            // cvcComboBox
            // 
            this.cvcComboBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.cvcComboBox.CustomButton.Image = null;
            this.cvcComboBox.CustomButton.Location = new System.Drawing.Point(13, 1);
            this.cvcComboBox.CustomButton.Name = "";
            this.cvcComboBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.cvcComboBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cvcComboBox.CustomButton.TabIndex = 1;
            this.cvcComboBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cvcComboBox.CustomButton.UseSelectable = true;
            this.cvcComboBox.CustomButton.Visible = false;
            this.cvcComboBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.cvcComboBox.Lines = new string[0];
            this.cvcComboBox.Location = new System.Drawing.Point(170, 248);
            this.cvcComboBox.MaxLength = 32767;
            this.cvcComboBox.Name = "cvcComboBox";
            this.cvcComboBox.PasswordChar = '\0';
            this.cvcComboBox.PromptText = "CVC";
            this.cvcComboBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cvcComboBox.SelectedText = "";
            this.cvcComboBox.SelectionLength = 0;
            this.cvcComboBox.SelectionStart = 0;
            this.cvcComboBox.ShortcutsEnabled = true;
            this.cvcComboBox.Size = new System.Drawing.Size(41, 29);
            this.cvcComboBox.Style = MetroFramework.MetroColorStyle.White;
            this.cvcComboBox.TabIndex = 57;
            this.cvcComboBox.UseCustomBackColor = true;
            this.cvcComboBox.UseSelectable = true;
            this.cvcComboBox.WaterMark = "CVC";
            this.cvcComboBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cvcComboBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(92, 252);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(14, 19);
            this.metroLabel10.TabIndex = 56;
            this.metroLabel10.Text = "/";
            // 
            // yearComboBox
            // 
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.ItemHeight = 23;
            this.yearComboBox.Items.AddRange(new object[] {
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.yearComboBox.Location = new System.Drawing.Point(110, 248);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.PromptText = "YY";
            this.yearComboBox.Size = new System.Drawing.Size(45, 29);
            this.yearComboBox.TabIndex = 55;
            this.yearComboBox.UseSelectable = true;
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.ItemHeight = 23;
            this.monthComboBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.monthComboBox.Location = new System.Drawing.Point(27, 247);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.PromptText = "MM";
            this.monthComboBox.Size = new System.Drawing.Size(59, 29);
            this.monthComboBox.TabIndex = 54;
            this.monthComboBox.UseSelectable = true;
            this.monthComboBox.SelectedIndexChanged += new System.EventHandler(this.monthComboBox_SelectedIndexChanged_1);
            // 
            // totalAmount
            // 
            this.totalAmount.AutoSize = true;
            this.totalAmount.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.totalAmount.Location = new System.Drawing.Point(343, 174);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(17, 19);
            this.totalAmount.TabIndex = 53;
            this.totalAmount.Text = "£";
            this.totalAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.totalLabel.Location = new System.Drawing.Point(254, 174);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(42, 19);
            this.totalLabel.TabIndex = 52;
            this.totalLabel.Text = "Total";
            // 
            // taxAmount
            // 
            this.taxAmount.AutoSize = true;
            this.taxAmount.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.taxAmount.Location = new System.Drawing.Point(352, 146);
            this.taxAmount.Name = "taxAmount";
            this.taxAmount.Size = new System.Drawing.Size(17, 19);
            this.taxAmount.TabIndex = 51;
            this.taxAmount.Text = "£";
            this.taxAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(276, 146);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(27, 19);
            this.metroLabel5.TabIndex = 50;
            this.metroLabel5.Text = "Tax";
            // 
            // currentBill
            // 
            this.currentBill.AutoSize = true;
            this.currentBill.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.currentBill.Location = new System.Drawing.Point(23, 95);
            this.currentBill.Name = "currentBill";
            this.currentBill.Size = new System.Drawing.Size(77, 19);
            this.currentBill.TabIndex = 46;
            this.currentBill.Text = "Current bill";
            // 
            // paymentComboBox
            // 
            this.paymentComboBox.FormattingEnabled = true;
            this.paymentComboBox.ItemHeight = 23;
            this.paymentComboBox.Items.AddRange(new object[] {
            "Credit",
            "Debit"});
            this.paymentComboBox.Location = new System.Drawing.Point(27, 206);
            this.paymentComboBox.Name = "paymentComboBox";
            this.paymentComboBox.PromptText = "Payment type";
            this.paymentComboBox.Size = new System.Drawing.Size(128, 29);
            this.paymentComboBox.TabIndex = 49;
            this.paymentComboBox.UseSelectable = true;
            this.paymentComboBox.SelectedIndexChanged += new System.EventHandler(this.paymentComboBox_SelectedIndexChanged_1);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.priceLabel.Location = new System.Drawing.Point(399, 72);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(38, 19);
            this.priceLabel.TabIndex = 45;
            this.priceLabel.Text = "Price";
            // 
            // currentBillAmount
            // 
            this.currentBillAmount.AutoSize = true;
            this.currentBillAmount.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.currentBillAmount.Location = new System.Drawing.Point(365, 95);
            this.currentBillAmount.Name = "currentBillAmount";
            this.currentBillAmount.Size = new System.Drawing.Size(17, 19);
            this.currentBillAmount.TabIndex = 44;
            this.currentBillAmount.Text = "£";
            this.currentBillAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // phoneNComboBox
            // 
            this.phoneNComboBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.phoneNComboBox.CustomButton.Image = null;
            this.phoneNComboBox.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.phoneNComboBox.CustomButton.Name = "";
            this.phoneNComboBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.phoneNComboBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.phoneNComboBox.CustomButton.TabIndex = 1;
            this.phoneNComboBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.phoneNComboBox.CustomButton.UseSelectable = true;
            this.phoneNComboBox.CustomButton.Visible = false;
            this.phoneNComboBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.phoneNComboBox.Lines = new string[0];
            this.phoneNComboBox.Location = new System.Drawing.Point(170, 206);
            this.phoneNComboBox.MaxLength = 32767;
            this.phoneNComboBox.Name = "phoneNComboBox";
            this.phoneNComboBox.PasswordChar = '\0';
            this.phoneNComboBox.PromptText = "9999 - 9999 - 9999 - 9999";
            this.phoneNComboBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phoneNComboBox.SelectedText = "";
            this.phoneNComboBox.SelectionLength = 0;
            this.phoneNComboBox.SelectionStart = 0;
            this.phoneNComboBox.ShortcutsEnabled = true;
            this.phoneNComboBox.Size = new System.Drawing.Size(267, 29);
            this.phoneNComboBox.Style = MetroFramework.MetroColorStyle.White;
            this.phoneNComboBox.TabIndex = 48;
            this.phoneNComboBox.UseCustomBackColor = true;
            this.phoneNComboBox.UseSelectable = true;
            this.phoneNComboBox.WaterMark = "9999 - 9999 - 9999 - 9999";
            this.phoneNComboBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.phoneNComboBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.phoneNComboBox.Leave += new System.EventHandler(this.phoneNComboBox_Leave_1);
            // 
            // reservation
            // 
            this.reservation.AutoSize = true;
            this.reservation.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.reservation.Location = new System.Drawing.Point(23, 72);
            this.reservation.Name = "reservation";
            this.reservation.Size = new System.Drawing.Size(80, 19);
            this.reservation.TabIndex = 43;
            this.reservation.Text = "Reservation";
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.BackColor = System.Drawing.Color.Transparent;
            this.paymentLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.paymentLabel.Location = new System.Drawing.Point(23, 184);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(63, 19);
            this.paymentLabel.TabIndex = 47;
            this.paymentLabel.Text = "Payment";
            this.paymentLabel.UseCustomBackColor = true;
            this.paymentLabel.UseCustomForeColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(349, 290);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(88, 34);
            this.nextButton.TabIndex = 42;
            this.nextButton.Text = "Next";
            this.nextButton.UseSelectable = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click_1);
            // 
            // FinalizePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 400);
            this.Controls.Add(this.foodBillAmount);
            this.Controls.Add(this.foodBillLabel);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.cardTypeView);
            this.Controls.Add(this.cvcComboBox);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.totalAmount);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxAmount);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.currentBill);
            this.Controls.Add(this.paymentComboBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.currentBillAmount);
            this.Controls.Add(this.phoneNComboBox);
            this.Controls.Add(this.reservation);
            this.Controls.Add(this.paymentLabel);
            this.Controls.Add(this.nextButton);
            this.Name = "FinalizePayment";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FinalizePayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel foodBillAmount;
        private MetroFramework.Controls.MetroLabel foodBillLabel;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel cardTypeView;
        public MetroFramework.Controls.MetroTextBox cvcComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        public MetroFramework.Controls.MetroComboBox yearComboBox;
        public MetroFramework.Controls.MetroComboBox monthComboBox;
        private MetroFramework.Controls.MetroLabel totalAmount;
        private MetroFramework.Controls.MetroLabel totalLabel;
        private MetroFramework.Controls.MetroLabel taxAmount;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel currentBill;
        public MetroFramework.Controls.MetroComboBox paymentComboBox;
        private MetroFramework.Controls.MetroLabel priceLabel;
        private MetroFramework.Controls.MetroLabel currentBillAmount;
        public MetroFramework.Controls.MetroTextBox phoneNComboBox;
        private MetroFramework.Controls.MetroLabel reservation;
        private MetroFramework.Controls.MetroLabel paymentLabel;
        private MetroFramework.Controls.MetroButton nextButton;
    }
}