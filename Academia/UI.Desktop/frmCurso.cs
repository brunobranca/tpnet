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
    public partial class frmCurso : Form
    {
        public frmCurso()
        {
            InitializeComponent();
        }

        public frmCurso(Curso curso)
        {
            InitializeComponent();
            txtId.Text = curso.ID.ToString();
            cbMateria.Text = curso.IDMateria.ToString();
            cbComision.Text = curso.IDComision.ToString();
            txtAnioCalendario.Text = curso.AnioCalendario.ToString();
            txtCupo.Text = curso.Cupo.ToString();
        }

        public General.TipoOperacion Operacion { get; set; }
    }
}
