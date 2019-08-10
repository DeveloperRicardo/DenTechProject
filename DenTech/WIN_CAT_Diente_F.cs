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
    public partial class WIN_CAT_Diente_F : WIN_Template_F
    {
        // Variables y objetos globales
        ConexionSQL BD = new ConexionSQL();
        int gnIdDiente = 0;
        public WIN_CAT_Diente_F(int idDiente = 0)
        {
            InitializeComponent();
            gnIdDiente = idDiente;
        }

        private void WIN_CAT_Diente_F_Load(object sender, EventArgs e)
        {
            TituloVentana += "Odontograma";
            TituloBanner = "Odontograma";
            // Verifica si se puede conectar con la base de datos
            if (BD.Conexion(true))
            {
                // Verifica que tenga información de un usuario existente
                if (gnIdDiente != 0)
                {
                    // Se estructura el query
                    SqlCommand cmd = BD.conexion.CreateCommand();
                    cmd.CommandText = "SELECT \n" +
                        "NumDiente, \n" +
                        "SuperiorArriba, \n" +
                        "SuperiorCentro, \n" +
                        "SuperiorIzq, \n" +
                        "SuperiorDer, \n" +
                        "SuperiorAbajo, \n" +
                        "LateralArriba, \n" +
                        "LateralAbajo \n" +
                        "FROM DIENTE " +
                        "WHERE DIENTE.Id_Diente = " + gnIdDiente;

                    // Ejecuta el query y almacena los datos consultados
                    SqlDataReader Reader = cmd.ExecuteReader();
                    Reader.Read();

                    // Revisa si cuenta con información
                    if (Reader.HasRows)
                    {
                        switch (Convert.ToInt16(Reader[1]))
                        {
                            case 1:
                                BTN_SuperiorArriba.BackColor = Color.Blue;
                                break;
                            case 2:
                                BTN_SuperiorArriba.BackColor = Color.Red;
                                break;
                        }
                        switch (Convert.ToInt16(Reader[2]))
                        {
                            case 1:
                                BTN_SuperiorCentro.BackColor = Color.Blue;
                                break;
                            case 2:
                                BTN_SuperiorCentro.BackColor = Color.Red;
                                break;
                        }
                        switch (Convert.ToInt16(Reader[3]))
                        {
                            case 1:
                                BTN_SuperiorIzq.BackColor = Color.Blue;
                                break;
                            case 2:
                                BTN_SuperiorIzq.BackColor = Color.Red;
                                break;
                        }
                        switch (Convert.ToInt16(Reader[4]))
                        {
                            case 1:
                                BTN_SuperiorDer.BackColor = Color.Blue;
                                break;
                            case 2:
                                BTN_SuperiorDer.BackColor = Color.Red;
                                break;
                        }
                        switch (Convert.ToInt16(Reader[5]))
                        {
                            case 1:
                                BTN_SuperiorAbajo.BackColor = Color.Blue;
                                break;
                            case 2:
                                BTN_SuperiorAbajo.BackColor = Color.Red;
                                break;
                        }
                        switch (Convert.ToInt16(Reader[6]))
                        {
                            case 1:
                                BTN_LateralArriba.BackColor = Color.Blue;
                                break;
                            case 2:
                                BTN_LateralArriba.BackColor = Color.Red;
                                break;
                        }
                    }
                    Reader.Close(); // Se libera
                }
            }
        }
    }
}
