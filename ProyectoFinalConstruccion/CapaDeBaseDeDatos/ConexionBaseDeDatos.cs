using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaDeBaseDeDatos
{

    public class GestionBaseDeDatos
    {
        private SqlConnection ConexionBaseDeDatos;
        private String connectionString;
        public GestionBaseDeDatos()
        {
            connectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            ConexionBaseDeDatos = new SqlConnection(connectionString);
        }
        public SqlConnection GetConnection()
        {
            return ConexionBaseDeDatos;
        }
        public void CloseConnection()
        {
            if (ConexionBaseDeDatos != null)
            {
                if (ConexionBaseDeDatos.State == System.Data.ConnectionState.Open)
                {
                    ConexionBaseDeDatos.Close();
                }
            }
        }


    }

}
