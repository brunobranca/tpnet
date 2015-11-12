using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entity.Logic;
using Business.Entity;
namespace UI.Desktop
{
    public partial class frmComisiones : Form
    {
        ComisionesLogic Logic { get; set; }

        public frmComisiones()
        {
            InitializeComponent();
            Logic = new ComisionesLogic();
            FillGrid();            
        }
        
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevaComision();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Comision comision = PickComision();
            Logic.Delete(comision);
            FillGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarComision();
        }

        private void NuevaComision()
        {
            ShowFrmDialog(General.TipoOperacion.Alta, null);
            FillGrid();
        }

        private void FillGrid()
        {
            dgvComisiones.DataSource = Logic.GetList();
        }

        private Comision PickComision()
        {
            Comision comision = (Comision)dgvComisiones.CurrentRow.DataBoundItem;
            return comision;
        }        

        private void ShowFrmDialog(General.TipoOperacion operacion, Comision comision)
        {
            frmComision ofrmComision;

            if (comision != null)
            {
                ofrmComision = new frmComision(comision);
            }
            else
            {
                ofrmComision = new frmComision();
            }

            ofrmComision.Operacion = operacion;
            ofrmComision.ShowDialog();
            ofrmComision.Close();
            ofrmComision = null;
        }

        private void EditarComision()
        {
            Comision comision = PickComision();
            ShowFrmDialog(General.TipoOperacion.Modificacion, comision);
            FillGrid();
        }
    }
}
