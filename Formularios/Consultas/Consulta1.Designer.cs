﻿namespace CRUD_RCTAN1.Formularios.Consultas
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
            this.rcTan1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rcTan1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcTan1DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.rcTan1DataSetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CRUD_RCTAN1.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-2, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(910, 538);
            this.reportViewer1.TabIndex = 0;
            // 
            // rcTan1DataSet
            // 
            this.rcTan1DataSet.DataSetName = "RcTan1DataSet";
            this.rcTan1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rcTan1DataSetBindingSource
            // 
            this.rcTan1DataSetBindingSource.DataSource = this.rcTan1DataSet;
            this.rcTan1DataSetBindingSource.Position = 0;
            // 
            // FrmConsulta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 549);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmConsulta1";
            this.Text = "Consulta1";
            this.Load += new System.EventHandler(this.Consulta1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rcTan1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcTan1DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rcTan1DataSetBindingSource;
        private RcTan1DataSet rcTan1DataSet;
    }
}