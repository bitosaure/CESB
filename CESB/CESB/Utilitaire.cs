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
    public static class Utilitaire
    {
        public static void testerChamps(TextBox tb)
        {
            if (tb.Text != "")
            {
                int alo;
                bool rep = int.TryParse(tb.Text, out alo);
                if (rep == true)
                {
                    MessageBox.Show("Lettres uniquement");
                    tb.Text = "";
                }

            }

        }
        public static string GetDateDuJour()
        {
            DateTime dt = DateTime.Now;
            string date = dt.Day+" "+Utilitaire.GetMois(dt.Month)+" "+dt.Year;
            return date;
        }
        private static string GetMois(int i){
            string mois = "";
            switch(i)
            {
                case 1:
                    mois =  "janvier";
                    break;
                 case 2:
                    mois="février";
                    break;
                 case 3:
                    mois = "mars";
                    break;
                case 4:
                    mois = "avril";
                    break;
                case 5:
                    mois = "mai";
                    break;
                case 6:
                    mois = "juin";
                    break;
                case 7:
                    mois = "juillet";
                    break;
                case 8:
                    mois = "août";
                    break;
                case 9:
                    mois = "septembre";
                    break;
                case 10:
                    mois = "octobre";
                    break;
                case 11:
                    mois = "novembre";
                    break;
                case 12:
                    mois = "decembre";
                    break;

            }
            return mois;

    }
    }
}
