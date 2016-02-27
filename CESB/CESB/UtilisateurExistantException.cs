using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CESB
{
    public class UtilisateurExistantException : Exception
    {
        public UtilisateurExistantException(string message)
            : base(message)
        {
        }
    }
}
