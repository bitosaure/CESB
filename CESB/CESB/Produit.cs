using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CESB
{
    public class Produit
    {
        private String code;

        public String Code
        {
            get { return code; }
            set { code = value; }
        }
        private String nom;

        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private double prix;

        public double Prix
        {
            get { return prix; }
            set { prix = value; }
        }
        private FamilleProduit famille;

        internal FamilleProduit Famille
        {
            get { return famille; }
            set { famille = value; }
        }
        public Produit(String codeP, String nomP, double prixP, FamilleProduit fam)
        {
            code = codeP;
            nom = nomP;
            prix = prixP;
            famille = fam;
        }
    }
}
