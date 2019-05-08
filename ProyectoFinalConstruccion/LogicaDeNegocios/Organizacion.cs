using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public class Organizacion
    {
        public String IDOrganizacion { get; set; }
        public String Nombre { get; set; }
        public String Calle { get; set; }
        public String Ciudad { get; set; }
        public String CodigoPostal { get; set; }
        public String Colonia { get; set; }
        public String CorreoElectronico { get; set; }
        public String Estado { get; set; }
        public int NumeroInterno { get; set; }
        public String Sector { get; set; }
        public int Telefono { get; set; }

        public Organizacion(String IDOrganizacion, String Nombre, String Calle, String Ciudad, String CodigoPostal, String Colonia,
            String CorreoElectronico, String Estado, int NumeroInterno, String Sector, int Telefono)
        {
            this.IDOrganizacion = IDOrganizacion;
            this.Nombre = Nombre;
            this.Calle = Calle;
            this.Ciudad = Ciudad;
            this.CodigoPostal = CodigoPostal;
            this.Colonia = Colonia;
            this.CorreoElectronico = CorreoElectronico;
            this.Estado = Estado;
            this.NumeroInterno = NumeroInterno;
            this.Sector = Sector;
            this.Telefono = Telefono;
        }

        public Organizacion()
        {

        }
    }
}
