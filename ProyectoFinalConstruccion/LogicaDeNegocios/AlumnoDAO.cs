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
    public class AlumnoDAO : IAlumnoDAO
    {
        public Alumno RecuperarPorMatricula(string matricula)
        {
            Alumno alumno = new Alumno();
            ConexionBaseDeDatos DBManager = new ConexionBaseDeDatos();
            using (SqlConnection conexion = DBManager.ObtenerConexion())
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand("Select * from Alumno where userid=@matricula", conexion))
                {
                    command.Parameters.Add(new SqlParameter("Matricula", matricula));
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        alumno.Nombre = reader["Nombre"].ToString();
                        alumno.ApellidoPaterno = reader["ApellidoPaterno"].ToString();
                        alumno.ApellidoMaterno = reader["ApellidoMaterno"].ToString();
                        alumno.CorreoElectronico = reader["CorreoElectronico"].ToString();
                        alumno.Seccion = reader["Seccion"].ToString();
                        alumno.Bloque = reader["Bloque"].ToString();
                    }
                }
                DBManager.CerrarConexion();
            }
            return alumno;
        }

        public static Boolean ResgistrarDatosAlumno(Alumno alumno)
        {
            ConexionBaseDeDatos DBManager = new ConexionBaseDeDatos();
            using (SqlConnection conexion = DBManager.ObtenerConexion())
            {
                conexion.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Alumno(@Nombre, @ApellidoPaterno, @ApellidoMaterno, @CorreoElectronico, @Bloque, @Seccion)", conexion);
                command.Parameters.AddWithValue("@Nombre", alumno.Nombre);
                command.Parameters.AddWithValue("@ApellidoPaterno", alumno.ApellidoPaterno);
                command.Parameters.AddWithValue("@ApellidoMaterno", alumno.ApellidoMaterno);
                command.Parameters.AddWithValue("@CorreoElectronico", alumno.CorreoElectronico);
                command.Parameters.AddWithValue("@Bloque", alumno.Bloque);
                command.Parameters.AddWithValue("@Seccion", alumno.Seccion);

                Boolean comprobacionDeQuery = Convert.ToBoolean(command.ExecuteNonQuery());
                conexion.Close();
                return comprobacionDeQuery;

            }
        }

        public Alumno RecuperarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public Alumno RecuperarPorApellidoPaterno(string apellidoPaterno)
        {
            throw new NotImplementedException();
        }

        public Alumno RecuperarPorApellidoMaterno(string apellidoMaterno)
        {
            throw new NotImplementedException();
        }

        public Alumno RecuperarPorCorreoElectronico(string correoElectronico)
        {
            throw new NotImplementedException();
        }
        public Alumno RecuperarPorBloque(string bloque)
        {
            throw new NotImplementedException();
        }

        public Alumno RecuperarPorSeccion(string seccion)
        {
            throw new NotImplementedException();
        }

        public List<Alumno> GetAlumno(string criterio)
        {
            throw new NotImplementedException();
        }


    }
}
