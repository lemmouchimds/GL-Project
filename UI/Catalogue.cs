using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GLMainProject
{
    public partial class Catalogue : Form
    {
        public Catalogue()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var add = new AgentDeVente.AddToCatalogue();
        }

        private void bnAdd_Click(object sender, EventArgs e)
        {
            var add = new AgentDeVente.AddToCatalogue();
            add.ShowDialog();
        }

        private void Catalogue_Load(object sender, EventArgs e)
        {
            
        }
    }
}
