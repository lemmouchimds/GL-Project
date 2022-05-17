namespace GLMainProject.Directeur
{
    partial class DirecteurUI
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
            this.bnCompar = new System.Windows.Forms.Button();
            this.lblBonjour = new System.Windows.Forms.Label();
            this.bnUsers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnCompar
            // 
            this.bnCompar.Location = new System.Drawing.Point(23, 177);
            this.bnCompar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnCompar.Name = "bnCompar";
            this.bnCompar.Size = new System.Drawing.Size(195, 200);
            this.bnCompar.TabIndex = 0;
            this.bnCompar.Text = "La comparaison stratigique";
            this.bnCompar.UseVisualStyleBackColor = true;
            // 
            // lblBonjour
            // 
            this.lblBonjour.AutoSize = true;
            this.lblBonjour.Location = new System.Drawing.Point(229, 9);
            this.lblBonjour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBonjour.Name = "lblBonjour";
            this.lblBonjour.Size = new System.Drawing.Size(137, 20);
            this.lblBonjour.TabIndex = 1;
            this.lblBonjour.Text = "Bonjour Directeur ";
            // 
            // bnUsers
            // 
            this.bnUsers.Location = new System.Drawing.Point(232, 177);
            this.bnUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnUsers.Name = "bnUsers";
            this.bnUsers.Size = new System.Drawing.Size(195, 200);
            this.bnUsers.TabIndex = 2;
            this.bnUsers.Text = "Gestion d\'utilisatuer";
            this.bnUsers.UseVisualStyleBackColor = true;
            this.bnUsers.Click += new System.EventHandler(this.bnUsers_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 177);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 200);
            this.button1.TabIndex = 3;
            this.button1.Text = "Gestion d\'utilisatuer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DirecteurUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 471);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bnUsers);
            this.Controls.Add(this.lblBonjour);
            this.Controls.Add(this.bnCompar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DirecteurUI";
            this.Text = "Directeur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnCompar;
        private System.Windows.Forms.Label lblBonjour;
        private System.Windows.Forms.Button bnUsers;
        private System.Windows.Forms.Button button1;
    }
}