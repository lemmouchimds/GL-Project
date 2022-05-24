using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GLMainProject.UI.Docs
{
    public partial class AddDetailDoc : Form
    {
        public AddDetailDoc()
        {
            InitializeComponent();
        }

        public DocumentDetail CurrentDocDetail;
        private void AddDetailDoc_Load(object sender, EventArgs e)
        {
            tbLabel.DataBindings.Add("Text", CurrentDocDetail, "Label");
            nupQuantity.DataBindings.Add("Text", CurrentDocDetail, "Quantity");
            cbProduct.DataSource = Controller.ListDispoProducts();
            cbProduct.DisplayMember = "Designation";
            cbProduct.ValueMember = "ID";
            cbProduct.DataBindings.Add("SelectedValue", CurrentDocDetail, nameof(DocumentDetail.ProduitID));

            //cbProduct.Items.AddRange(Controller.InventoryNameID().ToArray());
        }

        private void cbProduct_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
