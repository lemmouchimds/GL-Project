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
    public partial class AddToCatalogue : Form
    {
        public AddToCatalogue()
        {
            InitializeComponent();
        }

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
                var result = MessageBox.Show("Are you sure about that ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.No)
                    e.Cancel = true;
            }
        }
    }
}
