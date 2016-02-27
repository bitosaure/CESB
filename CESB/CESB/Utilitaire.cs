using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CESB
{
    public static class Utilitaire
    {
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
