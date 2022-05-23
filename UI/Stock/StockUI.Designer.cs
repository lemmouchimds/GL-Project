namespace GLMainProject.AgentDeVente
{
    partial class StockUI
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
            this.dataGridViewStock = new System.Windows.Forms.DataGridView();
            this.bnDelete = new System.Windows.Forms.Button();
            this.bnEdit = new System.Windows.Forms.Button();
            this.bnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStock
            // 
            this.dataGridViewStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStock.Location = new System.Drawing.Point(-2, 75);
            this.dataGridViewStock.Name = "dataGridViewStock";
            this.dataGridViewStock.RowHeadersWidth = 62;
            this.dataGridViewStock.RowTemplate.Height = 28;
            this.dataGridViewStock.Size = new System.Drawing.Size(797, 373);
            this.dataGridViewStock.TabIndex = 6;
            // 
            // bnDelete
            // 
            this.bnDelete.Location = new System.Drawing.Point(252, 14);
            this.bnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnDelete.Name = "bnDelete";
            this.bnDelete.Size = new System.Drawing.Size(112, 35);
            this.bnDelete.TabIndex = 26;
            this.bnDelete.Text = "Supprimer";
            this.bnDelete.UseVisualStyleBackColor = true;
            // 
            // bnEdit
            // 
            this.bnEdit.Location = new System.Drawing.Point(132, 14);
            this.bnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnEdit.Name = "bnEdit";
            this.bnEdit.Size = new System.Drawing.Size(112, 35);
            this.bnEdit.TabIndex = 27;
            this.bnEdit.Text = "Modifier";
            this.bnEdit.UseVisualStyleBackColor = true;
            // 
            // bnAdd
            // 
            this.bnAdd.Location = new System.Drawing.Point(10, 14);
            this.bnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnAdd.Name = "bnAdd";
            this.bnAdd.Size = new System.Drawing.Size(112, 35);
            this.bnAdd.TabIndex = 28;
            this.bnAdd.Text = "Ajouter";
            this.bnAdd.UseVisualStyleBackColor = true;
            // 
            // StockUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 446);
            this.Controls.Add(this.bnDelete);
            this.Controls.Add(this.bnEdit);
            this.Controls.Add(this.bnAdd);
            this.Controls.Add(this.dataGridViewStock);
            this.MinimumSize = new System.Drawing.Size(815, 502);
            this.Name = "StockUI";
            this.ShowIcon = false;
            this.Text = "Stock";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewStock;
        private System.Windows.Forms.Button bnDelete;
        private System.Windows.Forms.Button bnEdit;
        private System.Windows.Forms.Button bnAdd;
    }
}