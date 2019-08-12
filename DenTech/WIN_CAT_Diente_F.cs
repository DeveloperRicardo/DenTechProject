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
        string resName = "";
        public WIN_CAT_Diente_F(int idDiente = 0)
        {
            InitializeComponent();
            gnIdDiente = idDiente;
        }

        private void WIN_CAT_Diente_F_Load(object sender, EventArgs e)
        {

            // Verifica si se puede conectar con la base de datos
            if (BD.Conexion(true))
            {
                // Se estructura el query
                SqlCommand cmd = BD.conexion.CreateCommand();
                cmd.CommandText = "SELECT \n" +
                "NumDiente, \n" +
                "Descripcion \n" +
                "FROM DIENTE " +
                "WHERE DIENTE.Id_Diente = " + gnIdDiente;

                // Ejecuta el query y almacena los datos consultados
                SqlDataReader Reader = cmd.ExecuteReader();
                Reader.Read();

                // Revisa si cuenta con información
                if (Reader.HasRows)
                {
                    TituloBanner += Convert.ToInt16(Reader[0]);
                    EDT_Descripcion.Text = Reader[1].ToString();
                }
                Reader.Close();
                int estatus = 0;
                for (int i = 1; i < 8; i++)
                {
                    cmd.CommandText = "SELECT \n" +
                    "Estatus \n" +
                    "FROM DETALLEDIENTE " +
                    "WHERE Id_Diente = " + gnIdDiente +
                    "AND AreaDiente = " + i;
                    Reader = cmd.ExecuteReader();
                    // Ejecuta el query y almacena los datos consultados
                    Reader.Read();

                    // Revisa si cuenta con información
                    if (Reader.HasRows)
                    {
                        estatus = Convert.ToInt16(Reader[0]);
                        switch (i)
                        {
                            case 1:
                                switch (estatus)
                                {
                                    case 1:
                                        BTN_SuperiorArriba.BackColor = Color.Blue;
                                        break;
                                    case 2:
                                        BTN_SuperiorArriba.BackColor = Color.Red;
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 2:
                                switch (estatus)
                                {
                                    case 1:
                                        BTN_SuperiorIzq.BackColor = Color.Blue;
                                        break;
                                    case 2:
                                        BTN_SuperiorIzq.BackColor = Color.Red;
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 3:
                                switch (estatus)
                                {
                                    case 1:
                                        BTN_SuperiorCentro.BackColor = Color.Blue;
                                        break;
                                    case 2:
                                        BTN_SuperiorCentro.BackColor = Color.Red;
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 4:
                                switch (estatus)
                                {
                                    case 1:
                                        BTN_SuperiorDer.BackColor = Color.Blue;
                                        break;
                                    case 2:
                                        BTN_SuperiorDer.BackColor = Color.Red;
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 5:
                                switch (estatus)
                                {
                                    case 1:
                                        BTN_SuperiorAbajo.BackColor = Color.Blue;
                                        break;
                                    case 2:
                                        BTN_SuperiorAbajo.BackColor = Color.Red;
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 6:
                                switch (estatus)
                                {
                                    case 1:
                                        BTN_LateralArriba.BackColor = Color.Blue;
                                        break;
                                    case 2:
                                        BTN_LateralArriba.BackColor = Color.Red;
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 7:
                                switch (estatus)
                                {
                                    //Diente Extraccion Pendiente
                                    case 1:
                                        resName = $"Diente_extrac_Pendiente"; // Check the correct name in the .resx file. By using the wizards the extension is omitted, for example.
                                        IMG_LateralAbajo.Image = (Image)Properties.Resources.ResourceManager.GetObject(resName);
                                        break;
                                    //Diente Extraccion Realizado
                                    case 2:
                                        resName = $"Diente_extrac_Realizado"; // Check the correct name in the .resx file. By using the wizards the extension is omitted, for example.
                                        IMG_LateralAbajo.Image = (Image)Properties.Resources.ResourceManager.GetObject(resName);
                                        break;
                                    //Diente Implementacion Pendiente
                                    case 3:
                                        resName = $"Diente_imple_Pendiente"; // Check the correct name in the .resx file. By using the wizards the extension is omitted, for example.
                                        IMG_LateralAbajo.Image = (Image)Properties.Resources.ResourceManager.GetObject(resName);
                                        break;
                                    //Diente Implementacion Realizado
                                    case 4:
                                        resName = $"Diente_imple_Realizado"; // Check the correct name in the .resx file. By using the wizards the extension is omitted, for example.
                                        IMG_LateralAbajo.Image = (Image)Properties.Resources.ResourceManager.GetObject(resName);
                                        break;
                                    default:
                                        break;
                                }
                                break;
                        }
                    }
                    Reader.Close();
                }
            }
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_SuperiorArriba_Click(object sender, EventArgs e)
        {
            if (RADIO_Realizado.Checked)
            {
                BTN_SuperiorArriba.BackColor = Color.Blue;
                return;
            }
            if (RADIO_Pendiente.Checked)
            {
                BTN_SuperiorArriba.BackColor = Color.Red;
                return;
            }
            if (RADIO_Ninguno.Checked)
            {
                BTN_SuperiorArriba.BackColor = Color.White;
                return;
            }
        }

        private void BTN_SuperiorIzq_Click(object sender, EventArgs e)
        {
            if (RADIO_Realizado.Checked)
            {
                BTN_SuperiorIzq.BackColor = Color.Blue;
                return;
            }
            if (RADIO_Pendiente.Checked)
            {
                BTN_SuperiorIzq.BackColor = Color.Red;
                return;
            }
            if (RADIO_Ninguno.Checked)
            {
                BTN_SuperiorIzq.BackColor = Color.White;
                return;
            }
        }

        private void BTN_SuperiorCentro_Click(object sender, EventArgs e)
        {
            if (RADIO_Realizado.Checked)
            {
                BTN_SuperiorCentro.BackColor = Color.Blue;
                return;
            }
            if (RADIO_Pendiente.Checked)
            {
                BTN_SuperiorCentro.BackColor = Color.Red;
                return;
            }
            if (RADIO_Ninguno.Checked)
            {
                BTN_SuperiorCentro.BackColor = Color.White;
                return;
            }
        }

        private void BTN_SuperiorDer_Click(object sender, EventArgs e)
        {
            if (RADIO_Realizado.Checked)
            {
                BTN_SuperiorDer.BackColor = Color.Blue;
                return;
            }
            if (RADIO_Pendiente.Checked)
            {
                BTN_SuperiorDer.BackColor = Color.Red;
                return;
            }
            if (RADIO_Ninguno.Checked)
            {
                BTN_SuperiorDer.BackColor = Color.White;
                return;
            }
        }

        private void BTN_SuperiorAbajo_Click(object sender, EventArgs e)
        {
            if (RADIO_Realizado.Checked)
            {
                BTN_SuperiorAbajo.BackColor = Color.Blue;
                return;
            }
            if (RADIO_Pendiente.Checked)
            {
                BTN_SuperiorAbajo.BackColor = Color.Red;
                return;
            }
            if (RADIO_Ninguno.Checked)
            {
                BTN_SuperiorAbajo.BackColor = Color.White;
                return;
            }
        }

        private void BTN_LateralArriba_Click(object sender, EventArgs e)
        {
            if (RADIO_Realizado.Checked)
            {
                BTN_LateralArriba.BackColor = Color.Blue;
                return;
            }
            if (RADIO_Pendiente.Checked)
            {
                BTN_LateralArriba.BackColor = Color.Red;
                return;
            }
            if (RADIO_Ninguno.Checked)
            {
                BTN_LateralArriba.BackColor = Color.White;
                return;
            }
        }

        private void BTN_Implante_Click(object sender, EventArgs e)
        {
            if (RADIO_Realizado.Checked)
            {
                //Diente Implante Realizado
                resName = $"Diente_imple_Realizado"; // Check the correct name in the .resx file. By using the wizards the extension is omitted, for example.
                IMG_LateralAbajo.Image = (Image)Properties.Resources.ResourceManager.GetObject(resName);
                IMG_LateralAbajo.BackgroundImageLayout = ImageLayout.Stretch;
                return;
            }
            if (RADIO_Pendiente.Checked)
            {
                //Diente Implante Pendiente
                resName = $"Diente_imple_Pendiente"; // Check the correct name in the .resx file. By using the wizards the extension is omitted, for example.
                IMG_LateralAbajo.Image = (Image)Properties.Resources.ResourceManager.GetObject(resName);
                IMG_LateralAbajo.BackgroundImageLayout = ImageLayout.Stretch;
                return;
            }
            if (RADIO_Ninguno.Checked)
            {
                //Diente Implante Pendiente
                resName = $"Diente_lateral_Abajo"; // Check the correct name in the .resx file. By using the wizards the extension is omitted, for example.
                IMG_LateralAbajo.Image = (Image)Properties.Resources.ResourceManager.GetObject(resName);
                IMG_LateralAbajo.BackgroundImageLayout = ImageLayout.Stretch;
                return;
            }            
        }

        private void BTN_Extracción_Click(object sender, EventArgs e)
        {
            if (RADIO_Realizado.Checked)
            {
                //Diente Implante Realizado
                resName = $"Diente_extrac_Realizado"; // Check the correct name in the .resx file. By using the wizards the extension is omitted, for example.
                IMG_LateralAbajo.Image = (Image)Properties.Resources.ResourceManager.GetObject(resName);
                return;
            }
            if (RADIO_Pendiente.Checked)
            {
                //Diente Implante Pendiente
                resName = $"Diente_extrac_Pendiente"; // Check the correct name in the .resx file. By using the wizards the extension is omitted, for example.
                IMG_LateralAbajo.Image = (Image)Properties.Resources.ResourceManager.GetObject(resName);
                return;
            }
            if (RADIO_Ninguno.Checked)
            {
                //Diente Implante Pendiente
                resName = $"Diente_lateral_Abajo"; // Check the correct name in the .resx file. By using the wizards the extension is omitted, for example.
                IMG_LateralAbajo.Image = (Image)Properties.Resources.ResourceManager.GetObject(resName);
                return;
            }
        }

        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
