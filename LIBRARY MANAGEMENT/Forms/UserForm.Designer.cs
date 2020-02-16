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
            this.BtnUserSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnUserSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUserSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnUserSearch.Location = new System.Drawing.Point(419, 85);
            this.BtnUserSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnUserSearch.Name = "BtnUserSearch";
            this.BtnUserSearch.Size = new System.Drawing.Size(93, 39);
            this.BtnUserSearch.TabIndex = 29;
            this.BtnUserSearch.Text = "Search";
            this.BtnUserSearch.UseVisualStyleBackColor = false;
            this.BtnUserSearch.Click += new System.EventHandler(this.BtnUserSearch_Click);
            // 
            // BtnUserDelete
            // 
            this.BtnUserDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnUserDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUserDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnUserDelete.Location = new System.Drawing.Point(296, 84);
            this.BtnUserDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnUserDelete.Name = "BtnUserDelete";
            this.BtnUserDelete.Size = new System.Drawing.Size(93, 40);
            this.BtnUserDelete.TabIndex = 28;
            this.BtnUserDelete.Text = "Delete";
            this.BtnUserDelete.UseVisualStyleBackColor = false;
            this.BtnUserDelete.Click += new System.EventHandler(this.BtnUserDelete_Click);
            // 
            // BtnUserUpdate
            // 
            this.BtnUserUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnUserUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUserUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnUserUpdate.Location = new System.Drawing.Point(168, 84);
            this.BtnUserUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnUserUpdate.Name = "BtnUserUpdate";
            this.BtnUserUpdate.Size = new System.Drawing.Size(95, 40);
            this.BtnUserUpdate.TabIndex = 27;
            this.BtnUserUpdate.Text = "Update";
            this.BtnUserUpdate.UseVisualStyleBackColor = false;
            this.BtnUserUpdate.Click += new System.EventHandler(this.BtnUserUpdate_Click);
            // 
            // BtnUserAdd
            // 
            this.BtnUserAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnUserAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUserAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnUserAdd.Location = new System.Drawing.Point(27, 82);
            this.BtnUserAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnUserAdd.Name = "BtnUserAdd";
            this.BtnUserAdd.Size = new System.Drawing.Size(96, 43);
            this.BtnUserAdd.TabIndex = 26;
            this.BtnUserAdd.Text = "Add";
            this.BtnUserAdd.UseVisualStyleBackColor = false;
            this.BtnUserAdd.Click += new System.EventHandler(this.BtnUserAdd_Click);
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(297, 10);
            this.LblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(44, 15);
            this.LblEmail.TabIndex = 25;
            this.LblEmail.Text = "Email";
            // 
            // LblUserPassword
            // 
            this.LblUserPassword.AutoSize = true;
            this.LblUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserPassword.Location = new System.Drawing.Point(434, 10);
            this.LblUserPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUserPassword.Name = "LblUserPassword";
            this.LblUserPassword.Size = new System.Drawing.Size(69, 15);
            this.LblUserPassword.TabIndex = 24;
            this.LblUserPassword.Text = "Password";
            // 
            // LblUserPhone
            // 
            this.LblUserPhone.AutoSize = true;
            this.LblUserPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserPhone.Location = new System.Drawing.Point(164, 10);
            this.LblUserPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUserPhone.Name = "LblUserPhone";
            this.LblUserPhone.Size = new System.Drawing.Size(48, 15);
            this.LblUserPhone.TabIndex = 22;
            this.LblUserPhone.Text = "Phone";
            // 
            // LblFullName
            // 
            this.LblFullName.AutoSize = true;
            this.LblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFullName.Location = new System.Drawing.Point(23, 10);
            this.LblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFullName.Name = "LblFullName";
            this.LblFullName.Size = new System.Drawing.Size(69, 15);
            this.LblFullName.TabIndex = 21;
            this.LblFullName.Text = "FullName";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(433, 29);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(97, 21);
            this.TxtPassword.TabIndex = 20;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhone.Location = new System.Drawing.Point(159, 29);
            this.TxtPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(115, 21);
            this.TxtPhone.TabIndex = 19;
            // 
            // TxtUserEmail
            // 
            this.TxtUserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserEmail.Location = new System.Drawing.Point(296, 29);
            this.TxtUserEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtUserEmail.Name = "TxtUserEmail";
            this.TxtUserEmail.Size = new System.Drawing.Size(115, 21);
            this.TxtUserEmail.TabIndex = 18;
            // 
            // TxtFullName
            // 
            this.TxtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFullName.Location = new System.Drawing.Point(20, 29);
            this.TxtFullName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtFullName.Name = "TxtFullName";
            this.TxtFullName.Size = new System.Drawing.Size(115, 21);
            this.TxtFullName.TabIndex = 17;
            // 
            // DgvAddUsers
            // 
            this.DgvAddUsers.AllowUserToAddRows = false;
            this.DgvAddUsers.AllowUserToDeleteRows = false;
            this.DgvAddUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAddUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAddUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DgvAddUsers.Location = new System.Drawing.Point(4, 183);
            this.DgvAddUsers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DgvAddUsers.Name = "DgvAddUsers";
            this.DgvAddUsers.ReadOnly = true;
            this.DgvAddUsers.Size = new System.Drawing.Size(521, 226);
            this.DgvAddUsers.TabIndex = 30;
            this.DgvAddUsers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvAddUsers_CellMouseClick);
            this.DgvAddUsers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvAddUsers_RowHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Status";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fullname";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Phone";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Email";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Password";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 421);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UserForm";
            this.Text = "Users";
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