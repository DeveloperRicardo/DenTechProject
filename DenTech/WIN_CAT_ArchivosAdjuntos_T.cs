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
using System.IO;

namespace DenTech
{
    public partial class WIN_CAT_ArchivosAdjuntos_T : WIN_Template_F
    {
        // Objetos y vairables globales
        ConexionSQL BD = new ConexionSQL();
        MetodosGlobales MG = new MetodosGlobales();
        private int gnIdPaciente = 0;
        private string Path = Environment.CurrentDirectory + "\\Archivos Adjuntos";

        public WIN_CAT_ArchivosAdjuntos_T(int pIdPaciente = 0)
        {
            InitializeComponent();
            gnIdPaciente = pIdPaciente;
        }

        private void WIN_CAT_ArchivosAdjuntos_T_Load(object sender, EventArgs e)
        {
            // Valida el código mientras se ejecuta
            try
            {
                // Crea una carpeta que es donde se guardarán todos los archivos
                if (!Directory.Exists(this.Path))
                    Directory.CreateDirectory(this.Path);

                // Verifica si se puede conectar a la base de datos
                if (BD.Conexion(true))
                    Refrescar();
            }
            catch (Exception ex)
            {
                // Se manda mensaje de error con la exception
                MG.Mensajes(10, ex.Message);
            }
        }

        // Evento del botón Lupa
        private void BTN_Lupa_Click(object sender, EventArgs e)
        {
            // Valida el código mientras se ejecuta
            try
            {
                // Variables y objetos
                OpenFileDialog Archivo = new OpenFileDialog();

                // Filtramos el tipo de archivos que se pueden mostrar y cargar
                Archivo.Title = "Seleccionar archivo.";

                // Verifica que se haya clickeado el botón OK para mostrar la ruta en el control
                if (Archivo.ShowDialog() == DialogResult.OK)
                    EDT_Ruta.Text = Archivo.FileName.ToString();
            }
            catch (Exception ex)
            {
                // Se manda mensaje de error con la exception
                MG.Mensajes(10, ex.Message);
            }
        }

        // evento del botón CargarArchivo
        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            // Valida el código mientras se ejecuta
            try
            {
                // Revisa si el edt de la ruta tiene información
                if (EDT_Ruta.Text == string.Empty)
                    return;

                // Variables
                string Ruta = EDT_Ruta.Text;
                string[] RutaDiv = Ruta.Split('\\');
                string Nombre = RutaDiv[RutaDiv.Length - 1];

                // Se estructura un query para buscar si no existe el archivo
                SqlCommand cmd = BD.conexion.CreateCommand();
                cmd.CommandText = "If Exists" +
                    "(Select ARCHIVOSADJUNTOS.Nombre From ARCHIVOSADJUNTOS Where ARCHIVOSADJUNTOS.Nombre = '" + Nombre + "')" +
                    " Select 'true' Else Select 'false'";

                // Verifica si se encontró el usuario
                if (Convert.ToBoolean(cmd.ExecuteScalar()))
                {
                    // Notifica que un archivo con nombre similar ya existe
                    string Error = "Ya existe un archivo con el mismo nombre.\nSe cambiará el nombre para evitar conflictos técnicos.";
                    MessageBox.Show(Error, "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Se estructura un query para verificar cuantos archivos existen con el mismo nombre
                    cmd.CommandText = "Select Count(Nombre) From ARCHIVOSADJUNTOS Where Nombre = '" + Nombre + "'";
                    DataSet Data = new DataSet();
                    SqlDataAdapter Adaptador = new SqlDataAdapter();
                    Adaptador.SelectCommand = cmd;
                    Adaptador.Fill(Data);

                    // Se separan los nombres de los archivos para agregar el número de la copia
                    int Numero = (int)Data.Tables[0].Rows.Count;
                    string[] NombreDiv = Nombre.Split('.');
                    Nombre = NombreDiv[0] + "(" + (Numero) + ")";
                    Nombre += "." + NombreDiv[NombreDiv.Length - 1];
                }
                // Se realiza una copia en la carpeta donde se guardarán los archivos adjuntos
                File.Copy(Ruta, this.Path + "\\" + Nombre, false);

                // Se estructura query para crear el registro
                cmd.CommandText = "Insert Into ARCHIVOSADJUNTOS(Id_Paciente, Nombre, RutaLogica) " + 
                    "Values(" + gnIdPaciente + ", '" + Nombre + "', '" + this.Path + "\\" + Nombre + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro creado con éxito.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EDT_Ruta.Text = "";
                Refrescar();
            }
            catch (Exception ex)
            {
                // Se manda mensaje de error con la exception
                MG.Mensajes(10, ex.Message);
            }
        }

        // Evento del botón Eliminar
        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            // Valida el código mientras se ejecuta
            try
            {
                // Verifica que la tabla tenga información
                if (DGV_Tabla.RowCount == 0)
                    return;

                // Pregunta al usuario si desea eliminar el registro
                if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "DenTech", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Se estructura el query para eliminar el registro
                    SqlCommand cmd = BD.conexion.CreateCommand();
                    cmd.CommandText = "Delete From ARCHIVOSADJUNTOS Where Id = " + (int)DGV_Tabla.CurrentRow.Cells[0].Value;
                    cmd.ExecuteNonQuery(); // Se ejecuta

                    // Se elimina el archivo de la dirección
                    File.Delete(this.Path + "\\" + DGV_Tabla.CurrentRow.Cells[1].Value.ToString());

                    // Se confirma la eliminación del registro y se actualiza la información de la tabla
                    MessageBox.Show("Registro eliminado con éxito.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refrescar();
                }
            }
            catch (Exception ex)
            {
                // Se manda mensaje de error con la exception
                MG.Mensajes(10, ex.Message);
            }
        }

        // Evento del botón Descargar
        private void BTN_Descargar_Click(object sender, EventArgs e)
        {
            // Valida el código mientras lo ejecuta
            try
            {

            }
            catch (Exception ex)
            {
                // Se manda mensaje de error con la exception
                MG.Mensajes(10, ex.Message);
            }
        }

        // Método Refrescar
        private void Refrescar()
        {
            // Valida el código mientras se ejecuta
            try
            {
                // Se realiza la conexión a la BD y se instancia un objeto de la misma, además se declaran variables
                BD.conexion.CreateCommand();
                SqlCommand cmd = BD.conexion.CreateCommand();
                SqlDataAdapter Adaptador = new SqlDataAdapter();
                var Data = new DataTable();

                // Se estructura el query
                cmd.CommandText = "Select " +
                    "Id, " +
                    "Nombre, " +
                    "RutaLogica " +
                    "From ARCHIVOSADJUNTOS " +
                    "Where Id_Paciente = " + gnIdPaciente;
                cmd.ExecuteNonQuery(); // Se ejecuta

                // Se crea un adaptador de sql, guardará el data source que contiene la información de la consulta
                Adaptador.SelectCommand = cmd;
                Adaptador.Fill(Data);

                // Se inserta la información en el DataGridView
                DGV_Tabla.DataSource = Data;

                // Verifica que la tabla tenga información
                if (DGV_Tabla.RowCount == 0)
                    BTN_Eliminar.Visible = false;
                else
                    BTN_Eliminar.Visible = true;
            }
            catch (Exception ex)
            {
                // Se manda mensaje de error con la exception
                MG.Mensajes(10, ex.Message);
            }
        }
    }
}
