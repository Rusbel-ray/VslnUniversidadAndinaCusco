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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario del "Alumno"
            frmAlumno formulario = new frmAlumno();
            formulario.Show();
        }

        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Lamar al formulario "Docente"
            frmDocente formulario = new frmDocente();
            formulario.Show();
        }

        private void laboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Lamar al formulario "Laboratorio"
            frmLaboratorio formulario = new frmLaboratorio();
            formulario.Show();
        }
        
        private void asignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Lamar al formulario "Asignatura"
            frmAsignatura formulario = new frmAsignatura();
            formulario.Show();
        }

        private void jefeDePracticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Lamar al forumulario "JefePractica"
            frmJefePractica formulario = new frmJefePractica();
            formulario.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Lamar al forumulario "Notas"
            frmNotas formulario = new frmNotas();
            formulario.Show();
        }

        private void rectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Lamar al forumulario "Rector"
            frmRector formulario = new frmRector();
            formulario.Show();
        }

        private void practicasPreProfesionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Lamar al forumulario "PPP-(Practicas Pre Profesionales)"
            frmPPP formulario = new frmPPP();
            formulario.Show();
        }
    }
}
