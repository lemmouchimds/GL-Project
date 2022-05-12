namespace GLMainProject.AgentDeVente
{
    partial class AddEditDelet
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.bnEdit = new System.Windows.Forms.Button();
            this.bnDelete = new System.Windows.Forms.Button();
            this.bnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnEdit
            // 
            this.bnEdit.Font = new System.Drawing.Font("Wingdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.bnEdit.Location = new System.Drawing.Point(121, 179);
            this.bnEdit.Name = "bnEdit";
            this.bnEdit.Size = new System.Drawing.Size(67, 56);
            this.bnEdit.TabIndex = 11;
            this.bnEdit.Text = "!";
            this.bnEdit.UseVisualStyleBackColor = true;
            // 
            // bnDelete
            // 
            this.bnDelete.Font = new System.Drawing.Font("Wingdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.bnDelete.Location = new System.Drawing.Point(194, 179);
            this.bnDelete.Name = "bnDelete";
            this.bnDelete.Size = new System.Drawing.Size(67, 56);
            this.bnDelete.TabIndex = 10;
            this.bnDelete.Text = "Ö";
            this.bnDelete.UseVisualStyleBackColor = true;
            // 
            // bnAdd
            // 
            this.bnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnAdd.Location = new System.Drawing.Point(48, 179);
            this.bnAdd.Name = "bnAdd";
            this.bnAdd.Size = new System.Drawing.Size(67, 56);
            this.bnAdd.TabIndex = 9;
            this.bnAdd.Text = "+";
            this.bnAdd.UseVisualStyleBackColor = true;
            // 
            // AddEditDelet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bnEdit);
            this.Controls.Add(this.bnDelete);
            this.Controls.Add(this.bnAdd);
            this.Name = "AddEditDelet";
            this.Size = new System.Drawing.Size(475, 310);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bnEdit;
        private System.Windows.Forms.Button bnDelete;
        private System.Windows.Forms.Button bnAdd;
    }
}
