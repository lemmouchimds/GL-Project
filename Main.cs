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

        
        private void Main_Shown(object sender, EventArgs e)
        {
            
        }


        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newUser = new AddUser();
            newUser.ShowDialog();
        }


        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var client = new AgentDeVente.ClientUI();
            //client.Parent = this;
            client.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (Consts.CurrentUser.UserType != UserType.Directeur)
            {
                usersToolStripMenuItem.Visible = false;
            }
        }

        private void catalogueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cata = new Catalogue();
            cata.Show();
        }

        private void documentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vueAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var ui = UI.UserUI();

        }
    }
}
