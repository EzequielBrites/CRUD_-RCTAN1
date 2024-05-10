namespace CRUD_RCTAN1.Formularios.Consultas
{
    partial class FrmConsulta1
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rcTan1DataSet = new CRUD_RCTAN1.RcTan1DataSet();
            this.sp_listar_personal_datosTableAdapter1 = new CRUD_RCTAN1.RcTan1DataSetTableAdapters.sp_listar_personal_datosTableAdapter();
            this.rcTan1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splistarpersonaldatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rcTan1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcTan1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splistarpersonaldatosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.splistarpersonaldatosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CRUD_RCTAN1.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // rcTan1DataSet
            // 
            this.rcTan1DataSet.DataSetName = "RcTan1DataSet";
            this.rcTan1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_listar_personal_datosTableAdapter1
            // 
            this.sp_listar_personal_datosTableAdapter1.ClearBeforeFill = true;
            // 
            // rcTan1DataSetBindingSource
            // 
            this.rcTan1DataSetBindingSource.DataSource = this.rcTan1DataSet;
            this.rcTan1DataSetBindingSource.Position = 0;
            // 
            // splistarpersonaldatosBindingSource
            // 
            this.splistarpersonaldatosBindingSource.DataMember = "sp_listar_personal_datos";
            this.splistarpersonaldatosBindingSource.DataSource = this.rcTan1DataSetBindingSource;
            // 
            // FrmConsulta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmConsulta1";
            this.Text = "FrmConsulta1";
            this.Load += new System.EventHandler(this.FrmConsulta1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rcTan1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcTan1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splistarpersonaldatosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CRUD_RCTAN1.RcTan1DataSetTableAdapters.sp_listar_personal_datosTableAdapter sp_listar_personal_datosTableAdapter1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private RcTan1DataSet rcTan1DataSet;
        private System.Windows.Forms.BindingSource splistarpersonaldatosBindingSource;
        private System.Windows.Forms.BindingSource rcTan1DataSetBindingSource;
    }
}