namespace GLMainProject
{
    partial class Catalogue
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
            this.dataGridViewCatalogue = new System.Windows.Forms.DataGridView();
            this.bnEdit = new System.Windows.Forms.Button();
            this.bnDelete = new System.Windows.Forms.Button();
            this.bnAdd = new System.Windows.Forms.Button();
            this.tbSearsh = new System.Windows.Forms.TextBox();
            this.bnSearsh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalogue)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCatalogue
            // 
            this.dataGridViewCatalogue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCatalogue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCatalogue.Location = new System.Drawing.Point(12, 74);
            this.dataGridViewCatalogue.Name = "dataGridViewCatalogue";
            this.dataGridViewCatalogue.RowHeadersWidth = 62;
            this.dataGridViewCatalogue.RowTemplate.Height = 28;
            this.dataGridViewCatalogue.Size = new System.Drawing.Size(872, 425);
            this.dataGridViewCatalogue.TabIndex = 1;
            // 
            // bnEdit
            // 
            this.bnEdit.Font = new System.Drawing.Font("Wingdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.bnEdit.Location = new System.Drawing.Point(85, 12);
            this.bnEdit.Name = "bnEdit";
            this.bnEdit.Size = new System.Drawing.Size(67, 56);
            this.bnEdit.TabIndex = 8;
            this.bnEdit.Text = "!";
            this.bnEdit.UseVisualStyleBackColor = true;
            this.bnEdit.Click += new System.EventHandler(this.bnEdit_Click);
            // 
            // bnDelete
            // 
            this.bnDelete.Font = new System.Drawing.Font("Wingdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.bnDelete.Location = new System.Drawing.Point(158, 12);
            this.bnDelete.Name = "bnDelete";
            this.bnDelete.Size = new System.Drawing.Size(67, 56);
            this.bnDelete.TabIndex = 7;
            this.bnDelete.Text = "Ö";
            this.bnDelete.UseVisualStyleBackColor = true;
            // 
            // bnAdd
            // 
            this.bnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnAdd.Location = new System.Drawing.Point(12, 12);
            this.bnAdd.Name = "bnAdd";
            this.bnAdd.Size = new System.Drawing.Size(67, 56);
            this.bnAdd.TabIndex = 6;
            this.bnAdd.Text = "+";
            this.bnAdd.UseVisualStyleBackColor = true;
            this.bnAdd.Click += new System.EventHandler(this.bnAdd_Click);
            // 
            // tbSearsh
            // 
            this.tbSearsh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearsh.Location = new System.Drawing.Point(396, 25);
            this.tbSearsh.Name = "tbSearsh";
            this.tbSearsh.Size = new System.Drawing.Size(428, 26);
            this.tbSearsh.TabIndex = 17;
            // 
            // bnSearsh
            // 
            this.bnSearsh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnSearsh.Location = new System.Drawing.Point(830, 12);
            this.bnSearsh.Name = "bnSearsh";
            this.bnSearsh.Size = new System.Drawing.Size(54, 56);
            this.bnSearsh.TabIndex = 18;
            this.bnSearsh.Text = "🔍";
            this.bnSearsh.UseVisualStyleBackColor = true;
            // 
            // Catalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(896, 511);
            this.Controls.Add(this.bnSearsh);
            this.Controls.Add(this.tbSearsh);
            this.Controls.Add(this.bnEdit);
            this.Controls.Add(this.bnDelete);
            this.Controls.Add(this.bnAdd);
            this.Controls.Add(this.dataGridViewCatalogue);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(670, 459);
            this.Name = "Catalogue";
            this.Text = "Catalogue";
            this.Load += new System.EventHandler(this.Catalogue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalogue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewCatalogue;
        private System.Windows.Forms.Button bnEdit;
        private System.Windows.Forms.Button bnDelete;
        private System.Windows.Forms.Button bnAdd;
        private System.Windows.Forms.TextBox tbSearsh;
        private System.Windows.Forms.Button bnSearsh;
    }
}