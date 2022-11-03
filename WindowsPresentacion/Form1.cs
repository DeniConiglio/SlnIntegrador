using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.Models.Base;
using Negocio;
using Datos;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {

        AdmMedico admMedicos = new AdmMedico();
        AdmPaciente admPacientes = new AdmPaciente();
        AdmHabitacion admHabitaciones = new AdmHabitacion();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarMedicos_Click(object sender, EventArgs e)
        {

                gridListaMedPac.DataSource = admMedicos.Listar();

            
        }

        private void btnMostrarPacientes_Click(object sender, EventArgs e)
        {
            gridListaMedPac.DataSource = admPacientes.Listar();
        }

        private void btnMostrarHabitaciones_Click(object sender, EventArgs e)
        {
            foreach (Habitacion habitacion in admHabitaciones.Listar())
            {
                lstHabitaciones.Items.Add("Nro: " + habitacion.Numero + ", Estado: " + habitacion.Estado);
            }
        }

        private void btnClinicos_Click(object sender, EventArgs e)
        {
            lstMedicosClinicos.Items.Clear();

            foreach (Medico medico in admMedicos.Listar("Medico Clinico"))
            {

                lstMedicosClinicos.Items.Add("medicos clinicos:  "+medico.Nombre + " " + medico.Apellido);
            }
        }
    }
}
