namespace ReservationSystem
{
    partial class CheckOutScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.lst_CustomerSearch = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_CheckOut = new System.Windows.Forms.Button();
            this.btn_ExitCheckOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Guests";
            // 
            // lst_CustomerSearch
            // 
            this.lst_CustomerSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_CustomerSearch.FormattingEnabled = true;
            this.lst_CustomerSearch.ItemHeight = 21;
            this.lst_CustomerSearch.Location = new System.Drawing.Point(42, 104);
            this.lst_CustomerSearch.Name = "lst_CustomerSearch";
            this.lst_CustomerSearch.Size = new System.Drawing.Size(356, 256);
            this.lst_CustomerSearch.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Room #  Name  ";
            // 
            // btn_CheckOut
            // 
            this.btn_CheckOut.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_CheckOut.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckOut.Location = new System.Drawing.Point(42, 388);
            this.btn_CheckOut.Name = "btn_CheckOut";
            this.btn_CheckOut.Size = new System.Drawing.Size(356, 69);
            this.btn_CheckOut.TabIndex = 7;
            this.btn_CheckOut.Text = "Check Out";
            this.btn_CheckOut.UseVisualStyleBackColor = false;
            this.btn_CheckOut.Click += new System.EventHandler(this.Btn_CheckOut_Click);
            // 
            // btn_ExitCheckOut
            // 
            this.btn_ExitCheckOut.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_ExitCheckOut.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExitCheckOut.Location = new System.Drawing.Point(42, 476);
            this.btn_ExitCheckOut.Name = "btn_ExitCheckOut";
            this.btn_ExitCheckOut.Size = new System.Drawing.Size(356, 69);
            this.btn_ExitCheckOut.TabIndex = 8;
            this.btn_ExitCheckOut.Text = "Exit";
            this.btn_ExitCheckOut.UseVisualStyleBackColor = false;
            this.btn_ExitCheckOut.Click += new System.EventHandler(this.Btn_ExitCheckOut_Click);
            // 
            // CheckOutScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(441, 588);
            this.Controls.Add(this.btn_ExitCheckOut);
            this.Controls.Add(this.btn_CheckOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_CustomerSearch);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "CheckOutScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_CustomerSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_CheckOut;
        private System.Windows.Forms.Button btn_ExitCheckOut;
    }
}