namespace ReservationSystem
{
    partial class ReservationScreen
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
            this.roomSelector = new System.Windows.Forms.GroupBox();
            this.btn_ADARoom = new System.Windows.Forms.RadioButton();
            this.btn_Haunted = new System.Windows.Forms.RadioButton();
            this.btn_CharlesManor = new System.Windows.Forms.RadioButton();
            this.btn_Victorian = new System.Windows.Forms.RadioButton();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.num_NumberOfAdults = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.num_NumberOfChildren = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.num_LengthOfStay = new System.Windows.Forms.NumericUpDown();
            this.dte_CheckInDate = new System.Windows.Forms.DateTimePicker();
            this.btn_Process = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Payment = new System.Windows.Forms.Button();
            this.roomSelector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_NumberOfAdults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_NumberOfChildren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_LengthOfStay)).BeginInit();
            this.SuspendLayout();
            // 
            // roomSelector
            // 
            this.roomSelector.Controls.Add(this.btn_ADARoom);
            this.roomSelector.Controls.Add(this.btn_Haunted);
            this.roomSelector.Controls.Add(this.btn_CharlesManor);
            this.roomSelector.Controls.Add(this.btn_Victorian);
            this.roomSelector.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomSelector.Location = new System.Drawing.Point(29, 376);
            this.roomSelector.Margin = new System.Windows.Forms.Padding(4);
            this.roomSelector.Name = "roomSelector";
            this.roomSelector.Padding = new System.Windows.Forms.Padding(4);
            this.roomSelector.Size = new System.Drawing.Size(320, 248);
            this.roomSelector.TabIndex = 7;
            this.roomSelector.TabStop = false;
            this.roomSelector.Text = "Room Select";
            this.roomSelector.Enter += new System.EventHandler(this.RoomSelector_Enter);
            // 
            // btn_ADARoom
            // 
            this.btn_ADARoom.AutoSize = true;
            this.btn_ADARoom.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ADARoom.Location = new System.Drawing.Point(24, 180);
            this.btn_ADARoom.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ADARoom.Name = "btn_ADARoom";
            this.btn_ADARoom.Size = new System.Drawing.Size(218, 25);
            this.btn_ADARoom.TabIndex = 3;
            this.btn_ADARoom.TabStop = true;
            this.btn_ADARoom.Text = "Accessible/ADA Room";
            this.btn_ADARoom.UseVisualStyleBackColor = true;
            this.btn_ADARoom.Enter += new System.EventHandler(this.Btn_ADARoom_Enter);
            // 
            // btn_Haunted
            // 
            this.btn_Haunted.AutoSize = true;
            this.btn_Haunted.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Haunted.Location = new System.Drawing.Point(24, 135);
            this.btn_Haunted.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Haunted.Name = "btn_Haunted";
            this.btn_Haunted.Size = new System.Drawing.Size(204, 25);
            this.btn_Haunted.TabIndex = 2;
            this.btn_Haunted.TabStop = true;
            this.btn_Haunted.Text = "Haunted Floor Studio";
            this.btn_Haunted.UseVisualStyleBackColor = true;
            this.btn_Haunted.Enter += new System.EventHandler(this.Btn_Haunted_Enter);
            // 
            // btn_CharlesManor
            // 
            this.btn_CharlesManor.AutoSize = true;
            this.btn_CharlesManor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CharlesManor.Location = new System.Drawing.Point(24, 91);
            this.btn_CharlesManor.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CharlesManor.Name = "btn_CharlesManor";
            this.btn_CharlesManor.Size = new System.Drawing.Size(205, 25);
            this.btn_CharlesManor.TabIndex = 1;
            this.btn_CharlesManor.TabStop = true;
            this.btn_CharlesManor.Text = "Charles Manor Room";
            this.btn_CharlesManor.UseVisualStyleBackColor = true;
            this.btn_CharlesManor.Enter += new System.EventHandler(this.Btn_CharlesManor_Enter);
            // 
            // btn_Victorian
            // 
            this.btn_Victorian.AutoSize = true;
            this.btn_Victorian.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Victorian.Location = new System.Drawing.Point(24, 46);
            this.btn_Victorian.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Victorian.Name = "btn_Victorian";
            this.btn_Victorian.Size = new System.Drawing.Size(150, 25);
            this.btn_Victorian.TabIndex = 0;
            this.btn_Victorian.TabStop = true;
            this.btn_Victorian.Text = "Victorian Suite";
            this.btn_Victorian.UseVisualStyleBackColor = true;
            this.btn_Victorian.Enter += new System.EventHandler(this.Btn_Victorian_Enter);
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(25, 79);
            this.txt_FirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(194, 28);
            this.txt_FirstName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Guest Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(25, 142);
            this.txt_LastName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(194, 28);
            this.txt_LastName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number in Party";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Adults";
            // 
            // num_NumberOfAdults
            // 
            this.num_NumberOfAdults.Location = new System.Drawing.Point(93, 331);
            this.num_NumberOfAdults.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_NumberOfAdults.Name = "num_NumberOfAdults";
            this.num_NumberOfAdults.Size = new System.Drawing.Size(36, 28);
            this.num_NumberOfAdults.TabIndex = 4;
            this.num_NumberOfAdults.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Children";
            // 
            // num_NumberOfChildren
            // 
            this.num_NumberOfChildren.Location = new System.Drawing.Point(231, 331);
            this.num_NumberOfChildren.Name = "num_NumberOfChildren";
            this.num_NumberOfChildren.Size = new System.Drawing.Size(36, 28);
            this.num_NumberOfChildren.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Check In Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Length of Stay";
            // 
            // num_LengthOfStay
            // 
            this.num_LengthOfStay.Location = new System.Drawing.Point(159, 255);
            this.num_LengthOfStay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_LengthOfStay.Name = "num_LengthOfStay";
            this.num_LengthOfStay.Size = new System.Drawing.Size(55, 28);
            this.num_LengthOfStay.TabIndex = 3;
            this.num_LengthOfStay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dte_CheckInDate
            // 
            this.dte_CheckInDate.Location = new System.Drawing.Point(25, 205);
            this.dte_CheckInDate.Name = "dte_CheckInDate";
            this.dte_CheckInDate.Size = new System.Drawing.Size(325, 28);
            this.dte_CheckInDate.TabIndex = 2;
            // 
            // btn_Process
            // 
            this.btn_Process.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_Process.Location = new System.Drawing.Point(29, 640);
            this.btn_Process.Name = "btn_Process";
            this.btn_Process.Size = new System.Drawing.Size(316, 63);
            this.btn_Process.TabIndex = 8;
            this.btn_Process.Text = "Confirm With Customer";
            this.btn_Process.UseVisualStyleBackColor = false;
            this.btn_Process.Visible = false;
            this.btn_Process.Click += new System.EventHandler(this.Btn_Process_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_Exit.Location = new System.Drawing.Point(231, 721);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(114, 50);
            this.btn_Exit.TabIndex = 10;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // btn_Payment
            // 
            this.btn_Payment.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_Payment.Location = new System.Drawing.Point(29, 721);
            this.btn_Payment.Name = "btn_Payment";
            this.btn_Payment.Size = new System.Drawing.Size(155, 50);
            this.btn_Payment.TabIndex = 9;
            this.btn_Payment.Text = "Save Guest";
            this.btn_Payment.UseVisualStyleBackColor = false;
            this.btn_Payment.Visible = false;
            this.btn_Payment.Click += new System.EventHandler(this.Btn_Payment_Click);
            // 
            // ReservationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(395, 812);
            this.Controls.Add(this.btn_Payment);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Process);
            this.Controls.Add(this.dte_CheckInDate);
            this.Controls.Add(this.num_LengthOfStay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.num_NumberOfChildren);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.num_NumberOfAdults);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_FirstName);
            this.Controls.Add(this.roomSelector);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReservationScreen";
            this.Text = "Guest Reservation System";
            this.roomSelector.ResumeLayout(false);
            this.roomSelector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_NumberOfAdults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_NumberOfChildren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_LengthOfStay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox roomSelector;
        private System.Windows.Forms.RadioButton btn_ADARoom;
        private System.Windows.Forms.RadioButton btn_Haunted;
        private System.Windows.Forms.RadioButton btn_CharlesManor;
        private System.Windows.Forms.RadioButton btn_Victorian;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown num_NumberOfAdults;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown num_NumberOfChildren;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown num_LengthOfStay;
        private System.Windows.Forms.DateTimePicker dte_CheckInDate;
        private System.Windows.Forms.Button btn_Process;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Payment;
    }
}