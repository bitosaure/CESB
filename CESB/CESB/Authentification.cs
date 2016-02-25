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
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(""+ConnexionDataSource.SeConnecter());
            //ConnexionDataSource.SeConnecter();
            ConnexionDataSource.connexionUtilisateur(textBox1.Text, textBox2.Text);
            label1.Text = Proxy.PersonneConnecte.Nom + " " + Proxy.PersonneConnecte.Prenom;
        }
    }
}
