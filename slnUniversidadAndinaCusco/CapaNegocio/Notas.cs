using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Notas
    {
        //Atributos
        private string estudiante;
        private int notaA;
        private int notaB;
        private string evaluacion;

        //Propiedades
        public string Evaluacion
        {
            get { return evaluacion; } // Lectura del atributo
            set { evaluacion = value; } // Escritura del atributo
        }
        public string Estudiante
        {
            get { return estudiante; }
            set { estudiante = value; }
        }
        public int NotaA
        {
            get { return notaA; }  // (this) es opcional, no cambia mucho, y actuda de la misma forma
            set { notaA = value; } // (this) es opcional, no cambia mucho, y actuda de la misma forma
        }
        public int NotaB
        {
            get { return notaB; }  // (this) es opcional, no cambia mucho, y actuda de la misma forma
            set { notaB = value; } // (this) es opcional, no cambia mucho, y actuda de la misma forma
        }

        //Metodos u operaciones
        public string Guardar()
        {
            return "No se ha implementado el metodo Guardar";
        }
        public string Verificar()
        {
            return "No se ha implementado el metodo Verificar";
        }
        public string Evaluar()
        {
            return "No se ha implementado el metodo Evaluar";
        }

    }
}
