﻿namespace GLMainProject.AgentDeVente
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
            this.bnDelete = new System.Windows.Forms.Button();
            this.bnEdit = new System.Windows.Forms.Button();
            this.bnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnDelete
            // 
            this.bnDelete.Location = new System.Drawing.Point(261, 35);
            this.bnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnDelete.Name = "bnDelete";
            this.bnDelete.Size = new System.Drawing.Size(112, 35);
            this.bnDelete.TabIndex = 26;
            this.bnDelete.Text = "Supprimer";
            this.bnDelete.UseVisualStyleBackColor = true;
            // 
            // bnEdit
            // 
            this.bnEdit.Location = new System.Drawing.Point(140, 35);
            this.bnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnEdit.Name = "bnEdit";
            this.bnEdit.Size = new System.Drawing.Size(112, 35);
            this.bnEdit.TabIndex = 27;
            this.bnEdit.Text = "Modifier";
            this.bnEdit.UseVisualStyleBackColor = true;
            // 
            // bnAdd
            // 
            this.bnAdd.Location = new System.Drawing.Point(18, 35);
            this.bnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnAdd.Name = "bnAdd";
            this.bnAdd.Size = new System.Drawing.Size(112, 35);
            this.bnAdd.TabIndex = 28;
            this.bnAdd.Text = "Ajouter";
            this.bnAdd.UseVisualStyleBackColor = true;
            // 
            // AddEditDelet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bnDelete);
            this.Controls.Add(this.bnEdit);
            this.Controls.Add(this.bnAdd);
            this.Name = "AddEditDelet";
            this.Size = new System.Drawing.Size(403, 118);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnDelete;
        private System.Windows.Forms.Button bnEdit;
        private System.Windows.Forms.Button bnAdd;
    }
}
