using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_con_botones.Clases
{
    class AppSettings
    {
        


        public void SalirDeLaAplicacion()
        {
            DialogResult _dialog = MessageBox.Show("¿Está seguro que desea salir de la aplicación?", "¡Está saliendo de la aplicación!", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            if (_dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
