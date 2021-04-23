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
    public partial class frmAsignatura : Form
    {
        public frmAsignatura()
        {
            InitializeComponent();
        }

        //Instanciar la clase a travez de un objeto
        //En este parte del codigo se declaran variables globales
        CapaNegocio.Asignatura asignatura1 = new CapaNegocio.Asignatura();

        private void frmAsignatura_Load(object sender, EventArgs e)
        {
            
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string profesor = txtProfesor.Text;
            string areaTrabajo = txtAreaTrabajo.Text;
            string curso = txtCurso.Text;
            asignatura1.Profesor = profesor;
            asignatura1.AreaTrabajo = areaTrabajo;
            asignatura1.Curso = curso;
            MessageBox.Show("Se han registrado correctamente los datos de la Asignatura");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1  
            string profesor = asignatura1.Profesor;
            string areaTrabajo = asignatura1.AreaTrabajo;
            string curso = asignatura1.Curso;
            MessageBox.Show("Profesor: " + profesor +  "Area de Trabajo: " + areaTrabajo +  "Curso: " + curso);
        }

        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            // Mostrar el Metodo u Operacion "Enseñar"
            MessageBox.Show(asignatura1.Enseñar());
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            // Mostrar el Metodo u Operacion "Evaluar"
            MessageBox.Show(asignatura1.Evaluar());
        }
    }
}
