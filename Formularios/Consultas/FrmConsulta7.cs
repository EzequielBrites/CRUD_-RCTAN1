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
    public partial class FrmConsulta7 : Form
    {
        public FrmConsulta7()
        {
            InitializeComponent();
        }

        private void FrmConsulta7_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rcTan1DataSet7.sp_listar_soldados' Puede moverla o quitarla según sea necesario.
            this.sp_listar_soldadosTableAdapter.Fill(this.rcTan1DataSet7.sp_listar_soldados);

            this.reportViewer1.RefreshReport();
        }
    }
}
