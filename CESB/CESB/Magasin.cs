using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CESB
{
    public class Magasin
    {
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private Int64 soldeCompte;

        public Int64 SoldeCompte
        {
            get { return soldeCompte; }
            set { soldeCompte = value; }
        }
        private Int64 numCompte;

        public Int64 NumCompte
        {
            get { return numCompte; }
            set { numCompte = value; }
        }
        private string adresse;

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        private string codeMag;

        public string CodeMag
        {
            get { return codeMag; }
            set { codeMag = value; }
        }
        public Magasin(string code, string nom, string adresse,  Int64 num,Int64 solde)
        {
            this.CodeMag = code;
            this.Nom = nom;
            this.Adresse = adresse;
            this.NumCompte = num;
            this.SoldeCompte = solde;
            
        }
    }
}
