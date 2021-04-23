using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class JefePractica
    {
        //Atributos
        private string apellidos;
        private string nombres;
        private int edad;
        private int Dni;

        //Propiedades
        public string Apellidos
        {
            get { return apellidos; } // Lectura del atributo
            set { apellidos = value; } // Escritura del atributo
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public int Edad
        {
            get { return this.edad; }  // (this) es opcional, no cambia mucho, y actuda de la misma forma
            set { this.edad = value; } // (this) es opcional, no cambia mucho, y actuda de la misma forma
        }
        public int DNI
        {
            get { return Dni; }  // (this) es opcional, no cambia mucho, y actuda de la misma forma
            set { Dni = value; } // (this) es opcional, no cambia mucho, y actuda de la misma forma
        }

        //Metodos u operaciones
        public string Evaluar()
        {
            return "No se ha implementado el metodo Evaluar";
        }
        public string Trabajar()
        {
            return "No se ha implementado el metodo Trabajar";
        }

    }
}
