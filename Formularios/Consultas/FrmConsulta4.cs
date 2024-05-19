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
    public partial class FrmConsulta4 : Form
    {
        public FrmConsulta4()
        {
            InitializeComponent();
        }

        private void FrmConsulta4_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rcTan1DataSet3.sp_listar_suboficiales_subalternos' Puede moverla o quitarla según sea necesario.
            this.sp_listar_suboficiales_subalternosTableAdapter.Fill(this.rcTan1DataSet3.sp_listar_suboficiales_subalternos);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
