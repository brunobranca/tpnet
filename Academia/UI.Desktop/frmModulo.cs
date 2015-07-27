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
    public partial class frmModulo : Form
    {
        public General.TipoOperacion Operacion
        {
            get;
            set;
        }
        public frmModulo()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Ejecutar();
        }
        private void Ejecutar()
        {
            string desc = txtDescripcion.Text;
            if(Operacion == General.TipoOperacion.Alta)
            {
                Business.Modulo modulo = new Business.Modulo();
                modulo.Descripcion = desc;
                Business.Logic.ModuloLogic modlogic = new Business.Logic.ModuloLogic();
                try
                {
                    modlogic.Add(modulo);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("error");
                }
                this.Hide();

            }

        }
    }
}
