using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CESB
{
    public class FamilleProduit
    {
        private String code;

        public String Code
        {
            get { return code; }
            set { code = value; }
        }
        private String libelle;

        public String Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }
        public FamilleProduit(String codeF, String libelleF)
        {
            this.code = codeF;
            this.libelle = libelleF;
        }
        public FamilleProduit(String codeF)
        {
            this.code = codeF;
            this.libelle = "";
        }
        public override string ToString()
        {
            if (this.libelle == "")
            {
                return "code: " + this.code + "libelle " + this.libelle;
            }
            else
            {
                return "code: " + this.code;
            }
        }

    }
}
