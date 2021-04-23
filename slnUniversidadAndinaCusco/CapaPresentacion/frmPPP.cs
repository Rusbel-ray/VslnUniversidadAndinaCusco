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
    public partial class frmPPP : Form
    {
        public frmPPP()
        {
            InitializeComponent();
        }
        //Instanciar la clase a travez de un objeto
        //En este parte del codigo se declaran variables globales
        CapaNegocio.PPP_Practicas_Pre_Profesionales_ ppP1 = new CapaNegocio.PPP_Practicas_Pre_Profesionales_();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string profesorPractica = txtProfesorPractica.Text;
            string practicante = txtPracticante.Text;
            int nota = int.Parse(txtNota.Text);
            ppP1.ProfesorPractica = profesorPractica;
            ppP1.Practicante = practicante;
            ppP1.Nota = nota;

            MessageBox.Show("Se han generado correctamente los datos del Rector1");
        }

        private void frmPPP_Load(object sender, EventArgs e)
        {

        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1
            string profesionPractica = ppP1.ProfesorPractica;
            string practicante = ppP1.Practicante;
            int nota = ppP1.Nota;

            MessageBox.Show("Profesor de Practica: " + profesionPractica + "Nombre del Practicante: " + practicante + "Nota: " + nota);
        }

        private void btnPracticar_Click(object sender, EventArgs e)
        {
            // Mostrar el Metodo u Operacion "Evaluar"
            MessageBox.Show(ppP1.Practicar());
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppP1.Trabajar());
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppP1.Evaluar());
        }

        private void txtNota_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
