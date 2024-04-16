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
        Personal persona = new Personal();

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
            CargarCombos(cboSeccion, "sp_consultar_secciones");
            CargarCombos(cboTipos, "sp_consultar_tipos_grados");
            limpiar();
            txtDni.Enabled = true;
            Habilitar(false);
            cboGrados.Enabled = false;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnEditar.Visible = false;
            btnGuardarEdicion.Enabled = false;

        }
       
        private void limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            dtpFechaNacimiento.Value = DateTime.Today;
            txtDni.Text = "";
            
                  
            rbFemenino.Checked = false;
            rbMasculino.Checked = false;
            
            txtRolAdmin.Text = "";
            cboTipos.SelectedValue = -1;
            cboGrados.SelectedValue = -1;
            txtRolComb.Text = "";
            cboSubUnidad.SelectedValue = -1;    
            cboArmas.SelectedValue = -1;
            cboSeccion.SelectedValue = -1;
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
            if (txtDni.Text == "")
            {
                MessageBox.Show("Debe ingresar un DNI", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un NOMBRE", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtApellido.Text == "")
            {
                MessageBox.Show("Debe ingresar un APELLIDO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if (dtpFechaNacimiento.Value == DateTime.Today)
            {
                MessageBox.Show("Debe ingresar una fecha de nacimiento correcta", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (rbFemenino.Checked == false && rbMasculino.Checked == false)
            {
                MessageBox.Show("Debe seleccionar un Sexo", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboGrados.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Grado", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtRolAdmin.Text == "")
            {
                MessageBox.Show("Debe ingresar un Rol Administrativo", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtRolComb.Text == "")
            {
                MessageBox.Show("Debe ingresar un Rol de Combate", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cboSeccion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una Sección", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cboArmas.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Arma", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            lparametros.Clear();
            Personal p = new Personal();
            p.Nombre = txtNombre.Text;
            p.Apellido = txtApellido.Text;
            if (rbMasculino.Checked == true)
                p.Sexo = 1;
            else
                p.Sexo = 2;
            
            p.Dni = Convert.ToInt32(txtDni.Text);
            p.RolAdministrativo = txtRolAdmin.Text;
            p.RolCombate = txtRolComb.Text; 
            p.Grado = cboGrados.SelectedIndex+1;
            p.Seccion= cboSeccion.SelectedIndex;
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
                txtDni.Enabled = true;
                txtDni.Enabled = true;
                Habilitar(false);
                cboGrados.Enabled = false;
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = false;
                btnEditar.Visible = false;
                btnGuardarEdicion.Enabled = false;
                lparametros.Clear();
            }

        }

        public void Habilitar(bool x)
        {
            //txtDni.Enabled = x;
            txtNombre.Enabled = x;
            txtApellido.Enabled = x;
            dtpFechaNacimiento.Enabled = x;
            rbFemenino.Enabled = x;
            rbMasculino.Enabled = x;
            cboTipos.Enabled = x;
            cboSubUnidad.Enabled = x;
            txtRolAdmin.Enabled = x;
            txtRolComb.Enabled = x;
            cboSeccion.Enabled = x;
            cboArmas.Enabled = x;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //limpiar();
            Habilitar(true);
            txtDni.Focus();
            btnGuardar.Enabled = true;
            btnNuevo.Visible = false;
            btnEliminar.Visible = false;
            btnBuscar.Visible = false;
            btnGuardarEdicion.Visible = false;
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            if (txtDni.Text == "")
            {
                MessageBox.Show("Debe ingresar un DNI", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                btnBuscar.Visible = false;
                
                txtDni.Enabled = false;
                btnEditar.Visible = true;

                DataTable tabla = new DataTable();
                tabla = accesoBD.Consultar_Persona("sp_consultar_persona", int.Parse(txtDni.Text));

                foreach (DataRow fila in tabla.Rows)
                {
                    persona.Dni = Int32.Parse(fila["Dni"].ToString());
                    persona.Nombre = fila["Nombre"].ToString();
                    persona.Apellido = fila["Apellido"].ToString();
                    persona.FechaNacimiento = DateTime.Parse(fila["fecha_nac"].ToString());
                    if (Int32.Parse(fila["id_sexo"].ToString()) == 1)
                    {
                        persona.Sexo = 1;
                    }
                    else
                    {
                        persona.Sexo = 2;
                    }
                    persona.Grado = Int32.Parse(fila["id_grado"].ToString());
                    persona.RolAdministrativo = fila["rol_administrativo"].ToString();
                    persona.RolCombate = fila["rol_combate"].ToString();
                    persona.Seccion = Int32.Parse(fila["id_seccion"].ToString());
                    persona.Arma = Int32.Parse(fila["id_arma"].ToString());

                }

                txtDni.Text = persona.Dni.ToString();
                txtNombre.Text = persona.Nombre.ToString();
                txtApellido.Text = persona.Apellido.ToString();
                dtpFechaNacimiento.Text = persona.FechaNacimiento.ToString("dd/MM/yyyy");
                if (persona.Sexo == 1)
                {
                    rbMasculino.Checked = true;
                }
                else
                {
                    rbFemenino.Checked = true;
                }

                cboGrados.SelectedIndex = persona.Grado - 1;
                txtRolAdmin.Text = persona.RolAdministrativo;
                txtRolComb.Text = persona.RolCombate;
                cboSeccion.SelectedIndex = persona.Seccion;
                cboArmas.SelectedIndex = persona.Arma - 1;

            }

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            Habilitar(true);
            txtDni.Enabled = true;
            btnBuscar.Enabled = false;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = true;
            btnGuardarEdicion.Enabled = true;
            btnGuardar.Enabled=false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea eliminarlo?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                , MessageBoxDefaultButton.Button2) == DialogResult.Yes)
              
            lparametros.Clear();
            lparametros.Add(new Parametro("@dni", Int32.Parse(txtDni.Text)));
            if (accesoBD.actualizarBD("sp_eliminar_persona", lparametros) > 0)

            {
                MessageBox.Show("Se elimino correctamente");
                limpiar();
                txtDni.Enabled = true;
                Habilitar(false);
                cboGrados.Enabled = false;
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = false;
                btnEditar.Visible = false;
                btnGuardarEdicion.Enabled = false;
                lparametros.Clear();
            }
            
        }

        private void btnGuardarEdicion_Click(object sender, EventArgs e)
        {
            lparametros.Clear();
            Personal p = new Personal();
            p.Nombre = txtNombre.Text;
            p.Apellido = txtApellido.Text;
            if (rbMasculino.Checked == true)
                p.Sexo = 1;
            else
                p.Sexo = 2;

            p.Dni = Convert.ToInt32(txtDni.Text);
            p.RolAdministrativo = txtRolAdmin.Text;
            p.RolCombate = txtRolComb.Text;
            p.Grado = cboGrados.SelectedIndex + 1;
            p.Seccion = cboSeccion.SelectedIndex -1 ;
            p.Arma = cboArmas.SelectedIndex + 1;
            p.FechaNacimiento = dtpFechaNacimiento.Value;
            lparametros.Add(new Parametro("@Dni", p.Dni));
            lparametros.Add(new Parametro("@Nombre", p.Nombre));
            lparametros.Add(new Parametro("@Apellido", p.Apellido));
            lparametros.Add(new Parametro("@fecha_nac", p.FechaNacimiento));
            lparametros.Add(new Parametro("@sexo", p.Sexo));
            lparametros.Add(new Parametro("@grado", p.Grado));
            lparametros.Add(new Parametro("@seccion", p.Seccion));
            lparametros.Add(new Parametro("@arma", p.Arma));
            lparametros.Add(new Parametro("@rol_combate", p.RolCombate));
            lparametros.Add(new Parametro("@rol_administrativo", p.RolAdministrativo));
            

            if (accesoBD.actualizarBD("sp_editar_persona", lparametros) > 0)

            {
                MessageBox.Show("Se modificó con éxito!");
                limpiar();
                txtDni.Enabled = true;
                Habilitar(false);
                cboGrados.Enabled = false;
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = false;
                btnEditar.Visible = false;
                btnBuscar.Visible = true;
                btnBuscar.Enabled = true;
                btnGuardarEdicion.Enabled = false;
                lparametros.Clear();
            }
        }
    }
}
