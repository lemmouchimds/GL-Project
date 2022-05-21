namespace GLMainProject.UI.Docs
{
    partial class AddDoc
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
            this.lblRef = new System.Windows.Forms.Label();
            this.lblCust = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.dtPayment = new System.Windows.Forms.DateTimePicker();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbRef = new System.Windows.Forms.TextBox();
            this.cbCust = new System.Windows.Forms.ComboBox();
            this.bnDetails = new System.Windows.Forms.Button();
            this.bnOK = new System.Windows.Forms.Button();
            this.bnCancel = new System.Windows.Forms.Button();
            this.cbPayed = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Location = new System.Drawing.Point(12, 9);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(84, 20);
            this.lblRef.TabIndex = 0;
            this.lblRef.Text = "Reference";
            // 
            // lblCust
            // 
            this.lblCust.AutoSize = true;
            this.lblCust.Location = new System.Drawing.Point(12, 45);
            this.lblCust.Name = "lblCust";
            this.lblCust.Size = new System.Drawing.Size(49, 20);
            this.lblCust.TabIndex = 1;
            this.lblCust.Text = "Client";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 79);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(143, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date de l\'operation";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(12, 143);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(103, 20);
            this.lblTotalAmount.TabIndex = 3;
            this.lblTotalAmount.Text = "Total a paiyer";
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Location = new System.Drawing.Point(12, 111);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(127, 20);
            this.lblPaymentDate.TabIndex = 4;
            this.lblPaymentDate.Text = "Date de paiment";
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(172, 79);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(272, 26);
            this.dtDate.TabIndex = 5;
            // 
            // dtPayment
            // 
            this.dtPayment.Location = new System.Drawing.Point(172, 111);
            this.dtPayment.Name = "dtPayment";
            this.dtPayment.Size = new System.Drawing.Size(272, 26);
            this.dtPayment.TabIndex = 6;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(172, 143);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(272, 26);
            this.tbTotal.TabIndex = 7;
            // 
            // tbRef
            // 
            this.tbRef.Location = new System.Drawing.Point(172, 12);
            this.tbRef.Name = "tbRef";
            this.tbRef.Size = new System.Drawing.Size(272, 26);
            this.tbRef.TabIndex = 8;
            // 
            // cbCust
            // 
            this.cbCust.FormattingEnabled = true;
            this.cbCust.Location = new System.Drawing.Point(172, 45);
            this.cbCust.Name = "cbCust";
            this.cbCust.Size = new System.Drawing.Size(272, 28);
            this.cbCust.TabIndex = 9;
            // 
            // bnDetails
            // 
            this.bnDetails.Location = new System.Drawing.Point(12, 346);
            this.bnDetails.Name = "bnDetails";
            this.bnDetails.Size = new System.Drawing.Size(107, 35);
            this.bnDetails.TabIndex = 10;
            this.bnDetails.Text = "Voir detail";
            this.bnDetails.UseVisualStyleBackColor = true;
            // 
            // bnOK
            // 
            this.bnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnOK.Location = new System.Drawing.Point(241, 346);
            this.bnOK.Name = "bnOK";
            this.bnOK.Size = new System.Drawing.Size(101, 35);
            this.bnOK.TabIndex = 11;
            this.bnOK.Text = "OK";
            this.bnOK.UseVisualStyleBackColor = true;
            // 
            // bnCancel
            // 
            this.bnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnCancel.Location = new System.Drawing.Point(348, 346);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(101, 35);
            this.bnCancel.TabIndex = 12;
            this.bnCancel.Text = "Annuler";
            this.bnCancel.UseVisualStyleBackColor = true;
            // 
            // cbPayed
            // 
            this.cbPayed.AutoSize = true;
            this.cbPayed.Location = new System.Drawing.Point(172, 175);
            this.cbPayed.Name = "cbPayed";
            this.cbPayed.Size = new System.Drawing.Size(78, 24);
            this.cbPayed.TabIndex = 13;
            this.cbPayed.Text = "Paiyer";
            this.cbPayed.UseVisualStyleBackColor = true;
            // 
            // AddDoc
            // 
            this.AcceptButton = this.bnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bnCancel;
            this.ClientSize = new System.Drawing.Size(461, 393);
            this.Controls.Add(this.cbPayed);
            this.Controls.Add(this.bnCancel);
            this.Controls.Add(this.bnOK);
            this.Controls.Add(this.bnDetails);
            this.Controls.Add(this.cbCust);
            this.Controls.Add(this.tbRef);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.dtPayment);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.lblPaymentDate);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCust);
            this.Controls.Add(this.lblRef);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(483, 344);
            this.Name = "AddDoc";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Document";
            this.Load += new System.EventHandler(this.AddDoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.Label lblCust;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.DateTimePicker dtPayment;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbRef;
        private System.Windows.Forms.ComboBox cbCust;
        private System.Windows.Forms.Button bnDetails;
        private System.Windows.Forms.Button bnOK;
        private System.Windows.Forms.Button bnCancel;
        private System.Windows.Forms.CheckBox cbPayed;
    }
}