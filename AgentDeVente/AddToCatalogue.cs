﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GLMainProject.AgentDeVente
{
    public partial class AddToCatalogue : Form
    {
        public AddToCatalogue()
        {
            InitializeComponent();
        }

        private void AddToCatalogue_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(
                tbRef.Text == string.Empty ||
                tbDes.Text == string.Empty ||
                tbValNut.Text == string.Empty ||
                tbPoids.Text == string.Empty ||
                tbCoutRevient.Text == string.Empty ||
                tbGainSouaite.Text == string.Empty
                )
            {
                var result = MessageBox.Show("You have an empty field, are you sure you want to close it ?", 
                    Application.ProductName, 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Warning, 
                    MessageBoxDefaultButton.Button2);

                if (result == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void bnAdd_Click(object sender, EventArgs e)
        {

            using(var bd = new GLprojectDBcontext())
            {
                var result = new Produit
                {
                    Referance = tbRef.Text,
                    Designation = tbDes.Text,
                    ValNutritionnelle = double.Parse(tbValNut.Text),
                    PoidsNet = double.Parse(tbPoids.Text),
                    CoutRevient = decimal.Parse(tbCoutRevient.Text),
                    GainSouaite = decimal.Parse(tbGainSouaite.Text)
                };

                bd.Produit.Add(result);
                bd.SaveChanges();
            }
        }
    }
}
