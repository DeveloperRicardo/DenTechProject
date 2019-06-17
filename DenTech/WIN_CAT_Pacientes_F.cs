using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenTech
{
    public partial class WIN_CAT_Pacientes_F : Form
    {
        // Variables globales
        int gnIdPaciente = 0;

        // Evento inicializador de la ventana
        public WIN_CAT_Pacientes_F(int pIdPaciente = 0)
        {
            InitializeComponent();
            gnIdPaciente = pIdPaciente;
        }

        private void WIN_CAT_Pacientes_F_Load(object sender, EventArgs e)
        {

        }

        // Evento botón Cerrar
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra la ventana
        }

        // Evento botón Aceptar
        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            // Valida que los campos tengan información
            ValidarCampos();
        }

        // Método ValidarCampos
        private void ValidarCampos()
        {
            // Verifica que el campo Usuario tenga información
            if (EDT_Nombre.TextLength == 0 || EDT_Nombre.Text == "")
            {
                // Marca error y te regresa al campo
                MessageBox.Show("El campo Nombre no puede ir vacío.", "DenTech Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_Nombre.Focus();
                return;
            }

            // Verifica que el campo ApellidoP tenga información
            if (EDT_ApellidoP.TextLength == 0 || EDT_ApellidoP.Text == "")
            {
                // Marca error y te regresa al campo
                MessageBox.Show("El campo Ap. Paterno no puede ir vacío.", "DenTech Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_ApellidoP.Focus();
                return;
            }

            // Verifica que el campo ApellidoM tenga información
            if (EDT_ApellidoM.TextLength == 0 || EDT_ApellidoM.Text == "")
            {
                // Marca error y te regresa al campo
                MessageBox.Show("El campo Ap. Materno no puede ir vacío.", "DenTech Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_ApellidoM.Focus();
                return;
            }

            // Verifica que el campo Edad tenga información
            if (EDT_Edad.TextLength == 0 || EDT_Edad.Text == "")
            {
                // Marca error y te regresa al campo
                MessageBox.Show("El campo Edad no puede ir vacío.", "DenTech Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_Edad.Focus();
                return;
            }

            // Verifica que el campo Teléfono tenga información
            if (EDT_Telefono.TextLength == 0 || EDT_Telefono.Text == "")
            {
                // Marca error y te regresa al campo
                MessageBox.Show("El campo Teléfono no puede ir vacío.", "DenTech Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_Telefono.Focus();
                return;
            }

            // Verifica que el campo TeléfonoEm tenga información
            if (EDT_TelefonoEm.TextLength == 0 || EDT_TelefonoEm.Text == "")
            {
                // Marca error y te regresa al campo
                MessageBox.Show("El campo Tel. Emergencia no puede ir vacío.", "DenTech Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_TelefonoEm.Focus();
                return;
            }

            // Verifica que el campo Dirección tenga información
            if (EDT_Direccion.TextLength == 0 || EDT_Direccion.Text == "")
            {
                // Marca error y te regresa al campo
                MessageBox.Show("El campo Tel. Dirección no puede ir vacío.", "DenTech Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_Direccion.Focus();
                return;
            }
        }
    }
}
