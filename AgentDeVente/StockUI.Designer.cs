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
            this.bnEdit = new System.Windows.Forms.Button();
            this.bnDelete = new System.Windows.Forms.Button();
            this.bnAdd = new System.Windows.Forms.Button();
            this.dataGridViewStock = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).BeginInit();
            this.SuspendLayout();
            // 
            // bnEdit
            // 
            this.bnEdit.Font = new System.Drawing.Font("Wingdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.bnEdit.Location = new System.Drawing.Point(85, 12);
            this.bnEdit.Name = "bnEdit";
            this.bnEdit.Size = new System.Drawing.Size(67, 56);
            this.bnEdit.TabIndex = 5;
            this.bnEdit.Text = "!";
            this.bnEdit.UseVisualStyleBackColor = true;
            // 
            // bnDelete
            // 
            this.bnDelete.Font = new System.Drawing.Font("Wingdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.bnDelete.Location = new System.Drawing.Point(158, 12);
            this.bnDelete.Name = "bnDelete";
            this.bnDelete.Size = new System.Drawing.Size(67, 56);
            this.bnDelete.TabIndex = 4;
            this.bnDelete.Text = "Ö";
            this.bnDelete.UseVisualStyleBackColor = true;
            // 
            // bnAdd
            // 
            this.bnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnAdd.Location = new System.Drawing.Point(12, 12);
            this.bnAdd.Name = "bnAdd";
            this.bnAdd.Size = new System.Drawing.Size(67, 56);
            this.bnAdd.TabIndex = 3;
            this.bnAdd.Text = "+";
            this.bnAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStock
            // 
            this.dataGridViewStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStock.Location = new System.Drawing.Point(12, 75);
            this.dataGridViewStock.Name = "dataGridViewStock";
            this.dataGridViewStock.RowHeadersWidth = 62;
            this.dataGridViewStock.RowTemplate.Height = 28;
            this.dataGridViewStock.Size = new System.Drawing.Size(769, 359);
            this.dataGridViewStock.TabIndex = 6;
            // 
            // StockUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 446);
            this.Controls.Add(this.dataGridViewStock);
            this.Controls.Add(this.bnEdit);
            this.Controls.Add(this.bnDelete);
            this.Controls.Add(this.bnAdd);
            this.MinimumSize = new System.Drawing.Size(815, 502);
            this.Name = "StockUI";
            this.Text = "Stock";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnEdit;
        private System.Windows.Forms.Button bnDelete;
        private System.Windows.Forms.Button bnAdd;
        private System.Windows.Forms.DataGridView dataGridViewStock;
    }
}