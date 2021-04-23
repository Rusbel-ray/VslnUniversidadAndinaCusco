using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Rector
    {
        //Atributos
        private string apellidos;
        private string nombres;
        private int Dni;
        private int edad;
        private string profesion;

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
            set { this.edad = value; }
        }
        public int DNI
        {
            get { return Dni; }  // (this) es opcional, no cambia mucho, y actuda de la misma forma
            set { Dni = value; } // (this) es opcional, no cambia mucho, y actuda de la misma forma
        }

        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
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
        public string Dirigir()
        {
            return "No se ha implementado el metodo Dirigir";
        }
        public string Planificar()
        {
            return "No se ha implementado el metodo Planificar";
        }
    }
}
