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
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }

        private void bnOK_Click(object sender, EventArgs e)
        {
            var thisUser = Controller.UserExist(tbUsername.Text);
            if (thisUser != null && thisUser.Password == tbPassword.Text)
            {
                Consts.CurrentUser = thisUser;
                DialogResult = DialogResult.OK;
            }
            MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect!","Authetification",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            DialogResult = DialogResult.None;
        }

        private void Authentification_Validating(object sender, CancelEventArgs e)
        {

        }

    }
}
