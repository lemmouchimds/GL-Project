﻿using System;
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
            Form authentification = new Authentification();
            authentification.ShowDialog();
        }

        private void bnCatalogue_Click(object sender, EventArgs e)
        {
            var cata = new Catalogue();
            //cata.Parent = this;
            cata.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newUser = new AddUser();
            newUser.ShowDialog();
        }

        private void bnClient_Click(object sender, EventArgs e)
        {
            var client = new AgentDeVente.ClientUI();
            //client.Parent = this;
            client.Show();
        }
    }
}
