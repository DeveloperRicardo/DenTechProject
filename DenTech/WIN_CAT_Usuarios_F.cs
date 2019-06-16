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
    public partial class WIN_CAT_Usuarios_F : Form
    {
        // Variables globales
        int gnIdUsuario = 0;

        public WIN_CAT_Usuarios_F(int pIdUsuario = 0)
        {
            InitializeComponent();
            gnIdUsuario = pIdUsuario;
        }

        private void WIN_USU_Usuarios_F_Load(object sender, EventArgs e)
        {

        }

        // Evento del botón Cancelar
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Se cierra la ventana
        }

        // Método que verifica si los campos tienen información
        private void ValidarCampos()
        {
            // Verifica que el campo Usuario tenga información
            if (EDT_Usuario.TextLength == 0 || EDT_Usuario.Text == "")
            {
                // Marca error y te regresa al campo
                MessageBox.Show("El campo Usuario no puede ir vacío.", "DenTech Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_Usuario.Focus();
                return;
            }

            // Verifica que el campo Nombre tenga información
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

            // VErifica que el campo Password tenga información
            if (EDT_Password.TextLength == 0 || EDT_Password.Text == "")
            {
                // Marca error y te regresa al campo
                MessageBox.Show("El campo Contraseña no puede ir vacío.", "DenTech Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDT_Password.Focus();
                return;
            }
        }

        // Evento del botón Aceptar
        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            // Revisa los campos
            ValidarCampos();

            // Cierra la ventana
            this.Close(); 
        }
    }
}
