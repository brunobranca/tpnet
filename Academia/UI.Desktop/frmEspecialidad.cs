using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entity;
using Business.Entity.Logic;

namespace UI.Desktop
{
    public partial class frmEspecialidad : Form
    {
        private Especialidad oEspecialidad;

        public frmEspecialidad()
        {
            InitializeComponent();
        }

        public frmEspecialidad(Especialidad especialidad)
        {
            InitializeComponent();
            txtNombre.Text = especialidad.Descripcion;
            this.oEspecialidad = especialidad;
        }

        public General.TipoOperacion Operacion { get; set; }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            AceptarOperacion();
        }

        private void AceptarOperacion()
        {
            EspecialidadesLogic Logic = new EspecialidadesLogic();

            try
            {
                if (Operacion == General.TipoOperacion.Alta)
                {
                    Especialidad oEspecialidad = new Especialidad();
                    oEspecialidad.Descripcion = txtNombre.Text.Trim();
                    
                    Logic.Add(oEspecialidad);
                    ShowMessage("Especialidad Agregada!", MessageBoxIcon.Information);
                }
                else if (Operacion == General.TipoOperacion.Modificacion)
                {
                    this.oEspecialidad.Descripcion = txtNombre.Text.Trim();
                    Logic.Update(this.oEspecialidad);
                    ShowMessage("Especialidad Modificada!", MessageBoxIcon.Information);
                }

                this.Hide();
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message, MessageBoxIcon.Error);
            }
            finally
            {
                Logic = null;
            }
        }

        private void ShowMessage(string message, MessageBoxIcon icon)
        {
            MessageBox.Show(message, this.Text, MessageBoxButtons.OK, icon);
        }

    }
}
