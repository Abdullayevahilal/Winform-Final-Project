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
            this.BtnReport = new System.Windows.Forms.Button();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.BtnCustomer = new System.Windows.Forms.Button();
            this.BtnUser = new System.Windows.Forms.Button();
            this.BtnBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnReport
            // 
            this.BtnReport.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReport.Location = new System.Drawing.Point(235, 121);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(146, 23);
            this.BtnReport.TabIndex = 21;
            this.BtnReport.Text = "Report";
            this.BtnReport.UseVisualStyleBackColor = false;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click_1);
            // 
            // BtnReturn
            // 
            this.BtnReturn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturn.Location = new System.Drawing.Point(235, 80);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(146, 22);
            this.BtnReturn.TabIndex = 20;
            this.BtnReturn.Text = "Return";
            this.BtnReturn.UseVisualStyleBackColor = false;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // BtnOrder
            // 
            this.BtnOrder.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrder.Location = new System.Drawing.Point(235, 41);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(146, 24);
            this.BtnOrder.TabIndex = 19;
            this.BtnOrder.Text = "Order";
            this.BtnOrder.UseVisualStyleBackColor = false;
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click_1);
            // 
            // BtnCustomer
            // 
            this.BtnCustomer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomer.Location = new System.Drawing.Point(67, 42);
            this.BtnCustomer.Name = "BtnCustomer";
            this.BtnCustomer.Size = new System.Drawing.Size(124, 22);
            this.BtnCustomer.TabIndex = 18;
            this.BtnCustomer.Text = "Customer";
            this.BtnCustomer.UseVisualStyleBackColor = false;
            this.BtnCustomer.Click += new System.EventHandler(this.BtnCustomer_Click_1);
            // 
            // BtnUser
            // 
            this.BtnUser.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUser.Location = new System.Drawing.Point(67, 119);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.Size = new System.Drawing.Size(124, 23);
            this.BtnUser.TabIndex = 17;
            this.BtnUser.Text = "User";
            this.BtnUser.UseVisualStyleBackColor = false;
            this.BtnUser.Click += new System.EventHandler(this.BtnUser_Click_1);
            // 
            // BtnBook
            // 
            this.BtnBook.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBook.Location = new System.Drawing.Point(67, 79);
            this.BtnBook.Name = "BtnBook";
            this.BtnBook.Size = new System.Drawing.Size(124, 22);
            this.BtnBook.TabIndex = 16;
            this.BtnBook.Text = "Book";
            this.BtnBook.UseVisualStyleBackColor = false;
            this.BtnBook.Click += new System.EventHandler(this.BtnBook_Click_1);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(465, 192);
            this.Controls.Add(this.BtnReport);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnOrder);
            this.Controls.Add(this.BtnCustomer);
            this.Controls.Add(this.BtnUser);
            this.Controls.Add(this.BtnBook);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashboardForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnReport;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.Button BtnOrder;
        private System.Windows.Forms.Button BtnCustomer;
        private System.Windows.Forms.Button BtnUser;
        private System.Windows.Forms.Button BtnBook;
    }
}