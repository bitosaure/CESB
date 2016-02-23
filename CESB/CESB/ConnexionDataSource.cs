using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace CESB
{
    public static class ConnexionDataSource
    {
        private SqlConnection connection;

        public bool SeConnecter()
        {
            this.connection = new SqlConnection();
        }

    }
}
