using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class frmEspecialidades : Form
    {
        public frmEspecialidades()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevaEspecialidad();
        }


        private void NuevaEspecialidad()
        {
            frmEspecialidad ofrmEspecialidad = new frmEspecialidad();

            ofrmEspecialidad.Operacion = General.TipoOperacion.Alta;

            ofrmEspecialidad.ShowDialog();

            bool resultado = !ofrmEspecialidad.Cancelado;

            ofrmEspecialidad.Close();

            ofrmEspecialidad = null;
        }



    }
}
