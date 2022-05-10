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

        private void AddUser_Load(object sender, EventArgs e)
        {
            GetUsersType();
        }

        private void GetUsersType()
        {
            var names = Enum.GetNames(typeof(UserType));
            foreach (var name in names)
            {
                cbUserType.Items.Add(name);
            }
        }
    }
}
