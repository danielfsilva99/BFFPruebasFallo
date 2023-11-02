using System;
using System.Collections.Generic;
using System.Data;

using Microsoft.Data.SqlClient;

namespace Servicio.Contexto
{
    public class ContextoConexion
    {

        private string connectionString;

        public ContextoConexion()
        {
            connectionString = "server=localhost\\SQLEXPRESS;database=master; integrated security=True; Trusted_Connection=True; TrustServerCertificate=True;";
        }

        public IDbConnection connection
        {
            get
            {

                return new SqlConnection(connectionString);
            }

        }
    }
}
