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
    public partial class FrmConsulta6 : Form
    {
        public FrmConsulta6()
        {
            InitializeComponent();
        }

        private void FrmConsulta6_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rcTan1DataSet6.sp_listar_oficiales' Puede moverla o quitarla según sea necesario.
            this.sp_listar_oficialesTableAdapter.Fill(this.rcTan1DataSet6.sp_listar_oficiales);
            reportViewer6.Size = new Size(800, 600);
            this.reportViewer6.RefreshReport();
            this.ClientSize = new Size(reportViewer6.Width, reportViewer6.Height);
        }
        
    }
}
