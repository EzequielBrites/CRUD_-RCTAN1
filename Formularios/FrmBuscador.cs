using System;
using CRUD_RCTAN1.Datos;
using CRUD_RCTAN1.Dominio;
using CRUD_RCTAN1.Formularios;
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
    public partial class FrmConsultas : Form
    {
        Dbhelper accesoBD = new Dbhelper();
        Personal persona = new Personal();
        public FrmConsultas()
        {
            InitializeComponent();
        }

        private void Buscador_Load(object sender, EventArgs e)
        {
            txtdni.Enabled = false;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //FrmCargaPersonal formulario = new FrmCargaPersonal();
            //Habilitar(true);
            //cboGrados.Enabled = true;

            //DataTable tabla = new DataTable();
            //tabla = accesoBD.Consultar_Persona("sp_consultar_persona",int.Parse(txtBuscador.Text));

            //foreach (DataRow fila in tabla.Rows)
            //{ 
            //    persona.Dni = Int32.Parse(fila["Dni"].ToString());
            //    persona.Nombre = fila["Nombre"].ToString();
            //    persona.Apellido = fila["Apellido"].ToString();
            //    persona.FechaNacimiento = DateTime.Parse(fila["fecha_nac"].ToString());
            //    if (Int32.Parse(fila["id_sexo"].ToString()) == 1 )
            //    {
            //        persona.Sexo = 1;
            //    }
            //    else     
            //    {     
            //        persona.Sexo = 2;  
            //    }
            //    persona.Grado = Int32.Parse(fila["id_grado"].ToString());
            //    persona.RolAdministrativo = fila["rol_administrativo"].ToString();
            //    persona.RolCombate = fila["rol_combate"].ToString();
            //    persona.Seccion = Int32.Parse(fila["id_seccion"].ToString());
            //    persona.Arma = Int32.Parse(fila["id_arma"].ToString());
    
            //}

            //formulario.txtDni.Text = persona.Dni.ToString();
            //formulario.txtNombre.Text = persona.Nombre.ToString();
            //formulario.txtApellido.Text = persona.Apellido.ToString();
            //formulario.dtpFechaNacimiento.Text = persona.FechaNacimiento.ToString("dd/MM/yyyy");
            //if(persona.Sexo==1 ) 
            //{ 
            //    formulario.rbMasculino.Checked = true;
            //}
            //else 
            //{ 
            //    formulario.rbFemenino.Checked = true;
            //}

            ////formulario.cboGrados.SelectedIndex= persona.Grado;
            //formulario.txtRolAdmin.Text = persona.RolAdministrativo;
            //formulario.txtRolComb.Text = persona.RolCombate;
            ////formulario.cboSecciones.SelectedIndex = persona.Seccion;
            ////formulario.cboArmas.SelectedIndex = persona.Arma;

            
            
        }

        private void cboConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboListados.SelectedIndex == 0)
            {
                txtdni.Enabled = true;
            
            
            }
        }
    }
}
