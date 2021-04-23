using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class PPP_Practicas_Pre_Profesionales_
    {
        //Atributos
        private string profesorPractica;
        private string practicante;
        private int nota;

        //Propiedades
        public string ProfesorPractica
        {
            get { return profesorPractica; } // Lectura del atributo
            set { profesorPractica = value; } // Escritura del atributo
        }
        public string Practicante
        {
            get { return practicante; }
            set { practicante = value; }
        }

        public int Nota
        {
            get { return this.nota; }
            set { this.nota = value; }
        }

        //Metodos u operaciones
        public string Practicar()
        {
            return "No se ha implementado el metodo Practicar";
        }
        public string Trabajar()
        {
            return "No se ha implementado el metodo Trabajar";
        }
        public string Evaluar()
        {
            return "No se ha implementado el metodo Evaluar";
        }

    }
}
