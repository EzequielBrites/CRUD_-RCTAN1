namespace CRUD_RCTAN1.Formularios.Consultas
{
    partial class FrmConsulta7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta7));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rcTan1DataSet7 = new CRUD_RCTAN1.RcTan1DataSet7();
            this.splistarsoldadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_listar_soldadosTableAdapter = new CRUD_RCTAN1.RcTan1DataSet7TableAdapters.sp_listar_soldadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rcTan1DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splistarsoldadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.splistarsoldadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CRUD_RCTAN1.Reportes.reportViewer7.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1128, 504);
            this.reportViewer1.TabIndex = 0;
            // 
            // rcTan1DataSet7
            // 
            this.rcTan1DataSet7.DataSetName = "RcTan1DataSet7";
            this.rcTan1DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splistarsoldadosBindingSource
            // 
            this.splistarsoldadosBindingSource.DataMember = "sp_listar_soldados";
            this.splistarsoldadosBindingSource.DataSource = this.rcTan1DataSet7;
            // 
            // sp_listar_soldadosTableAdapter
            // 
            this.sp_listar_soldadosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmConsulta7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 504);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsulta7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Soldados Voluntarios";
            this.Load += new System.EventHandler(this.FrmConsulta7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rcTan1DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splistarsoldadosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private RcTan1DataSet7 rcTan1DataSet7;
        private System.Windows.Forms.BindingSource splistarsoldadosBindingSource;
        private RcTan1DataSet7TableAdapters.sp_listar_soldadosTableAdapter sp_listar_soldadosTableAdapter;
    }
}