﻿namespace CRUD_RCTAN1.Formularios.Consultas
{
    partial class FrmConsulta5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta5));
            this.splistarsuboficialessuperioresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rcTan1DataSet3 = new CRUD_RCTAN1.RcTan1DataSet3();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_listar_suboficiales_superioresTableAdapter = new CRUD_RCTAN1.RcTan1DataSet3TableAdapters.sp_listar_suboficiales_superioresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splistarsuboficialessuperioresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcTan1DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // splistarsuboficialessuperioresBindingSource
            // 
            this.splistarsuboficialessuperioresBindingSource.DataMember = "sp_listar_suboficiales_superiores";
            this.splistarsuboficialessuperioresBindingSource.DataSource = this.rcTan1DataSet3;
            // 
            // rcTan1DataSet3
            // 
            this.rcTan1DataSet3.DataSetName = "RcTan1DataSet3";
            this.rcTan1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.splistarsuboficialessuperioresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CRUD_RCTAN1.Reportes.reportViewer5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1128, 504);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_listar_suboficiales_superioresTableAdapter
            // 
            this.sp_listar_suboficiales_superioresTableAdapter.ClearBeforeFill = true;
            // 
            // FrmConsulta5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 504);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsulta5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado SubOficiales Superiores";
            this.Load += new System.EventHandler(this.FrmConsulta5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splistarsuboficialessuperioresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcTan1DataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private RcTan1DataSet3 rcTan1DataSet3;
        private System.Windows.Forms.BindingSource splistarsuboficialessuperioresBindingSource;
        private RcTan1DataSet3TableAdapters.sp_listar_suboficiales_superioresTableAdapter sp_listar_suboficiales_superioresTableAdapter;
    }
}