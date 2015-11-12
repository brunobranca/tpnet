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
    public partial class frmComision : Form
    {
        private Comision oComision;
         
        public frmComision()
        {
            InitializeComponent();
        }

        public frmComision(Comision comision)
        {
            InitializeComponent();
            txtId.Text = (comision.ID).ToString();
            txtDescripcion.Text = comision.Descripcion;
            txtAnioEspecialidad.Text = (comision.AnioEspecialidad).ToString();            
        }

        public General.TipoOperacion Operacion { get; set; }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            AceptarOperacion();
        }

        private void AceptarOperacion()
        {
            ComisionesLogic Logic = new ComisionesLogic();
            try
            {
                if (Operacion == General.TipoOperacion.Alta)
                {
                    Comision oComision = new Comision();
                    oComision.ID = Int32.Parse(txtId.Text);
                    oComision.Descripcion = txtDescripcion.Text;
                    oComision.AnioEspecialidad = Int32.Parse(txtAnioEspecialidad.Text);

                    Logic.Add(oComision);
                    ShowMessage("¡Comisión Agregada!", MessageBoxIcon.Information);
                }
                else if (Operacion == General.TipoOperacion.Modificacion)
                {
                    this.oComision.ID = Int32.Parse(txtId.Text);
                    this.oComision.Descripcion = txtDescripcion.Text;
                    this.oComision.AnioEspecialidad = Int32.Parse(txtAnioEspecialidad.Text);
                    Logic.Update(this.oComision);
                    ShowMessage("¡Comisión Modificada", MessageBoxIcon.Information);
                }
                this.Hide();
            }
            catch(Exception ex)
            {
                throw ex;
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
