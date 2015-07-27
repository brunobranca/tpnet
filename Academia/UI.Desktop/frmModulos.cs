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
    public partial class frmModulos : Form
    {
        public frmModulos()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmModulo frmModulo = new frmModulo();
            frmModulo.Operacion = General.TipoOperacion.Alta;
            frmModulo.ShowDialog();
            frmModulo.Close();
           
           
            

        }
    }
}
