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
            this.bnCatalogue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnCatalogue
            // 
            this.bnCatalogue.Location = new System.Drawing.Point(299, 37);
            this.bnCatalogue.Name = "bnCatalogue";
            this.bnCatalogue.Size = new System.Drawing.Size(201, 125);
            this.bnCatalogue.TabIndex = 1;
            this.bnCatalogue.Text = "Catalogue";
            this.bnCatalogue.UseVisualStyleBackColor = true;
            this.bnCatalogue.Click += new System.EventHandler(this.bnCatalogue_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 585);
            this.Controls.Add(this.bnCatalogue);
            this.Name = "Main";
            this.Text = "Milk Production Management";
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bnCatalogue;
    }
}

