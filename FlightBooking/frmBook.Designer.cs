namespace FlightBooking
{
    partial class frmBook
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
            cmbFromCity = new ComboBox();
            dtDeparture = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            cmbToCity = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            dtReturn = new DateTimePicker();
            txtPassengerNum = new NumericUpDown();
            label5 = new Label();
            rdBookType0 = new RadioButton();
            rdBookType1 = new RadioButton();
            btnDeparture = new Button();
            ((System.ComponentModel.ISupportInitialize)txtPassengerNum).BeginInit();
            SuspendLayout();
            // 
            // cmbFromCity
            // 
            cmbFromCity.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbFromCity.FormattingEnabled = true;
            cmbFromCity.Location = new Point(52, 55);
            cmbFromCity.Margin = new Padding(2);
            cmbFromCity.Name = "cmbFromCity";
            cmbFromCity.Size = new Size(129, 28);
            cmbFromCity.TabIndex = 0;
            // 
            // dtDeparture
            // 
            dtDeparture.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtDeparture.Location = new Point(52, 131);
            dtDeparture.Margin = new Padding(2);
            dtDeparture.Name = "dtDeparture";
            dtDeparture.Size = new Size(211, 27);
            dtDeparture.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(52, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 4;
            label1.Text = "Nereden";
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(284, 27);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 6;
            label2.Text = "Nereye";
            // 
            // cmbToCity
            // 
            cmbToCity.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbToCity.FormattingEnabled = true;
            cmbToCity.Location = new Point(284, 55);
            cmbToCity.Margin = new Padding(2);
            cmbToCity.Name = "cmbToCity";
            cmbToCity.Size = new Size(129, 28);
            cmbToCity.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(52, 104);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 7;
            label3.Text = "Gidiş Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(284, 104);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 9;
            label4.Text = "Dönüş Tarihi";
            // 
            // dtReturn
            // 
            dtReturn.Enabled = false;
            dtReturn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtReturn.Location = new Point(284, 131);
            dtReturn.Margin = new Padding(2);
            dtReturn.Name = "dtReturn";
            dtReturn.Size = new Size(211, 27);
            dtReturn.TabIndex = 8;
            // 
            // txtPassengerNum
            // 
            txtPassengerNum.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassengerNum.Location = new Point(52, 205);
            txtPassengerNum.Margin = new Padding(2);
            txtPassengerNum.Name = "txtPassengerNum";
            txtPassengerNum.Size = new Size(127, 27);
            txtPassengerNum.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(52, 176);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 11;
            label5.Text = "Yolcu Sayısı";
            // 
            // rdBookType0
            // 
            rdBookType0.AutoSize = true;
            rdBookType0.Checked = true;
            rdBookType0.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            rdBookType0.Location = new Point(284, 194);
            rdBookType0.Margin = new Padding(2);
            rdBookType0.Name = "rdBookType0";
            rdBookType0.Size = new Size(77, 24);
            rdBookType0.TabIndex = 12;
            rdBookType0.TabStop = true;
            rdBookType0.Text = "Tek Yön";
            rdBookType0.UseVisualStyleBackColor = true;
            rdBookType0.CheckedChanged += rdYon_CheckedChanged;
            // 
            // rdBookType1
            // 
            rdBookType1.AutoSize = true;
            rdBookType1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            rdBookType1.Location = new Point(386, 194);
            rdBookType1.Margin = new Padding(2);
            rdBookType1.Name = "rdBookType1";
            rdBookType1.Size = new Size(108, 24);
            rdBookType1.TabIndex = 13;
            rdBookType1.Text = "Gidiş-Dönüş";
            rdBookType1.UseVisualStyleBackColor = true;
            rdBookType1.CheckedChanged += rdYon2_CheckedChanged;
            // 
            // btnDeparture
            // 
            btnDeparture.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeparture.Location = new Point(361, 243);
            btnDeparture.Margin = new Padding(2);
            btnDeparture.Name = "btnDeparture";
            btnDeparture.Size = new Size(133, 29);
            btnDeparture.TabIndex = 14;
            btnDeparture.Text = " Gidiş Bilgileri";
            btnDeparture.UseVisualStyleBackColor = true;
            btnDeparture.Click += btnDeparture_Click;
            // 
            // frmBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 283);
            Controls.Add(btnDeparture);
            Controls.Add(rdBookType1);
            Controls.Add(rdBookType0);
            Controls.Add(label5);
            Controls.Add(txtPassengerNum);
            Controls.Add(label4);
            Controls.Add(dtReturn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbToCity);
            Controls.Add(label1);
            Controls.Add(dtDeparture);
            Controls.Add(cmbFromCity);
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Uçak Reservasyonu";
            FormClosed += frmBook_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)txtPassengerNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbFromCity;
        private DateTimePicker dtDeparture;
        private Label label1;
        private Label label2;
        private ComboBox cmbToCity;
        private Label label3;
        private Label label4;
        private DateTimePicker dtReturn;
        private NumericUpDown txtPassengerNum;
        private Label label5;
        private RadioButton rdBookType0;
        private RadioButton rdBookType1;
        private Button btnDeparture;
    }
}