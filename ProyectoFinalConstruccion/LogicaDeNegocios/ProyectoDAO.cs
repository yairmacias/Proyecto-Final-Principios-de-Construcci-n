using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseDeDatos;

namespace LogicaDeNegocios
{
    public class ProyectoDAO : IProyectoDAO
    {
        public Proyecto RecuperarPorIDProyecto(string idProyecto)
        {
            Proyecto proyecto = new Proyecto();
            ConexionBaseDeDatos dbManager = new ConexionBaseDeDatos();
            using (SqlConnection conexion = dbManager.ObtenerConexion())
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand("Select * from Proyecto where userid=@IDProyecto", conexion))
                {
                    command.Parameters.Add(new SqlParameter("IDProyecto", idProyecto));
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        proyecto.Nombre = reader["Nombre"].ToString();
                        proyecto.Actividad = reader["Actividad"].ToString();
                        proyecto.Calendarizacion = (int)reader["Calendarizacion"];
                        proyecto.DescripcionGeneral = reader["DescripcionGeneral"].ToString();
                        proyecto.Dias = (int)reader["Dias"];
                        proyecto.Duracion = reader["Duracion"].ToString();
                        proyecto.Funcion = reader["Funcion"].ToString();
                        proyecto.Hora = (float)reader["Hora"];
                        proyecto.Metodologia = reader["Metodologia"].ToString();
                        proyecto.ObjetivoGeneral = reader["ObjetivoGeneral"].ToString();
                        proyecto.ObjetivoInmediato = reader["ObjetivoInmediaro"].ToString();
                        proyecto.ObjetivoMediato = reader["ObjetivoMediato"].ToString();
                        proyecto.RecursoEconomico = reader["RecursoEconomico"].ToString();
                        proyecto.RecursoHumano = reader["RecursoHumano"].ToString();
                        proyecto.RecursoMaterial = reader["RecursoMaterial"].ToString();
                        proyecto.Responsabilidad = reader["Responsabilidad"].ToString();
                    }
                }
                dbManager.CerrarConexion();
            }
            return proyecto;
        }
        public static Boolean ResgistrarDatosProyecto(Proyecto proyecto)
        {
            ConexionBaseDeDatos dbManager = new ConexionBaseDeDatos();
            using (SqlConnection conexion = dbManager.ObtenerConexion())
            {
                SqlCommand command = new SqlCommand("INSERT INTO Proyecto(@IDProyecto, @Actividad, @Calendarizacion, @DescripcionGeneral, @Dias, Duracion, " +
                    "@Funcion, @Hora, @Metodologia, @Nombre, @ObjetivoGeneral, @ObjetivoInmediato, @ObjetivoMediato, @RecursosEconomico, @RecursoHumano, " +
                    "@RecursoMaterial, @Responsabilidad)", conexion);
                command.Parameters.AddWithValue("@IProyecto", proyecto.IDProyecto);
                command.Parameters.AddWithValue("@Actividad", proyecto.Actividad);
                command.Parameters.AddWithValue("@Calendarizacion", proyecto.Calendarizacion);
                command.Parameters.AddWithValue("@DescripcionGeneral", proyecto.DescripcionGeneral);
                command.Parameters.AddWithValue("@Dias", proyecto.Dias);
                command.Parameters.AddWithValue("@Duracion", proyecto.Duracion);
                command.Parameters.AddWithValue("@Funcion", proyecto.Funcion);
                command.Parameters.AddWithValue("@Hora", proyecto.Hora);
                command.Parameters.AddWithValue("@Metodologia", proyecto.Metodologia);
                command.Parameters.AddWithValue("@Nombre", proyecto.Nombre);
                command.Parameters.AddWithValue("@ObjetivoGeneral", proyecto.ObjetivoGeneral);
                command.Parameters.AddWithValue("@ObejtivoInmediato", proyecto.ObjetivoInmediato);
                command.Parameters.AddWithValue("@ObjetivoMediato", proyecto.ObjetivoMediato);
                command.Parameters.AddWithValue("@DRecursosEconomico", proyecto.RecursoEconomico);
                command.Parameters.AddWithValue("@RecursoHumano", proyecto.RecursoHumano);
                command.Parameters.AddWithValue("@RecursoMaterial", proyecto.RecursoMaterial);
                command.Parameters.AddWithValue("@Responsabilidad", proyecto.Responsabilidad);
                conexion.Open();

                Boolean comprobacionDeQuery = Convert.ToBoolean(command.ExecuteNonQuery());
                dbManager.CerrarConexion();
                return comprobacionDeQuery;

            }
        }

        public Proyecto RecuperarPorActividad(string actividad)
        {
            throw new NotImplementedException();
        }

        public Proyecto RecuperarPorCalendarizacion(int calendarizacion)
        {
            throw new NotImplementedException();
        }

        public Proyecto RecuperarPorDias(int dias)
        {
            throw new NotImplementedException();
        }

        public Proyecto RecuperarPorDuracion(string duracion)
        {
            throw new NotImplementedException();
        }

        public Proyecto RecuperarPorFuncion(string funcion)
        {
            throw new NotImplementedException();
        }

        public Proyecto RecuperarPorHora(float hora)
        {
            throw new NotImplementedException();
        }

        public Proyecto RecuperarPorMetodologia(string metdologia)
        {
            throw new NotImplementedException();
        }

        public Proyecto RecuperarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public Proyecto RecuperarPorObjetivoGeneral(string objetivoGeneral)
        {
            throw new NotImplementedException();
        }

        public Proyecto RecuperarPorObjetivoInmediato(string objetivoImediato)
        {
            throw new NotImplementedException();
        }

        public Proyecto RecuperarPorObjetivoMediato(string objetivoMediato)
        {
            throw new NotImplementedException();
        }

        public Proyecto RecuperarPorRecursoEconomico(string recursoEconomico)
        {
            throw new NotImplementedException();
        }

        public Proyecto RecuperarPorRecursoHumano(string recursoHumano)
        {
            throw new NotImplementedException();
        }

        public Proyecto RecuperarPorRecursoMaterial(string recursoMaterial)
        {
            throw new NotImplementedException();
        }

        public Proyecto RecuperarPorResponsabilidad(string responsabilidad)
        {
            throw new NotImplementedException();
        }

        public List<Proyecto> GetProyecto(string criterio)
        {
            throw new NotImplementedException();
        }

    }
}
