using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GLMainProject.UI.Stock
{
    public partial class AddStock : Form
    {
        public AddStock()
        {
            InitializeComponent();
        }

        public Inventory CurrentInventory;

        private void bnOK_Click(object sender, EventArgs e)
        {
            ValidateChildren();
        }

        private void AddStock_Load(object sender, EventArgs e)
        {
            //cbProduct.DataBindings.Add("Text", CurrentInventory, "Product");
            dtDateProduction.DataBindings.Add("value", CurrentInventory, "DateProduction");
            dtDatePeremption.DataBindings.Add("value", CurrentInventory, "DatePeremption");
            nupQuantity.DataBindings.Add("value", CurrentInventory, "InStock");

            cbProduct.DataSource = Controller.ListAllProducts();
            cbProduct.DisplayMember = "Designation";
            cbProduct.ValueMember = "ID";
            cbProduct.DataBindings.Add("SelectedValue", CurrentInventory, nameof(CurrentInventory.ProductID));

            //cbProduct.Items.AddRange(Controller.ProductNamesID().ToArray());
        }
    }
}
