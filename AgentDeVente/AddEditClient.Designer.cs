namespace GLMainProject.AgentDeVente
{
    partial class AddEditClient
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
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.cbRevenduer = new System.Windows.Forms.CheckBox();
            this.bnCancel = new System.Windows.Forms.Button();
            this.bnOk = new System.Windows.Forms.Button();
            this.tbResponsable = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.tbDesignation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(12, 32);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(94, 20);
            this.lblDesignation.TabIndex = 0;
            this.lblDesignation.Text = "Designation";
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(12, 140);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(103, 20);
            this.lblResponsable.TabIndex = 1;
            this.lblResponsable.Text = "Responsable";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 104);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(12, 65);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(59, 20);
            this.lblAdress.TabIndex = 3;
            this.lblAdress.Text = "Adress";
            // 
            // cbRevenduer
            // 
            this.cbRevenduer.AutoSize = true;
            this.cbRevenduer.Location = new System.Drawing.Point(121, 178);
            this.cbRevenduer.Name = "cbRevenduer";
            this.cbRevenduer.Size = new System.Drawing.Size(113, 24);
            this.cbRevenduer.TabIndex = 5;
            this.cbRevenduer.Text = "Revendeur";
            this.cbRevenduer.UseVisualStyleBackColor = true;
            // 
            // bnCancel
            // 
            this.bnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnCancel.Location = new System.Drawing.Point(326, 342);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(105, 35);
            this.bnCancel.TabIndex = 14;
            this.bnCancel.Text = "Annuler";
            this.bnCancel.UseVisualStyleBackColor = true;
            // 
            // bnOk
            // 
            this.bnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnOk.Location = new System.Drawing.Point(215, 342);
            this.bnOk.Name = "bnOk";
            this.bnOk.Size = new System.Drawing.Size(105, 35);
            this.bnOk.TabIndex = 15;
            this.bnOk.Text = "Ok";
            this.bnOk.UseVisualStyleBackColor = true;
            this.bnOk.Click += new System.EventHandler(this.bnAjouter_Click);
            // 
            // tbResponsable
            // 
            this.tbResponsable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResponsable.Location = new System.Drawing.Point(121, 140);
            this.tbResponsable.Name = "tbResponsable";
            this.tbResponsable.Size = new System.Drawing.Size(310, 26);
            this.tbResponsable.TabIndex = 19;
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmail.Location = new System.Drawing.Point(121, 104);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(310, 26);
            this.tbEmail.TabIndex = 18;
            // 
            // tbAdress
            // 
            this.tbAdress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAdress.Location = new System.Drawing.Point(121, 68);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(310, 26);
            this.tbAdress.TabIndex = 17;
            // 
            // tbDesignation
            // 
            this.tbDesignation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDesignation.Location = new System.Drawing.Point(121, 32);
            this.tbDesignation.Name = "tbDesignation";
            this.tbDesignation.Size = new System.Drawing.Size(310, 26);
            this.tbDesignation.TabIndex = 16;
            // 
            // AddEditClient
            // 
            this.AcceptButton = this.bnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bnCancel;
            this.ClientSize = new System.Drawing.Size(443, 389);
            this.Controls.Add(this.tbResponsable);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.tbDesignation);
            this.Controls.Add(this.bnOk);
            this.Controls.Add(this.bnCancel);
            this.Controls.Add(this.cbRevenduer);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.lblDesignation);
            this.MaximumSize = new System.Drawing.Size(762, 445);
            this.MinimumSize = new System.Drawing.Size(465, 445);
            this.Name = "AddEditClient";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.AddEditClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.CheckBox cbRevenduer;
        private System.Windows.Forms.Button bnCancel;
        private System.Windows.Forms.Button bnOk;
        private System.Windows.Forms.TextBox tbResponsable;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.TextBox tbDesignation;
    }
}