using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CESB
{
    public class CentraleAchat
    {
        private String code;
        private List<Ingredient> listIng;
        private String nom;
        public CentraleAchat(String code, String nom, List<Ingredient> listIng)
        {
            this.code = code;
            this.nom = nom;
            this.listIng = listIng;
        }
        public CentraleAchat(String code, String nom)
        {
            this.code = code;
            this.nom = nom;
            listIng = new List<Ingredient>();
        }

        public  List<Ingredient> ListIng
        {
            get { return listIng; }
            set { listIng = value; }
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
        

    }
}
