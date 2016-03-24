using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CESB
{
    public class Vente
    {
        private Personne vendeur;
        private Int64 numero;
        private string heureVente;
        private string dateVente;
        private Dictionary<Produit, Int32> contenuVente;

    }
}
