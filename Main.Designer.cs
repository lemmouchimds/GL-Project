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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vueAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewDashboard = new System.Windows.Forms.DataGridView();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.catalogueToolStripMenuItem,
            this.documentToolStripMenuItem});
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
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(114, 29);
            this.usersToolStripMenuItem.Text = "Utilisateurs";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.addToolStripMenuItem.Text = "&Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // vueAllToolStripMenuItem
            // 
            this.vueAllToolStripMenuItem.Name = "vueAllToolStripMenuItem";
            this.vueAllToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.vueAllToolStripMenuItem.Text = "&Vue All";
            this.vueAllToolStripMenuItem.Click += new System.EventHandler(this.vueAllToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.clientToolStripMenuItem.Text = "&Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // catalogueToolStripMenuItem
            // 
            this.catalogueToolStripMenuItem.Name = "catalogueToolStripMenuItem";
            this.catalogueToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.catalogueToolStripMenuItem.Text = "Ca&talogue";
            this.catalogueToolStripMenuItem.Click += new System.EventHandler(this.catalogueToolStripMenuItem_Click);
            // 
            // documentToolStripMenuItem
            // 
            this.documentToolStripMenuItem.Name = "documentToolStripMenuItem";
            this.documentToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.documentToolStripMenuItem.Text = "&Document";
            this.documentToolStripMenuItem.Click += new System.EventHandler(this.documentToolStripMenuItem_Click);
            // 
            // dataGridViewDashboard
            // 
            this.dataGridViewDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDashboard.Location = new System.Drawing.Point(12, 108);
            this.dataGridViewDashboard.Name = "dataGridViewDashboard";
            this.dataGridViewDashboard.RowHeadersWidth = 62;
            this.dataGridViewDashboard.RowTemplate.Height = 28;
            this.dataGridViewDashboard.Size = new System.Drawing.Size(988, 465);
            this.dataGridViewDashboard.TabIndex = 6;
            // 
            // lblDashboard
            // 
            this.lblDashboard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(377, 47);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(232, 48);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Dashboard";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1012, 585);
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.dataGridViewDashboard);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Milk Production Management";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDashboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vueAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewDashboard;
        private System.Windows.Forms.Label lblDashboard;
    }
}

