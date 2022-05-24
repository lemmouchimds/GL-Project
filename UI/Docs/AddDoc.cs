using System;
using System.Windows.Forms;

namespace GLMainProject.UI.Docs
{
    public partial class AddDoc : Form
    {
        public AddDoc()
        {
            InitializeComponent();
        }

        public Document CurrentDoc { get; set; }
        public int CurrentDocID { get; set; }

        private void AddDoc_Load(object sender, EventArgs e)
        {
            tbRef.DataBindings.Add("text", CurrentDoc, "Reference");
            dtDate.DataBindings.Add("value", CurrentDoc, "Date");
            dtPayment.DataBindings.Add("value", CurrentDoc, "PaymentDate");

            cbCust.DataSource = Controller.ListAllCusts();
            cbCust.ValueMember = "ID";
            cbCust.DisplayMember = "Designation";
            cbCust.DataBindings.Add("SelectedValue", CurrentDoc, nameof(CurrentDoc.CustomerID));

            //cbCust.Items.AddRange(Controller.GetCustomerNames().ToArray());
            refreshGrid();
        }

        private void bnOK_Click(object sender, EventArgs e)
        {
            ValidateChildren();
        }

        private void bnAdd_Click(object sender, EventArgs e)
        {
            using (var newCust = new AddDetailDoc()
            {
                CurrentDocDetail = new DocumentDetail() { DocumentID = CurrentDoc.ID, Document = CurrentDoc }
            })
            {
                if (newCust.ShowDialog() == DialogResult.OK)
                {
                    CurrentDoc.DocumentDetails.Add(newCust.CurrentDocDetail);
                    refreshGrid();
                }
            }
        }

        private void refreshGrid()
        {
            dataGridViewDetailDoc.DataSource = Controller.ListAllDetailDocs(CurrentDoc.ID);
        }

        private void bnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewDetailDoc.SelectedRows.Count <= 0)
                return;
            var currentDetailDoc = dataGridViewDetailDoc.SelectedRows[0].DataBoundItem as DocumentDetail;
            if (currentDetailDoc == null)
                return;


            using (var newDetailDoc = new AddDetailDoc()
            {
                CurrentDocDetail = currentDetailDoc
            })
            {
                if (newDetailDoc.ShowDialog() == DialogResult.OK)
                {
                    refreshGrid();
                }
            }
        }

        private void bnDelete_Click(object sender, EventArgs e)
        {
            if (!IsOneSelected())
                return;
            var currentCust = dataGridViewDetailDoc.SelectedRows[0].DataBoundItem as DocumentDetail;
            if (currentCust == null)
                return;

            var dialogResult = MessageBox.Show($"Voulez-vous vraiment supprimer le document '{currentCust.Label}'?", "Attention!"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {
                CurrentDoc.DocumentDetails.Remove(currentCust);
                refreshGrid();
            }
        }

        private bool IsOneSelected()
        {
            return dataGridViewDetailDoc.SelectedCells.Count <= 0 || dataGridViewDetailDoc.SelectedCells.Count > 1;
        }

        private void bnPay_Click(object sender, EventArgs e)
        {

        }
    }
}
