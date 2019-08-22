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
    public partial class WIN_CAT_Citas_T : WIN_Template_T
    {
        // Variables y objetos globales
        ConexionSQL BD = new ConexionSQL();
        MetodosGlobales Glo = new MetodosGlobales();
        List<FlowLayoutPanel> Lista = new List<FlowLayoutPanel>();
        DateTime FechaActual = DateTime.Today;
        int Id = 0;
        int IdPaciente = 0;
        string FechaInicio = "";

        public WIN_CAT_Citas_T()
        {
            InitializeComponent();
        }

        // Evento al cargar la ventana
        private void WIN_CAT_Citas_T_Load(object sender, EventArgs e)
        {
            try
            {
                // Verifica si se puede conectar con la base de datos
                if (BD.Conexion(true))
                {
                    // Genera los cuadros del mes y agrega la información
                    GenerarPaneles(42);
                    AgregarNumeroDia(ObtenerPrimerDiaMes(), ObtenerDiasMes());
                    CargarCitas(ObtenerPrimerDiaMes());

                    // Muestra la información del mes y año actual
                    STC_MesAño.Text = this.FechaActual.ToString("MMMM, yyyy");
                }
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        // Evento del botón Atrás
        private void BTN_Atras_Click(object sender, EventArgs e)
        {
            try
            {
                // Se retrocede un mes y se muestra
                this.FechaActual = this.FechaActual.AddMonths(-1);
                MostrarFechaActual();
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        // Evento del botón Fecha Actual
        private void BTN_FechaActual_Click(object sender, EventArgs e)
        {
            try
            {
                // Cambia el valor al de la fecha actual y la muestra
                this.FechaActual = DateTime.Today;
                MostrarFechaActual();
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        // Evento del botón Siguiente
        private void BTN_Adelante_Click(object sender, EventArgs e)
        {
            try
            {
                // Se avanza un mes y se muestra
                this.FechaActual = this.FechaActual.AddMonths(1);
                MostrarFechaActual();
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        // Evento del botón Cancelar
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Se cierra la ventana
        }

        // Método GenerarCuadros
        private void GenerarPaneles(int NumDias)
        {
            try
            {
                // Se limpia el control y el objeto
                LAYOUT_Cuerpo.Controls.Clear();
                Lista.Clear();

                // Clico que se repetirá por el número de días indicado
                for (int i = 1; i <= NumDias; i++)
                {
                    // Se instancia objeto de tipo Layout
                    FlowLayoutPanel Cuadro = new FlowLayoutPanel();

                    // Se agrega información a sus propiedades
                    Cuadro.Name = $"LAYOUT_Dia{i}";
                    Cuadro.Size = new Size(132, 71);
                    Cuadro.BackColor = Color.White;
                    Cuadro.BorderStyle = BorderStyle.FixedSingle;
                    Cuadro.Cursor = Cursors.Hand;
                    Cuadro.Click += new EventHandler(AgregarCita);
                    Cuadro.AutoScroll = true;
                    LAYOUT_Cuerpo.Controls.Add(Cuadro);
                    Lista.Add(Cuadro);
                }
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        // Método AgregarNumeroDia
        private void AgregarNumeroDia(int DiaI, int DiaF)
        {
            try
            {
                // Limpia el número de los días
                foreach (FlowLayoutPanel STC in Lista)
                {
                    STC.Controls.Clear();
                    STC.Tag = 0;
                }

                // Variable
                int Dia = 1;

                // Ciclo que se repetirá por la cantidad de registros en la lista
                for (int i = 1; i <= DiaF; i++)
                {
                    // Se instancia objeto de tipo Label
                    Label Static = new Label();

                    // Se agregan las propiedades del objeto
                    Static.Name = $"STC_DiaNum{i}";
                    Static.AutoSize = false;
                    Static.TextAlign = ContentAlignment.MiddleRight;
                    Static.Size = new Size(119, 25);
                    Static.Text = Dia.ToString();
                    Lista[(i - 1) + (DiaI - 1)].Tag = i;
                    Lista[(i - 1) + (DiaI - 1)].Controls.Add(Static);
                    Dia++;
                }
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        // Método MostrarFechaActual
        private void MostrarFechaActual()
        {
            try
            {
                // Muestra la información de la fecha posicionada
                STC_MesAño.Text = this.FechaActual.ToString("MMMM, yyyy");
                int PrimerDiaMes = ObtenerPrimerDiaMes();
                AgregarNumeroDia(PrimerDiaMes, ObtenerDiasMes());
                CargarCitas(PrimerDiaMes);
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        // Método ObtenerPrimerDiaMes
        private int ObtenerPrimerDiaMes()
        {
            try
            {
                // Variable de mes
                string Mes = this.FechaActual.Month.ToString();

                // Verifica que el mes tenga 1 caracter para agregar el 0
                if (Mes == "1" || Mes == "2" || Mes == "3" || Mes == "4" || Mes == "5" || Mes == "6" || Mes == "7" || Mes == "8" || Mes == "9")
                    Mes = "0" + Mes;

                // Crea la fecha en el formato que corresponde para cambiar la estructura del calendario
                this.FechaInicio = this.FechaActual.Year.ToString() + "-" + Mes + "-01";
                DateTime Fecha = Convert.ToDateTime(this.FechaInicio);
                return (int)Fecha.DayOfWeek + 1;
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
                return 0;
            }
        }

        // Método ObtenerDiasMes
        public int ObtenerDiasMes()
        {
            try
            {
                // Variable de mes
                string Mes = this.FechaActual.Month.ToString();

                // Verifica que el mes tenga 1 caracter para agregar el 0
                if (Mes == "1" || Mes == "2" || Mes == "3" || Mes == "4" || Mes == "5" || Mes == "6" || Mes == "7" || Mes == "8" || Mes == "9")
                    Mes = "0" + Mes;

                // Crea la fecha en el formato que corresponde para cambiar la estructura del calendario
                this.FechaInicio = this.FechaActual.Year.ToString() + "-" + Mes + "-01";
                DateTime Fecha = Convert.ToDateTime(this.FechaInicio);
                return (int)Fecha.AddMonths(1).AddDays(-1).Day;
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
                return 0;
            }
        }

        // Método CargarCitas
        private void CargarCitas(int Inicio)
        {
            try
            {
                // Variables de fecha 
                DateTime FechaI = Convert.ToDateTime(this.FechaInicio);
                DateTime FechaF = FechaI.AddMonths(1).AddDays(-1);

                // Se realiza la conexión a la BD y se instancia un objeto de la misma, además se declaran variables
                BD.conexion.CreateCommand();
                SqlCommand cmd = BD.conexion.CreateCommand();
                SqlDataAdapter Adaptador = new SqlDataAdapter();
                var Data = new DataTable();

                // Se estructura el query
                cmd.CommandText = "Select " +
                    "Id_Cita,  " +
                    "CITAS.Id_Empleado,  " +
                    "CITAS.Id_Paciente,  " +
                    "CITAS.Id_Servicios,  " +
                    "Fecha_Cita,  " +
                    "NombreOdontologo = (EMPLEADOS.Nombre + ' ' + EMPLEADOS.ApellidoP + ' ' + EMPLEADOS.ApellidoM), " +
                    "NombrePaciente = (PACIENTES.Nombre + ' ' + PACIENTES.ApellidoP + ' ' + PACIENTES.ApellidoM), " +
                    "Servicio = (SERVICIOS.Descripcion) " +
                    "From CITAS " +
                    "Left Join EMPLEADOS on EMPLEADOS.Id_Empleado = CITAS.Id_Empleado " +
                    "Left Join PACIENTES on PACIENTES.Id_Paciente = CITAS.Id_Paciente " +
                    "Left Join SERVICIOS on SERVICIOS.Id_Servicios = CITAS.Id_Servicios " +
                    "Where Fecha_Cita Between '" + FechaI.ToShortDateString() + "' And '" + FechaF.ToShortDateString() + "'" +
                    "Order By Fecha_Cita Desc";
                cmd.ExecuteNonQuery(); // Se ejecuta

                // Se crea un adaptador de sql, guardará el data source que contiene la información de la consulta
                Adaptador.SelectCommand = cmd;
                Adaptador.Fill(Data);

                // Ciclo for each
                foreach (DataRow Row in Data.Rows)
                {
                    // Se pasa la información para agregar los Links
                    DateTime Fecha = DateTime.Parse(Row[4].ToString());
                    LinkLabel Zelda = new LinkLabel();
                    Zelda.Tag = Row[2];
                    Zelda.Name = $"{Row[0]}";
                    Zelda.Text = Row[6].ToString();
                    Zelda.Click += new EventHandler(ModificarCita);
                    Lista[(Fecha.Day - 1) + (Inicio - 1)].Controls.Add(Zelda);
                }
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        // Evento AgregarCita
        private void AgregarCita(object sender, EventArgs e)
        {
            try
            {
                // Se instancia un objeto de tipo ventana para abrirla y refrescar la tabla
                WIN_CAT_Citas_F Window = new WIN_CAT_Citas_F();
                FlowLayoutPanel tag = (FlowLayoutPanel)sender;
                int Dia = Int32.Parse(tag.Name.ToString());

                // Verifica que día tenga valor válido
                if (Dia != 0)
                {
                    // Abre la ventana
                    Window.Fecha = new DateTime(this.FechaActual.Year, this.FechaActual.Month, Dia);
                    Window.ShowDialog();
                    MostrarFechaActual();
                }
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        // Evento ModificarCita
        private void ModificarCita(object sender, EventArgs e)
        {
            try
            {
                // Se transifere la información del Id para modificar su registro en la ventana
                LinkLabel tag = (LinkLabel)sender;
                this.Id = Int32.Parse(tag.Name.ToString());
                this.IdPaciente = Int32.Parse(tag.Tag.ToString());
                Menu_ModEli.Show(tag, new Point(0, tag.Height));
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        // Evento de la opción Modificar del Popup
        private void MenuOp_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Abre la ventana
                WIN_CAT_Citas_F Window = new WIN_CAT_Citas_F(this.Id);
                Window.ShowDialog();
                MostrarFechaActual();
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        // Evento de la opción Eliminar del Popup
        private void MenuOp_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Elimina
                // Pregunta al usuario si desea eliminar el registro
                if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", "DenTech", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Se estructura el query para eliminar el registro
                    SqlCommand cmd = BD.conexion.CreateCommand();
                    cmd.CommandText = "Delete From CITAS Where Id_Cita = " + this.Id;
                    cmd.ExecuteNonQuery(); // Se ejecuta

                    // Se confirma la eliminación del registro y se actualiza la información de la tabla
                    MessageBox.Show("Registro eliminado con éxito.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarFechaActual();
                }
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        // Evento de la opción Recetas del Popup
        private void recetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Se instancia un objeto de tipo ventana para abrirla y refrescar la tabla
                WIN_CAT_Recetas_T Window = new WIN_CAT_Recetas_T(this.IdPaciente);
                Window.ShowDialog();
                MostrarFechaActual();
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }
    }
}