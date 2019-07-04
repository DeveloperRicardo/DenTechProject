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
    public partial class WIN_CAT_Seleccion_F : Form
    {
        // Variables y objetos globales
        ConexionSQL BD = new ConexionSQL();
        int gnOpcion = 0;

        public WIN_CAT_Seleccion_F(int pOpcion)
        {
            InitializeComponent();
            gnOpcion = pOpcion;
        }

        // Evento cuando se carga la ventana
        private void WIN_CAT_Seleccion_F_Load(object sender, EventArgs e)
        {
            // Verifica si se puede conectar con la base de datos
            if (BD.Conexion(true))
            {
                // Verifica el valor del parámetro y asigna información correspondiente
                if (gnOpcion == 1)
                    STC_Titulo.Text = "Usuarios";
                else
                    STC_Titulo.Text = "Pacientes";

                Refrescar();
            }
        }

        // Método Refrescar
        private void Refrescar()
        {
            // Se realiza la conexión a la BD y se instancia un objeto de la misma, además se declaran variables
            BD.conexion.CreateCommand();
            SqlCommand cmd = BD.conexion.CreateCommand();
            SqlDataAdapter Adaptador = new SqlDataAdapter();
            var Data = new DataTable();

            // Revisa como estructurar el query
            if (gnOpcion == 1)
                cmd.CommandText = "Select\n" +
                "Id_Empleado,\n" +
                "NombreCompleto = (EMPLEADOS.Nombre + ' ' + EMPLEADOS.ApellidoP + ' ' + EMPLEADOS.ApellidoM)\n" +
                "From EMPLEADOS" +
                "Where EMPLEADOS.Tipo_Usuario = 2";
            else
                cmd.CommandText = "Select\n" +
                "Id_Paciente,\n" +
                "NombreCompleto = (PACIENTES.Nombre + ' ' + PACIENTES.ApellidoP + ' ' + PACIENTES.ApellidoM)\n" +
                "From PACIENTES";

            cmd.ExecuteNonQuery(); // Se ejecuta

            // Se crea un adaptador de sql, guardará el data source que contiene la información de la consulta
            Adaptador.SelectCommand = cmd;
            Adaptador.Fill(Data);

            // Se inserta la información en el DataGridView
            DGV_TablaSeleccion.DataSource = Data;
        }

        // Evento del botón Cancelar
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Se cierra la ventana
        }

        // Evento del botón Seleccionar
        private void BTN_Seleccionar_Click(object sender, EventArgs e)
        {
           // if (DGV_TablaSeleccion.RowCount != 0)
                //return (int)DGV_TablaSeleccion.CurrentRow.Cells[0].Value;
        }
    }
}
