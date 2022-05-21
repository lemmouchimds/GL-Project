namespace GLMainProject.UI.Docs
{
    partial class DocsUI
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
            this.bnDelete = new System.Windows.Forms.Button();
            this.bnDetail = new System.Windows.Forms.Button();
            this.bnAdd = new System.Windows.Forms.Button();
            this.dataGridViewDocs = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocs)).BeginInit();
            this.SuspendLayout();
            // 
            // bnDelete
            // 
            this.bnDelete.Location = new System.Drawing.Point(258, 10);
            this.bnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnDelete.Name = "bnDelete";
            this.bnDelete.Size = new System.Drawing.Size(112, 35);
            this.bnDelete.TabIndex = 20;
            this.bnDelete.Text = "Supprimer";
            this.bnDelete.UseVisualStyleBackColor = true;
            this.bnDelete.Click += new System.EventHandler(this.bnDelete_Click);
            // 
            // bnDetail
            // 
            this.bnDetail.Location = new System.Drawing.Point(137, 10);
            this.bnDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnDetail.Name = "bnDetail";
            this.bnDetail.Size = new System.Drawing.Size(112, 35);
            this.bnDetail.TabIndex = 21;
            this.bnDetail.Text = "Detail";
            this.bnDetail.UseVisualStyleBackColor = true;
            this.bnDetail.Click += new System.EventHandler(this.bnDetail_Click);
            // 
            // bnAdd
            // 
            this.bnAdd.Location = new System.Drawing.Point(15, 10);
            this.bnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnAdd.Name = "bnAdd";
            this.bnAdd.Size = new System.Drawing.Size(112, 35);
            this.bnAdd.TabIndex = 22;
            this.bnAdd.Text = "Ajouter";
            this.bnAdd.UseVisualStyleBackColor = true;
            this.bnAdd.Click += new System.EventHandler(this.bnAdd_Click);
            // 
            // dataGridViewDocs
            // 
            this.dataGridViewDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDocs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Customer,
            this.Date,
            this.PaymentDate});
            this.dataGridViewDocs.Location = new System.Drawing.Point(-2, 69);
            this.dataGridViewDocs.Name = "dataGridViewDocs";
            this.dataGridViewDocs.RowHeadersWidth = 62;
            this.dataGridViewDocs.RowTemplate.Height = 28;
            this.dataGridViewDocs.Size = new System.Drawing.Size(850, 418);
            this.dataGridViewDocs.TabIndex = 23;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "CustomerNamesOnly.Name";
            this.Customer.HeaderText = "Client";
            this.Customer.MinimumWidth = 8;
            this.Customer.Name = "Customer";
            this.Customer.Width = 150;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date de l\'operation";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            this.Date.Width = 150;
            // 
            // PaymentDate
            // 
            this.PaymentDate.DataPropertyName = "PaymentDate";
            this.PaymentDate.HeaderText = "Date de paiment";
            this.PaymentDate.MinimumWidth = 8;
            this.PaymentDate.Name = "PaymentDate";
            this.PaymentDate.Width = 150;
            // 
            // DocsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 486);
            this.Controls.Add(this.dataGridViewDocs);
            this.Controls.Add(this.bnDelete);
            this.Controls.Add(this.bnDetail);
            this.Controls.Add(this.bnAdd);
            this.Name = "DocsUI";
            this.ShowIcon = false;
            this.Text = "Documents";
            this.Load += new System.EventHandler(this.DocsUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnDelete;
        private System.Windows.Forms.Button bnDetail;
        private System.Windows.Forms.Button bnAdd;
        private System.Windows.Forms.DataGridView dataGridViewDocs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDate;
    }
}