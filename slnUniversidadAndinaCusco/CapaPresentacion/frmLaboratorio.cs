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
    public partial class frmLaboratorio : Form
    {
        public frmLaboratorio()
        {
            InitializeComponent();
        }

        //Instanciar la clase a travez de un objeto
        //En este parte del codigo se declaran variables globales
        CapaNegocio.Laboratorio laboratorio1 = new CapaNegocio.Laboratorio();

        private void frmLaboratorio_Load(object sender, EventArgs e)
        {

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string instrumentos = txtInstrumentos.Text;
            string materiales = txtMateriales.Text;
            string lugarTrabajo = txtLugarTrabajo.Text;
            laboratorio1.Instrumentos = instrumentos;
            laboratorio1.Materiales = materiales;
            laboratorio1.LugarTrabajo = lugarTrabajo;
            MessageBox.Show("Se han registrado correctamente los datos de Laboratorio1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Mostrar los datos almacenados en el objeto 1  
            string instrumentos = laboratorio1.Instrumentos;
            string materiales = laboratorio1.Materiales;
            string lugarTrabajo = laboratorio1.LugarTrabajo;
            MessageBox.Show("Instrumentos: " + instrumentos + "Area de Trabajo: " + materiales + "Curso: " + lugarTrabajo);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Mostrar el Metodo u Operacion "Guardar"
            MessageBox.Show(laboratorio1.Guardar());
        }

        private void btnCuidar_Click(object sender, EventArgs e)
        {
            // Mostrar el Metodo u Operacion "Guardar"
            MessageBox.Show(laboratorio1.Cuidar());
        }
    }
}
