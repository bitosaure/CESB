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
    public partial class AdmSuppressionProduit : Form
    {
        public AdmSuppressionProduit()
        {
            InitializeComponent();
            
            listProduit.DataSource = ConnexionDataSource.GetListeProduit();
        }

        private void listProduit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btValider_Click(object sender, EventArgs e)
        {
            ConnexionDataSource.SupprimerProduit((Produit)listProduit.SelectedItem);
            MessageBox.Show("Produit supprimé");
            listProduit.DataSource = ConnexionDataSource.GetListeProduit();
        }
    }
}
