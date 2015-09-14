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
                Business.Entity.Modulo modulo = new Business.Entity.Modulo();
                modulo.Descripcion = desc;
                Business.Entity.Logic.ModuloLogic modlogic = new Business.Entity.Logic.ModuloLogic();
                try
                {
                    modlogic.Add(modulo);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message + " - " + ex.StackTrace.ToString());
                    MessageBox.Show("error");
                }
                this.Hide();

            }

        }
    }
}
