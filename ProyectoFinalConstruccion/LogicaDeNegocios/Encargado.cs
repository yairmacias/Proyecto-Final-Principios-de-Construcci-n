using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
   public class Encargado
    {
        public String IDEncargado { get; set; }
        public String Nombre { get; set; }
        public String ApellidoPaterno { get; set; }
        public String ApellidoMaterno { get; set; }
        public String CorreoElectronico { get; set; }
        public int Telefono { get; set; }

        public Encargado(String IDEncargado, String Nombre, String ApellidoPaterno, String ApellidoMaterno, String CorreoElectronico,
            int Telefono)
        {
            this.IDEncargado = IDEncargado;
            this.Nombre = Nombre;
            this.ApellidoPaterno = ApellidoPaterno;
            this.ApellidoMaterno = ApellidoMaterno;
            this.CorreoElectronico = CorreoElectronico;
            this.Telefono = Telefono;
        }

        public Encargado()
        {

        }
    }
}
