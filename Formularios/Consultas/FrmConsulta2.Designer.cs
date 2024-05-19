namespace CRUD_RCTAN1.Formularios.Consultas
{
    partial class FrmConsulta2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta2));
            this.splistarpersonalrolcombateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rcTan1DataSet1 = new CRUD_RCTAN1.RcTan1DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rcTan1DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new CRUD_RCTAN1.RcTan1DataSet2TableAdapters.TableAdapterManager();
            this.sp_listar_personal_rol_combateTableAdapter = new CRUD_RCTAN1.RcTan1DataSet1TableAdapters.sp_listar_personal_rol_combateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splistarpersonalrolcombateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcTan1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcTan1DataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splistarpersonalrolcombateBindingSource
            // 
            this.splistarpersonalrolcombateBindingSource.DataMember = "sp_listar_personal_rol_combate";
            this.splistarpersonalrolcombateBindingSource.DataSource = this.rcTan1DataSet1;
            // 
            // rcTan1DataSet1
            // 
            this.rcTan1DataSet1.DataSetName = "RcTan1DataSet1";
            this.rcTan1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.splistarpersonalrolcombateBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CRUD_RCTAN1.Reportes.reportViewer2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1031, 670);
            this.reportViewer1.TabIndex = 0;
            // 
            // rcTan1DataSet1BindingSource
            // 
            this.rcTan1DataSet1BindingSource.DataSource = this.rcTan1DataSet1;
            this.rcTan1DataSet1BindingSource.Position = 0;
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
            // sp_listar_personal_rol_combateTableAdapter
            // 
            this.sp_listar_personal_rol_combateTableAdapter.ClearBeforeFill = true;
            // 
            // FrmConsulta2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 670);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsulta2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Personal ";
            this.Load += new System.EventHandler(this.FrmConsulta2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splistarpersonalrolcombateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcTan1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcTan1DataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rcTan1DataSet1BindingSource;
        private RcTan1DataSet1 rcTan1DataSet1;
        private RcTan1DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource splistarpersonalrolcombateBindingSource;
        private RcTan1DataSet1TableAdapters.sp_listar_personal_rol_combateTableAdapter sp_listar_personal_rol_combateTableAdapter;
    }
}