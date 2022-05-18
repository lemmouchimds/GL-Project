namespace GLMainProject
{
    partial class Authentification
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
            this.bnOK = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPswrd = new System.Windows.Forms.Label();
            this.bnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnOK
            // 
            this.bnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bnOK.Location = new System.Drawing.Point(414, 119);
            this.bnOK.Name = "bnOK";
            this.bnOK.Size = new System.Drawing.Size(92, 34);
            this.bnOK.TabIndex = 0;
            this.bnOK.Text = "OK";
            this.bnOK.UseVisualStyleBackColor = true;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(98, 74);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(510, 26);
            this.tbPassword.TabIndex = 1;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(98, 24);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(510, 26);
            this.tbUsername.TabIndex = 2;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 27);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 20);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "User";
            // 
            // lblPswrd
            // 
            this.lblPswrd.AutoSize = true;
            this.lblPswrd.Location = new System.Drawing.Point(12, 77);
            this.lblPswrd.Name = "lblPswrd";
            this.lblPswrd.Size = new System.Drawing.Size(78, 20);
            this.lblPswrd.TabIndex = 4;
            this.lblPswrd.Text = "Password";
            this.lblPswrd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bnCancel
            // 
            this.bnCancel.CausesValidation = false;
            this.bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnCancel.Location = new System.Drawing.Point(512, 119);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(96, 34);
            this.bnCancel.TabIndex = 5;
            this.bnCancel.Text = "Annuler";
            this.bnCancel.UseVisualStyleBackColor = true;
            // 
            // Authentification
            // 
            this.AcceptButton = this.bnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bnCancel;
            this.ClientSize = new System.Drawing.Size(620, 165);
            this.ControlBox = false;
            this.Controls.Add(this.bnCancel);
            this.Controls.Add(this.lblPswrd);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.bnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(642, 221);
            this.MinimumSize = new System.Drawing.Size(642, 221);
            this.Name = "Authentification";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Authentification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnOK;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPswrd;
        private System.Windows.Forms.Button bnCancel;
    }
}