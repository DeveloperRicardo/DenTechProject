using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DenTech
{
    public partial class WIN_CAT_Implante_T : WIN_Template_F
    {
        // Variables y objetos globales
        ConexionSQL BD = new ConexionSQL();

        public WIN_CAT_Implante_T()
        {
            InitializeComponent();
        }
        // Método Refrescar
        private void Refrescar()
        {
            // Se realiza la conexión a la BD y se instancia un objeto de la misma, además se declaran variables
            BD.conexion.CreateCommand();
            SqlCommand cmd = BD.conexion.CreateCommand();
            SqlDataAdapter Adaptador = new SqlDataAdapter();
            var Data = new DataTable();

            // Se estructura el query
            cmd.CommandText = "Select\n" +
                "Id_Implante,\n" +
                "Descripcion,\n" +
                "Precio \n" +
                "From IMPLANTE";
            cmd.ExecuteNonQuery(); // Se ejecuta

            // Se crea un adaptador de sql, guardará el data source que contiene la información de la consulta
            Adaptador.SelectCommand = cmd;
            Adaptador.Fill(Data);

            // Se inserta la información en el DataGridView
            DGV_TablaImplante.DataSource = Data;
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla y refrescar la tabla
            WIN_CAT_Implante_F Window = new WIN_CAT_Implante_F();
            Window.ShowDialog();
            Refrescar();
        }

        private void WIN_CAT_Implante_T_Load(object sender, EventArgs e)
        {
            // Verifica si se puede conectar con la base de datos
            if (BD.Conexion(true))
                Refrescar();
        }

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            // Verifica que la tabla tenga información
            if (DGV_TablaImplante.RowCount == 0)
                return;

            // Se instancia un objeto de tipo ventana para abrirla y refrescar la tabla
            WIN_CAT_Implante_F Window = new WIN_CAT_Implante_F((int)DGV_TablaImplante.CurrentRow.Cells[0].Value);
            Window.ShowDialog();
            Refrescar();
        }

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            // Verifica que la tabla tenga información
            if (DGV_TablaImplante.RowCount == 0)
                return;

            bool ExisteSeleccion = false;
            //Verifica si el tratamiento esta seleccionado en otro
            SqlCommand cmd = BD.conexion.CreateCommand();
            cmd.CommandText = "IF EXISTS(SELECT * FROM IMPLANTEDIENTE WHERE Id_Implante = " + (int)DGV_TablaImplante.CurrentRow.Cells[0].Value +
                              ") SELECT 'true' ELSE SELECT 'false'";
            ExisteSeleccion = Convert.ToBoolean(cmd.ExecuteScalar());
            if (ExisteSeleccion == true)
            {
                MessageBox.Show("No se puede eliminar el registro debido a que esta en uso.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Pregunta al usuario si desea eliminar el registro
                if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "DenTech", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Se estructura el query para eliminar el registro
                    cmd.CommandText = "Delete From IMPLANTE Where Id_Implante = " + (int)DGV_TablaImplante.CurrentRow.Cells[0].Value;
                    cmd.ExecuteNonQuery(); // Se ejecuta

                    // Se confirma la eliminación del registro y se actualiza la información de la tabla
                    MessageBox.Show("Registro eliminado con éxito.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refrescar();
                }
            }
        }
    }
}
