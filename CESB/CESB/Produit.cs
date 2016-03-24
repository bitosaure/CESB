using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CESB
{
    public class Produit
    {
        private String code;
        private List<Ingredient> listIng;

        private Dictionary<Ingredient, Int32> listeIngredientsDuProduit;
        private String nom;
        private double prix;
        private FamilleProduit famille;
        public Produit(String codeP, String nomP, double prixP, FamilleProduit fam)
        {
            code = codeP;
            nom = nomP;
            prix = prixP;
            famille = fam;
            listIng = new List<Ingredient>();
        }

        public Produit(String codeP, String nomP, double prixP, FamilleProduit fam, List<Ingredient> listIng)
        {
            code = codeP;
            nom = nomP;
            prix = prixP;
            famille = fam;
            listIng = new List<Ingredient>();
        }
        public override string ToString()
        {
            return famille.ToString() + " code " + code + " nom " + nom + " prix " + prix;
        }
        
        public String Code
        {
            get { return code; }
            set { code = value; }
        }
        

        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        
        public double Prix
        {
            get { return prix; }
            set { prix = value; }
        }
        public List<Ingredient> ListIng
        {
            get { return listIng; }
            set { listIng = value; }
        }

        public FamilleProduit Famille
        {
            get { return famille; }
            set { famille = value; }
        }
       
    }
}
