using System;
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
    public partial class FrmMote : Form
    {
        public FrmMote()
        {
            InitializeComponent();
        }

        private void FrmMote_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rcTan1DataSet21.sp_listar_personal_datos' Puede moverla o quitarla según sea necesario.
            this.sp_listar_personal_datosTableAdapter.Fill(this.rcTan1DataSet21.sp_listar_personal_datos);


            this.reportViewer1.RefreshReport();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
