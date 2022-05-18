namespace GLMainProject.UI.User
{
    partial class UserList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bnDelete = new System.Windows.Forms.Button();
            this.bnEdit = new System.Windows.Forms.Button();
            this.bnAdd = new System.Windows.Forms.Button();
            this.gridUsers = new System.Windows.Forms.DataGridView();
            this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bnDelete);
            this.panel1.Controls.Add(this.bnEdit);
            this.panel1.Controls.Add(this.bnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 44);
            this.panel1.TabIndex = 0;
            // 
            // bnDelete
            // 
            this.bnDelete.Location = new System.Drawing.Point(174, 12);
            this.bnDelete.Name = "bnDelete";
            this.bnDelete.Size = new System.Drawing.Size(75, 23);
            this.bnDelete.TabIndex = 0;
            this.bnDelete.Text = "Supprimer";
            this.bnDelete.UseVisualStyleBackColor = true;
            this.bnDelete.Click += new System.EventHandler(this.bnDelete_Click);
            // 
            // bnEdit
            // 
            this.bnEdit.Location = new System.Drawing.Point(93, 12);
            this.bnEdit.Name = "bnEdit";
            this.bnEdit.Size = new System.Drawing.Size(75, 23);
            this.bnEdit.TabIndex = 0;
            this.bnEdit.Text = "Modifier";
            this.bnEdit.UseVisualStyleBackColor = true;
            this.bnEdit.Click += new System.EventHandler(this.bnEdit_Click);
            // 
            // bnAdd
            // 
            this.bnAdd.Location = new System.Drawing.Point(12, 12);
            this.bnAdd.Name = "bnAdd";
            this.bnAdd.Size = new System.Drawing.Size(75, 23);
            this.bnAdd.TabIndex = 0;
            this.bnAdd.Text = "Ajouter";
            this.bnAdd.UseVisualStyleBackColor = true;
            this.bnAdd.Click += new System.EventHandler(this.bnAdd_Click);
            // 
            // gridUsers
            // 
            this.gridUsers.AllowUserToAddRows = false;
            this.gridUsers.AllowUserToDeleteRows = false;
            this.gridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clID,
            this.clUsername,
            this.clType});
            this.gridUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUsers.Location = new System.Drawing.Point(0, 44);
            this.gridUsers.Name = "gridUsers";
            this.gridUsers.ReadOnly = true;
            this.gridUsers.Size = new System.Drawing.Size(800, 406);
            this.gridUsers.TabIndex = 1;
            // 
            // clID
            // 
            this.clID.DataPropertyName = "Id";
            this.clID.HeaderText = "ID";
            this.clID.Name = "clID";
            this.clID.ReadOnly = true;
            // 
            // clUsername
            // 
            this.clUsername.DataPropertyName = "Username";
            this.clUsername.HeaderText = "Nom d\'utilisateur";
            this.clUsername.Name = "clUsername";
            this.clUsername.ReadOnly = true;
            // 
            // clType
            // 
            this.clType.DataPropertyName = "Type";
            this.clType.HeaderText = "Type utilisateur";
            this.clType.Name = "clType";
            this.clType.ReadOnly = true;
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridUsers);
            this.Controls.Add(this.panel1);
            this.Name = "UserList";
            this.Text = "Liste des utilisateurs";
            this.Load += new System.EventHandler(this.UserList_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bnDelete;
        private System.Windows.Forms.Button bnEdit;
        private System.Windows.Forms.Button bnAdd;
        private System.Windows.Forms.DataGridView gridUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn clID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn clType;
    }
}