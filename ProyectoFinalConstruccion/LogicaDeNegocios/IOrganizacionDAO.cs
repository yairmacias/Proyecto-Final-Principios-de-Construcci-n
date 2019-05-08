using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public interface IOrganizacionDAO
    {
        Organizacion RecuperarPorIDOrganizacion(String idOrganizacion);
        Organizacion RecuperarPorNombre(String nombre);
        Organizacion RecuperarPorCalle(String calle);
        Organizacion RecuperarPorCiudad(String ciudad);
        Organizacion RecuperarPorCodigoPostal(String codigoPostal);
        Organizacion RecuperarPorColonia(String colonia);
        Organizacion RecuperarPorCorreoElectronico(String correoElectronico);
        Organizacion RecuperarPorEstado(String estado);
        Organizacion RecuperarPorNumeroInterno(int numeroInterno);
        Organizacion RecuperarPorSector(String sector);
        Organizacion RecuperarPorTelefono(int telefono);
        List<Organizacion> GetOrganizacion(String criterio);

    }
}
