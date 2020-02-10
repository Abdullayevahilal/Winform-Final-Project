namespace LIBRARY_MANAGEMENT.Forms
{
    partial class Book
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.LblBookName = new System.Windows.Forms.Label();
            this.LblAuthor = new System.Windows.Forms.Label();
            this.LblRentalPrice = new System.Windows.Forms.Label();
            this.LblLanguage = new System.Windows.Forms.Label();
            this.LblBookAvailable = new System.Windows.Forms.Label();
            this.BtnBookSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(96, 59);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(96, 164);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(96, 129);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 5;
            // 
            // LblBookName
            // 
            this.LblBookName.AutoSize = true;
            this.LblBookName.Location = new System.Drawing.Point(35, 25);
            this.LblBookName.Name = "LblBookName";
            this.LblBookName.Size = new System.Drawing.Size(57, 13);
            this.LblBookName.TabIndex = 6;
            this.LblBookName.Text = "Kitabın Adı";
            // 
            // LblAuthor
            // 
            this.LblAuthor.AutoSize = true;
            this.LblAuthor.Location = new System.Drawing.Point(38, 60);
            this.LblAuthor.Name = "LblAuthor";
            this.LblAuthor.Size = new System.Drawing.Size(34, 13);
            this.LblAuthor.TabIndex = 7;
            this.LblAuthor.Text = "Yazar";
            // 
            // LblRentalPrice
            // 
            this.LblRentalPrice.AutoSize = true;
            this.LblRentalPrice.Location = new System.Drawing.Point(33, 95);
            this.LblRentalPrice.Name = "LblRentalPrice";
            this.LblRentalPrice.Size = new System.Drawing.Size(60, 13);
            this.LblRentalPrice.TabIndex = 8;
            this.LblRentalPrice.Text = "İcarə haqqı";
            // 
            // LblLanguage
            // 
            this.LblLanguage.AutoSize = true;
            this.LblLanguage.Location = new System.Drawing.Point(41, 136);
            this.LblLanguage.Name = "LblLanguage";
            this.LblLanguage.Size = new System.Drawing.Size(19, 13);
            this.LblLanguage.TabIndex = 9;
            this.LblLanguage.Text = "Dil";
            // 
            // LblBookAvailable
            // 
            this.LblBookAvailable.AutoSize = true;
            this.LblBookAvailable.Location = new System.Drawing.Point(44, 171);
            this.LblBookAvailable.Name = "LblBookAvailable";
            this.LblBookAvailable.Size = new System.Drawing.Size(37, 13);
            this.LblBookAvailable.TabIndex = 10;
            this.LblBookAvailable.Text = "Status";
            // 
            // BtnBookSearch
            // 
            this.BtnBookSearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnBookSearch.Location = new System.Drawing.Point(108, 199);
            this.BtnBookSearch.Name = "BtnBookSearch";
            this.BtnBookSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnBookSearch.TabIndex = 11;
            this.BtnBookSearch.Text = "Axtar";
            this.BtnBookSearch.UseVisualStyleBackColor = false;
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(331, 243);
            this.Controls.Add(this.BtnBookSearch);
            this.Controls.Add(this.LblBookAvailable);
            this.Controls.Add(this.LblLanguage);
            this.Controls.Add(this.LblRentalPrice);
            this.Controls.Add(this.LblAuthor);
            this.Controls.Add(this.LblBookName);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Book";
            this.Text = "Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label LblBookName;
        private System.Windows.Forms.Label LblAuthor;
        private System.Windows.Forms.Label LblRentalPrice;
        private System.Windows.Forms.Label LblLanguage;
        private System.Windows.Forms.Label LblBookAvailable;
        private System.Windows.Forms.Button BtnBookSearch;
    }
}