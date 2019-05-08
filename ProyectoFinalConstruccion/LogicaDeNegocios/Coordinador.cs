using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public class Coordinador
    {
        public String IDCoordinador { get; set; }
        public String Nombre { get; set; }
        public String ApellidoPaterno { get; set; }
        public String ApellidoMaterno { get; set; }
        public int NumeroPersonal { get; set; }

        public Coordinador(String IDCoordinador, String Nombre, String ApellidoPaterno, String ApellidoMaterno, int NumeroPersonal)
        {
            this.IDCoordinador = IDCoordinador;
            this.Nombre = Nombre;
            this.ApellidoPaterno = ApellidoPaterno;
            this.ApellidoMaterno = ApellidoMaterno;
            this.NumeroPersonal = NumeroPersonal;
        }

        public Coordinador()
        {

        }
    }
}
