namespace CRUD_RCTAN1.Formularios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta1));
            this.sp_listar_personal_datosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rcTan1DataSet2 = new CRUD_RCTAN1.RcTan1DataSet2();
            this.sp_listar_personal_datosTableAdapter = new CRUD_RCTAN1.RcTan1DataSet2TableAdapters.sp_listar_personal_datosTableAdapter();
            this.tableAdapterManager = new CRUD_RCTAN1.RcTan1DataSet2TableAdapters.TableAdapterManager();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.sp_listar_personal_datosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcTan1DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_listar_personal_datosBindingSource
            // 
            this.sp_listar_personal_datosBindingSource.DataMember = "sp_listar_personal_datos";
            this.sp_listar_personal_datosBindingSource.DataSource = this.rcTan1DataSet2;
            // 
            // rcTan1DataSet2
            // 
            this.rcTan1DataSet2.DataSetName = "RcTan1DataSet2";
            this.rcTan1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_listar_personal_datosTableAdapter
            // 
            this.sp_listar_personal_datosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministradoresTableAdapter = null;
            this.tableAdapterManager.armasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.condiciones_tirosTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.estados_civilesTableAdapter = null;
            this.tableAdapterManager.gradosTableAdapter = null;
            this.tableAdapterManager.personalTableAdapter = null;
            this.tableAdapterManager.pruebas_tiroTableAdapter = null;
            this.tableAdapterManager.roles_administrativosTableAdapter = null;
            this.tableAdapterManager.roles_combateTableAdapter = null;
            this.tableAdapterManager.sala_armasTableAdapter = null;
            this.tableAdapterManager.seccionesTableAdapter = null;
            this.tableAdapterManager.sexosTableAdapter = null;
            this.tableAdapterManager.subunidadesTableAdapter = null;
            this.tableAdapterManager.tipos_gradosTableAdapter = null;
            this.tableAdapterManager.tipos_rolesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CRUD_RCTAN1.RcTan1DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.sp_listar_personal_datosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CRUD_RCTAN1.Reportes.reportViewer1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1031, 670);
            this.reportViewer1.TabIndex = 0;
            // 
            // FrmConsulta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CRUD_RCTAN1.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(1031, 670);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsulta1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Personal";
            this.Load += new System.EventHandler(this.FrmConsulta1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_listar_personal_datosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcTan1DataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RcTan1DataSet2 rcTan1DataSet2;
        private System.Windows.Forms.BindingSource sp_listar_personal_datosBindingSource;
        private RcTan1DataSet2TableAdapters.sp_listar_personal_datosTableAdapter sp_listar_personal_datosTableAdapter;
        private RcTan1DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}