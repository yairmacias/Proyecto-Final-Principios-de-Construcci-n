using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public class Alumno
    {
        public String Nombre { get; set; }
        public String ApellidoPaterno { get; set; }
        public String ApellidoMaterno { get; set; }
        public String CorreoElectronico { get; set; }
        public String Matricula { get; set; }
        public String Seccion { get; set; }
        public String Bloque { get; set; }

        public Alumno(String nombre, String apellidoPaterno, String apellidoMaterno,
            String correoElectronico, String matricula, String seccion, String bloque)
        {
            this.Nombre = nombre;
            this.ApellidoPaterno = apellidoPaterno;
            this.ApellidoMaterno = apellidoMaterno;
            this.CorreoElectronico = correoElectronico;
            this.Matricula = matricula;
            this.Seccion = seccion;
            this.Bloque = bloque;
        }

        public Alumno()
        {

        }
    }
}
