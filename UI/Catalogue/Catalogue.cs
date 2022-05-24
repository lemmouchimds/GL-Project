using System;
using System.Windows.Forms;

namespace GLMainProject
{
    public partial class Catalogue : Form
    {
        public Catalogue()
        {
            InitializeComponent();
        }

        
        private void Catalogue_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void bnAdd_Click(object sender, EventArgs e)
        {
            using (var newProduct = new AgentDeVente.AddCatalogue()
            {
                CurrentProduct = new Product()
            })
            {
                if (newProduct.ShowDialog() == DialogResult.OK)
                {
                    Controller.AddProduit(newProduct.CurrentProduct);
                    refreshGrid();
                }
            }
        }

        private void bnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewCatalogue.SelectedRows.Count <= 0)
                return;
            var currentProduct = dataGridViewCatalogue.SelectedRows[0].DataBoundItem as Dto.ProductDto;
            if (currentProduct == null)
                return;

            var cust = Controller.GetProductById(currentProduct.ID);
            if (cust == null)
                return;

            using (var newProduct = new AgentDeVente.AddCatalogue()
            {
                CurrentProduct = cust
            })
            {
                if (newProduct.ShowDialog() == DialogResult.OK)
                {
                    Controller.EditProduct(newProduct.CurrentProduct);
                    refreshGrid();
                }
            }
        }

        private void bnDelete_Click(object sender, EventArgs e)
        {
            if (!IsOneSelected())
                return;
            var currentProduct = dataGridViewCatalogue.SelectedRows[0].DataBoundItem as Dto.ProductDto;
            if (currentProduct == null)
                return;

            var dialogResult = MessageBox.Show($"Voulez-vous vraiment supprimer le produit '{currentProduct.Designation}'?", "Attention!"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes && Controller.DeleteProduit(currentProduct.ID))
            {
                refreshGrid();
            }
        }

        private bool IsOneSelected()
        {
            return dataGridViewCatalogue.SelectedCells.Count <= 0 || dataGridViewCatalogue.SelectedCells.Count > 1;
        }

        private void bnSearsh_Click(object sender, EventArgs e)
        {
             if(string.IsNullOrEmpty(tbSearsh.Text))
             {
                refreshGrid();
                return;
             }

            dataGridViewCatalogue.DataSource = Controller.Search(tbSearsh.Text);

        }

        private void refreshGrid()
        {
            
            dataGridViewCatalogue.DataSource = Controller.ListAllProducts();
            tbSearsh.Text = string.Empty;
        }

    }
}
