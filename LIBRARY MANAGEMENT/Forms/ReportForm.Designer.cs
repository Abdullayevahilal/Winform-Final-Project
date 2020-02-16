namespace LIBRARY_MANAGEMENT.Forms
{
    partial class ReportForm
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
            this.DgvReport = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnExport = new System.Windows.Forms.Button();
            this.DtpStart = new System.Windows.Forms.DateTimePicker();
            this.DtpEnd = new System.Windows.Forms.DateTimePicker();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.LblStardate = new System.Windows.Forms.Label();
            this.lblEbdDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvReport
            // 
            this.DgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.DgvReport.Location = new System.Drawing.Point(-6, 198);
            this.DgvReport.Name = "DgvReport";
            this.DgvReport.Size = new System.Drawing.Size(844, 150);
            this.DgvReport.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Customer Name";
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
            this.Column8.HeaderText = "Return Time";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Total Price";
            this.Column9.Name = "Column9";
            // 
            // BtnExport
            // 
            this.BtnExport.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnExport.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnExport.Location = new System.Drawing.Point(14, 38);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(135, 44);
            this.BtnExport.TabIndex = 1;
            this.BtnExport.Text = "Export";
            this.BtnExport.UseVisualStyleBackColor = false;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // DtpStart
            // 
            this.DtpStart.Location = new System.Drawing.Point(304, 23);
            this.DtpStart.Name = "DtpStart";
            this.DtpStart.Size = new System.Drawing.Size(233, 20);
            this.DtpStart.TabIndex = 2;
            // 
            // DtpEnd
            // 
            this.DtpEnd.Location = new System.Drawing.Point(302, 62);
            this.DtpEnd.Name = "DtpEnd";
            this.DtpEnd.Size = new System.Drawing.Size(233, 20);
            this.DtpEnd.TabIndex = 3;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnSearch.Location = new System.Drawing.Point(579, 38);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(101, 38);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // LblStardate
            // 
            this.LblStardate.AutoSize = true;
            this.LblStardate.Location = new System.Drawing.Point(248, 23);
            this.LblStardate.Name = "LblStardate";
            this.LblStardate.Size = new System.Drawing.Size(38, 13);
            this.LblStardate.TabIndex = 5;
            this.LblStardate.Text = "From:";
            // 
            // lblEbdDate
            // 
            this.lblEbdDate.AutoSize = true;
            this.lblEbdDate.Location = new System.Drawing.Point(253, 68);
            this.lblEbdDate.Name = "lblEbdDate";
            this.lblEbdDate.Size = new System.Drawing.Size(26, 13);
            this.lblEbdDate.TabIndex = 6;
            this.lblEbdDate.Text = "To:";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 346);
            this.Controls.Add(this.lblEbdDate);
            this.Controls.Add(this.LblStardate);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.DtpEnd);
            this.Controls.Add(this.DtpStart);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.DgvReport);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ReportForm";
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.DgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.DateTimePicker DtpStart;
        private System.Windows.Forms.DateTimePicker DtpEnd;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label LblStardate;
        private System.Windows.Forms.Label lblEbdDate;
    }
}