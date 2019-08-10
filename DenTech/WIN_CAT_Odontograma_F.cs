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
                        "Descripcion \n" +
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

        private void BTN_Diente48_Click(object sender, EventArgs e)
        {
            // Se instancia un objeto de tipo ventana para abrirla
            WIN_CAT_Diente_F Window = new WIN_CAT_Diente_F(gnIdDiente[31]);
            Window.ShowDialog();
            //Refrescar();
        }
    }
}
