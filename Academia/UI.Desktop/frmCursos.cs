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
    public partial class frmCursos : Form
    {
        CursosLogic Logic { get; set; }

        public frmCursos()
        {
            InitializeComponent();
            Logic = new CursosLogic();
            FillGrid();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoCurso();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Curso curso = PickCurso();
            Logic.Delete(curso);
            FillGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarCurso();
        }

        private void FillGrid()
        {
            dgvCursos.DataSource = Logic.GetList();
        }

        private void NuevoCurso()
        {
            ShowFrmDialog(General.TipoOperacion.Alta, null);
            FillGrid();
        }

        private Curso PickCurso()
        {
            Curso curso = (Curso)dgvCursos.CurrentRow.DataBoundItem;
            return curso;
        }

        private void EditarCurso()
        {
            Curso curso = PickCurso();
            ShowFrmDialog(General.TipoOperacion.Modificacion, curso);
            FillGrid();
        }

        private void ShowFrmDialog(General.TipoOperacion operacion, Curso curso)
        {
            frmCurso ofrmCurso;

            if (curso != null)
            {
                ofrmCurso = new frmCurso(curso);
            }
            else
            {
                ofrmCurso = new frmCurso();
            }

            ofrmCurso.Operacion = operacion;
            ofrmCurso.ShowDialog();
            ofrmCurso.Close();
            ofrmCurso = null;
        }
    }
}
