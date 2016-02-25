using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CESB
{
    public class Personne
    {
        public Personne(Int16 mat, Magasin mag, string code, string nom, string prenom, string user)
        {
            this.Matricule = mat;
            this.Mag = mag;
            this.CodeType = code;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Login = user;
        }
        public Personne(Int16 mat, string code, string nom, string prenom, string user):
            this(mat, null, code, nom, prenom, user)
        {
        }
        private Int16 matricule;

        public Int16 Matricule
        {
            get { return matricule; }
            set { matricule = value; }
        }
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private string prenom;

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        private Magasin mag;

        public Magasin Mag
        {
            get { return mag; }
            set { mag = value; }
        }
        private string login;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        private string codeType;

        public string CodeType
        {
            get { return codeType; }
            set { codeType = value; }
        }
    }
}
