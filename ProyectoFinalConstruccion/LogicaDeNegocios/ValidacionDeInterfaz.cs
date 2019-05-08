using System;
using System.Windows;
using System.Windows.Controls;
using BaseDeDatos;


namespace LogicaDeNegocios
{
   public class ValidacionDeInterfaz
    {
        public static Boolean ValidarTextbox(UIElementCollection ElementoColeccion)
        {
            Boolean bandera = false;

            foreach (UIElement ElementoInterfaz in ElementoColeccion)
            {
                if (ElementoInterfaz is TextBox TextBox)
                {
                    if (TextBox.Text == "")
                    {
                        bandera = false;
                        break;
                    }
                    else
                    { bandera = true; }
                }
            }

            return bandera;
        }

        public static Boolean GuardarRegistroAlumno(Alumno alumno)
        {
            return AlumnoDAO.ResgistrarDatosAlumno(alumno);
        }
    }
}
