﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Alumno
    {
        //Atributos
        private string apellidos;
        private string nombres;
        private int edad;
        private string lugarNacimiento;
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
        public string LugarNacimiento
        {
            get { return this.lugarNacimiento; }
            set { this.lugarNacimiento = value; }
        }

        //Metodos u operaciones
        public string Estudiar()
        {
            return "No se ha implementado el metodo estudiar";
        }
        public string Trabajar()
        {
            return "No se ha implementado el metodo trabajar";
        }
        public string AprobarExamen()
        {
            return "No se ha implementado el metodo aprobar examen";
        }
    }
}
