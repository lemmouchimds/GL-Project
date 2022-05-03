using System;
using System.Windows.Forms;

namespace GLMainProject.AgentDeVente
{
    public partial class AddEditClient : Form
    {
        public AddEditClient()
        {
            InitializeComponent();
        }


        private void bnAjouter_Click(object sender, EventArgs e)
        {
            var result = new Client
            {
                Designation = tbDesignation.Text,
                Adress = tbAdress.Text,
                Email = tbEmail.Text,
                Responsable = tbResponsable.Text,
                IsRevendeur = cbRevenduer.Checked
            };

            //todo: uncomment this "Controller.AddClient(result);"
        }

        private void AddEditClient_Load(object sender, EventArgs e)
        {

        }
    }
}
