namespace ReservationSystem
{
    partial class CheckInScreen
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
            this.lst_CustomerSearch = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CheckIn = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_ExitCheckIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_CustomerSearch
            // 
            this.lst_CustomerSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_CustomerSearch.FormattingEnabled = true;
            this.lst_CustomerSearch.ItemHeight = 21;
            this.lst_CustomerSearch.Location = new System.Drawing.Point(36, 111);
            this.lst_CustomerSearch.Name = "lst_CustomerSearch";
            this.lst_CustomerSearch.Size = new System.Drawing.Size(356, 256);
            this.lst_CustomerSearch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Active Reservations";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_CheckIn
            // 
            this.btn_CheckIn.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_CheckIn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckIn.Location = new System.Drawing.Point(36, 411);
            this.btn_CheckIn.Name = "btn_CheckIn";
            this.btn_CheckIn.Size = new System.Drawing.Size(168, 73);
            this.btn_CheckIn.TabIndex = 2;
            this.btn_CheckIn.Text = "Check In";
            this.btn_CheckIn.UseVisualStyleBackColor = false;
            this.btn_CheckIn.Click += new System.EventHandler(this.Btn_CheckIn_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_Cancel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(226, 411);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(168, 73);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel Reservation";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // btn_ExitCheckIn
            // 
            this.btn_ExitCheckIn.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_ExitCheckIn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExitCheckIn.Location = new System.Drawing.Point(36, 503);
            this.btn_ExitCheckIn.Name = "btn_ExitCheckIn";
            this.btn_ExitCheckIn.Size = new System.Drawing.Size(356, 73);
            this.btn_ExitCheckIn.TabIndex = 4;
            this.btn_ExitCheckIn.Text = "Exit";
            this.btn_ExitCheckIn.UseVisualStyleBackColor = false;
            this.btn_ExitCheckIn.Click += new System.EventHandler(this.Btn_ExitCheckIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Room #  Name  ";
            // 
            // CheckInScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(441, 588);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ExitCheckIn);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_CheckIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_CustomerSearch);
            this.Name = "CheckInScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_CustomerSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CheckIn;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_ExitCheckIn;
        private System.Windows.Forms.Label label2;
    }
}