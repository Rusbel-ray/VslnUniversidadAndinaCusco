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
    public partial class frmJefePractica : Form
    {
        public frmJefePractica()
        {
            InitializeComponent();
        }

        //Instanciar la clase a travez de un objeto
        //En este parte del codigo se declaran variables globales
        CapaNegocio.JefePractica jefePractica1 = new CapaNegocio.JefePractica();

        private void frmJefePractica_Load(object sender, EventArgs e)
        {

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            int edad = int.Parse(txtEdad.Text);
            int Dni = int.Parse(txtDni.Text);
            jefePractica1.Apellidos = apellidos;
            jefePractica1.Nombres = nombres;
            jefePractica1.Edad = edad;
            jefePractica1.DNI = Dni;

            MessageBox.Show("Se han generado correctamente los datos del Docente");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1
            string apellidos = jefePractica1.Apellidos;
            string nombres = jefePractica1.Nombres;
            int edad = jefePractica1.Edad;
            int dni = jefePractica1.DNI;

            MessageBox.Show("Apellidos: " + apellidos + "Nombres: " + nombres + "Edad: " + edad + "DNI: " + dni );
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            // Mostrar el Metodo u Operacion "Evaluar"
            MessageBox.Show(jefePractica1.Evaluar());
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica1.Trabajar());
        }
    }
}
