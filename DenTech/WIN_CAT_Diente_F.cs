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
        MetodosGlobales Glo = new MetodosGlobales();
        int gnIdDiente = 0;
        int[] gnIdDetalle = new int[7];
        string resName = "";
        int estatus = 0, estatusLateral = 0;

        public WIN_CAT_Diente_F(int idDiente = 0)
        {
            InitializeComponent();
            gnIdDiente = idDiente;
        }

        private void WIN_CAT_Diente_F_Load(object sender, EventArgs e)
        {
            try
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
                    for (int i = 1; i < 8; i++)
                    {
                        cmd.CommandText = "SELECT \n" +
                        "Estatus, \n" +
                        "Id_Detalle \n" +
                        "FROM DETALLEDIENTE " +
                        "WHERE Id_Diente = " + gnIdDiente +
                        "AND AreaDiente = " + i;
                        Reader = cmd.ExecuteReader();
                        // Ejecuta el query y almacena los datos consultados
                        Reader.Read();

                        // Revisa si cuenta con información
                        if (Reader.HasRows)
                        {
                            gnIdDetalle[i - 1] = Convert.ToInt16(Reader[1]);
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
                                            break;
                                        //Diente Extraccion Realizado
                                        case 2:
                                            resName = $"Diente_extrac_Realizado"; // Check the correct name in the .resx file. By using the wizards the extension is omitted, for example.
                                            break;
                                        //Diente Implementacion Pendiente
                                        case 3:
                                            resName = $"Diente_imple_Pendiente"; // Check the correct name in the .resx file. By using the wizards the extension is omitted, for example.
                                            break;
                                        //Diente Implementacion Realizado
                                        case 4:
                                            resName = $"Diente_imple_Realizado"; // Check the correct name in the .resx file. By using the wizards the extension is omitted, for example.
                                            break;
                                        default:
                                            break;
                                    }
                                    estatusLateral = estatus;
                                    IMG_LateralAbajo.Image = (Image)Properties.Resources.ResourceManager.GetObject(resName);
                                    break;
                            }
                        }
                        Reader.Close();
                    }
                    RefrescarTratamientos();
                }
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        private void RefrescarTratamientos()
        {
            try
            {
                SqlCommand cmd = BD.conexion.CreateCommand();
                cmd.CommandText = "SELECT \n" +
                "Id_TrataDiente, \n" +
                "Descripcion, \n" +
                "Precio \n" +
                "FROM TRATAMIENTO " +
                "INNER JOIN TRATAMIENTODIENTE " +
                "ON TRATAMIENTO.Id_Tratamiento = TRATAMIENTODIENTE.Id_Tratamiento " +
                "WHERE Id_Diente = " + gnIdDiente;
                var Data = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter();
                cmd.ExecuteNonQuery();
                // Se crea un adaptador de sql, guardará el data source que contiene la información de la consulta
                Adaptador.SelectCommand = cmd;
                Adaptador.Fill(Data);
                DGV_TablaTratamiento.DataSource = Data;
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_SuperiorArriba_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        private void BTN_SuperiorIzq_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        private void BTN_SuperiorCentro_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        private void BTN_SuperiorDer_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        private void BTN_SuperiorAbajo_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        private void BTN_LateralArriba_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        private void BTN_Implante_Click(object sender, EventArgs e)
        {
            try
            {
                if (estatusLateral == 0)
                {
                    OP_ImpSeleccionar_Click(sender, e);
                }
                else
                {
                    Menu_Implante.Show(BTN_Implante, new Point(0, BTN_Implante.Height));
                }
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            } 
        }

        private void BTN_Extracción_Click(object sender, EventArgs e)
        {
            try
            {
                if (estatusLateral == 0)
                {
                    OP_ExSeleccionar_Click(sender, e);
                }
                else
                {
                    Menu_Extraccion.Show(BTN_Extraccion, new Point(0, BTN_Extraccion.Height));
                }
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se instancia un objeto de tipo ventana para abrirla y refrescar la tabla
                WIN_CAT_Tratamiento_T Window = new WIN_CAT_Tratamiento_T(gnIdDiente);
                Window.ShowDialog();
                RefrescarTratamientos();
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que la tabla tenga información
                if (DGV_TablaTratamiento.RowCount == 0)
                    return;

                // Pregunta al usuario si desea eliminar el registro
                if (MessageBox.Show("¿Desea eliminar el tratamiento seleccionado del diente?", "DenTech", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand cmd3 = BD.conexion.CreateCommand();
                    // Se estructura el query para eliminar el registro
                    cmd3.CommandText = "Delete From TRATAMIENTODIENTE Where Id_TrataDiente = " + (int)DGV_TablaTratamiento.CurrentRow.Cells[0].Value;
                    cmd3.ExecuteNonQuery(); // Se ejecuta

                    // Se confirma la eliminación del registro y se actualiza la información de la tabla
                    MessageBox.Show("Registro eliminado con éxito.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarTratamientos();
                }
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        private void OP_ExSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se instancia un objeto de tipo ventana para abrirla y refrescar la tabla
                WIN_CAT_Extraccion_T Window = new WIN_CAT_Extraccion_T(gnIdDiente);
                Window.ShowDialog();
                switch (Window.Estatus)
                {
                    case 2:
                        //Diente Extraccion Realizado
                        resName = $"Diente_extrac_Realizado"; // Check the correct name in the .resx file. By using the wizards the extension is omitted, for example.
                        estatusLateral = Window.Estatus;
                        break;
                    case 1:
                        //Diente Extraccion Pendiente
                        resName = $"Diente_extrac_Pendiente"; // Check the correct name in the .resx file. By using the wizards the extension is omitted, for example.
                        estatusLateral = Window.Estatus;
                        break;
                }
                IMG_LateralAbajo.Image = (Image)Properties.Resources.ResourceManager.GetObject(resName);
                return;
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        private void OP_ExNinguno_Click(object sender, EventArgs e)
        {
            try
            {
                //Diente Extraccion Pendiente
                resName = $"Diente_lateral_Abajo"; // Check the correct name in the .resx file. By using the wizards the extension is omitted, for example.
                estatusLateral = 0;
                IMG_LateralAbajo.Image = (Image)Properties.Resources.ResourceManager.GetObject(resName);
                return;
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        private void OP_ImpSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se instancia un objeto de tipo ventana para abrirla y refrescar la tabla
                WIN_CAT_Implante_T Window = new WIN_CAT_Implante_T(gnIdDiente);
                Window.ShowDialog();
                switch (Window.Estatus)
                {
                    case 4:
                        //Diente Implante Realizado
                        resName = $"Diente_imple_Realizado"; // Check the correct name in the .resx file. By using the wizards the extension is omitted, for example.
                        estatusLateral = Window.Estatus;
                        break;
                    case 3:
                        //Diente Implante Pendiente
                        resName = $"Diente_imple_Pendiente";
                        estatusLateral = Window.Estatus;
                        break;
                }
                IMG_LateralAbajo.Image = (Image)Properties.Resources.ResourceManager.GetObject(resName);
                IMG_LateralAbajo.BackgroundImageLayout = ImageLayout.Stretch;
                return;
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }

        private void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = BD.conexion.CreateCommand();
                for (int i = 1; i < 8; i++)
                {
                    switch (i)
                    {
                        case 1:
                            if (BTN_SuperiorArriba.BackColor == Color.Blue)
                            {
                                estatus = 1;
                            }
                            if (BTN_SuperiorArriba.BackColor == Color.Red)
                            {
                                estatus = 2;
                            }
                            if (BTN_SuperiorArriba.BackColor == Color.White)
                            {
                                estatus = 0;
                            }
                            break;
                        case 2:
                            if (BTN_SuperiorIzq.BackColor == Color.Blue)
                            {
                                estatus = 1;
                            }
                            if (BTN_SuperiorIzq.BackColor == Color.Red)
                            {
                                estatus = 2;
                            }
                            if (BTN_SuperiorIzq.BackColor == Color.White)
                            {
                                estatus = 0;
                            }
                            break;
                        case 3:
                            if (BTN_SuperiorCentro.BackColor == Color.Blue)
                            {
                                estatus = 1;
                            }
                            if (BTN_SuperiorCentro.BackColor == Color.Red)
                            {
                                estatus = 2;
                            }
                            if (BTN_SuperiorCentro.BackColor == Color.White)
                            {
                                estatus = 0;
                            }
                            break;
                        case 4:
                            if (BTN_SuperiorDer.BackColor == Color.Blue)
                            {
                                estatus = 1;
                            }
                            if (BTN_SuperiorDer.BackColor == Color.Red)
                            {
                                estatus = 2;
                            }
                            if (BTN_SuperiorDer.BackColor == Color.White)
                            {
                                estatus = 0;
                            }
                            break;
                        case 5:
                            if (BTN_SuperiorAbajo.BackColor == Color.Blue)
                            {
                                estatus = 1;
                            }
                            if (BTN_SuperiorAbajo.BackColor == Color.Red)
                            {
                                estatus = 2;
                            }
                            if (BTN_SuperiorAbajo.BackColor == Color.White)
                            {
                                estatus = 0;
                            }
                            break;
                        case 6:
                            if (BTN_LateralArriba.BackColor == Color.Blue)
                            {
                                estatus = 1;
                            }
                            if (BTN_LateralArriba.BackColor == Color.Red)
                            {
                                estatus = 2;
                            }
                            if (BTN_LateralArriba.BackColor == Color.White)
                            {
                                estatus = 0;
                            }
                            break;
                        case 7:
                            estatus = estatusLateral;
                            break;
                        default:
                            break;
                    }
                    cmd.CommandText = "UPDATE DETALLEDIENTE SET Estatus = " + estatus + "WHERE Id_Detalle = " + gnIdDetalle[i - 1];
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = "UPDATE DIENTE SET Descripcion = '" + EDT_Descripcion.Text + "' WHERE DIENTE.Id_Diente = " + gnIdDiente;
                // Ejecuta el query y almacena los datos consultados
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro modificado con éxito.", "Dentech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Se cierra la ventana
            }
            catch (Exception ex)
            {
                Glo.Mensajes(10, ex.Message);
            }
        }
    }
}
