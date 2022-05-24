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
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.dtPayment = new System.Windows.Forms.DateTimePicker();
            this.tbRef = new System.Windows.Forms.TextBox();
            this.cbCust = new System.Windows.Forms.ComboBox();
            this.bnOK = new System.Windows.Forms.Button();
            this.bnCancel = new System.Windows.Forms.Button();
            this.bnDelete = new System.Windows.Forms.Button();
            this.bnEdit = new System.Windows.Forms.Button();
            this.bnAdd = new System.Windows.Forms.Button();
            this.dataGridViewDetailDoc = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.bnPay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailDoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Location = new System.Drawing.Point(19, 54);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(84, 20);
            this.lblRef.TabIndex = 0;
            this.lblRef.Text = "Reference";
            // 
            // lblCust
            // 
            this.lblCust.AutoSize = true;
            this.lblCust.Location = new System.Drawing.Point(19, 90);
            this.lblCust.Name = "lblCust";
            this.lblCust.Size = new System.Drawing.Size(49, 20);
            this.lblCust.TabIndex = 1;
            this.lblCust.Text = "Client";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(19, 124);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(143, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date de l\'operation";
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Location = new System.Drawing.Point(15, 82);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(127, 20);
            this.lblPaymentDate.TabIndex = 4;
            this.lblPaymentDate.Text = "Date de paiment";
            // 
            // dtDate
            // 
            this.dtDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDate.Location = new System.Drawing.Point(179, 124);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(463, 26);
            this.dtDate.TabIndex = 5;
            // 
            // dtPayment
            // 
            this.dtPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPayment.Enabled = false;
            this.dtPayment.Location = new System.Drawing.Point(177, 82);
            this.dtPayment.Name = "dtPayment";
            this.dtPayment.Size = new System.Drawing.Size(285, 26);
            this.dtPayment.TabIndex = 6;
            // 
            // tbRef
            // 
            this.tbRef.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRef.Location = new System.Drawing.Point(179, 57);
            this.tbRef.Name = "tbRef";
            this.tbRef.Size = new System.Drawing.Size(463, 26);
            this.tbRef.TabIndex = 8;
            // 
            // cbCust
            // 
            this.cbCust.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCust.FormattingEnabled = true;
            this.cbCust.Location = new System.Drawing.Point(179, 90);
            this.cbCust.Name = "cbCust";
            this.cbCust.Size = new System.Drawing.Size(463, 28);
            this.cbCust.TabIndex = 9;
            // 
            // bnOK
            // 
            this.bnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bnOK.Location = new System.Drawing.Point(972, 658);
            this.bnOK.Name = "bnOK";
            this.bnOK.Size = new System.Drawing.Size(101, 35);
            this.bnOK.TabIndex = 11;
            this.bnOK.Text = "OK";
            this.bnOK.UseVisualStyleBackColor = true;
            this.bnOK.Click += new System.EventHandler(this.bnOK_Click);
            // 
            // bnCancel
            // 
            this.bnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnCancel.Location = new System.Drawing.Point(1079, 658);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(101, 35);
            this.bnCancel.TabIndex = 12;
            this.bnCancel.Text = "Annuler";
            this.bnCancel.UseVisualStyleBackColor = true;
            // 
            // bnDelete
            // 
            this.bnDelete.Location = new System.Drawing.Point(261, 38);
            this.bnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnDelete.Name = "bnDelete";
            this.bnDelete.Size = new System.Drawing.Size(112, 35);
            this.bnDelete.TabIndex = 27;
            this.bnDelete.Text = "Supprimer";
            this.bnDelete.UseVisualStyleBackColor = true;
            this.bnDelete.Click += new System.EventHandler(this.bnDelete_Click);
            // 
            // bnEdit
            // 
            this.bnEdit.Location = new System.Drawing.Point(140, 38);
            this.bnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnEdit.Name = "bnEdit";
            this.bnEdit.Size = new System.Drawing.Size(112, 35);
            this.bnEdit.TabIndex = 28;
            this.bnEdit.Text = "Modifier";
            this.bnEdit.UseVisualStyleBackColor = true;
            this.bnEdit.Click += new System.EventHandler(this.bnEdit_Click);
            // 
            // bnAdd
            // 
            this.bnAdd.Location = new System.Drawing.Point(18, 38);
            this.bnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnAdd.Name = "bnAdd";
            this.bnAdd.Size = new System.Drawing.Size(112, 35);
            this.bnAdd.TabIndex = 29;
            this.bnAdd.Text = "Ajouter";
            this.bnAdd.UseVisualStyleBackColor = true;
            this.bnAdd.Click += new System.EventHandler(this.bnAdd_Click);
            // 
            // dataGridViewDetailDoc
            // 
            this.dataGridViewDetailDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDetailDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetailDoc.Location = new System.Drawing.Point(0, 95);
            this.dataGridViewDetailDoc.Name = "dataGridViewDetailDoc";
            this.dataGridViewDetailDoc.RowHeadersWidth = 62;
            this.dataGridViewDetailDoc.RowTemplate.Height = 28;
            this.dataGridViewDetailDoc.Size = new System.Drawing.Size(1159, 328);
            this.dataGridViewDetailDoc.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Etat :";
            // 
            // bnPay
            // 
            this.bnPay.Location = new System.Drawing.Point(19, 114);
            this.bnPay.Name = "bnPay";
            this.bnPay.Size = new System.Drawing.Size(237, 37);
            this.bnPay.TabIndex = 34;
            this.bnPay.Text = "Payer la facture";
            this.bnPay.UseVisualStyleBackColor = true;
            this.bnPay.Click += new System.EventHandler(this.bnPay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbRef);
            this.groupBox1.Controls.Add(this.lblRef);
            this.groupBox1.Controls.Add(this.cbCust);
            this.groupBox1.Controls.Add(this.lblCust);
            this.groupBox1.Controls.Add(this.dtDate);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 178);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information General";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtPayment);
            this.groupBox2.Controls.Add(this.lblPaymentDate);
            this.groupBox2.Controls.Add(this.bnPay);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(697, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 178);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dataGridViewDetailDoc);
            this.groupBox3.Controls.Add(this.bnAdd);
            this.groupBox3.Controls.Add(this.bnEdit);
            this.groupBox3.Controls.Add(this.bnDelete);
            this.groupBox3.Location = new System.Drawing.Point(16, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1164, 429);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Details de la facture";
            // 
            // AddDoc
            // 
            this.AcceptButton = this.bnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bnCancel;
            this.ClientSize = new System.Drawing.Size(1192, 705);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bnCancel);
            this.Controls.Add(this.bnOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(483, 344);
            this.Name = "AddDoc";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Document";
            this.Load += new System.EventHandler(this.AddDoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailDoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.Label lblCust;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.DateTimePicker dtPayment;
        private System.Windows.Forms.TextBox tbRef;
        private System.Windows.Forms.ComboBox cbCust;
        private System.Windows.Forms.Button bnOK;
        private System.Windows.Forms.Button bnCancel;
        private System.Windows.Forms.Button bnDelete;
        private System.Windows.Forms.Button bnEdit;
        private System.Windows.Forms.Button bnAdd;
        private System.Windows.Forms.DataGridView dataGridViewDetailDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bnPay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}