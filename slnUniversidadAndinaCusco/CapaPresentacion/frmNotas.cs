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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        //Instanciar la clase a travez de un objeto
        //En este parte del codigo se declaran variables globales
        CapaNegocio.Notas notas1 = new CapaNegocio.Notas();

        private void frmNotas_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string estudiante = txtEstudiante.Text;
            int notaA = int.Parse(txtNotaA.Text);
            int notaB = int.Parse(txtNotaB.Text);
            string evaluar = txtEvaluacion.Text;
            notas1.Estudiante = estudiante;
            notas1.NotaA = notaA;
            notas1.NotaB = notaB;
            notas1.Evaluacion = evaluar;

            MessageBox.Show("Se han generado correctamente los datos del Docente");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1
            string estudiante = notas1.Estudiante;
            int notaA = notas1.NotaA;
            int notaB = notas1.NotaB;
            string evaluar = notas1.Evaluacion;

            MessageBox.Show("Estudiante: " + estudiante + "NotaA: " + notaA + "NotaB: " + notaB + "Evaluar: " + evaluar);
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            // Mostrar el Metodo u Operacion "Evaluar"
            MessageBox.Show(notas1.Evaluar());
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            // Mostrar el Metodo u Operacion "Evaluar"
            MessageBox.Show(notas1.Verificar());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas1.Guardar());
        }
    }
}
