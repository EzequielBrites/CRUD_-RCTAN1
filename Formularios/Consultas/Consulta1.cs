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
    public partial class FrmConsulta1 : Form
    {
        public FrmConsulta1()
        {
            InitializeComponent();
        }

        private void Consulta1_Load(object sender, EventArgs e)
        {


            this.reportViewer1.RefreshReport();
        }
    }
}
