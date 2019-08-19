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
    public partial class WIN_CAT_Seleccion_F : WIN_Template_F
    {
        // Variables y objetos globales
        ConexionSQL BD = new ConexionSQL();
        int gnOpcion = 0;

        // Propiedades
        private int ReturnId;

        // Propiedades encapsuladas
        public int _ReturnId { get => ReturnId; set => ReturnId = value; }

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
                // Verifica que título se colocará
                switch (gnOpcion)
                {
                    case 1: TituloBanner = "Seleccionar Usuarios"; break;
                    case 2: TituloBanner = "Seleccionar Pacientes"; break;
                    case 3: TituloBanner = "Seleccionar Servicios"; break;
                    default: TituloBanner = "Nande"; break;
                }
                Refrescar();
            }
        }

        // Evento del botón Seleccionar
        private void BTN_Seleccionar_Click(object sender, EventArgs e)
        {
            // Verifica que la tabla tenga información
            if (DGV_TablaSeleccion.RowCount == 0)
                return;

            // Se asigna el id seleccionado y se cierra la ventana
            this.ReturnId = (int)DGV_TablaSeleccion.CurrentRow.Cells[0].Value;
            this.Close();
        }

        // Evento del botón Cancelar
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Se cierra la ventana
        }

        // Método Refrescar
        private void Refrescar()
        {
            // Se realiza la conexión a la BD y se instancia un objeto de la misma, además se declaran variables
            BD.conexion.CreateCommand();
            SqlCommand cmd = BD.conexion.CreateCommand();
            SqlDataAdapter Adaptador = new SqlDataAdapter();
            var Data = new DataTable();

            // Revisa de que tabla se obtendrán los datos
            switch (gnOpcion)
            {
                case 1:
                    // Estructura el query de Empleados
                    cmd.CommandText = "Select\n" +
                    "Id_Empleado as Id,\n" +
                        "NombreCompleto = (EMPLEADOS.Nombre + ' ' + EMPLEADOS.ApellidoP + ' ' + EMPLEADOS.ApellidoM)\n" +
                        "From EMPLEADOS\n" +
                        "Where EMPLEADOS.Tipo_Usuario = 1";
                    break;
                case 2:
                    // Estructura el query de Pacientes
                    cmd.CommandText = "Select\n" +
                        "Id_Paciente as Id,\n" +
                        "NombreCompleto = (PACIENTES.Nombre + ' ' + PACIENTES.ApellidoP + ' ' + PACIENTES.ApellidoM)\n" +
                        "From PACIENTES";
                    break;
                case 3:
                    // Estructura el query de Servicios
                    cmd.CommandText = "Select " +
                        "Id_Servicios as Id, " +
                        "Descripcion as NombreCompleto " +
                        "From Servicios";
                    break;
                default: MessageBox.Show("NANDE?", "Super Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
            }

            cmd.ExecuteNonQuery(); // Se ejecuta

            // Se crea un adaptador de sql, guardará el data source que contiene la información de la consulta
            Adaptador.SelectCommand = cmd;
            Adaptador.Fill(Data);

            // Se inserta la información en el DataGridView
            DGV_TablaSeleccion.DataSource = Data;
        }
    }
}
