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
    public partial class frmEspecialidades : Form
    {
        EspecialidadesLogic Logic { get; set; }

        public frmEspecialidades()
        {
            InitializeComponent();
            Logic = new EspecialidadesLogic();
            FillGrid();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevaEspecialidad();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Especialidad especialidad = PickEspecialidad();
            Logic.Delete(especialidad);
            FillGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarEspecialidad();
        }

        private void NuevaEspecialidad()
        {
            ShowFrmDialog(General.TipoOperacion.Alta, null); 
            FillGrid();
        }

        private void FillGrid()
        {
            dgvEspecialidades.DataSource = Logic.GetList();
        }

        private Especialidad PickEspecialidad()
        {
            Especialidad especialidad = (Especialidad)dgvEspecialidades.CurrentRow.DataBoundItem;
            return especialidad;
        }

        private void ShowFrmDialog(General.TipoOperacion operacion, Especialidad especialidad)
        {
            frmEspecialidad ofrmEspecialidad;

            if (especialidad != null)
            {
                ofrmEspecialidad = new frmEspecialidad(especialidad);
            }
            else
            {
                ofrmEspecialidad = new frmEspecialidad();
            }

            ofrmEspecialidad.Operacion = operacion;
            ofrmEspecialidad.ShowDialog();
            ofrmEspecialidad.Close();
            ofrmEspecialidad = null;
        }

        private void EditarEspecialidad()
        {
            Especialidad especialidad = PickEspecialidad();
            ShowFrmDialog(General.TipoOperacion.Modificacion, especialidad);
            FillGrid();
        }

        
    }
}
