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
    public partial class frmRector : Form
    {
        public frmRector()
        {
            InitializeComponent();
        }

        //Instanciar la clase a travez de un objeto
        //En este parte del codigo se declaran variables globales
        CapaNegocio.Rector rector1 = new CapaNegocio.Rector();

        private void frmRector_Load(object sender, EventArgs e)
        {

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            int edad = int.Parse(txtEdad.Text);
            int Dni = int.Parse(txtDni.Text);
            string profesion = txtProfesion.Text;
            rector1.Apellidos = apellidos;
            rector1.Nombres = nombres;
            rector1.Edad = edad;
            rector1.DNI = Dni;
            rector1.Profesion = profesion;

            MessageBox.Show("Se han generado correctamente los datos del Rector1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1
            string apellidos = rector1.Apellidos;
            string nombres = rector1.Nombres;
            int edad = rector1.Edad;
            int dni = rector1.DNI;
            string profesion = rector1.Profesion;
            MessageBox.Show("Apellidos: " + apellidos + "Nombres: " + nombres + "Edad: " + edad + "DNI: " + dni + "Profesion: " + profesion);
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            // Mostrar el Metodo u Operacion "Evaluar"
            MessageBox.Show(rector1.Evaluar());
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Trabajar());
        }

        private void btnDirigir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Dirigir());
        }

        private void btnPlanificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Planificar());
        }
    }
}
