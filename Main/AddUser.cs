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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }
        public User CurrentUser { get; set; }
        private void AddUser_Load(object sender, EventArgs e)
        {
            tbUsername.DataBindings.Add("Text", CurrentUser, "Username");
            tbPassword.DataBindings.Add("Text", CurrentUser, "Password");

            GetUsersType();

        }

        private void GetUsersType()
        {
            var values = Enum.GetValues(typeof(UserType));
            foreach (UserType value in values)
            {
                cbUserType.Items.Add(value.FriendlyName());
            }
        }

        private void cbUserType_TextChanged(object sender, EventArgs e)
        {
            CurrentUser.UserType = cbUserType.Text.ToUserType();
        }
    }
}
