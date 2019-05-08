using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public interface IEncargadoDAO
    {
        Encargado RecuperarPorIDEncargado(String idEncargado);
        Encargado RecuperarPorNombre(String nombre);
        Encargado RecuperarPorApellidoPaterno(String apellidoPaterno);
        Encargado RecuperarPorApellidoMaterno(String apellidoMaterno);
        Encargado RecuperarPorCorreoElectronico(String correoElectronico);
        Encargado RecuperarPorTelefono(int telefono);
        List<Encargado> GetEncargado(String criterio);



    }
}
