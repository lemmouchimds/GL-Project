using GLMainProject.Dto;
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

        private void bnEdit_Click(object sender, EventArgs e)
        {
            if (gridUsers.SelectedRows.Count <= 0)
                return;
            var currentUser = gridUsers.SelectedRows[0].DataBoundItem as UserDto;
            if (currentUser == null)
                return;
            
            var user = Controller.GetUserById(currentUser.Id);
            if (user == null)
                return;

            using (var newUser = new AddUser()
            {
                CurrentUser = user
            })
            {
                if (newUser.ShowDialog() == DialogResult.OK)
                {
                    Controller.EditUser(newUser.CurrentUser);
                    refreshGrid();
                }
            }
        }

        private void bnDelete_Click(object sender, EventArgs e)
        {
            if (gridUsers.SelectedRows.Count <= 0)
                return;
            var currentUser = gridUsers.SelectedRows[0].DataBoundItem as UserDto;
            if (currentUser == null)
                return;
            if(currentUser.Id == 1)
            {
                MessageBox.Show("Impossible de supprimer l'administrateur de system","Alerte",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }
            var dialogResult = MessageBox.Show($"Voulez-vous vraiment supprimer l'utilisateur '{currentUser.Username}'?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes && Controller.DeleteUser(currentUser.Id))
            {
                refreshGrid();
            }
            
        }
    }
}
