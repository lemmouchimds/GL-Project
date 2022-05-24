namespace GLMainProject.UI.Docs
{
    partial class AddDetailDoc
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
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblLabel = new System.Windows.Forms.Label();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.nupQuantity = new System.Windows.Forms.NumericUpDown();
            this.tbLabel = new System.Windows.Forms.TextBox();
            this.bnCancel = new System.Windows.Forms.Button();
            this.bnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(27, 32);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(59, 20);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Produit";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(27, 79);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(73, 20);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantitie";
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(27, 126);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(48, 20);
            this.lblLabel.TabIndex = 2;
            this.lblLabel.Text = "Label";
            // 
            // cbProduct
            // 
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(162, 32);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(310, 28);
            this.cbProduct.TabIndex = 3;
            // 
            // nupQuantity
            // 
            this.nupQuantity.Location = new System.Drawing.Point(162, 79);
            this.nupQuantity.Name = "nupQuantity";
            this.nupQuantity.Size = new System.Drawing.Size(310, 26);
            this.nupQuantity.TabIndex = 4;
            // 
            // tbLabel
            // 
            this.tbLabel.Location = new System.Drawing.Point(162, 120);
            this.tbLabel.Name = "tbLabel";
            this.tbLabel.Size = new System.Drawing.Size(310, 26);
            this.tbLabel.TabIndex = 5;
            // 
            // bnCancel
            // 
            this.bnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnCancel.Location = new System.Drawing.Point(359, 181);
            this.bnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(112, 35);
            this.bnCancel.TabIndex = 25;
            this.bnCancel.Text = "Annuler";
            this.bnCancel.UseVisualStyleBackColor = true;
            // 
            // bnOK
            // 
            this.bnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bnOK.Location = new System.Drawing.Point(238, 181);
            this.bnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnOK.Name = "bnOK";
            this.bnOK.Size = new System.Drawing.Size(112, 35);
            this.bnOK.TabIndex = 26;
            this.bnOK.Text = "OK";
            this.bnOK.UseVisualStyleBackColor = true;
            // 
            // AddDetailDoc
            // 
            this.AcceptButton = this.bnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bnCancel;
            this.ClientSize = new System.Drawing.Size(484, 230);
            this.Controls.Add(this.bnCancel);
            this.Controls.Add(this.bnOK);
            this.Controls.Add(this.tbLabel);
            this.Controls.Add(this.nupQuantity);
            this.Controls.Add(this.cbProduct);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblProduct);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(506, 286);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(506, 286);
            this.Name = "AddDetailDoc";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Detail Document";
            this.Load += new System.EventHandler(this.AddDetailDoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.NumericUpDown nupQuantity;
        private System.Windows.Forms.TextBox tbLabel;
        private System.Windows.Forms.Button bnCancel;
        private System.Windows.Forms.Button bnOK;
    }
}