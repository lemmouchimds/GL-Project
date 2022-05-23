namespace GLMainProject.UI.Docs
{
    partial class DetailDoc
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bnDelete = new System.Windows.Forms.Button();
            this.bnEdit = new System.Windows.Forms.Button();
            this.bnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(836, 533);
            this.dataGridView1.TabIndex = 0;
            // 
            // bnDelete
            // 
            this.bnDelete.Location = new System.Drawing.Point(256, 14);
            this.bnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnDelete.Name = "bnDelete";
            this.bnDelete.Size = new System.Drawing.Size(112, 35);
            this.bnDelete.TabIndex = 23;
            this.bnDelete.Text = "Supprimer";
            this.bnDelete.UseVisualStyleBackColor = true;
            // 
            // bnEdit
            // 
            this.bnEdit.Location = new System.Drawing.Point(135, 14);
            this.bnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnEdit.Name = "bnEdit";
            this.bnEdit.Size = new System.Drawing.Size(112, 35);
            this.bnEdit.TabIndex = 24;
            this.bnEdit.Text = "Modifier";
            this.bnEdit.UseVisualStyleBackColor = true;
            // 
            // bnAdd
            // 
            this.bnAdd.Location = new System.Drawing.Point(13, 14);
            this.bnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnAdd.Name = "bnAdd";
            this.bnAdd.Size = new System.Drawing.Size(112, 35);
            this.bnAdd.TabIndex = 25;
            this.bnAdd.Text = "Ajouter";
            this.bnAdd.UseVisualStyleBackColor = true;
            // 
            // DetailDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 599);
            this.Controls.Add(this.bnDelete);
            this.Controls.Add(this.bnEdit);
            this.Controls.Add(this.bnAdd);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(616, 562);
            this.Name = "DetailDoc";
            this.ShowIcon = false;
            this.Text = "Detail Document";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bnDelete;
        private System.Windows.Forms.Button bnEdit;
        private System.Windows.Forms.Button bnAdd;
    }
}