using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GLMainProject.UI.User
{
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }
        private void refreshGrid()
        {
            gridUsers.DataSource = Controller.ListAllUsers();
        }

        private void bnAdd_Click(object sender, EventArgs e)
        {
            using (var newUser = new AddUser()
            {
                CurrentUser = new GLMainProject.User()
            }) { 
                if (newUser.ShowDialog() == DialogResult.OK)
                {
                    Controller.AddUser(newUser.CurrentUser);
                    refreshGrid();

                }
            }
        }
    }
}
