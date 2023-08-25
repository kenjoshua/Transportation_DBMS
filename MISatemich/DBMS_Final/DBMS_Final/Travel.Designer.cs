
namespace DBMS_Final
{
    partial class Travel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Travel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ID_Edit = new System.Windows.Forms.TextBox();
            this.TCostTb = new System.Windows.Forms.TextBox();
            this.Destination = new System.Windows.Forms.ComboBox();
            this.Source = new System.Windows.Forms.ComboBox();
            this.TCode = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TravDate = new System.Windows.Forms.DateTimePicker();
            this.button_WOC4 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC2 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.TravelDGV = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TravelDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(105)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.ID_Edit);
            this.panel1.Controls.Add(this.TCostTb);
            this.panel1.Controls.Add(this.Destination);
            this.panel1.Controls.Add(this.Source);
            this.panel1.Controls.Add(this.TCode);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.TravDate);
            this.panel1.Controls.Add(this.button_WOC4);
            this.panel1.Controls.Add(this.button_WOC2);
            this.panel1.Controls.Add(this.button_WOC1);
            this.panel1.Controls.Add(this.TravelDGV);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(-3, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 571);
            this.panel1.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB Demi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(250, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(383, 33);
            this.label10.TabIndex = 24;
            this.label10.Text = "Railway Reservation System";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 462);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 26);
            this.label8.TabIndex = 23;
            this.label8.Text = "Travel Code:";
            // 
            // ID_Edit
            // 
            this.ID_Edit.Font = new System.Drawing.Font("Candara", 12F);
            this.ID_Edit.Location = new System.Drawing.Point(17, 493);
            this.ID_Edit.Name = "ID_Edit";
            this.ID_Edit.Size = new System.Drawing.Size(271, 27);
            this.ID_Edit.TabIndex = 22;
            // 
            // TCostTb
            // 
            this.TCostTb.Font = new System.Drawing.Font("Candara", 12F);
            this.TCostTb.Location = new System.Drawing.Point(17, 385);
            this.TCostTb.Name = "TCostTb";
            this.TCostTb.Size = new System.Drawing.Size(271, 27);
            this.TCostTb.TabIndex = 21;
            // 
            // Destination
            // 
            this.Destination.Font = new System.Drawing.Font("Candara", 12F);
            this.Destination.FormattingEnabled = true;
            this.Destination.Items.AddRange(new object[] {
            "North Avenue",
            "Quezon Avenue",
            "GMA Kamuning",
            "Cubao",
            "Santolan-Annapolis",
            "Ortigas",
            "Ortigas",
            "Shaw Boulevard",
            "Boni",
            "Guadalupe",
            "Buendia",
            "Ayala",
            "Magallanes",
            "Taft Avenue"});
            this.Destination.Location = new System.Drawing.Point(17, 318);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(271, 27);
            this.Destination.TabIndex = 20;
            this.Destination.SelectedIndexChanged += new System.EventHandler(this.Destination_SelectedIndexChanged);
            // 
            // Source
            // 
            this.Source.Font = new System.Drawing.Font("Candara", 12F);
            this.Source.FormattingEnabled = true;
            this.Source.Items.AddRange(new object[] {
            "North Avenue",
            "Quezon Avenue",
            "GMA Kamuning",
            "Cubao",
            "Santolan-Annapolis",
            "Ortigas",
            "Ortigas",
            "Shaw Boulevard",
            "Boni",
            "Guadalupe",
            "Buendia",
            "Ayala",
            "Magallanes",
            "Taft Avenue"});
            this.Source.Location = new System.Drawing.Point(17, 251);
            this.Source.Name = "Source";
            this.Source.Size = new System.Drawing.Size(271, 27);
            this.Source.TabIndex = 20;
            this.Source.SelectedIndexChanged += new System.EventHandler(this.Source_SelectedIndexChanged);
            // 
            // TCode
            // 
            this.TCode.Font = new System.Drawing.Font("Candara", 12F);
            this.TCode.FormattingEnabled = true;
            this.TCode.Location = new System.Drawing.Point(17, 186);
            this.TCode.Name = "TCode";
            this.TCode.Size = new System.Drawing.Size(271, 27);
            this.TCode.TabIndex = 20;
            this.TCode.SelectedIndexChanged += new System.EventHandler(this.TCode_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(336, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // TravDate
            // 
            this.TravDate.CalendarFont = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TravDate.Font = new System.Drawing.Font("Candara", 12F);
            this.TravDate.Location = new System.Drawing.Point(17, 119);
            this.TravDate.Name = "TravDate";
            this.TravDate.Size = new System.Drawing.Size(271, 27);
            this.TravDate.TabIndex = 18;
            this.TravDate.ValueChanged += new System.EventHandler(this.TravDate_ValueChanged);
            // 
            // button_WOC4
            // 
            this.button_WOC4.BackColor = System.Drawing.Color.Green;
            this.button_WOC4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(156)))), ((int)(((byte)(27)))));
            this.button_WOC4.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(156)))), ((int)(((byte)(27)))));
            this.button_WOC4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_WOC4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC4.Location = new System.Drawing.Point(133, 418);
            this.button_WOC4.Name = "button_WOC4";
            this.button_WOC4.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(156)))), ((int)(((byte)(27)))));
            this.button_WOC4.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(156)))), ((int)(((byte)(27)))));
            this.button_WOC4.OnHoverTextColor = System.Drawing.Color.Black;
            this.button_WOC4.Size = new System.Drawing.Size(110, 27);
            this.button_WOC4.TabIndex = 14;
            this.button_WOC4.Text = "RESET";
            this.button_WOC4.TextColor = System.Drawing.Color.Black;
            this.button_WOC4.UseVisualStyleBackColor = false;
            this.button_WOC4.Click += new System.EventHandler(this.button_WOC4_Click);
            // 
            // button_WOC2
            // 
            this.button_WOC2.BackColor = System.Drawing.Color.Green;
            this.button_WOC2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(156)))), ((int)(((byte)(27)))));
            this.button_WOC2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(156)))), ((int)(((byte)(27)))));
            this.button_WOC2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_WOC2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.button_WOC2.Location = new System.Drawing.Point(17, 526);
            this.button_WOC2.Name = "button_WOC2";
            this.button_WOC2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(156)))), ((int)(((byte)(27)))));
            this.button_WOC2.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(156)))), ((int)(((byte)(27)))));
            this.button_WOC2.OnHoverTextColor = System.Drawing.Color.Black;
            this.button_WOC2.Size = new System.Drawing.Size(110, 27);
            this.button_WOC2.TabIndex = 14;
            this.button_WOC2.Text = "EDIT";
            this.button_WOC2.TextColor = System.Drawing.Color.Black;
            this.button_WOC2.UseVisualStyleBackColor = false;
            this.button_WOC2.Click += new System.EventHandler(this.button_WOC2_Click);
            // 
            // button_WOC1
            // 
            this.button_WOC1.BackColor = System.Drawing.Color.Green;
            this.button_WOC1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(156)))), ((int)(((byte)(27)))));
            this.button_WOC1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(156)))), ((int)(((byte)(27)))));
            this.button_WOC1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_WOC1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.button_WOC1.Location = new System.Drawing.Point(17, 418);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(156)))), ((int)(((byte)(27)))));
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(156)))), ((int)(((byte)(27)))));
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Black;
            this.button_WOC1.Size = new System.Drawing.Size(110, 27);
            this.button_WOC1.TabIndex = 14;
            this.button_WOC1.Text = "ADD";
            this.button_WOC1.TextColor = System.Drawing.Color.Black;
            this.button_WOC1.UseVisualStyleBackColor = false;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // TravelDGV
            // 
            this.TravelDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TravelDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TravelDGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.TravelDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TravelDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TravelDGV.Location = new System.Drawing.Point(303, 119);
            this.TravelDGV.Name = "TravelDGV";
            this.TravelDGV.Size = new System.Drawing.Size(586, 434);
            this.TravelDGV.TabIndex = 13;
            this.TravelDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TravelDGV_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 26);
            this.label7.TabIndex = 10;
            this.label7.Text = "Travel Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Destination Point";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Starting Point";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Train Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(387, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Travel Master";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(9, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 27);
            this.label9.TabIndex = 24;
            this.label9.Text = "Cashier";
            // 
            // Travel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(156)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(902, 639);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Travel";
            this.Text = "RSS | Cashier: Travel Master";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TravelDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ePOSOne.btnProduct.Button_WOC button_WOC4;
        private ePOSOne.btnProduct.Button_WOC button_WOC2;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
        private System.Windows.Forms.DataGridView TravelDGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker TravDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Destination;
        private System.Windows.Forms.ComboBox Source;
        private System.Windows.Forms.ComboBox TCode;
        private System.Windows.Forms.TextBox TCostTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ID_Edit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}