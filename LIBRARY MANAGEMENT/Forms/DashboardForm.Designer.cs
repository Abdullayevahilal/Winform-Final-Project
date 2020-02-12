namespace LIBRARY_MANAGEMENT.Forms
{
    partial class DashboardForm
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
            this.GrbReport = new System.Windows.Forms.GroupBox();
            this.GrbManager = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnReturnBook = new System.Windows.Forms.Button();
            this.BtnFollow = new System.Windows.Forms.Button();
            this.BtnCreateOrder = new System.Windows.Forms.Button();
            this.BtnBook = new System.Windows.Forms.Button();
            this.BtnUser = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbReport
            // 
            this.GrbReport.Location = new System.Drawing.Point(370, 177);
            this.GrbReport.Name = "GrbReport";
            this.GrbReport.Size = new System.Drawing.Size(329, 100);
            this.GrbReport.TabIndex = 6;
            this.GrbReport.TabStop = false;
            this.GrbReport.Text = "Hesabatlar";
            // 
            // GrbManager
            // 
            this.GrbManager.Location = new System.Drawing.Point(402, 339);
            this.GrbManager.Name = "GrbManager";
            this.GrbManager.Size = new System.Drawing.Size(284, 100);
            this.GrbManager.TabIndex = 7;
            this.GrbManager.TabStop = false;
            this.GrbManager.Text = "İdarəçilər";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnReturnBook);
            this.groupBox1.Controls.Add(this.BtnFollow);
            this.groupBox1.Controls.Add(this.BtnCreateOrder);
            this.groupBox1.Location = new System.Drawing.Point(35, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 143);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // BtnReturnBook
            // 
            this.BtnReturnBook.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnReturnBook.Location = new System.Drawing.Point(44, 57);
            this.BtnReturnBook.Name = "BtnReturnBook";
            this.BtnReturnBook.Size = new System.Drawing.Size(154, 23);
            this.BtnReturnBook.TabIndex = 2;
            this.BtnReturnBook.Text = "Kitab Qaytarma";
            this.BtnReturnBook.UseVisualStyleBackColor = false;
            // 
            // BtnFollow
            // 
            this.BtnFollow.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnFollow.Location = new System.Drawing.Point(46, 98);
            this.BtnFollow.Name = "BtnFollow";
            this.BtnFollow.Size = new System.Drawing.Size(154, 23);
            this.BtnFollow.TabIndex = 1;
            this.BtnFollow.Text = "Kitab Qaytaranları İzləmə";
            this.BtnFollow.UseVisualStyleBackColor = false;
            // 
            // BtnCreateOrder
            // 
            this.BtnCreateOrder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnCreateOrder.Location = new System.Drawing.Point(46, 19);
            this.BtnCreateOrder.Name = "BtnCreateOrder";
            this.BtnCreateOrder.Size = new System.Drawing.Size(154, 23);
            this.BtnCreateOrder.TabIndex = 0;
            this.BtnCreateOrder.Text = "Sifarış Yaratma";
            this.BtnCreateOrder.UseVisualStyleBackColor = false;
            // 
            // BtnBook
            // 
            this.BtnBook.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBook.Location = new System.Drawing.Point(12, 12);
            this.BtnBook.Name = "BtnBook";
            this.BtnBook.Size = new System.Drawing.Size(99, 33);
            this.BtnBook.TabIndex = 9;
            this.BtnBook.Text = "Book";
            this.BtnBook.UseVisualStyleBackColor = false;
            this.BtnBook.Click += new System.EventHandler(this.BtnBook_Click);
            // 
            // BtnUser
            // 
            this.BtnUser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUser.Location = new System.Drawing.Point(134, 12);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.Size = new System.Drawing.Size(99, 33);
            this.BtnUser.TabIndex = 10;
            this.BtnUser.Text = "User";
            this.BtnUser.UseVisualStyleBackColor = false;
            this.BtnUser.Click += new System.EventHandler(this.BtnUser_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(856, 514);
            this.Controls.Add(this.BtnUser);
            this.Controls.Add(this.BtnBook);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GrbManager);
            this.Controls.Add(this.GrbReport);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GrbReport;
        private System.Windows.Forms.GroupBox GrbManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnReturnBook;
        private System.Windows.Forms.Button BtnFollow;
        private System.Windows.Forms.Button BtnCreateOrder;
        private System.Windows.Forms.Button BtnBook;
        private System.Windows.Forms.Button BtnUser;
    }
}