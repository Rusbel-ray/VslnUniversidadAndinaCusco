using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Asignatura
    {
        //Atributos
        private string profesor;
        private string areaTrabajo;
        private string curso;

        //Propiedades
        public string Profesor
        {
            get { return profesor; } // Lectura del atributo
            set { profesor = value; } // Escritura del atributo
        }
        public string AreaTrabajo
        {
            get { return areaTrabajo; }
            set { areaTrabajo = value; }
        }
        public string Curso
        {
            get { return this.curso; }  // (this) es opcional, no cambia mucho, y actuda de la misma forma
            set { this.curso = value; } // (this) es opcional, no cambia mucho, y actuda de la misma forma
        }

        //Metodos u operaciones
        public string Enseñar()
        {
            return "No se ha implementado el metodo Enseñar";
        }
        public string Evaluar()
        {
            return "No se ha implementado el metodo Evaluar";
        }
    }
}
