using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CESB
{
    public class Ingredient
    {
        private String code;
        private String mesure;
        private String nom;
        public Ingredient(String code, String nom, String mesure)
        {
            this.code = code;
            this.nom = nom;
            this.mesure = mesure;
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
        

        public String Mesure
        {
            get { return mesure; }
            set { mesure = value; }
        }

    }
}
