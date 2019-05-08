using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public class Proyecto
    {
        public String IDProyecto { get; set; }
        public String Actividad { get; set; }
        public int Calendarizacion { get; set; }
        public String DescripcionGeneral { get; set; }
        public int Dias { get; set; }
        public String Duracion { get; set; }
        public String Funcion { get; set; }
        public float Hora { get; set; }
        public String Metodologia { get; set; }
        public String Nombre { get; set; }
        public String ObjetivoGeneral { get; set; }
        public String ObjetivoInmediato { get; set; }
        public String ObjetivoMediato { get; set; }
        public String RecursoEconomico { get; set; }
        public String RecursoHumano { get; set; }
        public String RecursoMaterial { get; set; }
        public String Responsabilidad { get; set; }

        public Proyecto(string IDProyecto, String Actividad, int Calendarizacion, String DescripcionGeneral, int Dias, String Duracion, 
            String Funcion, float Hora, String Metodologia, String Nombre, String ObjetivoGeneral, String ObjetivoInmediato, String ObjetivoMediato,
            String RecursosEconomico, String RecursoHumano, String RecursoMaterial, String Responsabilidad)
        {
            this.IDProyecto = IDProyecto;
            this.Actividad = Actividad;
            this.Calendarizacion = Calendarizacion;
            this.DescripcionGeneral = DescripcionGeneral;
            this.Dias = Dias;
            this.Duracion = Duracion;
            this.Funcion = Funcion;
            this.Hora = Hora;
            this.Metodologia = Metodologia;
            this.Nombre = Nombre;
            this.ObjetivoGeneral = ObjetivoGeneral;
            this.ObjetivoInmediato = ObjetivoInmediato;
            this.ObjetivoMediato = ObjetivoMediato;
            this.RecursoEconomico = RecursoEconomico;
            this.RecursoHumano = RecursoHumano;
            this.Responsabilidad = Responsabilidad;

        }

        public Proyecto()
        {

        }
    }
}
