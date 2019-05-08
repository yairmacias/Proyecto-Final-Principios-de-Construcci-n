using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
   public  interface IProyectoDAO
    {
        Proyecto RecuperarPorIDProyecto(String idProyecto);
        Proyecto RecuperarPorActividad(String actividad);
        Proyecto RecuperarPorCalendarizacion(int calendarizacion);
        Proyecto RecuperarPorDias(int dias);
        Proyecto RecuperarPorDuracion(String duracion);
        Proyecto RecuperarPorFuncion(String funcion);
        Proyecto RecuperarPorHora(float hora);
        Proyecto RecuperarPorMetodologia(String metodologia);
        Proyecto RecuperarPorNombre(String nombre);
        Proyecto RecuperarPorObjetivoGeneral(String objetivoGeneral);
        Proyecto RecuperarPorObjetivoInmediato(String objetivoInmediato);
        Proyecto RecuperarPorObjetivoMediato(String objetivoMediato);
        Proyecto RecuperarPorRecursoEconomico(String recursoEconomico);
        Proyecto RecuperarPorRecursoHumano(String recursoHumano);
        Proyecto RecuperarPorRecursoMaterial(String recursoMaterial);
        Proyecto RecuperarPorResponsabilidad(String reponsabilidad);
        List<Proyecto> GetProyecto(String criterio);
       


    }
}
