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
            var id = SelectedClientID();
            if (id < 0)
            {
                return;
            }

            Controller.DeleteClient(id);
            refreshGrid();
        }

        private void bnEdit_Click(object sender, EventArgs e)
        {
            var edit = new AgentDeVente.AddEditClient();
            
        }

        /// <summary>
        /// To know if there is only one row selected
        /// </summary>
        /// <returns>true if one row is selected, else it's false</returns>
        private bool IsOneRowSelected()
        {
            return dataGridViewClient.SelectedRows.Count == 1;
        }

        private int SelectedClientID()
        {
            if (!IsOneRowSelected())
            {
                MessageBox.Show("Selectionne une cellule.");
                return -1;
            }

            dynamic result = dataGridViewClient.SelectedRows[0].DataBoundItem;
            int ID = result.ID;
            

            return ID;
        }
    }
}
