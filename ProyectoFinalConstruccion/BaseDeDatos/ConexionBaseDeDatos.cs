using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace BaseDeDatos
{
    public class ConexionBaseDeDatos
    {
        private SqlConnection ConexionABaseDeDatos;
        private String connectionString;
        public ConexionBaseDeDatos()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ConexionSql"].ConnectionString;
            ConexionABaseDeDatos = new SqlConnection(connectionString);
        }

        public SqlConnection ObtenerConexion()
        {
            return ConexionABaseDeDatos;
        }

        public void CerrarConexion()
        {
            if(ConexionABaseDeDatos != null)
            {
                if(ConexionABaseDeDatos.State == System.Data.ConnectionState.Open)
                {
                    ConexionABaseDeDatos.Close();
                }
            }
        }

    }
}

