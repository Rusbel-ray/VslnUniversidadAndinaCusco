﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmAlumno : Form
    {
        public frmAlumno()
        {
            InitializeComponent();
        }

        //Instanciar la clase a travez de un objeto
        //En este parte del codigo se declaran variables globales
        CapaNegocio.Alumno alumno1 = new CapaNegocio.Alumno();

        private void Form1_Load(object sender, EventArgs e)
        {        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            int edad = int.Parse(txtEdad.Text);
            string lugarNacimiento = txtLugarNacimiento.Text;
            alumno1.Apellidos = apellidos;
            alumno1.Nombres = nombres;
            alumno1.Edad = edad;
            alumno1.LugarNacimiento = lugarNacimiento;
            MessageBox.Show("Se han registrado correctamente los datos de Alumno 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1  
            string apellidos = alumno1.Apellidos;
            string nombres = alumno1.Nombres;
            int edad = alumno1.Edad;
            string lugarNacimiento = alumno1.LugarNacimiento;
            MessageBox.Show("Apellidos: " + apellidos + "Nombres: " + "Edad: " 
                            + edad + "Lugar de Nacimiento" + lugarNacimiento);
        }

        private void btnEstudiar_Click(object sender, EventArgs e)
        {
            // Mostrar el Metodo u Operacion "Estudiar"
            MessageBox.Show(alumno1.Estudiar());
        }
        private void btnAprobarExamen_Click(object sender, EventArgs e)
        {
            // Mostrar el Metodo u Operacion "Trabajar"
            MessageBox.Show(alumno1.AprobarExamen());
        }
        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            // Mostrar el Metodo u Operacion "Trabajar"
            MessageBox.Show(alumno1.Trabajar());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
