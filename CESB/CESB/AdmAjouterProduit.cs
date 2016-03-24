using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CESB
{
    public partial class AdmAjouterProduit : Form
    {
 
        public AdmAjouterProduit()
        {

           
            InitializeComponent();

            cbFamille.DataSource = ConnexionDataSource.GetFamilleProduit();
        }

        private void AdmAjouterProduit_Load(object sender, EventArgs e)
        {

        }
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btValider_Click(object sender, EventArgs e)
        {
            FamilleProduit famille =(FamilleProduit) cbFamille.SelectedItem;
            Produit p = new Produit(tbCode.Text, tbNom.Text, Convert.ToDouble(tbPrix.Text), famille);
            ConnexionDataSource.CreerProduit(p);
        }
    }
}
