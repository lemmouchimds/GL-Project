using System;
using System.Windows.Forms;

namespace GLMainProject.AgentDeVente
{
    public partial class ClientUI : Form
    {
        public ClientUI()
        {
            InitializeComponent();
        }

        private void bnAdd_Click(object sender, EventArgs e)
        {
            var add = new AgentDeVente.AddEditClient();
            add.Customer = new Customer();
            add.ShowDialog();
            refreshGrid();
        }

        private void refreshGrid()
        {
            dataGridViewClient.DataSource = Controller.Clients;
        }

        private void ClientUI_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void bnDelete_Click(object sender, EventArgs e)
        {
            //todo: delete customers
            var cust = SelectedClient() as Customer;
            if (cust == null)
            { return; }

            Controller.DeleteClient(cust.ID);
            refreshGrid();
        }

        private void bnEdit_Click(object sender, EventArgs e)
        {
            var edit = new AgentDeVente.AddEditClient();
            edit.Customer = SelectedClient() as Customer; //todo: make this work
            edit.ShowDialog();
            refreshGrid();
        }


        private bool IsOneSelected()
        {
            return dataGridViewClient.SelectedCells.Count <= 0 || dataGridViewClient.SelectedCells.Count > 1;
        }

        private object SelectedClient()
        {
            if (!IsOneSelected())
            {
                MessageBox.Show("Selectionne une cellule.");
                return null;
            }

            var result = dataGridViewClient.SelectedCells[0];
            

            return result;
        }
    }
}
