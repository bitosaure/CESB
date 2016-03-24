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
    public partial class AdmAccueil : Form
    {
        public AdmAccueil()
        {
            InitializeComponent();
            string date = DateTime.Now.Date.Day + "/" + DateTime.Now.Date.Month + "/" + DateTime.Now.Date.Year;
            lbBienvenue.Text = "Bienvenue "+Proxy.PersonneConnecte.Prenom+" "+Proxy.PersonneConnecte.Nom+". Nous sommes le "+Utilitaire.GetDateDuJour();
        }

        private void créationDesUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdmCreationUtilisateur crea = new AdmCreationUtilisateur();
            this.Hide();
            crea.ShowDialog();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void suppressionDesUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdmSuppressionUtilisateur sup = new AdmSuppressionUtilisateur();
            this.Hide();
            sup.ShowDialog();
            
        }

        private void créationDeProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdmAjouterProduit aj = new AdmAjouterProduit();
            this.Hide();
            aj.ShowDialog();
        }

        private void suppressionDeProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdmSuppressionProduit asP = new AdmSuppressionProduit();
            this.Hide();
            asP.ShowDialog();
        }
    }
}
