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
            
        }

        private void refreshGrid()
        {
            dataGridViewClient.DataSource = Controller.ListAllCusts();
        }

        private void ClientUI_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }

        //private void bnDelete_Click(object sender, EventArgs e)
        //{
        //    if (!IsOneSelected())
        //        return;
        //    var currentCust = dataGridViewClient.SelectedRows[0].DataBoundItem as CustomerDto;
        //    if (currentCust == null)
        //        return;
            
        //    var dialogResult = MessageBox.Show($"Voulez-vous vraiment supprimer le client '{currentCust.Designation}'?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //    if (dialogResult == DialogResult.Yes && Controller.DeleteUser(currentCust.ID))
        //    {
        //        refreshGrid();
        //    }
        //}

        //private void bnEdit_Click(object sender, EventArgs e)
        //{
        //    if (dataGridViewClient.SelectedRows.Count <= 0)
        //        return;
        //    var currentCust = dataGridViewClient.SelectedRows[0].DataBoundItem as CustomerDto;
        //    if (currentCust == null)
        //        return;

        //    var cust = Controller.GetCustById(currentCust.ID);
        //    if (cust== null)
        //        return;

        //    using (var newCust = new AddEditClient()
        //    {
        //        CurrentCust = cust
        //    })
        //    {
        //        if (newCust.ShowDialog() == DialogResult.OK)
        //        {
        //            Controller.EditClient(newCust.CurrentCust);
        //            refreshGrid();
        //        }
        //    }
        //}


        private bool IsOneSelected()
        {
            return dataGridViewClient.SelectedCells.Count <= 0 || dataGridViewClient.SelectedCells.Count > 1;
        }

        //private bool SelectedClient()
        //{
        //    if (!IsOneSelected())
        //    {
        //        MessageBox.Show("Selectionne une cellule.");
        //        return false;
        //    }

        //    //var result = dataGridViewClient.SelectedCells[0];
            
        //    return true;
        //}

        private void bnAdd_Click_1(object sender, EventArgs e)
        {
            using (var newCust = new AddEditClient()
            {
                CurrentCust = new Customer()
            })
            {
                if (newCust.ShowDialog() == DialogResult.OK)
                {
                    Controller.AddClient(newCust.CurrentCust);
                    refreshGrid();
                }
            }
        }

        private void bnDelete_Click_1(object sender, EventArgs e)
        {
            if (!IsOneSelected())
                return;
            var currentCust = dataGridViewClient.SelectedRows[0].DataBoundItem as CustomerDto;
            if (currentCust == null)
                return;

            var dialogResult = MessageBox.Show($"Voulez-vous vraiment supprimer le client '{currentCust.Designation}'?", "Attention!"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes && Controller.DeleteClient(currentCust.ID))
            {
                refreshGrid();
            }
        }

        private void bnEdit_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewClient.SelectedRows.Count <= 0)
                return;
            var currentCust = dataGridViewClient.SelectedRows[0].DataBoundItem as CustomerDto;
            if (currentCust == null)
                return;

            var cust = Controller.GetCustById(currentCust.ID);
            if (cust == null)
                return;

            using (var newCust = new AddEditClient()
            {
                CurrentCust = cust
            })
            {
                if (newCust.ShowDialog() == DialogResult.OK)
                {
                    Controller.EditClient(newCust.CurrentCust);
                    refreshGrid();
                }
            }
        }
    }
}
