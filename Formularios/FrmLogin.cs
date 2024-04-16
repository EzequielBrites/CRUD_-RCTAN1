using CRUD_RCTAN1.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_RCTAN1.Formularios
{
    public partial class FrmLogin : Form
    {
        Dbhelper accesoBD = new Dbhelper();
        
        
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
            txtContraseña.PasswordChar = '*';
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Cerrar la aplicacion?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                , MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }
        private void Limpiar()
        {
            txtContraseña.Text = "";
            txtUsuario.Text = "";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            //int resultado = accesoBD.VerificarUsuario(txtUsuario.Text, txtContraseña.Text);
            //if (resultado == 1)
            //{
                FrmPrincipal carga = new FrmPrincipal();
                this.Hide();
                carga.ShowDialog();
            //}
            //else if (resultado == 0)
            //{
            //    MessageBox.Show("Usuario o contraseña incorrecta");
                
            //}

        }
    }
}
