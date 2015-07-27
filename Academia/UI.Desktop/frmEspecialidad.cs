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
    public partial class frmEspecialidad : Form
    {
        public frmEspecialidad()
        {
            InitializeComponent();
        }

        public General.TipoOperacion Operacion { get; set; }

        public bool Cancelado { get; set; }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            AceptarOperacion();
        }



        private void AceptarOperacion()
        {
            Business.Logic.EspecialidadesLogic oEspLogic = new Business.Logic.EspecialidadesLogic();
            Business.Especialidad oEspecialidad = new Business.Especialidad();

            try
            {
                oEspecialidad.Descripcion = txtNombre.Text.Trim();

                if (Operacion == General.TipoOperacion.Alta)
                {
                    oEspLogic.Add(oEspecialidad);
                    MessageBox.Show("Especialidad Agregada!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Cancelado = false;
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                oEspecialidad = null;
                oEspLogic = null;
            }
        }

    }
}
