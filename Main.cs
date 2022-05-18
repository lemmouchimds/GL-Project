using GLMainProject.UI;
using GLMainProject.UI.User;
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
        }


        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var client = new AgentDeVente.ClientUI();
            //client.Parent = this;
            client.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ShowHideAdminControls();
            SetDashboardForm();
        }
        DashboardForm dashboardForm;
        private void SetDashboardForm()
        {
            dashboardForm = new DashboardForm
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            dashboardForm.Show();
        }

        private void ShowHideAdminControls()
        {
            Text += $"- ({Consts.CurrentUser.Username})";
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

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new UserList()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            form.Show();
        }
    }
}
