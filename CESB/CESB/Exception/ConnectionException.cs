using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CESB
{
    public class ConnectionException : Exception
    {
        public ConnectionException(string message)
            : base(message)
        {
        }
    }
}
