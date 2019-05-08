using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public interface IAlumnoDAO
    {
        Alumno RecuperarPorNombre(String nombre);
        Alumno RecuperarPorApellidoPaterno(String apellidoPaterno);
        Alumno RecuperarPorApellidoMaterno(String apellidoMaterno);
        Alumno RecuperarPorCorreoElectronico(String correoElectronico);
        Alumno RecuperarPorMatricula(String matricula);
        Alumno RecuperarPorSeccion(String seccion);
        Alumno RecuperarPorBloque(String bloque);
        List<Alumno> GetAlumno(String criterio);
    }
}
