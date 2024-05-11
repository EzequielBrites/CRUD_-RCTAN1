namespace CRUD_RCTAN1.Formularios
{
    partial class FrmMote
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
            this.rcTan1DataSet21 = new CRUD_RCTAN1.RcTan1DataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rcTan1DataSet21BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splistarpersonaldatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_listar_personal_datosTableAdapter = new CRUD_RCTAN1.RcTan1DataSet2TableAdapters.sp_listar_personal_datosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rcTan1DataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcTan1DataSet21BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splistarpersonaldatosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rcTan1DataSet21
            // 
            this.rcTan1DataSet21.DataSetName = "RcTan1DataSet2";
            this.rcTan1DataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.splistarpersonaldatosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CRUD_RCTAN1.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(845, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // rcTan1DataSet21BindingSource
            // 
            this.rcTan1DataSet21BindingSource.DataSource = this.rcTan1DataSet21;
            this.rcTan1DataSet21BindingSource.Position = 0;
            // 
            // splistarpersonaldatosBindingSource
            // 
            this.splistarpersonaldatosBindingSource.DataMember = "sp_listar_personal_datos";
            this.splistarpersonaldatosBindingSource.DataSource = this.rcTan1DataSet21BindingSource;
            // 
            // sp_listar_personal_datosTableAdapter
            // 
            this.sp_listar_personal_datosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmMote";
            this.Text = "FrmMote";
            this.Load += new System.EventHandler(this.FrmMote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rcTan1DataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcTan1DataSet21BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splistarpersonaldatosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RcTan1DataSet2 rcTan1DataSet21;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rcTan1DataSet21BindingSource;
        private System.Windows.Forms.BindingSource splistarpersonaldatosBindingSource;
        private RcTan1DataSet2TableAdapters.sp_listar_personal_datosTableAdapter sp_listar_personal_datosTableAdapter;
    }
}