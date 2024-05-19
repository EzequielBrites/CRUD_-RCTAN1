using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_RCTAN1.Formularios
{
    public partial class FrmMote : Form
    {
        private int dni;
        public FrmMote()
        {
            InitializeComponent();
        }

        private void FrmMote_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rcTan1DataSet21.sp_listar_personal_datos' Puede moverla o quitarla según sea necesario.
            


            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            dni = Convert.ToInt32(txtdni.Text);
            
            this.sp_consultar_condicion_actualTableAdapter1.Fill(this.rcTan1DataSet10.sp_consultar_condicion_actual, dni);
            this.reportViewer1.RefreshReport();
        }
    }
}
