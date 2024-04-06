using CRUD_RCTAN1.Datos;
using CRUD_RCTAN1.Dominio;
using CRUD_RCTAN1.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CRUD_RCTAN1
{
    public partial class FrmCargaPersonal : Form
    {
        
        Dbhelper accesoBD = new Dbhelper();
        List<Parametro> lparametros;
        public FrmCargaPersonal()
        {
            InitializeComponent();
            
            lparametros = new List<Parametro>();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            CargarCombos(cboSubUnidad, "sp_consultar_subunidades");
            CargarCombos(cboArmas, "sp_consultar_armas");
            CargarCombos(cboSecciones, "sp_consultar_secciones");
            CargarCombos(cboTipos, "sp_consultar_tipos_grados");
            limpiar();
            
            cboGrados.Enabled = false;

        }
       
        private void limpiar()
        {
            txbNombre.Text = "";
            txbApellido.Text = "";
            dtpFechaNacimiento.Value = DateTime.Today;
            txbDni.Text = "";
            
                  
            rbFemenino.Checked = false;
            rbMasculino.Checked = false;
            
            txtRolAdmin.Text = "";
            cboTipos.SelectedValue = -1;
            cboGrados.SelectedValue = -1;
            txtRolComb.Text = "";
            cboSubUnidad.SelectedValue = -1;    
            cboArmas.SelectedValue = -1;
            cboSecciones.SelectedValue = -1;
            cboTipos.SelectedValue= -1; 

        }
        
        public void CargarCombos(System.Windows.Forms.ComboBox combo, string sp)
        {
            DataTable tabla = new DataTable();
            tabla = accesoBD.Consultar_SP(sp);
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Cerrar el formulario?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                , MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            //FrmPrincipal carga = new FrmPrincipal();
            ////this.Hide();
            //carga.ShowDialog();
            this.Close();
        }

        //private void cboProvincias_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cboCiudades.Enabled = true;

        //    if (cboProvincias.SelectedIndex != -1) 
        //    {
        //        cboCiudades.DataSource = accesoBD.Consultar_Ciudades("sp_consultar_ciudades", cboProvincias.SelectedIndex);
        //        cboCiudades.ValueMember = "id_ciudad";
        //        cboCiudades.DisplayMember = "Ciudad";


        //    }
            


        //}

        private void cboTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboGrados.Enabled = true;
            if (cboTipos.SelectedIndex != -1)
            {
                cboGrados.DataSource = accesoBD.Consultar_grados("sp_consultar_grados", cboTipos.SelectedIndex);
                cboGrados.ValueMember = "id_grado";
                cboGrados.DisplayMember = "grado";


            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lparametros.Clear();
            Personal p = new Personal();
            p.Nombre = txbNombre.Text;
            p.Apellido = txbApellido.Text;
            if (rbMasculino.Checked == true)
                p.Sexo = 1;
            else
                p.Sexo = 2;
            
            p.Dni = Convert.ToInt32(txbDni.Text);
            
            p.RolAdministrativo = txtRolAdmin.Text;
            p.RolCombate = txtRolComb.Text;
            
            p.Grado = cboGrados.SelectedIndex+1;
            p.Seccion= cboSecciones.SelectedIndex + 1;
            p.Arma= cboArmas.SelectedIndex + 1;
            
            p.FechaNacimiento = dtpFechaNacimiento.Value;

            
            lparametros.Add(new Parametro("@nombre", p.Nombre));
            lparametros.Add(new Parametro("@apellido", p.Apellido));
            
            
            lparametros.Add(new Parametro("@fecha_nacimiento", p.FechaNacimiento));
            lparametros.Add(new Parametro("@sexo", p.Sexo));
            
            lparametros.Add(new Parametro("@grado", p.Grado));
            
            lparametros.Add(new Parametro("@seccion", p.Seccion));
            lparametros.Add(new Parametro("@arma", p.Arma));
            lparametros.Add(new Parametro("@rolCombate", p.RolCombate));
            lparametros.Add(new Parametro("@rolAdministrativo", p.RolAdministrativo));
            lparametros.Add(new Parametro("@dni", p.Dni));

            if (accesoBD.actualizarBD("sp_insertar_personal", lparametros) > 0)

            {
                MessageBox.Show("Se registro con exito!");
                limpiar();
            }
        }
    }
}
