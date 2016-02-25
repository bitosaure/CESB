using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CESB
{
    public static class Proxy
    {
        private static Personne personneConnecte;

        public static Personne PersonneConnecte
        {
            get { return personneConnecte; }
            set { personneConnecte = value; }
        }
    }
}
