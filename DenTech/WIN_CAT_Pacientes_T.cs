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
    public partial class WIN_CAT_Pacientes_T : Form
    {
        public WIN_CAT_Pacientes_T()
        {
            InitializeComponent();
        }

        // Evento botón cancelar
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Se cierra la ventana
        }

        // Evento botón Agregar
        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            // Se insatncia un objeto de tipo ventana para abrirla y refrescar la tabla
            WIN_CAT_Pacientes_F Window = new WIN_CAT_Pacientes_F();
            Window.ShowDialog();
            // Refrescar();
        }

        // Evento botón Modificar
        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            // Verifica que la tabla tenga información
            if (DGV_TablaPacientes.RowCount == 0)
                return;

            // Se insatncia un objeto de tipo ventana para abrirla y refrescar la tabla
            WIN_CAT_Pacientes_F Window = new WIN_CAT_Pacientes_F((int)DGV_TablaPacientes.CurrentRow.Cells[0].Value);
            Window.ShowDialog();
            // Refrescar();
        }
    }
}
