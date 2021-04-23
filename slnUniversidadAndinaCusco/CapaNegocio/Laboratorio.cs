using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Laboratorio
    {
        //Atributos
        private string instrumentos;
        private string materiales;
        private string lugarTrabajo;

        //Propiedades
        public string Instrumentos
        {
            get { return instrumentos; } // Lectura del atributo
            set { instrumentos = value; } // Escritura del atributo
        }
        public string Materiales
        {
            get { return materiales; }
            set { materiales = value; }
        }
        public string LugarTrabajo
        {
            get { return this.lugarTrabajo; }  // (this) es opcional, no cambia mucho, y actuda de la misma forma
            set { this.lugarTrabajo = value; } // (this) es opcional, no cambia mucho, y actuda de la misma forma
        }

        //Metodos u operaciones
        public string Guardar()
        {
            return "No se ha implementado el metodo Guardar";
        }
        public string Cuidar()
        {
            return "No se ha implementado el metodo Cuidar";
        }
       
    }
}
