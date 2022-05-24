using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GLMainProject.UI.Docs
{
    public partial class DetailDoc : Form
    {
        public DetailDoc()
        {
            InitializeComponent();
        }

        public int ProductID;

        private void DetailDoc_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void bnAdd_Click(object sender, EventArgs e)
        {
            using (var newCust = new AddDetailDoc()
            {
                CurrentDocDetail = new DocumentDetail()
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
            dataGridViewDetailDoc.DataSource = Controller.ListAllDetailDocs(ProductID);
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
    }
}
