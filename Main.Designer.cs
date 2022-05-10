namespace GLMainProject
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.bnCatalogue = new System.Windows.Forms.Button();
            this.bnClient = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vueAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bnOperations = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnCatalogue
            // 
            this.bnCatalogue.Location = new System.Drawing.Point(345, 257);
            this.bnCatalogue.Name = "bnCatalogue";
            this.bnCatalogue.Size = new System.Drawing.Size(201, 125);
            this.bnCatalogue.TabIndex = 1;
            this.bnCatalogue.Text = "Catalogue";
            this.bnCatalogue.UseVisualStyleBackColor = true;
            this.bnCatalogue.Click += new System.EventHandler(this.bnCatalogue_Click);
            // 
            // bnClient
            // 
            this.bnClient.Location = new System.Drawing.Point(112, 257);
            this.bnClient.Name = "bnClient";
            this.bnClient.Size = new System.Drawing.Size(201, 125);
            this.bnClient.TabIndex = 2;
            this.bnClient.Text = "Client";
            this.bnClient.UseVisualStyleBackColor = true;
            this.bnClient.Click += new System.EventHandler(this.bnClient_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.vueAllToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(169, 34);
            this.addToolStripMenuItem.Text = "&Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // vueAllToolStripMenuItem
            // 
            this.vueAllToolStripMenuItem.Name = "vueAllToolStripMenuItem";
            this.vueAllToolStripMenuItem.Size = new System.Drawing.Size(169, 34);
            this.vueAllToolStripMenuItem.Text = "&Vue All";
            // 
            // bnOperations
            // 
            this.bnOperations.Location = new System.Drawing.Point(585, 257);
            this.bnOperations.Name = "bnOperations";
            this.bnOperations.Size = new System.Drawing.Size(201, 125);
            this.bnOperations.TabIndex = 4;
            this.bnOperations.Text = "Operations de ventes";
            this.bnOperations.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 585);
            this.Controls.Add(this.bnOperations);
            this.Controls.Add(this.bnClient);
            this.Controls.Add(this.bnCatalogue);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Milk Production Management";
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bnCatalogue;
        private System.Windows.Forms.Button bnClient;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vueAllToolStripMenuItem;
        private System.Windows.Forms.Button bnOperations;
    }
}

