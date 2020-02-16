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
            this.BtnBook = new System.Windows.Forms.Button();
            this.BtnUser = new System.Windows.Forms.Button();
            this.BtnCustomer = new System.Windows.Forms.Button();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.BtnUser.Location = new System.Drawing.Point(119, 12);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.Size = new System.Drawing.Size(99, 33);
            this.BtnUser.TabIndex = 10;
            this.BtnUser.Text = "User";
            this.BtnUser.UseVisualStyleBackColor = false;
            this.BtnUser.Click += new System.EventHandler(this.BtnUser_Click);
            // 
            // BtnCustomer
            // 
            this.BtnCustomer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomer.Location = new System.Drawing.Point(225, 12);
            this.BtnCustomer.Name = "BtnCustomer";
            this.BtnCustomer.Size = new System.Drawing.Size(99, 33);
            this.BtnCustomer.TabIndex = 11;
            this.BtnCustomer.Text = "Customer";
            this.BtnCustomer.UseVisualStyleBackColor = false;
            this.BtnCustomer.Click += new System.EventHandler(this.BtnCustomer_Click);
            // 
            // BtnOrder
            // 
            this.BtnOrder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrder.Location = new System.Drawing.Point(344, 12);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(99, 33);
            this.BtnOrder.TabIndex = 12;
            this.BtnOrder.Text = "Order";
            this.BtnOrder.UseVisualStyleBackColor = false;
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(856, 514);
            this.Controls.Add(this.BtnOrder);
            this.Controls.Add(this.BtnCustomer);
            this.Controls.Add(this.BtnUser);
            this.Controls.Add(this.BtnBook);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnBook;
        private System.Windows.Forms.Button BtnUser;
        private System.Windows.Forms.Button BtnCustomer;
        private System.Windows.Forms.Button BtnOrder;
    }
}