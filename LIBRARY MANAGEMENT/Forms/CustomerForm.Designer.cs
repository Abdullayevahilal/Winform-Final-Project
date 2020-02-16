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
            this.LblName = new System.Windows.Forms.Label();
            this.LblSurname = new System.Windows.Forms.Label();
            this.LblPhone = new System.Windows.Forms.Label();
            this.TxtCustomerName = new System.Windows.Forms.TextBox();
            this.TxtCustomerSurname = new System.Windows.Forms.TextBox();
            this.TxtCustomerPhone = new System.Windows.Forms.TextBox();
            this.TxtCustomerEmail = new System.Windows.Forms.TextBox();
            this.LblCustomerEmail = new System.Windows.Forms.Label();
            this.BtnCustomerSearch = new System.Windows.Forms.Button();
            this.BtnCustomerDelete = new System.Windows.Forms.Button();
            this.BtnCustomerUpdate = new System.Windows.Forms.Button();
            this.BtnCustomerAdd = new System.Windows.Forms.Button();
            this.DgvAddCustomer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtCustomerIdNumber = new System.Windows.Forms.TextBox();
            this.LblIdNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAddCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(16, 10);
            this.LblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(45, 15);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Name";
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSurname.Location = new System.Drawing.Point(119, 10);
            this.LblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(65, 15);
            this.LblSurname.TabIndex = 2;
            this.LblSurname.Text = "Surname";
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPhone.Location = new System.Drawing.Point(218, 10);
            this.LblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(48, 15);
            this.LblPhone.TabIndex = 3;
            this.LblPhone.Text = "Phone";
            // 
            // TxtCustomerName
            // 
            this.TxtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustomerName.Location = new System.Drawing.Point(16, 29);
            this.TxtCustomerName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtCustomerName.Name = "TxtCustomerName";
            this.TxtCustomerName.Size = new System.Drawing.Size(86, 21);
            this.TxtCustomerName.TabIndex = 4;
            // 
            // TxtCustomerSurname
            // 
            this.TxtCustomerSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustomerSurname.Location = new System.Drawing.Point(122, 28);
            this.TxtCustomerSurname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtCustomerSurname.Name = "TxtCustomerSurname";
            this.TxtCustomerSurname.Size = new System.Drawing.Size(84, 21);
            this.TxtCustomerSurname.TabIndex = 5;
            // 
            // TxtCustomerPhone
            // 
            this.TxtCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustomerPhone.Location = new System.Drawing.Point(221, 28);
            this.TxtCustomerPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtCustomerPhone.Name = "TxtCustomerPhone";
            this.TxtCustomerPhone.Size = new System.Drawing.Size(95, 21);
            this.TxtCustomerPhone.TabIndex = 6;
            // 
            // TxtCustomerEmail
            // 
            this.TxtCustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustomerEmail.Location = new System.Drawing.Point(337, 28);
            this.TxtCustomerEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtCustomerEmail.Name = "TxtCustomerEmail";
            this.TxtCustomerEmail.Size = new System.Drawing.Size(86, 21);
            this.TxtCustomerEmail.TabIndex = 7;
            // 
            // LblCustomerEmail
            // 
            this.LblCustomerEmail.AutoSize = true;
            this.LblCustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCustomerEmail.Location = new System.Drawing.Point(334, 10);
            this.LblCustomerEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCustomerEmail.Name = "LblCustomerEmail";
            this.LblCustomerEmail.Size = new System.Drawing.Size(44, 15);
            this.LblCustomerEmail.TabIndex = 10;
            this.LblCustomerEmail.Text = "Email";
            // 
            // BtnCustomerSearch
            // 
            this.BtnCustomerSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnCustomerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomerSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCustomerSearch.Location = new System.Drawing.Point(398, 104);
            this.BtnCustomerSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCustomerSearch.Name = "BtnCustomerSearch";
            this.BtnCustomerSearch.Size = new System.Drawing.Size(93, 39);
            this.BtnCustomerSearch.TabIndex = 33;
            this.BtnCustomerSearch.Text = "Search";
            this.BtnCustomerSearch.UseVisualStyleBackColor = false;
            this.BtnCustomerSearch.Click += new System.EventHandler(this.BtnCustomerSearch_Click);
            // 
            // BtnCustomerDelete
            // 
            this.BtnCustomerDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnCustomerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomerDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCustomerDelete.Location = new System.Drawing.Point(285, 103);
            this.BtnCustomerDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCustomerDelete.Name = "BtnCustomerDelete";
            this.BtnCustomerDelete.Size = new System.Drawing.Size(93, 40);
            this.BtnCustomerDelete.TabIndex = 32;
            this.BtnCustomerDelete.Text = "Delete";
            this.BtnCustomerDelete.UseVisualStyleBackColor = false;
            this.BtnCustomerDelete.Click += new System.EventHandler(this.BtnCustomerDelete_Click);
            // 
            // BtnCustomerUpdate
            // 
            this.BtnCustomerUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnCustomerUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomerUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCustomerUpdate.Location = new System.Drawing.Point(171, 103);
            this.BtnCustomerUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCustomerUpdate.Name = "BtnCustomerUpdate";
            this.BtnCustomerUpdate.Size = new System.Drawing.Size(95, 40);
            this.BtnCustomerUpdate.TabIndex = 31;
            this.BtnCustomerUpdate.Text = "Update";
            this.BtnCustomerUpdate.UseVisualStyleBackColor = false;
            this.BtnCustomerUpdate.Click += new System.EventHandler(this.BtnCustomerUpdate_Click);
            // 
            // BtnCustomerAdd
            // 
            this.BtnCustomerAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnCustomerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomerAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCustomerAdd.Location = new System.Drawing.Point(40, 100);
            this.BtnCustomerAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCustomerAdd.Name = "BtnCustomerAdd";
            this.BtnCustomerAdd.Size = new System.Drawing.Size(96, 43);
            this.BtnCustomerAdd.TabIndex = 30;
            this.BtnCustomerAdd.Text = "Add";
            this.BtnCustomerAdd.UseVisualStyleBackColor = false;
            this.BtnCustomerAdd.Click += new System.EventHandler(this.BtnCustomerAdd_Click);
            // 
            // DgvAddCustomer
            // 
            this.DgvAddCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAddCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DgvAddCustomer.Location = new System.Drawing.Point(2, 193);
            this.DgvAddCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DgvAddCustomer.Name = "DgvAddCustomer";
            this.DgvAddCustomer.Size = new System.Drawing.Size(544, 264);
            this.DgvAddCustomer.TabIndex = 34;
            this.DgvAddCustomer.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvAddCustomer_CellMouseClick);
            this.DgvAddCustomer.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvAddCustomer_RowHeaderMouseClick);
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
            // Column4
            // 
            this.Column4.HeaderText = "Phone";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Email";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ID Number";
            this.Column6.Name = "Column6";
            // 
            // TxtCustomerIdNumber
            // 
            this.TxtCustomerIdNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustomerIdNumber.Location = new System.Drawing.Point(440, 28);
            this.TxtCustomerIdNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtCustomerIdNumber.Name = "TxtCustomerIdNumber";
            this.TxtCustomerIdNumber.Size = new System.Drawing.Size(85, 21);
            this.TxtCustomerIdNumber.TabIndex = 35;
            // 
            // LblIdNumber
            // 
            this.LblIdNumber.AutoSize = true;
            this.LblIdNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdNumber.Location = new System.Drawing.Point(444, 10);
            this.LblIdNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblIdNumber.Name = "LblIdNumber";
            this.LblIdNumber.Size = new System.Drawing.Size(76, 15);
            this.LblIdNumber.TabIndex = 36;
            this.LblIdNumber.Text = "ID Number";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(559, 453);
            this.Controls.Add(this.TxtCustomerIdNumber);
            this.Controls.Add(this.LblIdNumber);
            this.Controls.Add(this.DgvAddCustomer);
            this.Controls.Add(this.BtnCustomerSearch);
            this.Controls.Add(this.BtnCustomerDelete);
            this.Controls.Add(this.BtnCustomerUpdate);
            this.Controls.Add(this.BtnCustomerAdd);
            this.Controls.Add(this.TxtCustomerEmail);
            this.Controls.Add(this.LblCustomerEmail);
            this.Controls.Add(this.TxtCustomerName);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TxtCustomerPhone);
            this.Controls.Add(this.TxtCustomerSurname);
            this.Controls.Add(this.LblPhone);
            this.Controls.Add(this.LblSurname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CustomerForm";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAddCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblSurname;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.TextBox TxtCustomerName;
        private System.Windows.Forms.TextBox TxtCustomerSurname;
        private System.Windows.Forms.TextBox TxtCustomerPhone;
        private System.Windows.Forms.TextBox TxtCustomerEmail;
        private System.Windows.Forms.Label LblCustomerEmail;
        private System.Windows.Forms.Button BtnCustomerSearch;
        private System.Windows.Forms.Button BtnCustomerDelete;
        private System.Windows.Forms.Button BtnCustomerUpdate;
        private System.Windows.Forms.Button BtnCustomerAdd;
        private System.Windows.Forms.DataGridView DgvAddCustomer;
        private System.Windows.Forms.TextBox TxtCustomerIdNumber;
        private System.Windows.Forms.Label LblIdNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}