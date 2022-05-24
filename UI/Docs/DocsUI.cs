using System;
using System.Windows.Forms;

namespace GLMainProject.UI.Docs
{
    public partial class DocsUI : Form
    {
        public DocsUI()
        {
            InitializeComponent();
        }

        private void bnAdd_Click(object sender, EventArgs e)
        {
            using (var newDocs = new AddDoc()
            {
                CurrentDoc = new Document() { Date = DateTime.Now, PaymentDate = DateTime.Now }
            })
            {
                if (newDocs.ShowDialog() == DialogResult.OK)
                {
                    Controller.AddDocument(newDocs.CurrentDoc);
                    refreshGrid();
                }
            }
        }

        private void bnDetail_Click(object sender, EventArgs e)
        {
            if (dataGridViewDocs.SelectedRows.Count <= 0)
                return;
            var currentDoc = dataGridViewDocs.SelectedRows[0].DataBoundItem as Dto.DocsDto;
            if (currentDoc == null)
                return;

            var doc = Controller.GetDocById(currentDoc.ID);
            if (doc == null)
                return;

            using (var newDoc = new AddDoc()
            {
                CurrentDoc = doc
            })
            {
                if (newDoc.ShowDialog() == DialogResult.OK)
                {
                    Controller.EditDocument(newDoc.CurrentDoc);
                    refreshGrid();
                }
            }
        }

        private void bnDelete_Click(object sender, EventArgs e)
        {
            if (!IsOneSelected())
                return;
            var currentDoc = dataGridViewDocs.SelectedRows[0].DataBoundItem as Dto.DocsDto;
            if (currentDoc == null)
                return;

            var dialogResult = MessageBox.Show($"Voulez-vous vraiment supprimer ce document ?", "Attention!"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes && Controller.DeleteDocument(currentDoc.ID))
            {
                refreshGrid();
            }

        }

        private void refreshGrid()
        {
            dataGridViewDocs.DataSource = Controller.ListAllDocs();
        }

        private void DocsUI_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }
        private bool IsOneSelected()
        {
            return dataGridViewDocs.SelectedCells.Count <= 0 || dataGridViewDocs.SelectedCells.Count > 1;
        }
    }
}
