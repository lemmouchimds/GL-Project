namespace GLMainProject.AgentDeVente
{
    partial class MettrePrix
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
            this.lvPrix = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvPrix
            // 
            this.lvPrix.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lvPrix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPrix.HideSelection = false;
            this.lvPrix.Location = new System.Drawing.Point(12, 53);
            this.lvPrix.Name = "lvPrix";
            this.lvPrix.Size = new System.Drawing.Size(588, 330);
            this.lvPrix.TabIndex = 1;
            this.lvPrix.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "H";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MettrePrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 395);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvPrix);
            this.MinimumSize = new System.Drawing.Size(454, 318);
            this.Name = "MettrePrix";
            this.Text = "MettrePrix";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvPrix;
        private System.Windows.Forms.Button button1;
    }
}