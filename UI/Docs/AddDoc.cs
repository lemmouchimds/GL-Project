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

        private void AddDoc_Load(object sender, EventArgs e)
        {
            tbRef.DataBindings.Add("text", CurrentDoc, "Reference");
            dtDate.DataBindings.Add("value", CurrentDoc, "Date");
            dtPayment.DataBindings.Add("value", CurrentDoc, "PaymentDate");
            

            cbCust.Items.AddRange(Controller.GetCustomerNames().ToArray());
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
                    Controller.AddDocDetail(newCust.CurrentDocDetail);
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
            var currentDetailDoc = dataGridViewDetailDoc.SelectedRows[0].DataBoundItem as Dto.DocsDetailDto;
            if (currentDetailDoc == null)
                return;

            var detailDoc = Controller.GetDetailDocById(currentDetailDoc.ID);
            if (detailDoc == null)
                return;

            using (var newDetailDoc = new AddDetailDoc()
            {
                CurrentDocDetail = detailDoc
            })
            {
                if (newDetailDoc.ShowDialog() == DialogResult.OK)
                {
                    Controller.EditDetailDoc(newDetailDoc.CurrentDocDetail);
                    refreshGrid();
                }
            }
        }

        private void bnDelete_Click(object sender, EventArgs e)
        {
            if (!IsOneSelected())
                return;
            var currentCust = dataGridViewDetailDoc.SelectedRows[0].DataBoundItem as Dto.DocsDetailDto;
            if (currentCust == null)
                return;

            var dialogResult = MessageBox.Show($"Voulez-vous vraiment supprimer le document '{currentCust.Label}'?", "Attention!"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes && Controller.DeleteDetailDoc(currentCust.ID))
            {
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
