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
    public partial class AddDoc : Form
    {
        public AddDoc()
        {
            InitializeComponent();
        }

        public Document CurrentDoc { get; set; }

        private void AddDoc_Load(object sender, EventArgs e)
        {
            tbRef.DataBindings.Add("text", CurrentDoc, "Reference");
            dtDate.DataBindings.Add("value", CurrentDoc, "Date");
            dtPayment.DataBindings.Add("value", CurrentDoc, "PaymentDate");
            

            cbCust.Items.AddRange(Controller.GetCustomerNames().ToArray());
        }

        private void bnOK_Click(object sender, EventArgs e)
        {
            ValidateChildren();
        }
    }
}
