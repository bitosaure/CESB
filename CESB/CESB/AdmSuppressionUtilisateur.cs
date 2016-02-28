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
    public partial class AdmSuppressionUtilisateur : Form
    {
        public AdmSuppressionUtilisateur()
        {
            InitializeComponent();
            listUtil.DataSource = ConnexionDataSource.GetListePersonnes();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            try
            {
                ConnexionDataSource.SupprimerPersonne((Personne)listUtil.SelectedItem);
                MessageBox.Show("Utilisateur supprimé");
                listUtil.DataSource = ConnexionDataSource.GetListePersonnes();

            }
            catch(UtilisateurExistantException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
