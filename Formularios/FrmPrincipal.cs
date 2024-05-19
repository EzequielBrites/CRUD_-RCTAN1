using CRUD_RCTAN1.Formularios.Consultas;
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
            lblConsultas.Visible = true;
            btnMote.Visible = false;
            btnEducacion.Visible = false;
            btnAtras.Visible = true;
            btnSubUnidades.Visible = false;
            cboConsultas.Visible = true;
            cboConsultas.SelectedIndex = -1;
            pictureBox1.Visible = false;

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
            pictureBox1.Visible = false;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            cboConsultas.Visible = false;
            
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            lblConsultas.Visible = false;

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            btnAdministrar.Visible = false;
            btnSubUnidades.Visible = true;
            btnMote.Visible = true;
            btnEducacion.Visible = true;
            pictureBox1.Visible = true;
            lblConsultas.Visible = false;
            btnAtras.Visible = false;
            btnCursillos.Visible = false;
            btnExamenes.Visible = false;
            cboConsultas.Visible=false;
            btnCargarListado.Visible=false;
        }

        private void btnEducacion_Click(object sender, EventArgs e)
        {
            btnMote.Visible = false;
            pictureBox1.Visible = false;
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
            
            if(cboConsultas.SelectedIndex==0)
            {
                FrmConsulta1 carga = new FrmConsulta1();
                ////this.Hide();
                carga.ShowDialog();

            }
            if (cboConsultas.SelectedIndex == 1)
            {
                FrmConsulta2 carga = new FrmConsulta2();
                ////this.Hide();
                carga.ShowDialog();

            }
            if (cboConsultas.SelectedIndex == 2)
            {
                FrmConsulta3 carga = new FrmConsulta3();
                ////this.Hide();
                carga.ShowDialog();

            }
            if (cboConsultas.SelectedIndex == 3)
            {
                FrmConsulta4 carga = new FrmConsulta4();
                ////this.Hide();
                carga.ShowDialog();

            }
            if (cboConsultas.SelectedIndex == 4)
            {
                FrmConsulta5 carga = new FrmConsulta5();
                ////this.Hide();
                carga.ShowDialog();

            }
            if (cboConsultas.SelectedIndex == 5)
            {
                FrmConsulta6 carga = new FrmConsulta6();
                ////this.Hide();
                carga.ShowDialog();

            }
            if (cboConsultas.SelectedIndex == 6)
            {
                FrmConsulta7 carga = new FrmConsulta7();
                ////this.Hide();
                carga.ShowDialog();

            }



        }

        private void btnMote_Click(object sender, EventArgs e)
        {
            FrmMote carga = new FrmMote();
            ////this.Hide();
            carga.ShowDialog();
            pictureBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Cerrar el formulario?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                , MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                //FrmPrincipal carga = new FrmPrincipal();
                ////this.Hide();
                //carga.ShowDialog();
                this.Close();
        }

        private void btnSubUnidades_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
