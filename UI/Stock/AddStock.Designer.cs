namespace GLMainProject.UI.Stock
{
    partial class AddStock
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
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblDateProduction = new System.Windows.Forms.Label();
            this.lblDatePeremption = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.bnCancel = new System.Windows.Forms.Button();
            this.bnOK = new System.Windows.Forms.Button();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.dtDateProduction = new System.Windows.Forms.DateTimePicker();
            this.dtDatePeremption = new System.Windows.Forms.DateTimePicker();
            this.nupQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(23, 29);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(59, 20);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Produit";
            // 
            // lblDateProduction
            // 
            this.lblDateProduction.AutoSize = true;
            this.lblDateProduction.Location = new System.Drawing.Point(23, 67);
            this.lblDateProduction.Name = "lblDateProduction";
            this.lblDateProduction.Size = new System.Drawing.Size(124, 20);
            this.lblDateProduction.TabIndex = 1;
            this.lblDateProduction.Text = "Date Production";
            // 
            // lblDatePeremption
            // 
            this.lblDatePeremption.AutoSize = true;
            this.lblDatePeremption.Location = new System.Drawing.Point(23, 111);
            this.lblDatePeremption.Name = "lblDatePeremption";
            this.lblDatePeremption.Size = new System.Drawing.Size(129, 20);
            this.lblDatePeremption.TabIndex = 2;
            this.lblDatePeremption.Text = "Date Peremption";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(23, 150);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(73, 20);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantitie";
            // 
            // bnCancel
            // 
            this.bnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnCancel.Location = new System.Drawing.Point(401, 277);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(101, 35);
            this.bnCancel.TabIndex = 14;
            this.bnCancel.Text = "Annuler";
            this.bnCancel.UseVisualStyleBackColor = true;
            // 
            // bnOK
            // 
            this.bnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bnOK.Location = new System.Drawing.Point(294, 277);
            this.bnOK.Name = "bnOK";
            this.bnOK.Size = new System.Drawing.Size(101, 35);
            this.bnOK.TabIndex = 13;
            this.bnOK.Text = "OK";
            this.bnOK.UseVisualStyleBackColor = true;
            this.bnOK.Click += new System.EventHandler(this.bnOK_Click);
            // 
            // cbProduct
            // 
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(235, 29);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(267, 28);
            this.cbProduct.TabIndex = 15;
            // 
            // dtDateProduction
            // 
            this.dtDateProduction.Location = new System.Drawing.Point(235, 67);
            this.dtDateProduction.Name = "dtDateProduction";
            this.dtDateProduction.Size = new System.Drawing.Size(267, 26);
            this.dtDateProduction.TabIndex = 16;
            // 
            // dtDatePeremption
            // 
            this.dtDatePeremption.Location = new System.Drawing.Point(235, 106);
            this.dtDatePeremption.Name = "dtDatePeremption";
            this.dtDatePeremption.Size = new System.Drawing.Size(267, 26);
            this.dtDatePeremption.TabIndex = 17;
            // 
            // nupQuantity
            // 
            this.nupQuantity.Location = new System.Drawing.Point(235, 144);
            this.nupQuantity.Name = "nupQuantity";
            this.nupQuantity.Size = new System.Drawing.Size(267, 26);
            this.nupQuantity.TabIndex = 18;
            // 
            // AddStock
            // 
            this.AcceptButton = this.bnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bnCancel;
            this.ClientSize = new System.Drawing.Size(514, 324);
            this.Controls.Add(this.nupQuantity);
            this.Controls.Add(this.dtDatePeremption);
            this.Controls.Add(this.dtDateProduction);
            this.Controls.Add(this.cbProduct);
            this.Controls.Add(this.bnCancel);
            this.Controls.Add(this.bnOK);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblDatePeremption);
            this.Controls.Add(this.lblDateProduction);
            this.Controls.Add(this.lblProduct);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(536, 380);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(536, 380);
            this.Name = "AddStock";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.AddStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblDateProduction;
        private System.Windows.Forms.Label lblDatePeremption;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button bnCancel;
        private System.Windows.Forms.Button bnOK;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.DateTimePicker dtDateProduction;
        private System.Windows.Forms.DateTimePicker dtDatePeremption;
        private System.Windows.Forms.NumericUpDown nupQuantity;
    }
}