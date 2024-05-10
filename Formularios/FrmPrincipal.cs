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
            btnCursillos.Visible = false;
            btnExamenes.Visible = false;
            btnAtras.Visible = false;
            btnCargarListado.Visible = false;
        }

        private void btnCargaPersonal_Click(object sender, EventArgs e)
        {
            //FrmCargaPersonal carga = new FrmCargaPersonal();
            ////this.Hide();
            //carga.ShowDialog();
            btnAdministrar.Visible = true;
            btnConsultar.Visible = true;
            btnMote.Visible = false;
            btnEducacion.Visible = false;
            btnAtras.Visible = true;
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

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            cboConsultas.Visible = false;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            btnAdministrar.Visible = false;
            btnConsultar.Visible = false;
            btnMote.Visible = true;
            btnEducacion.Visible = true;
            btnAtras.Visible = false;
            btnCursillos.Visible = false;
            btnExamenes.Visible = false;
            cboConsultas.Visible=false;
            btnCargarListado.Visible=false;
        }

        private void btnEducacion_Click(object sender, EventArgs e)
        {
            btnMote.Visible = false;
            btnEducacion.Visible = false;
            btnAdministrar.Visible = false;
            btnCursillos.Visible = true;
            btnExamenes.Visible = true;
            btnAtras.Visible = true;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            cboConsultas.Visible = true ;
            cboConsultas.SelectedIndex = -1;
        }

        private void cboConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCargarListado.Visible = true;
            
        }

        private void btnCargarListado_Click(object sender, EventArgs e)
        {
            

                FrmConsulta1 carga = new FrmConsulta1();
                ////this.Hide();
                carga.ShowDialog();
              

            
        }

        private void btnMote_Click(object sender, EventArgs e)
        {
            FrmMote carga = new FrmMote();
            ////this.Hide();
            carga.ShowDialog();
        }
    }
}
