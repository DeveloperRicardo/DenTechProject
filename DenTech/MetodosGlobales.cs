using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenTech
{
    public class MetodosGlobales
    {
        #region Mensajes
        public void Mensajes(int Mensaje)
        {
            switch (Mensaje)
            {
                case 1:
                    MessageBox.Show("Conexión exitosa.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    MessageBox.Show("Conexión no exitosa.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 3:
                    MessageBox.Show("Los campos no pueden estar vacios.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 4:
                    MessageBox.Show("Ya existen todas las tablas.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 5:
                    MessageBox.Show("Se han creado las tablas faltantes.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 6:
                    MessageBox.Show("Se ha guardado la configuración.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 7:
                    MessageBox.Show("No se pudo cerrar la conexión con la base de datos.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 8:
                    MessageBox.Show("Contraseña incorrecta.", "DenTech", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
        #endregion
    }
}
