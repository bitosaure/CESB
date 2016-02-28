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
    public partial class AdmCreationUtilisateur : Form
    {
        public AdmCreationUtilisateur()
        {
            InitializeComponent();
            cbMag.DataSource = ConnexionDataSource.GetMagasins();
            cbType.DataSource = ConnexionDataSource.GetTypesUtilisateurs();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbConfMdp_TextChanged(object sender, EventArgs e)
        {
            if (!tbConfMdp.Text.Equals(tbMdp.Text))
            {
                labErreur.Visible = true;
                labErreur.Text = "Mot de passe différent";
            }
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            Personne p = new Personne((Magasin)cbMag.SelectedItem, (string)cbType.SelectedItem , tbNom.Text, tbPrenom.Text,Convert.ToInt32(tbTel.Text), tbLogin.Text, tbMdp.Text);
           
            ConnexionDataSource.CreerPersonne(p);


        }

        public void testerChamps(TextBox tb)
        {
            if (tb.Text != "")
            {
                int alo;
                bool rep = int.TryParse(tb.Text, out alo);
                if (rep == true)
                {
                    MessageBox.Show("Lettres uniquement");
                }

            }
        }

        private void tbNom_TextChanged(object sender, EventArgs e)
        {
            testerChamps(this.tbNom);
        }
    }
}
