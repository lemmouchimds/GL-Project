using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GLMainProject.AgentDeVente
{
    public partial class StockUI : Form
    {
        public StockUI()
        {
            InitializeComponent();
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

        
    }
}
