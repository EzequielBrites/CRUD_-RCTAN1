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
            this.btnSubUnidades = new System.Windows.Forms.Button();
            this.btnEducacion = new System.Windows.Forms.Button();
            this.btnMote = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnAdministrar = new System.Windows.Forms.Button();
            this.btnCursillos = new System.Windows.Forms.Button();
            this.btnExamenes = new System.Windows.Forms.Button();
            this.cboConsultas = new System.Windows.Forms.ComboBox();
            this.btnCargarListado = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblConsultas = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRcTan1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.btnPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonal.Location = new System.Drawing.Point(186, 108);
            this.btnPersonal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(412, 58);
            this.btnPersonal.TabIndex = 1;
            this.btnPersonal.Text = "Personal";
            this.btnPersonal.UseVisualStyleBackColor = true;
            this.btnPersonal.Click += new System.EventHandler(this.btnCargaPersonal_Click);
            // 
            // btnSubUnidades
            // 
            this.btnSubUnidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubUnidades.Location = new System.Drawing.Point(186, 208);
            this.btnSubUnidades.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubUnidades.Name = "btnSubUnidades";
            this.btnSubUnidades.Size = new System.Drawing.Size(412, 58);
            this.btnSubUnidades.TabIndex = 2;
            this.btnSubUnidades.Text = "SubUnidades";
            this.btnSubUnidades.UseVisualStyleBackColor = true;
            this.btnSubUnidades.Click += new System.EventHandler(this.btnSubUnidades_Click);
            // 
            // btnEducacion
            // 
            this.btnEducacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEducacion.Location = new System.Drawing.Point(186, 305);
            this.btnEducacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEducacion.Name = "btnEducacion";
            this.btnEducacion.Size = new System.Drawing.Size(412, 58);
            this.btnEducacion.TabIndex = 3;
            this.btnEducacion.Text = "Educación";
            this.btnEducacion.UseVisualStyleBackColor = true;
            this.btnEducacion.Click += new System.EventHandler(this.btnEducacion_Click);
            // 
            // btnMote
            // 
            this.btnMote.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMote.Location = new System.Drawing.Point(186, 396);
            this.btnMote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMote.Name = "btnMote";
            this.btnMote.Size = new System.Drawing.Size(412, 58);
            this.btnMote.TabIndex = 4;
            this.btnMote.Text = "Mote";
            this.btnMote.UseVisualStyleBackColor = true;
            this.btnMote.Click += new System.EventHandler(this.btnMote_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtras.Location = new System.Drawing.Point(19, 23);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(1);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(59, 78);
            this.btnAtras.TabIndex = 5;
            this.btnAtras.Text = "↰";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnAdministrar
            // 
            this.btnAdministrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrar.Location = new System.Drawing.Point(186, 108);
            this.btnAdministrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdministrar.Name = "btnAdministrar";
            this.btnAdministrar.Size = new System.Drawing.Size(412, 58);
            this.btnAdministrar.TabIndex = 6;
            this.btnAdministrar.Text = "Administrar";
            this.btnAdministrar.UseVisualStyleBackColor = true;
            this.btnAdministrar.Click += new System.EventHandler(this.btnAdministrar_Click);
            // 
            // btnCursillos
            // 
            this.btnCursillos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursillos.Location = new System.Drawing.Point(186, 108);
            this.btnCursillos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCursillos.Name = "btnCursillos";
            this.btnCursillos.Size = new System.Drawing.Size(412, 58);
            this.btnCursillos.TabIndex = 8;
            this.btnCursillos.Text = "Cursillos";
            this.btnCursillos.UseVisualStyleBackColor = true;
            // 
            // btnExamenes
            // 
            this.btnExamenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExamenes.Location = new System.Drawing.Point(186, 208);
            this.btnExamenes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExamenes.Name = "btnExamenes";
            this.btnExamenes.Size = new System.Drawing.Size(412, 58);
            this.btnExamenes.TabIndex = 9;
            this.btnExamenes.Text = "Exámenes";
            this.btnExamenes.UseVisualStyleBackColor = true;
            // 
            // cboConsultas
            // 
            this.cboConsultas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboConsultas.FormattingEnabled = true;
            this.cboConsultas.Items.AddRange(new object[] {
            "Listado de personal",
            "Listado de personal por rol de combate",
            "Listado de personal por rol administrativo",
            "Listado de SubOficiales (subalternos)",
            "Listado de SubOficiales (superiores)",
            "Listado de Oficiales",
            "Listado de Soldados Voluntarios"});
            this.cboConsultas.Location = new System.Drawing.Point(186, 305);
            this.cboConsultas.Name = "cboConsultas";
            this.cboConsultas.Size = new System.Drawing.Size(412, 33);
            this.cboConsultas.TabIndex = 10;
            this.cboConsultas.SelectedIndexChanged += new System.EventHandler(this.cboConsultas_SelectedIndexChanged);
            // 
            // btnCargarListado
            // 
            this.btnCargarListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarListado.Location = new System.Drawing.Point(472, 413);
            this.btnCargarListado.Name = "btnCargarListado";
            this.btnCargarListado.Size = new System.Drawing.Size(126, 41);
            this.btnCargarListado.TabIndex = 11;
            this.btnCargarListado.Text = "Mostrar";
            this.btnCargarListado.UseVisualStyleBackColor = true;
            this.btnCargarListado.Click += new System.EventHandler(this.btnCargarListado_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(627, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblConsultas
            // 
            this.lblConsultas.AutoSize = true;
            this.lblConsultas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultas.Location = new System.Drawing.Point(323, 222);
            this.lblConsultas.Name = "lblConsultas";
            this.lblConsultas.Size = new System.Drawing.Size(136, 31);
            this.lblConsultas.TabIndex = 13;
            this.lblConsultas.Text = "Consultas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::CRUD_RCTAN1.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(232, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 77);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lblRcTan1
            // 
            this.lblRcTan1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRcTan1.AutoSize = true;
            this.lblRcTan1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRcTan1.Image = global::CRUD_RCTAN1.Properties.Resources.fondoliso2;
            this.lblRcTan1.Location = new System.Drawing.Point(296, 23);
            this.lblRcTan1.Name = "lblRcTan1";
            this.lblRcTan1.Size = new System.Drawing.Size(194, 55);
            this.lblRcTan1.TabIndex = 15;
            this.lblRcTan1.Text = "Rc Tan 1";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::CRUD_RCTAN1.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(792, 585);
            this.Controls.Add(this.lblRcTan1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblConsultas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCargarListado);
            this.Controls.Add(this.cboConsultas);
            this.Controls.Add(this.btnExamenes);
            this.Controls.Add(this.btnCursillos);
            this.Controls.Add(this.btnAdministrar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnMote);
            this.Controls.Add(this.btnEducacion);
            this.Controls.Add(this.btnSubUnidades);
            this.Controls.Add(this.btnPersonal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Button btnSubUnidades;
        private System.Windows.Forms.Button btnEducacion;
        private System.Windows.Forms.Button btnMote;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAdministrar;
        private System.Windows.Forms.Button btnCursillos;
        private System.Windows.Forms.Button btnExamenes;
        private System.Windows.Forms.ComboBox cboConsultas;
        private System.Windows.Forms.Button btnCargarListado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblConsultas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRcTan1;
    }
}