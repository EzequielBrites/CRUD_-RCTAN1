namespace CRUD_RCTAN1.Formularios.Consultas
{
    partial class FrmConsulta3
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta3));
            this.splistarpersonalroladminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rcTan1DataSet1 = new CRUD_RCTAN1.RcTan1DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_listar_personal_rol_adminTableAdapter = new CRUD_RCTAN1.RcTan1DataSet1TableAdapters.sp_listar_personal_rol_adminTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splistarpersonalroladminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcTan1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // splistarpersonalroladminBindingSource
            // 
            this.splistarpersonalroladminBindingSource.DataMember = "sp_listar_personal_rol_admin";
            this.splistarpersonalroladminBindingSource.DataSource = this.rcTan1DataSet1;
            // 
            // rcTan1DataSet1
            // 
            this.rcTan1DataSet1.DataSetName = "RcTan1DataSet1";
            this.rcTan1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.splistarpersonalroladminBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CRUD_RCTAN1.Reportes.reportViewer3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1128, 504);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_listar_personal_rol_adminTableAdapter
            // 
            this.sp_listar_personal_rol_adminTableAdapter.ClearBeforeFill = true;
            // 
            // FrmConsulta3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 504);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsulta3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Personal ";
            this.Load += new System.EventHandler(this.FrmConsulta3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splistarpersonalroladminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcTan1DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private RcTan1DataSet1 rcTan1DataSet1;
        private System.Windows.Forms.BindingSource splistarpersonalroladminBindingSource;
        private RcTan1DataSet1TableAdapters.sp_listar_personal_rol_adminTableAdapter sp_listar_personal_rol_adminTableAdapter;
    }
}