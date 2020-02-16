namespace LIBRARY_MANAGEMENT.Forms
{
    partial class OrderForm
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
            this.LblFindCustomer = new System.Windows.Forms.Label();
            this.DgvFindCustomer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtFindCustomer = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblOrderBookCount = new System.Windows.Forms.Label();
            this.TxtOrderBookCount = new System.Windows.Forms.TextBox();
            this.LblReturnTime = new System.Windows.Forms.Label();
            this.DtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.BtnDeleteOrder = new System.Windows.Forms.Button();
            this.BtnBookSearc = new System.Windows.Forms.Button();
            this.BtnCustomerSearch = new System.Windows.Forms.Button();
            this.TxtFindBook = new System.Windows.Forms.TextBox();
            this.LblFindBook = new System.Windows.Forms.Label();
            this.BtnOrderAdd = new System.Windows.Forms.Button();
            this.DgvOrder = new System.Windows.Forms.DataGridView();
            this.DgvFindBook = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFindCustomer)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFindBook)).BeginInit();
            this.SuspendLayout();
            // 
            // LblFindCustomer
            // 
            this.LblFindCustomer.AutoSize = true;
            this.LblFindCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFindCustomer.Location = new System.Drawing.Point(15, 20);
            this.LblFindCustomer.Name = "LblFindCustomer";
            this.LblFindCustomer.Size = new System.Drawing.Size(100, 15);
            this.LblFindCustomer.TabIndex = 0;
            this.LblFindCustomer.Text = "Find Customer";
            // 
            // DgvFindCustomer
            // 
            this.DgvFindCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvFindCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFindCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6});
            this.DgvFindCustomer.Location = new System.Drawing.Point(18, 49);
            this.DgvFindCustomer.Name = "DgvFindCustomer";
            this.DgvFindCustomer.Size = new System.Drawing.Size(341, 183);
            this.DgvFindCustomer.TabIndex = 2;
            this.DgvFindCustomer.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvFindCustomer_RowHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Surname";
            this.Column3.Name = "Column3";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Identify Number";
            this.Column6.Name = "Column6";
            // 
            // TxtFindCustomer
            // 
            this.TxtFindCustomer.Location = new System.Drawing.Point(121, 19);
            this.TxtFindCustomer.Name = "TxtFindCustomer";
            this.TxtFindCustomer.Size = new System.Drawing.Size(139, 20);
            this.TxtFindCustomer.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblOrderBookCount);
            this.groupBox1.Controls.Add(this.TxtOrderBookCount);
            this.groupBox1.Controls.Add(this.LblReturnTime);
            this.groupBox1.Controls.Add(this.DtpDeadline);
            this.groupBox1.Controls.Add(this.BtnDeleteOrder);
            this.groupBox1.Controls.Add(this.BtnBookSearc);
            this.groupBox1.Controls.Add(this.BtnCustomerSearch);
            this.groupBox1.Controls.Add(this.TxtFindBook);
            this.groupBox1.Controls.Add(this.LblFindBook);
            this.groupBox1.Controls.Add(this.BtnOrderAdd);
            this.groupBox1.Controls.Add(this.DgvOrder);
            this.groupBox1.Controls.Add(this.DgvFindBook);
            this.groupBox1.Controls.Add(this.DgvFindCustomer);
            this.groupBox1.Controls.Add(this.TxtFindCustomer);
            this.groupBox1.Controls.Add(this.LblFindCustomer);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1033, 507);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Book";
            // 
            // LblOrderBookCount
            // 
            this.LblOrderBookCount.AutoSize = true;
            this.LblOrderBookCount.Location = new System.Drawing.Point(46, 270);
            this.LblOrderBookCount.Name = "LblOrderBookCount";
            this.LblOrderBookCount.Size = new System.Drawing.Size(63, 13);
            this.LblOrderBookCount.TabIndex = 17;
            this.LblOrderBookCount.Text = "Book Count";
            // 
            // TxtOrderBookCount
            // 
            this.TxtOrderBookCount.Location = new System.Drawing.Point(121, 267);
            this.TxtOrderBookCount.Name = "TxtOrderBookCount";
            this.TxtOrderBookCount.Size = new System.Drawing.Size(100, 20);
            this.TxtOrderBookCount.TabIndex = 16;
            // 
            // LblReturnTime
            // 
            this.LblReturnTime.AutoSize = true;
            this.LblReturnTime.Location = new System.Drawing.Point(334, 270);
            this.LblReturnTime.Name = "LblReturnTime";
            this.LblReturnTime.Size = new System.Drawing.Size(49, 13);
            this.LblReturnTime.TabIndex = 15;
            this.LblReturnTime.Text = "Deadline";
            // 
            // DtpDeadline
            // 
            this.DtpDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDeadline.Location = new System.Drawing.Point(399, 267);
            this.DtpDeadline.Name = "DtpDeadline";
            this.DtpDeadline.Size = new System.Drawing.Size(228, 20);
            this.DtpDeadline.TabIndex = 13;
            // 
            // BtnDeleteOrder
            // 
            this.BtnDeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteOrder.Location = new System.Drawing.Point(785, 257);
            this.BtnDeleteOrder.Name = "BtnDeleteOrder";
            this.BtnDeleteOrder.Size = new System.Drawing.Size(95, 30);
            this.BtnDeleteOrder.TabIndex = 12;
            this.BtnDeleteOrder.Text = "Delete Order";
            this.BtnDeleteOrder.UseVisualStyleBackColor = true;
            this.BtnDeleteOrder.Click += new System.EventHandler(this.BtnDeleteOrder_Click);
            // 
            // BtnBookSearc
            // 
            this.BtnBookSearc.Location = new System.Drawing.Point(770, 20);
            this.BtnBookSearc.Name = "BtnBookSearc";
            this.BtnBookSearc.Size = new System.Drawing.Size(110, 23);
            this.BtnBookSearc.TabIndex = 11;
            this.BtnBookSearc.Text = "Search";
            this.BtnBookSearc.UseVisualStyleBackColor = true;
            this.BtnBookSearc.Click += new System.EventHandler(this.BtnBookSearc_Click);
            // 
            // BtnCustomerSearch
            // 
            this.BtnCustomerSearch.Location = new System.Drawing.Point(275, 18);
            this.BtnCustomerSearch.Name = "BtnCustomerSearch";
            this.BtnCustomerSearch.Size = new System.Drawing.Size(84, 23);
            this.BtnCustomerSearch.TabIndex = 10;
            this.BtnCustomerSearch.Text = "Search";
            this.BtnCustomerSearch.UseVisualStyleBackColor = true;
            this.BtnCustomerSearch.Click += new System.EventHandler(this.BtnCustomerSearch_Click);
            // 
            // TxtFindBook
            // 
            this.TxtFindBook.Location = new System.Drawing.Point(572, 20);
            this.TxtFindBook.Name = "TxtFindBook";
            this.TxtFindBook.Size = new System.Drawing.Size(171, 20);
            this.TxtFindBook.TabIndex = 9;
            // 
            // LblFindBook
            // 
            this.LblFindBook.AutoSize = true;
            this.LblFindBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFindBook.Location = new System.Drawing.Point(486, 25);
            this.LblFindBook.Name = "LblFindBook";
            this.LblFindBook.Size = new System.Drawing.Size(71, 15);
            this.LblFindBook.TabIndex = 8;
            this.LblFindBook.Text = "Find Book";
            // 
            // BtnOrderAdd
            // 
            this.BtnOrderAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrderAdd.Location = new System.Drawing.Point(681, 260);
            this.BtnOrderAdd.Name = "BtnOrderAdd";
            this.BtnOrderAdd.Size = new System.Drawing.Size(90, 30);
            this.BtnOrderAdd.TabIndex = 7;
            this.BtnOrderAdd.Text = "Create Order";
            this.BtnOrderAdd.UseVisualStyleBackColor = true;
            this.BtnOrderAdd.Click += new System.EventHandler(this.BtnOrderAdd_Click);
            // 
            // DgvOrder
            // 
            this.DgvOrder.AllowUserToAddRows = false;
            this.DgvOrder.AllowUserToDeleteRows = false;
            this.DgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.DgvOrder.Location = new System.Drawing.Point(6, 318);
            this.DgvOrder.Name = "DgvOrder";
            this.DgvOrder.ReadOnly = true;
            this.DgvOrder.Size = new System.Drawing.Size(917, 183);
            this.DgvOrder.TabIndex = 6;
            this.DgvOrder.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvOrder_RowHeaderMouseClick);
            // 
            // DgvFindBook
            // 
            this.DgvFindBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvFindBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFindBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column8,
            this.Column9});
            this.DgvFindBook.Location = new System.Drawing.Point(489, 49);
            this.DgvFindBook.Name = "DgvFindBook";
            this.DgvFindBook.Size = new System.Drawing.Size(400, 183);
            this.DgvFindBook.TabIndex = 5;
            this.DgvFindBook.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvFindBook_RowHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Book Name";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Author";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Genre";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Rental Price";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Count";
            this.Column9.Name = "Column9";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Customer Name";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Customer Surname";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Book Name";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Deadline";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Book Count";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Total Price";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 507);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.DgvFindCustomer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFindBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblFindCustomer;
        private System.Windows.Forms.DataGridView DgvFindCustomer;
        private System.Windows.Forms.TextBox TxtFindCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnOrderAdd;
        private System.Windows.Forms.DataGridView DgvOrder;
        private System.Windows.Forms.DataGridView DgvFindBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox TxtFindBook;
        private System.Windows.Forms.Label LblFindBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button BtnBookSearc;
        private System.Windows.Forms.Button BtnCustomerSearch;
        private System.Windows.Forms.Button BtnDeleteOrder;
        private System.Windows.Forms.Label LblOrderBookCount;
        private System.Windows.Forms.TextBox TxtOrderBookCount;
        private System.Windows.Forms.Label LblReturnTime;
        private System.Windows.Forms.DateTimePicker DtpDeadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
    }
}