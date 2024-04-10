namespace CRUD_RCTAN1.Formularios
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnEscuadrones = new System.Windows.Forms.Button();
            this.btnEducacion = new System.Windows.Forms.Button();
            this.btnMote = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnAdministrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCursillos = new System.Windows.Forms.Button();
            this.btnExamenes = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 26);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // btnPersonal
            // 
            this.btnPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonal.Location = new System.Drawing.Point(223, 69);
            this.btnPersonal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(261, 58);
            this.btnPersonal.TabIndex = 1;
            this.btnPersonal.Text = "Personal";
            this.btnPersonal.UseVisualStyleBackColor = true;
            this.btnPersonal.Click += new System.EventHandler(this.btnCargaPersonal_Click);
            // 
            // btnEscuadrones
            // 
            this.btnEscuadrones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscuadrones.Location = new System.Drawing.Point(223, 145);
            this.btnEscuadrones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEscuadrones.Name = "btnEscuadrones";
            this.btnEscuadrones.Size = new System.Drawing.Size(261, 58);
            this.btnEscuadrones.TabIndex = 2;
            this.btnEscuadrones.Text = "Escuadrones";
            this.btnEscuadrones.UseVisualStyleBackColor = true;
            // 
            // btnEducacion
            // 
            this.btnEducacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEducacion.Location = new System.Drawing.Point(223, 221);
            this.btnEducacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEducacion.Name = "btnEducacion";
            this.btnEducacion.Size = new System.Drawing.Size(261, 58);
            this.btnEducacion.TabIndex = 3;
            this.btnEducacion.Text = "Educación";
            this.btnEducacion.UseVisualStyleBackColor = true;
            this.btnEducacion.Click += new System.EventHandler(this.btnEducacion_Click);
            // 
            // btnMote
            // 
            this.btnMote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMote.Location = new System.Drawing.Point(223, 300);
            this.btnMote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMote.Name = "btnMote";
            this.btnMote.Size = new System.Drawing.Size(261, 58);
            this.btnMote.TabIndex = 4;
            this.btnMote.Text = "Mote";
            this.btnMote.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(30, 492);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(123, 46);
            this.btnAtras.TabIndex = 5;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnAdministrar
            // 
            this.btnAdministrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrar.Location = new System.Drawing.Point(223, 69);
            this.btnAdministrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdministrar.Name = "btnAdministrar";
            this.btnAdministrar.Size = new System.Drawing.Size(261, 58);
            this.btnAdministrar.TabIndex = 6;
            this.btnAdministrar.Text = "Administrar";
            this.btnAdministrar.UseVisualStyleBackColor = true;
            this.btnAdministrar.Click += new System.EventHandler(this.btnAdministrar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(223, 145);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(261, 58);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnCursillos
            // 
            this.btnCursillos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursillos.Location = new System.Drawing.Point(223, 69);
            this.btnCursillos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCursillos.Name = "btnCursillos";
            this.btnCursillos.Size = new System.Drawing.Size(261, 58);
            this.btnCursillos.TabIndex = 8;
            this.btnCursillos.Text = "Cursillos";
            this.btnCursillos.UseVisualStyleBackColor = true;
            // 
            // btnExamenes
            // 
            this.btnExamenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExamenes.Location = new System.Drawing.Point(223, 145);
            this.btnExamenes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExamenes.Name = "btnExamenes";
            this.btnExamenes.Size = new System.Drawing.Size(261, 58);
            this.btnExamenes.TabIndex = 9;
            this.btnExamenes.Text = "Exámenes";
            this.btnExamenes.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::CRUD_RCTAN1.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(697, 562);
            this.Controls.Add(this.btnExamenes);
            this.Controls.Add(this.btnCursillos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAdministrar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnMote);
            this.Controls.Add(this.btnEducacion);
            this.Controls.Add(this.btnEscuadrones);
            this.Controls.Add(this.btnPersonal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Button btnEscuadrones;
        private System.Windows.Forms.Button btnEducacion;
        private System.Windows.Forms.Button btnMote;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAdministrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCursillos;
        private System.Windows.Forms.Button btnExamenes;
    }
}