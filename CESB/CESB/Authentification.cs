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
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
            ConnexionDataSource.SeConnecter();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                ConnexionDataSource.connexionUtilisateur(tbId.Text, tbMdp.Text);
                if (Proxy.PersonneConnecte.CodeType.Equals(Constantes.codeAdm))
                {
                    AdmAccueil nextForm = new AdmAccueil();
                    this.Hide();
                    nextForm.ShowDialog();
                }
                else
                {
                }
            }
            catch(ConnectionException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
                
            
        }

        
    }
}
