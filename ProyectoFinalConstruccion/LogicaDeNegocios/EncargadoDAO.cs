using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseDeDatos;

namespace LogicaDeNegocios
{
    public class EncargadoDAO : IEncargadoDAO
    {
        public Encargado RecuperarPorIDEncargado(string idEncargado)
        {
            Encargado encargado = new Encargado();
            ConexionBaseDeDatos dbManager = new ConexionBaseDeDatos();
            using (SqlConnection conexion = dbManager.ObtenerConexion())
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand("Select * from Encargado where userid=@IDEncargado", conexion))
                {
                    command.Parameters.Add(new SqlParameter("IDEncargado", idEncargado));
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        encargado.Nombre = reader["Nombre"].ToString();
                        encargado.ApellidoPaterno = reader["ApellidoPaterno"].ToString();
                        encargado.ApellidoMaterno = reader["ApellidoMaterno"].ToString();
                        encargado.CorreoElectronico = reader["CorreoElectronico"].ToString();
                        encargado.Telefono = (int)reader["Telefono"];
                    }
                }
                dbManager.ObtenerConexion();
            }
            return encargado;
        }
        public static Boolean ResgistrarDatosEncargado(Encargado encargado)
        {
            ConexionBaseDeDatos dbManager = new ConexionBaseDeDatos();
            using (SqlConnection conexion = dbManager.ObtenerConexion())
            {
                SqlCommand command = new SqlCommand("INSERT INTO Encargado(@IDEncargado, @Nombre, @ApellidoPaterno, @ApellidoMaterno, @CorreoElectronico, @Telefono)", conexion);
                command.Parameters.AddWithValue("@IDEncargado", encargado.IDEncargado);
                command.Parameters.AddWithValue("@Nombre", encargado.Nombre);
                command.Parameters.AddWithValue("@ApellidoPaterno", encargado.ApellidoPaterno);
                command.Parameters.AddWithValue("@ApellidoMaterno", encargado.ApellidoMaterno);
                command.Parameters.AddWithValue("@CorreoElectronico", encargado.CorreoElectronico);
                command.Parameters.AddWithValue("@Telefono", encargado.Telefono);
                conexion.Open();

                Boolean comprobacionDeQuery = Convert.ToBoolean(command.ExecuteNonQuery());
                dbManager.CerrarConexion();
                return comprobacionDeQuery;

            }
        }

        public Encargado RecuperarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public Encargado RecuperarPorApellidoPaterno(string apellidoPaterno)
        {
            throw new NotImplementedException();
        }

        public Encargado RecuperarPorApellidoMaterno(string apellidoMaterno)
        {
            throw new NotImplementedException();
        }

        public Encargado RecuperarPorCorreoElectronico(string correoElectronico)
        {
            throw new NotImplementedException();
        }

        public Encargado RecuperarPorTelefono(int telefono)
        {
            throw new NotImplementedException();
        }

        public List<Encargado> GetEncargado(string criterio)
        {
            throw new NotImplementedException();
        }
    }
}
