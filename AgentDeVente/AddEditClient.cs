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


        //private void bnAjouter_Click(object sender, EventArgs e)
        //{
        //}

        private void AddEditClient_Load(object sender, EventArgs e)
        {

        }

        private int errorCount;
        private void AddEditClient_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            errorProvider1.Clear();
            errorCount = 0;
            if (string.IsNullOrWhiteSpace(tbDesignation.Text))
            {
                errorProvider1.SetError(tbDesignation, "La désignation ne peux pas être vide.");
                errorCount++;
            }
            else
            {
                errorProvider1.SetError(tbDesignation, "");
            }

            if (errorCount > 0)
            {
                e.Cancel = true;
            }
        }

        private void bnOk_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
        
            
        }

        private void bnOk_Click(object sender, EventArgs e)
        {

            ValidateChildren();

            if(errorCount > 0)
            {
                DialogResult = DialogResult.None;
                return;
            }

            var result = new Client
            {
                Designation = tbDesignation.Text,
                Adress = tbAdress.Text,
                Email = tbEmail.Text,
                Responsable = tbResponsable.Text,
                IsRevendeur = cbRevenduer.Checked
            };



            //todo: uncomment this "Controller.AddClient(result);"
            Controller.AddClient(result);
        }
    }
}
