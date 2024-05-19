using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_RCTAN1.Formularios.Consultas
{
    public partial class FrmConsulta3 : Form
    {
        public FrmConsulta3()
        {
            InitializeComponent();
        }

        private void FrmConsulta3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rcTan1DataSet1.sp_listar_personal_rol_admin' Puede moverla o quitarla según sea necesario.
            this.sp_listar_personal_rol_adminTableAdapter.Fill(this.rcTan1DataSet1.sp_listar_personal_rol_admin);

            this.reportViewer1.RefreshReport();
        }
    }
}
