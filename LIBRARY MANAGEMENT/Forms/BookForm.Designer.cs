namespace LIBRARY_MANAGEMENT.Forms
{
    partial class BookForm
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
            this.TxtBookName = new System.Windows.Forms.TextBox();
            this.TxtRentalPrice = new System.Windows.Forms.TextBox();
            this.TxtAuthor = new System.Windows.Forms.TextBox();
            this.TxtCount = new System.Windows.Forms.TextBox();
            this.LblBookName = new System.Windows.Forms.Label();
            this.LblAuthor = new System.Windows.Forms.Label();
            this.LblRentalPrice = new System.Windows.Forms.Label();
            this.LblBookCount = new System.Windows.Forms.Label();
            this.LblBookGenre = new System.Windows.Forms.Label();
            this.BtnBookAdd = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.DgvAddBooks = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmbGenre = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAddBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBookName
            // 
            this.TxtBookName.Location = new System.Drawing.Point(14, 27);
            this.TxtBookName.Name = "TxtBookName";
            this.TxtBookName.Size = new System.Drawing.Size(91, 21);
            this.TxtBookName.TabIndex = 0;
            // 
            // TxtRentalPrice
            // 
            this.TxtRentalPrice.Location = new System.Drawing.Point(335, 27);
            this.TxtRentalPrice.Name = "TxtRentalPrice";
            this.TxtRentalPrice.Size = new System.Drawing.Size(97, 21);
            this.TxtRentalPrice.TabIndex = 1;
            // 
            // TxtAuthor
            // 
            this.TxtAuthor.Location = new System.Drawing.Point(128, 27);
            this.TxtAuthor.Name = "TxtAuthor";
            this.TxtAuthor.Size = new System.Drawing.Size(97, 21);
            this.TxtAuthor.TabIndex = 2;
            // 
            // TxtCount
            // 
            this.TxtCount.Location = new System.Drawing.Point(452, 27);
            this.TxtCount.Name = "TxtCount";
            this.TxtCount.Size = new System.Drawing.Size(90, 21);
            this.TxtCount.TabIndex = 5;
            // 
            // LblBookName
            // 
            this.LblBookName.AutoSize = true;
            this.LblBookName.Location = new System.Drawing.Point(17, 9);
            this.LblBookName.Name = "LblBookName";
            this.LblBookName.Size = new System.Drawing.Size(81, 15);
            this.LblBookName.TabIndex = 6;
            this.LblBookName.Text = "Book Name";
            // 
            // LblAuthor
            // 
            this.LblAuthor.AutoSize = true;
            this.LblAuthor.Location = new System.Drawing.Point(125, 9);
            this.LblAuthor.Name = "LblAuthor";
            this.LblAuthor.Size = new System.Drawing.Size(48, 15);
            this.LblAuthor.TabIndex = 7;
            this.LblAuthor.Text = "Author";
            // 
            // LblRentalPrice
            // 
            this.LblRentalPrice.AutoSize = true;
            this.LblRentalPrice.Location = new System.Drawing.Point(333, 9);
            this.LblRentalPrice.Name = "LblRentalPrice";
            this.LblRentalPrice.Size = new System.Drawing.Size(86, 15);
            this.LblRentalPrice.TabIndex = 8;
            this.LblRentalPrice.Text = "Rental Price";
            // 
            // LblBookCount
            // 
            this.LblBookCount.AutoSize = true;
            this.LblBookCount.Location = new System.Drawing.Point(451, 9);
            this.LblBookCount.Name = "LblBookCount";
            this.LblBookCount.Size = new System.Drawing.Size(44, 15);
            this.LblBookCount.TabIndex = 9;
            this.LblBookCount.Text = "Count";
            // 
            // LblBookGenre
            // 
            this.LblBookGenre.AutoSize = true;
            this.LblBookGenre.Location = new System.Drawing.Point(233, 9);
            this.LblBookGenre.Name = "LblBookGenre";
            this.LblBookGenre.Size = new System.Drawing.Size(46, 15);
            this.LblBookGenre.TabIndex = 10;
            this.LblBookGenre.Text = "Genre";
            // 
            // BtnBookAdd
            // 
            this.BtnBookAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnBookAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBookAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnBookAdd.Location = new System.Drawing.Point(48, 85);
            this.BtnBookAdd.Name = "BtnBookAdd";
            this.BtnBookAdd.Size = new System.Drawing.Size(96, 37);
            this.BtnBookAdd.TabIndex = 11;
            this.BtnBookAdd.Text = "Add";
            this.BtnBookAdd.UseVisualStyleBackColor = false;
            this.BtnBookAdd.Click += new System.EventHandler(this.BtnBookAdd_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnUpdate.Location = new System.Drawing.Point(169, 85);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(86, 35);
            this.BtnUpdate.TabIndex = 12;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnDelete.Location = new System.Drawing.Point(278, 83);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(86, 35);
            this.BtnDelete.TabIndex = 13;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnSearch.Location = new System.Drawing.Point(393, 84);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(90, 34);
            this.BtnSearch.TabIndex = 14;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // DgvAddBooks
            // 
            this.DgvAddBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAddBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAddBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DgvAddBooks.Location = new System.Drawing.Point(3, 172);
            this.DgvAddBooks.Name = "DgvAddBooks";
            this.DgvAddBooks.Size = new System.Drawing.Size(586, 241);
            this.DgvAddBooks.TabIndex = 15;
            this.DgvAddBooks.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvAddBooks_CellMouseClick);
            this.DgvAddBooks.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvAddBooks_RowHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Book Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Author";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Genre";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Rental Price";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Count";
            this.Column6.Name = "Column6";
            // 
            // CmbGenre
            // 
            this.CmbGenre.FormattingEnabled = true;
            this.CmbGenre.Location = new System.Drawing.Point(236, 28);
            this.CmbGenre.Name = "CmbGenre";
            this.CmbGenre.Size = new System.Drawing.Size(82, 23);
            this.CmbGenre.TabIndex = 16;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(589, 425);
            this.Controls.Add(this.CmbGenre);
            this.Controls.Add(this.DgvAddBooks);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnBookAdd);
            this.Controls.Add(this.LblBookGenre);
            this.Controls.Add(this.LblBookCount);
            this.Controls.Add(this.LblRentalPrice);
            this.Controls.Add(this.LblAuthor);
            this.Controls.Add(this.LblBookName);
            this.Controls.Add(this.TxtCount);
            this.Controls.Add(this.TxtAuthor);
            this.Controls.Add(this.TxtRentalPrice);
            this.Controls.Add(this.TxtBookName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BookForm";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.BookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAddBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBookName;
        private System.Windows.Forms.TextBox TxtRentalPrice;
        private System.Windows.Forms.TextBox TxtAuthor;
        private System.Windows.Forms.TextBox TxtCount;
        private System.Windows.Forms.Label LblBookName;
        private System.Windows.Forms.Label LblAuthor;
        private System.Windows.Forms.Label LblRentalPrice;
        private System.Windows.Forms.Label LblBookCount;
        private System.Windows.Forms.Label LblBookGenre;
        private System.Windows.Forms.Button BtnBookAdd;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridView DgvAddBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ComboBox CmbGenre;
    }
}