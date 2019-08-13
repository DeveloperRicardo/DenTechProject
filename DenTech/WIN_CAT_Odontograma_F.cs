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
    public partial class WIN_CAT_Odontograma_F : WIN_Template_F
    {
        // Variables y objetos globales
        ConexionSQL BD = new ConexionSQL();
        int gnIdOdontograma = 0;
        int NumDiente = 11;
        int[] gnIdDiente = new int[32]; 

        public WIN_CAT_Odontograma_F(int IdOdontograma = 0)
        {
            InitializeComponent();
            gnIdOdontograma = IdOdontograma;
        }

        private void WIN_CAT_Odontograma_F_Load(object sender, EventArgs e)
        {
            // Verifica si se puede conectar con la base de datos
            if (BD.Conexion(true))
            {
                // Verifica que tenga información de un usuario existente
                if (gnIdOdontograma != 0)
                {
                    // Se estructura el query
                    SqlCommand cmd = BD.conexion.CreateCommand();
                    cmd.CommandText = "Select \n" +
                        "Descripcion, \n" +
                        "Fecha_Registro \n" +
                        "From ODONTOGRAMA " +
                        "Where ODONTOGRAMA.Id_Odontograma = " + gnIdOdontograma;

                    // Ejecuta el query y almacena los datos consultados
                    SqlDataReader Reader = cmd.ExecuteReader();
                    Reader.Read();

                    // Revisa si cuenta con información
                    if (Reader.HasRows)
                    {
                        // Inserta la información a los controles
                        EDT_Descripcion.Text = Reader[0].ToString();
                        DateTime dia = Convert.ToDateTime(Reader[1]);
                        STC_FechaRegistro.Text += dia.ToShortDateString();
                    }
                    Reader.Close(); // Se libera

                    for (int i = 0; i < 32; i++)
                    {
                        // Se estructura el query para obtener los dientes
                        cmd = BD.conexion.CreateCommand();
                        cmd.CommandText = "SELECT \n" +
                            "Id_Diente \n" +
                            "FROM DIENTE " +
                            "WHERE DIENTE.Id_Odontograma = " + gnIdOdontograma +
                            " AND DIENTE.NumDiente = " + NumDiente;
                        // Ejecuta el query y almacena los datos consultados
                        Reader = cmd.ExecuteReader();
                        Reader.Read();

                        // Revisa si cuenta con información
                        if (Reader.HasRows)
                        {
                            // Inserta la información a los controles
                            gnIdDiente[i] = Convert.ToInt16(Reader[0]);
                        }
                        Reader.Close(); // Se libera

                        if (NumDiente == 18 || NumDiente == 28 || NumDiente == 38)
                        {
                            NumDiente += 3;
                        }
                        else
                        {
                            NumDiente += 1;
                        }
                    }
                }
            }
        }

        #region Dientes 11-18
        private void BTN_Diente11_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[0]);
            Window.ShowDialog();
            //Refrescar();
        }

        private void BTN_Diente12_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[1]);
            Window.ShowDialog();
            //Refrescar();
        }

        private void BTN_Diente13_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[2]);
            Window.ShowDialog();
            //Refrescar();
        }

        private void BTN_Diente14_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[3]);
            Window.ShowDialog();
            //Refrescar();
        }

        private void BTN_Diente15_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[4]);
            Window.ShowDialog();
            //Refrescar();
        }

        private void BTN_Diente16_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[5]);
            Window.ShowDialog();
            //Refrescar();
        }

        private void BTN_Diente17_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[6]);
            Window.ShowDialog();
            //Refrescar();
        }

        private void BTN_Diente18_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[7]);
            Window.ShowDialog();
            //Refrescar();
        }
        #endregion

        #region Dientes 21-28
        private void BTN_Diente21_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[8]);
            Window.ShowDialog();
            //Refrescar();
        }

        private void BTN_Diente22_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[9]);
            Window.ShowDialog();
            //Refrescar();
        }

        private void BTN_Diente23_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[10]);
            Window.ShowDialog();
            //Refrescar();
        }

        private void BTN_Diente24_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[11]);
            Window.ShowDialog();
            //Refrescar();
        }

        private void BTN_Diente25_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[12]);
            Window.ShowDialog();
            //Refrescar();
        }

        private void BTN_Diente26_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[13]);
            Window.ShowDialog();
            //Refrescar();
        }

        private void BTN_Diente27_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[14]);
            Window.ShowDialog();
            //Refrescar();
        }

        private void BTN_Diente28_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[15]);
            Window.ShowDialog();
            //Refrescar();
        }
        #endregion

        #region Dientes 31-38
        private void BTN_Diente31_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[16]);
            Window.ShowDialog();
            //Refrescar();
        }

        private void BTN_Diente32_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[17]);
            Window.ShowDialog();
            //Refrescar();
        }

        private void BTN_Diente33_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[18]);
            Window.ShowDialog();
            //Refrescar();
        }

        private void BTN_Diente34_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[19]);
            Window.ShowDialog();
            //Refrescar();
        }

        private void BTN_Diente35_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[20]);
            Window.ShowDialog();
            //Refrescar();
        }

        private void BTN_Diente36_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[21]);
            Window.ShowDialog();
            //Refrescar();
        }

        private void BTN_Diente37_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[22]);
            Window.ShowDialog();
            //Refrescar();
        }

        private void BTN_Diente38_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[23]);
            Window.ShowDialog();
            //Refrescar();
        }
        #endregion

        #region Dientes 41-48
        private void BTN_Diente41_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[24]);
            Window.ShowDialog();
            //Refrescar();
        }

        private void BTN_Diente42_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[25]);
            Window.ShowDialog();
            //Refrescar();
        }

        private void BTN_Diente43_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[26]);
            Window.ShowDialog();
            //Refrescar();
        }

        private void BTN_Diente44_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[27]);
            Window.ShowDialog();
            //Refrescar();
        }

        private void BTN_Diente45_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[28]);
            Window.ShowDialog();
            //Refrescar();
        }

        private void BTN_Diente46_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[29]);
            Window.ShowDialog();
            //Refrescar();
        }

        private void BTN_Diente47_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[30]);
            Window.ShowDialog();
            //Refrescar();
        }

        private void BTN_Diente48_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[31]);
            Window.ShowDialog();
            //Refrescar();
        }
        #endregion

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            // Se abre la conexión y se estructura el query para agregar el registro
            SqlCommand cmd = BD.conexion.CreateCommand();
            cmd.CommandText = "UPDATE ODONTOGRAMA SET Fecha_Registro = '" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "', Descripcion = '" + EDT_Descripcion.Text + "'" +
                              "WHERE Id_Odontograma = " + gnIdOdontograma + ";";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro modificado con éxito.", "Dentech", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Se cierra la ventana
        }
    }
}
