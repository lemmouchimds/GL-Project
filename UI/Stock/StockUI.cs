using System;
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
            using (var newProduct = new UI.Stock.AddStock() 
            {
                CurrentInventory = new Inventory() { DatePeremption = DateTime.Now, DateProduction = DateTime.Now }
            })
            {
                if (newProduct.ShowDialog() == DialogResult.OK) //todo: there's a problem here, i can't add
                {
                    Controller.AddStock(newProduct.CurrentInventory);
                    refreshGrid();
                }
            }
        }

        private void refreshGrid()
        {
            dataGridViewStock.DataSource = Controller.ListAllInventories();
        }

        private void bnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewStock.SelectedRows.Count <= 0)
                return;
            var currentInventory = dataGridViewStock.SelectedRows[0].DataBoundItem as Dto.StockDto;
            if (currentInventory == null)
                return;

            var prod = Controller.GetStockById(currentInventory.ID);
            if (prod == null)
                return;

            using (var newInventory = new UI.Stock.AddStock()
            {
                CurrentInventory = prod
            })
            {
                if (newInventory.ShowDialog() == DialogResult.OK)
                {
                    Controller.EditInventory(newInventory.CurrentInventory);
                    refreshGrid();
                }
            }
        }

        private void bnDelete_Click(object sender, EventArgs e)
        {
            if (!IsOneSelected())
                return;
            var currentProduct = dataGridViewStock.SelectedRows[0].DataBoundItem as Dto.StockDto;
            if (currentProduct == null)
                return;

            var dialogResult = MessageBox.Show($"Voulez-vous vraiment supprimer le produit '{currentProduct.Product}' ?", "Attention!"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes && Controller.DeleteInventory(currentProduct.ID))
            {
                refreshGrid();
            }
        }

        private bool IsOneSelected()
        {
            return dataGridViewStock.SelectedCells.Count <= 0 || dataGridViewStock.SelectedCells.Count > 1;
        }

        private void StockUI_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }
    }
}
