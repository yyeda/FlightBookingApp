namespace FlightBooking
{
    partial class frmFlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFlight));
            lblTime = new Label();
            dtTime = new DateTimePicker();
            label2 = new Label();
            txtName = new TextBox();
            grdSeat = new DataGridView();
            btnSeatCancel = new Button();
            btnAction = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)grdSeat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.Location = new Point(29, 16);
            lblTime.Margin = new Padding(2, 0, 2, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(79, 20);
            lblTime.TabIndex = 9;
            lblTime.Text = "Gidiş Saati";
            // 
            // dtTime
            // 
            dtTime.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtTime.Format = DateTimePickerFormat.Time;
            dtTime.Location = new Point(29, 43);
            dtTime.Margin = new Padding(2);
            dtTime.Name = "dtTime";
            dtTime.Size = new Size(211, 27);
            dtTime.TabIndex = 8;
            dtTime.ValueChanged += dtTime_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 224);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 12;
            label2.Text = "Adı Soyadı";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(29, 253);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(211, 27);
            txtName.TabIndex = 13;
            // 
            // grdSeat
            // 
            grdSeat.AllowUserToAddRows = false;
            grdSeat.AllowUserToDeleteRows = false;
            grdSeat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSeat.Location = new Point(266, 16);
            grdSeat.Margin = new Padding(2);
            grdSeat.MultiSelect = false;
            grdSeat.Name = "grdSeat";
            grdSeat.RowHeadersWidth = 62;
            grdSeat.RowTemplate.Height = 33;
            grdSeat.Size = new Size(465, 356);
            grdSeat.TabIndex = 14;
            grdSeat.CellContentClick += grdSeat_CellContentClick;
            // 
            // btnSeatCancel
            // 
            btnSeatCancel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeatCancel.Location = new Point(116, 297);
            btnSeatCancel.Margin = new Padding(2);
            btnSeatCancel.Name = "btnSeatCancel";
            btnSeatCancel.Size = new Size(124, 29);
            btnSeatCancel.TabIndex = 15;
            btnSeatCancel.Text = "Kolutuk İptal";
            btnSeatCancel.UseVisualStyleBackColor = true;
            btnSeatCancel.Click += btnSeatCancel_Click;
            // 
            // btnAction
            // 
            btnAction.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnAction.Location = new Point(116, 340);
            btnAction.Margin = new Padding(2);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(124, 29);
            btnAction.TabIndex = 16;
            btnAction.Text = "Dönüş Bilgileri";
            btnAction.UseVisualStyleBackColor = true;
            btnAction.Click += btnAction_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 146);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // frmFlight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 393);
            Controls.Add(pictureBox1);
            Controls.Add(btnAction);
            Controls.Add(btnSeatCancel);
            Controls.Add(grdSeat);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(lblTime);
            Controls.Add(dtTime);
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmFlight";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gidiş Reservasyon";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)grdSeat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTime;
        private DateTimePicker dtTime;
        private Label label2;
        private TextBox txtName;
        private DataGridView grdSeat;
        private Button btnSeatCancel;
        private Button btnAction;
        private PictureBox pictureBox1;
    }
}