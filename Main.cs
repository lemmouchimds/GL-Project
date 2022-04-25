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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void nbPrix_Click(object sender, EventArgs e)
        {
            var m = new AgentDeVente.MettrePrix();
            m.ShowDialog();
            m.Close();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            Form authentification = new Authentification();
            authentification.ShowDialog();
        }

        private void bnCatalogue_Click(object sender, EventArgs e)
        {
            var cata = new Catalogue();
            cata.Show();
        }
    }
}
