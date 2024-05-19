namespace CRUD_RCTAN1.Formularios.Consultas
{
    partial class FrmConsulta6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta6));
            this.splistaroficialesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rcTan1DataSet6 = new CRUD_RCTAN1.RcTan1DataSet6();
            this.reportViewer6 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_listar_oficialesTableAdapter = new CRUD_RCTAN1.RcTan1DataSet6TableAdapters.sp_listar_oficialesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splistaroficialesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcTan1DataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // splistaroficialesBindingSource
            // 
            this.splistaroficialesBindingSource.DataMember = "sp_listar_oficiales";
            this.splistaroficialesBindingSource.DataSource = this.rcTan1DataSet6;
            // 
            // rcTan1DataSet6
            // 
            this.rcTan1DataSet6.DataSetName = "RcTan1DataSet6";
            this.rcTan1DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer6
            // 
            this.reportViewer6.AutoSize = true;
            this.reportViewer6.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.splistaroficialesBindingSource;
            this.reportViewer6.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer6.LocalReport.ReportEmbeddedResource = "CRUD_RCTAN1.Reportes.reportViewer6.rdlc";
            this.reportViewer6.Location = new System.Drawing.Point(0, 0);
            this.reportViewer6.Name = "reportViewer6";
            this.reportViewer6.ServerReport.BearerToken = null;
            this.reportViewer6.Size = new System.Drawing.Size(1128, 504);
            this.reportViewer6.TabIndex = 0;
            // 
            // sp_listar_oficialesTableAdapter
            // 
            this.sp_listar_oficialesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmConsulta6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1128, 504);
            this.Controls.Add(this.reportViewer6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsulta6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Oficiales";
            this.Load += new System.EventHandler(this.FrmConsulta6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splistaroficialesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcTan1DataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer6;
        private RcTan1DataSet6 rcTan1DataSet6;
        private System.Windows.Forms.BindingSource splistaroficialesBindingSource;
        private RcTan1DataSet6TableAdapters.sp_listar_oficialesTableAdapter sp_listar_oficialesTableAdapter;
    }
}