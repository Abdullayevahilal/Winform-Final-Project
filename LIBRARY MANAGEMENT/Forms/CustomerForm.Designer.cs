namespace LIBRARY_MANAGEMENT.Forms
{
    partial class CustomerForm
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
            this.GrbCustomer = new System.Windows.Forms.GroupBox();
            this.BtnCancelCustomer = new System.Windows.Forms.Button();
            this.LblReservationDate = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblPhone = new System.Windows.Forms.Label();
            this.LblSurname = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.BtnAddCustomer = new System.Windows.Forms.Button();
            this.GrbCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbCustomer
            // 
            this.GrbCustomer.Controls.Add(this.BtnCancelCustomer);
            this.GrbCustomer.Controls.Add(this.LblReservationDate);
            this.GrbCustomer.Controls.Add(this.textBox4);
            this.GrbCustomer.Controls.Add(this.textBox3);
            this.GrbCustomer.Controls.Add(this.textBox2);
            this.GrbCustomer.Controls.Add(this.textBox1);
            this.GrbCustomer.Controls.Add(this.LblPhone);
            this.GrbCustomer.Controls.Add(this.LblSurname);
            this.GrbCustomer.Controls.Add(this.LblName);
            this.GrbCustomer.Controls.Add(this.BtnAddCustomer);
            this.GrbCustomer.Location = new System.Drawing.Point(12, 22);
            this.GrbCustomer.Name = "GrbCustomer";
            this.GrbCustomer.Size = new System.Drawing.Size(273, 250);
            this.GrbCustomer.TabIndex = 1;
            this.GrbCustomer.TabStop = false;
            this.GrbCustomer.Text = "Müştərilər";
            // 
            // BtnCancelCustomer
            // 
            this.BtnCancelCustomer.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnCancelCustomer.Location = new System.Drawing.Point(140, 166);
            this.BtnCancelCustomer.Name = "BtnCancelCustomer";
            this.BtnCancelCustomer.Size = new System.Drawing.Size(100, 23);
            this.BtnCancelCustomer.TabIndex = 11;
            this.BtnCancelCustomer.Text = "İmtina Et";
            this.BtnCancelCustomer.UseVisualStyleBackColor = false;
            // 
            // LblReservationDate
            // 
            this.LblReservationDate.AutoSize = true;
            this.LblReservationDate.Location = new System.Drawing.Point(6, 118);
            this.LblReservationDate.Name = "LblReservationDate";
            this.LblReservationDate.Size = new System.Drawing.Size(77, 13);
            this.LblReservationDate.TabIndex = 10;
            this.LblReservationDate.Text = "Qeydiyyat tarixi";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(104, 118);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(104, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.Location = new System.Drawing.Point(21, 84);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(43, 13);
            this.LblPhone.TabIndex = 3;
            this.LblPhone.Text = "Telefon";
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.Location = new System.Drawing.Point(21, 59);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(39, 13);
            this.LblSurname.TabIndex = 2;
            this.LblSurname.Text = "Soyadı";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(21, 28);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(22, 13);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Adı";
            // 
            // BtnAddCustomer
            // 
            this.BtnAddCustomer.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnAddCustomer.Location = new System.Drawing.Point(24, 166);
            this.BtnAddCustomer.Name = "BtnAddCustomer";
            this.BtnAddCustomer.Size = new System.Drawing.Size(100, 23);
            this.BtnAddCustomer.TabIndex = 0;
            this.BtnAddCustomer.Text = "Əlavə Et";
            this.BtnAddCustomer.UseVisualStyleBackColor = false;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(371, 315);
            this.Controls.Add(this.GrbCustomer);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.GrbCustomer.ResumeLayout(false);
            this.GrbCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbCustomer;
        private System.Windows.Forms.Label LblReservationDate;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.Label LblSurname;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Button BtnAddCustomer;
        private System.Windows.Forms.Button BtnCancelCustomer;
    }
}