using System;
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
    public partial class frmDocente : Form
    {
        public frmDocente()
        {
            InitializeComponent();
        }

        //Instanciar la clase a travez de un objeto
        //En este parte del codigo se declaran variables globales
        CapaNegocio.Docente Docente1 = new CapaNegocio.Docente();

        private void frmDocente_Load(object sender, EventArgs e)
        {

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            int edad = int.Parse(txtEdad.Text);
            int Dni = int.Parse(txtDni.Text);
            DateTime fechaNacimiento = dtFechaNacimiento.Value;
            Docente1.Apellidos = apellidos;
            Docente1.Nombres = nombres;
            Docente1.Edad = edad;
            Docente1.DNI = Dni;
            Docente1.FechaNacimiento = fechaNacimiento;

            MessageBox.Show("Se han generado correctamente los datos del Docente");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1
            string apellidos = Docente1.Apellidos;
            string nombres = Docente1.Nombres;
            int edad = Docente1.Edad;
            int dni = Docente1.DNI;
            DateTime fechaNacimiento = Docente1.FechaNacimiento;
            MessageBox.Show("Apellidos: " + apellidos + "Nombres: " + nombres + "Edad: " + edad + "DNI: " + dni + "Fecha de Nacimiento: " + fechaNacimiento);
        }

        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Docente1.Enseñar());
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Docente1.Trabajar());
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Docente1.Aprobar());
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Docente1.Desaprobar());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
