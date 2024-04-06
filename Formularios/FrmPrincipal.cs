using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_RCTAN1.Formularios
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            btnAdministrar.Visible = false;
            btnConsultar.Visible = false;
        }

        private void btnCargaPersonal_Click(object sender, EventArgs e)
        {
            //FrmCargaPersonal carga = new FrmCargaPersonal();
            ////this.Hide();
            //carga.ShowDialog();
            btnAdministrar.Visible = true;
            btnConsultar.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmCargaPersonal carga = new FrmCargaPersonal();
            //this.Hide();
            carga.ShowDialog();
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            FrmCargaPersonal carga = new FrmCargaPersonal();
            ////this.Hide();
            carga.ShowDialog();
        }
    }
}
