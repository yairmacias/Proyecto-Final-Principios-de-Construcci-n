using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseDeDatos;
using System.Data.SqlClient;

namespace LogicaDeNegocios
{
    public class OrganizacionDAO : IOrganizacionDAO
    {
        public Organizacion RecuperarPorIDOrganizacion(string idOrganizacion)
        {
            Organizacion organizacion = new Organizacion();
            ConexionBaseDeDatos DBManager = new ConexionBaseDeDatos();
            using (SqlConnection conexion = DBManager.ObtenerConexion())
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand("Select * from Organizacion where userid=@IDOrganizacion", conexion))
                {
                    command.Parameters.Add(new SqlParameter("IDOrganizacion", idOrganizacion));
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        organizacion.Nombre = reader["Nombre"].ToString();
                        organizacion.Calle = reader["Calle"].ToString();
                        organizacion.Ciudad = reader["Ciudad"].ToString();
                        organizacion.CodigoPostal = reader["CodigoPostal"].ToString();
                        organizacion.Colonia = reader["Colonia"].ToString();
                        organizacion.CorreoElectronico = reader["CorreoElectronico"].ToString();
                        organizacion.Estado = reader["Estado"].ToString();
                        organizacion.NumeroInterno = (int)reader["NumeroInterno"];
                        organizacion.Sector = reader["Sector"].ToString();
                        organizacion.Telefono = (int)reader["Telefono"];
                    }
                }
                DBManager.CerrarConexion();
            }
            return organizacion;
        }

        public static Boolean ResgistrarDatosOrganizacion(Organizacion organizacion)
        {
            ConexionBaseDeDatos DBManager = new ConexionBaseDeDatos();
            using (SqlConnection conexion = DBManager.ObtenerConexion())
            {
                SqlCommand command = new SqlCommand("INSERT INTO Organizacion(@Nombre, @Calle, @Ciudad, @CodigoPostal, @Colonia, @CorreoElectronico, @Estado, @NumeroInterno, @Sector, @Telefono)", conexion);
                command.Parameters.AddWithValue("@Nombre", organizacion.Nombre);
                command.Parameters.AddWithValue("@ACalle", organizacion.Calle);
                command.Parameters.AddWithValue("@Ciudad", organizacion.Ciudad);
                command.Parameters.AddWithValue("@CodigoPostal", organizacion.CodigoPostal);
                command.Parameters.AddWithValue("@Colonia", organizacion.Colonia);
                command.Parameters.AddWithValue("@CorreoElectronico", organizacion.CorreoElectronico);
                command.Parameters.AddWithValue("@Estado", organizacion.Estado);
                command.Parameters.AddWithValue("@NumeroInterno", organizacion.NumeroInterno);
                command.Parameters.AddWithValue("@Sector", organizacion.Sector);
                command.Parameters.AddWithValue("@Telefono", organizacion.Telefono);
                conexion.Open();

                Boolean comprobacionDeQuery = Convert.ToBoolean(command.ExecuteNonQuery());
                DBManager.CerrarConexion();
                return comprobacionDeQuery;

            }
        }

        public Organizacion RecuperarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public Organizacion RecuperarPorCalle(string calle)
        {
            throw new NotImplementedException();
        }

        public Organizacion RecuperarPorCiudad(string ciudad)
        {
            throw new NotImplementedException();
        }

        public Organizacion RecuperarPorCodigoPostal(string codigoPostal)
        {
            throw new NotImplementedException();
        }

        public Organizacion RecuperarPorColonia(string calle)
        {
            throw new NotImplementedException();
        }

        public Organizacion RecuperarPorCorreoElectronico(string calle)
        {
            throw new NotImplementedException();
        }

        public Organizacion RecuperarPorEstado(string calle)
        {
            throw new NotImplementedException();
        }

        public Organizacion RecuperarPorNumeroInterno(int numeroInterno)
        {
            throw new NotImplementedException();
        }

        public Organizacion RecuperarPorSector(string sector)
        {
            throw new NotImplementedException();
        }

        public Organizacion RecuperarPorTelefono(int telefono)
        {
            throw new NotImplementedException();
        }

        public List<Organizacion> GetOrganizacion(string criterio)
        {
            throw new NotImplementedException();
        }
    }
}
