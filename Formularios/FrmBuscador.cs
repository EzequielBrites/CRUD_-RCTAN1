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
    public partial class Buscador : Form
    {
        Dbhelper accesoBD = new Dbhelper();
        public Buscador()
        {
            InitializeComponent();
        }

        private void Buscador_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = accesoBD.Consultar_Persona("sp_consultar_persona",int.Parse(txtBuscador.Text));
            
        }
    }
}
