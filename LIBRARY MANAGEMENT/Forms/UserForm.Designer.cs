namespace LIBRARY_MANAGEMENT.Forms
{
    partial class UserForm
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
            this.BtnUserSearch = new System.Windows.Forms.Button();
            this.BtnUserDelete = new System.Windows.Forms.Button();
            this.BtnUserUpdate = new System.Windows.Forms.Button();
            this.BtnUserAdd = new System.Windows.Forms.Button();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblUserPassword = new System.Windows.Forms.Label();
            this.LblUserPhone = new System.Windows.Forms.Label();
            this.LblFullName = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.TxtUserEmail = new System.Windows.Forms.TextBox();
            this.TxtFullName = new System.Windows.Forms.TextBox();
            this.DgvAddUsers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAddUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnUserSearch
            // 
            this.BtnUserSearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnUserSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUserSearch.Location = new System.Drawing.Point(314, 74);
            this.BtnUserSearch.Name = "BtnUserSearch";
            this.BtnUserSearch.Size = new System.Drawing.Size(70, 34);
            this.BtnUserSearch.TabIndex = 29;
            this.BtnUserSearch.Text = "Search";
            this.BtnUserSearch.UseVisualStyleBackColor = false;
            this.BtnUserSearch.Click += new System.EventHandler(this.BtnUserSearch_Click);
            // 
            // BtnUserDelete
            // 
            this.BtnUserDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnUserDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUserDelete.Location = new System.Drawing.Point(222, 73);
            this.BtnUserDelete.Name = "BtnUserDelete";
            this.BtnUserDelete.Size = new System.Drawing.Size(70, 35);
            this.BtnUserDelete.TabIndex = 28;
            this.BtnUserDelete.Text = "Delete";
            this.BtnUserDelete.UseVisualStyleBackColor = false;
            this.BtnUserDelete.Click += new System.EventHandler(this.BtnUserDelete_Click);
            // 
            // BtnUserUpdate
            // 
            this.BtnUserUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnUserUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUserUpdate.Location = new System.Drawing.Point(126, 73);
            this.BtnUserUpdate.Name = "BtnUserUpdate";
            this.BtnUserUpdate.Size = new System.Drawing.Size(71, 35);
            this.BtnUserUpdate.TabIndex = 27;
            this.BtnUserUpdate.Text = "Update";
            this.BtnUserUpdate.UseVisualStyleBackColor = false;
            // 
            // BtnUserAdd
            // 
            this.BtnUserAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnUserAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUserAdd.Location = new System.Drawing.Point(20, 71);
            this.BtnUserAdd.Name = "BtnUserAdd";
            this.BtnUserAdd.Size = new System.Drawing.Size(72, 37);
            this.BtnUserAdd.TabIndex = 26;
            this.BtnUserAdd.Text = "Add";
            this.BtnUserAdd.UseVisualStyleBackColor = false;
            this.BtnUserAdd.Click += new System.EventHandler(this.BtnUserAdd_Click);
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(235, 9);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(32, 13);
            this.LblEmail.TabIndex = 25;
            this.LblEmail.Text = "Email";
            // 
            // LblUserPassword
            // 
            this.LblUserPassword.AutoSize = true;
            this.LblUserPassword.Location = new System.Drawing.Point(361, 9);
            this.LblUserPassword.Name = "LblUserPassword";
            this.LblUserPassword.Size = new System.Drawing.Size(53, 13);
            this.LblUserPassword.TabIndex = 24;
            this.LblUserPassword.Text = "Password";
            // 
            // LblUserPhone
            // 
            this.LblUserPhone.AutoSize = true;
            this.LblUserPhone.Location = new System.Drawing.Point(129, 9);
            this.LblUserPhone.Name = "LblUserPhone";
            this.LblUserPhone.Size = new System.Drawing.Size(38, 13);
            this.LblUserPhone.TabIndex = 22;
            this.LblUserPhone.Text = "Phone";
            // 
            // LblFullName
            // 
            this.LblFullName.AutoSize = true;
            this.LblFullName.Location = new System.Drawing.Point(17, 9);
            this.LblFullName.Name = "LblFullName";
            this.LblFullName.Size = new System.Drawing.Size(51, 13);
            this.LblFullName.TabIndex = 21;
            this.LblFullName.Text = "FullName";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(358, 25);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(90, 20);
            this.TxtPassword.TabIndex = 20;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(126, 25);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(97, 20);
            this.TxtPhone.TabIndex = 19;
            // 
            // TxtUserEmail
            // 
            this.TxtUserEmail.Location = new System.Drawing.Point(238, 25);
            this.TxtUserEmail.Name = "TxtUserEmail";
            this.TxtUserEmail.Size = new System.Drawing.Size(97, 20);
            this.TxtUserEmail.TabIndex = 18;
            // 
            // TxtFullName
            // 
            this.TxtFullName.Location = new System.Drawing.Point(15, 25);
            this.TxtFullName.Name = "TxtFullName";
            this.TxtFullName.Size = new System.Drawing.Size(91, 20);
            this.TxtFullName.TabIndex = 17;
            // 
            // DgvAddUsers
            // 
            this.DgvAddUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAddUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DgvAddUsers.Location = new System.Drawing.Point(3, 172);
            this.DgvAddUsers.Name = "DgvAddUsers";
            this.DgvAddUsers.Size = new System.Drawing.Size(639, 276);
            this.DgvAddUsers.TabIndex = 30;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Status";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fullname";
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
            this.Column6.HeaderText = "Password";
            this.Column6.Name = "Column6";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.DgvAddUsers);
            this.Controls.Add(this.BtnUserSearch);
            this.Controls.Add(this.BtnUserDelete);
            this.Controls.Add(this.BtnUserUpdate);
            this.Controls.Add(this.BtnUserAdd);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblUserPassword);
            this.Controls.Add(this.LblUserPhone);
            this.Controls.Add(this.LblFullName);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.TxtUserEmail);
            this.Controls.Add(this.TxtFullName);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAddUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnUserSearch;
        private System.Windows.Forms.Button BtnUserDelete;
        private System.Windows.Forms.Button BtnUserUpdate;
        private System.Windows.Forms.Button BtnUserAdd;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblUserPassword;
        private System.Windows.Forms.Label LblUserPhone;
        private System.Windows.Forms.Label LblFullName;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.TextBox TxtUserEmail;
        private System.Windows.Forms.TextBox TxtFullName;
        private System.Windows.Forms.DataGridView DgvAddUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}