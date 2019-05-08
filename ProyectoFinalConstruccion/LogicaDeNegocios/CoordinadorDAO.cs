using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using BaseDeDatos;

namespace LogicaDeNegocios
{
     public class CoordinadorDAO
    {
        public Coordinador RecuperarPorIdentificador(string idCoordinador)
        {
            Coordinador coordinador = new Coordinador();
            ConexionBaseDeDatos dbManager = new ConexionBaseDeDatos();
            using (SqlConnection conexion = dbManager.ObtenerConexion())
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand("Select * from Coordinador where userid=@IDCoordinador", conexion))
                {
                    command.Parameters.Add(new SqlParameter("IDCoordinador", idCoordinador));
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        coordinador.Nombre = reader["Nombre"].ToString();
                        coordinador.ApellidoPaterno = reader["ApellidoPaterno"].ToString();
                        coordinador.ApellidoMaterno = reader["ApellidoMaterno"].ToString();
                        coordinador.NumeroPersonal = (int)reader["NumeroPersonal"];
                    }
                }
                dbManager.CerrarConexion();
            }
            return coordinador;


        }
        public static Boolean RegistraDatosCoordinador(Coordinador coordinador)
        {
            ConexionBaseDeDatos dbManager = new ConexionBaseDeDatos();
            using (SqlConnection conexion = dbManager.ObtenerConexion())
            {
                SqlCommand command = new SqlCommand("INSERT INTO Coordinador(@IDCoordinador, @Nombre, @ApellidoPaterno, @ApellidoMaterno, @NumeroPersonal)", conexion);
                command.Parameters.AddWithValue("@IDCoordinador", coordinador.IDCoordinador);
                command.Parameters.AddWithValue("@Nombre", coordinador.Nombre);
                command.Parameters.AddWithValue("@ApellidoPaterno", coordinador.ApellidoPaterno);
                command.Parameters.AddWithValue("@ApellidoMaterno", coordinador.ApellidoMaterno);
                command.Parameters.AddWithValue("@NumeroPersonal", coordinador.NumeroPersonal);
                conexion.Open();

                Boolean comprobacionDeQuery = Convert.ToBoolean(command.ExecuteNonQuery());
                dbManager.CerrarConexion();
                return comprobacionDeQuery;

            }
        }
    }
}
