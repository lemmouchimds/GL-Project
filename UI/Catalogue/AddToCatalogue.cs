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
    public partial class AddCatalogue : Form
    {
        public AddCatalogue()
        {
            InitializeComponent();
        }

        public Product CurrentProduct { get; set; }

        private void AddToCatalogue_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(
                tbRef.Text == string.Empty ||
                tbDes.Text == string.Empty ||
                tbValNut.Text == string.Empty ||
                tbPoids.Text == string.Empty ||
                tbCoutRevient.Text == string.Empty ||
                tbGainSouaite.Text == string.Empty
                )
            {
                var result = MessageBox.Show("You have an empty field, are you sure you want to close it ?", 
                    Application.ProductName, 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Warning, 
                    MessageBoxDefaultButton.Button2);

                if (result == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void bnAdd_Click(object sender, EventArgs e)
        {
            ValidateChildren();
            
        }

        private void AddCatalogue_Load(object sender, EventArgs e)
        {
            //tbDesignation.DataBindings.Add("Text", CurrentCust, "Designation");
            tbDes.DataBindings.Add("Text", CurrentProduct, "Designation");
            tbRef.DataBindings.Add("Text", CurrentProduct, "Referance");
            tbValNut.DataBindings.Add("Text", CurrentProduct, "ValNutritionnelle");
            tbPoids.DataBindings.Add("Text", CurrentProduct, "PoidsNet");
            tbCoutRevient.DataBindings.Add("Text", CurrentProduct, "CoutRevient");
            tbGainSouaite.DataBindings.Add("Text", CurrentProduct, "GainSouaite");

        }
    }
}
