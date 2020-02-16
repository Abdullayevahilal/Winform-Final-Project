namespace LIBRARY_MANAGEMENT.Forms
{
    partial class ReturnOrderBookForm
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
            this.DgvReturnOrderBook = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblFindCustomer = new System.Windows.Forms.Label();
            this.TxtReturnBookCustomer = new System.Windows.Forms.TextBox();
            this.BtnCustomerSearch = new System.Windows.Forms.Button();
            this.TxtTotalPrice = new System.Windows.Forms.TextBox();
            this.LblTotalPrice = new System.Windows.Forms.Label();
            this.BtnReturnBook = new System.Windows.Forms.Button();
            this.LblReturnTime = new System.Windows.Forms.Label();
            this.DtpReturnTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReturnOrderBook)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvReturnOrderBook
            // 
            this.DgvReturnOrderBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvReturnOrderBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.DgvReturnOrderBook.Location = new System.Drawing.Point(5, 176);
            this.DgvReturnOrderBook.Name = "DgvReturnOrderBook";
            this.DgvReturnOrderBook.Size = new System.Drawing.Size(745, 262);
            this.DgvReturnOrderBook.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Costumer Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Customer Surname";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Book Name";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Book Count";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Order Time";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Deadline";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Book Price";
            this.Column8.Name = "Column8";
            // 
            // LblFindCustomer
            // 
            this.LblFindCustomer.AutoSize = true;
            this.LblFindCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFindCustomer.Location = new System.Drawing.Point(12, 31);
            this.LblFindCustomer.Name = "LblFindCustomer";
            this.LblFindCustomer.Size = new System.Drawing.Size(100, 15);
            this.LblFindCustomer.TabIndex = 1;
            this.LblFindCustomer.Text = "Find Customer";
            // 
            // TxtReturnBookCustomer
            // 
            this.TxtReturnBookCustomer.Location = new System.Drawing.Point(136, 31);
            this.TxtReturnBookCustomer.Name = "TxtReturnBookCustomer";
            this.TxtReturnBookCustomer.Size = new System.Drawing.Size(139, 20);
            this.TxtReturnBookCustomer.TabIndex = 4;
            // 
            // BtnCustomerSearch
            // 
            this.BtnCustomerSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnCustomerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomerSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCustomerSearch.Location = new System.Drawing.Point(301, 24);
            this.BtnCustomerSearch.Name = "BtnCustomerSearch";
            this.BtnCustomerSearch.Size = new System.Drawing.Size(92, 29);
            this.BtnCustomerSearch.TabIndex = 11;
            this.BtnCustomerSearch.Text = "Search";
            this.BtnCustomerSearch.UseVisualStyleBackColor = false;
            this.BtnCustomerSearch.Click += new System.EventHandler(this.BtnCustomerSearch_Click);
            // 
            // TxtTotalPrice
            // 
            this.TxtTotalPrice.Location = new System.Drawing.Point(136, 77);
            this.TxtTotalPrice.Name = "TxtTotalPrice";
            this.TxtTotalPrice.Size = new System.Drawing.Size(139, 20);
            this.TxtTotalPrice.TabIndex = 12;
            // 
            // LblTotalPrice
            // 
            this.LblTotalPrice.AutoSize = true;
            this.LblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalPrice.Location = new System.Drawing.Point(9, 82);
            this.LblTotalPrice.Name = "LblTotalPrice";
            this.LblTotalPrice.Size = new System.Drawing.Size(76, 15);
            this.LblTotalPrice.TabIndex = 13;
            this.LblTotalPrice.Text = "Total Price";
            // 
            // BtnReturnBook
            // 
            this.BtnReturnBook.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnReturnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturnBook.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnReturnBook.Location = new System.Drawing.Point(466, 82);
            this.BtnReturnBook.Name = "BtnReturnBook";
            this.BtnReturnBook.Size = new System.Drawing.Size(149, 43);
            this.BtnReturnBook.TabIndex = 14;
            this.BtnReturnBook.Text = "Return Book";
            this.BtnReturnBook.UseVisualStyleBackColor = false;
            // 
            // LblReturnTime
            // 
            this.LblReturnTime.AutoSize = true;
            this.LblReturnTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReturnTime.Location = new System.Drawing.Point(8, 124);
            this.LblReturnTime.Name = "LblReturnTime";
            this.LblReturnTime.Size = new System.Drawing.Size(86, 15);
            this.LblReturnTime.TabIndex = 15;
            this.LblReturnTime.Text = "Return Time";
            // 
            // DtpReturnTime
            // 
            this.DtpReturnTime.Location = new System.Drawing.Point(109, 119);
            this.DtpReturnTime.Name = "DtpReturnTime";
            this.DtpReturnTime.Size = new System.Drawing.Size(200, 20);
            this.DtpReturnTime.TabIndex = 17;
            // 
            // ReturnOrderBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 450);
            this.Controls.Add(this.DtpReturnTime);
            this.Controls.Add(this.LblReturnTime);
            this.Controls.Add(this.BtnReturnBook);
            this.Controls.Add(this.LblTotalPrice);
            this.Controls.Add(this.TxtTotalPrice);
            this.Controls.Add(this.BtnCustomerSearch);
            this.Controls.Add(this.TxtReturnBookCustomer);
            this.Controls.Add(this.LblFindCustomer);
            this.Controls.Add(this.DgvReturnOrderBook);
            this.Name = "ReturnOrderBookForm";
            this.Text = "ReturnBookForm";
            ((System.ComponentModel.ISupportInitialize)(this.DgvReturnOrderBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvReturnOrderBook;
        private System.Windows.Forms.Label LblFindCustomer;
        private System.Windows.Forms.TextBox TxtReturnBookCustomer;
        private System.Windows.Forms.Button BtnCustomerSearch;
        private System.Windows.Forms.TextBox TxtTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label LblTotalPrice;
        private System.Windows.Forms.Button BtnReturnBook;
        private System.Windows.Forms.Label LblReturnTime;
        private System.Windows.Forms.DateTimePicker DtpReturnTime;
    }
}