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
            add.ShowDialog();
            refreshGrid();
        }

        private void refreshGrid()
        {
            //MessageBox.Show("REFRESH"); //todo: remove this
            dataGridViewClient.DataSource = Controller.Clients;
        }

        private void ClientUI_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void bnDelete_Click(object sender, EventArgs e)
        {
            //Controller.DeleteClient(SelectedClient());
        }

        private void bnEdit_Click(object sender, EventArgs e)
        {
            var edit = new AgentDeVente.AddEditClient();
            
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
