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
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnCompar
            // 
            this.bnCompar.Location = new System.Drawing.Point(37, 115);
            this.bnCompar.Name = "bnCompar";
            this.bnCompar.Size = new System.Drawing.Size(130, 130);
            this.bnCompar.TabIndex = 0;
            this.bnCompar.Text = "La comparaison stratigique";
            this.bnCompar.UseVisualStyleBackColor = true;
            // 
            // lblBonjour
            // 
            this.lblBonjour.AutoSize = true;
            this.lblBonjour.Location = new System.Drawing.Point(148, 9);
            this.lblBonjour.Name = "lblBonjour";
            this.lblBonjour.Size = new System.Drawing.Size(92, 13);
            this.lblBonjour.TabIndex = 1;
            this.lblBonjour.Text = "Bonjour Directeur ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(251, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 130);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DirecteurUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 306);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblBonjour);
            this.Controls.Add(this.bnCompar);
            this.Name = "DirecteurUI";
            this.Text = "DirecteurUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnCompar;
        private System.Windows.Forms.Label lblBonjour;
        private System.Windows.Forms.Button button2;
    }
}