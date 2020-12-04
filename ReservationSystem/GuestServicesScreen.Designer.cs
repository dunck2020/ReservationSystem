namespace ReservationSystem
{
    partial class GuestServiceMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestServiceMenu));
            this.btn_ReservationAccess = new System.Windows.Forms.Button();
            this.btn_CheckIn = new System.Windows.Forms.Button();
            this.btn_Amenities = new System.Windows.Forms.Button();
            this.btn_CheckOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lnk_WeatherCheck = new System.Windows.Forms.LinkLabel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_About = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ReservationAccess
            // 
            this.btn_ReservationAccess.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_ReservationAccess.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReservationAccess.Location = new System.Drawing.Point(67, 137);
            this.btn_ReservationAccess.Name = "btn_ReservationAccess";
            this.btn_ReservationAccess.Size = new System.Drawing.Size(257, 155);
            this.btn_ReservationAccess.TabIndex = 0;
            this.btn_ReservationAccess.Text = "New Guests";
            this.btn_ReservationAccess.UseVisualStyleBackColor = false;
            this.btn_ReservationAccess.Click += new System.EventHandler(this.Btn_ReservationAccess_Click);
            // 
            // btn_CheckIn
            // 
            this.btn_CheckIn.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_CheckIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckIn.Location = new System.Drawing.Point(67, 332);
            this.btn_CheckIn.Name = "btn_CheckIn";
            this.btn_CheckIn.Size = new System.Drawing.Size(257, 155);
            this.btn_CheckIn.TabIndex = 1;
            this.btn_CheckIn.Text = "Check In / Search Reservations";
            this.btn_CheckIn.UseVisualStyleBackColor = false;
            this.btn_CheckIn.Click += new System.EventHandler(this.Btn_CheckIn_Click);
            // 
            // btn_Amenities
            // 
            this.btn_Amenities.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_Amenities.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Amenities.Location = new System.Drawing.Point(386, 137);
            this.btn_Amenities.Name = "btn_Amenities";
            this.btn_Amenities.Size = new System.Drawing.Size(257, 155);
            this.btn_Amenities.TabIndex = 2;
            this.btn_Amenities.Text = "Amenities";
            this.btn_Amenities.UseVisualStyleBackColor = false;
            this.btn_Amenities.Click += new System.EventHandler(this.Btn_Amenities_Click);
            // 
            // btn_CheckOut
            // 
            this.btn_CheckOut.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_CheckOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckOut.Location = new System.Drawing.Point(386, 332);
            this.btn_CheckOut.Name = "btn_CheckOut";
            this.btn_CheckOut.Size = new System.Drawing.Size(257, 155);
            this.btn_CheckOut.TabIndex = 3;
            this.btn_CheckOut.Text = "Check Out / View Current Guests";
            this.btn_CheckOut.UseVisualStyleBackColor = false;
            this.btn_CheckOut.Click += new System.EventHandler(this.Btn_CheckOut_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Charleston Manor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lnk_WeatherCheck
            // 
            this.lnk_WeatherCheck.AutoSize = true;
            this.lnk_WeatherCheck.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_WeatherCheck.Location = new System.Drawing.Point(74, 522);
            this.lnk_WeatherCheck.Name = "lnk_WeatherCheck";
            this.lnk_WeatherCheck.Size = new System.Drawing.Size(209, 21);
            this.lnk_WeatherCheck.TabIndex = 5;
            this.lnk_WeatherCheck.TabStop = true;
            this.lnk_WeatherCheck.Text = "Check Today\'s Weather";
            this.lnk_WeatherCheck.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lnk_WeatherCheck_LinkClicked);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_Exit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(470, 514);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(173, 37);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Light", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(520, 41);
            this.label2.TabIndex = 7;
            this.label2.Text = "Guest Services";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btn_About
            // 
            this.btn_About.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_About.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_About.Location = new System.Drawing.Point(386, 514);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(78, 37);
            this.btn_About.TabIndex = 9;
            this.btn_About.Text = "About";
            this.btn_About.UseVisualStyleBackColor = false;
            this.btn_About.Click += new System.EventHandler(this.Btn_About_Click);
            // 
            // GuestServiceMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(702, 573);
            this.Controls.Add(this.btn_About);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lnk_WeatherCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CheckOut);
            this.Controls.Add(this.btn_Amenities);
            this.Controls.Add(this.btn_CheckIn);
            this.Controls.Add(this.btn_ReservationAccess);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(720, 620);
            this.Name = "GuestServiceMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ReservationAccess;
        private System.Windows.Forms.Button btn_CheckIn;
        private System.Windows.Forms.Button btn_Amenities;
        private System.Windows.Forms.Button btn_CheckOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnk_WeatherCheck;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_About;
    }
}

