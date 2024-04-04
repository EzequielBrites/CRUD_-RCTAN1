namespace CRUD_RCTAN1
{
    partial class FrmCargaPersonal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargaPersonal));
            this.cboEstadosCiviles = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mspCargaPersonal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirAltf4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txbDni = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblRolAdministrativo = new System.Windows.Forms.Label();
            this.lblRolDeCombate = new System.Windows.Forms.Label();
            this.lblSubUnidad = new System.Windows.Forms.Label();
            this.lblGrado = new System.Windows.Forms.Label();
            this.LblSexo = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cboCiudades = new System.Windows.Forms.ComboBox();
            this.cboProvincias = new System.Windows.Forms.ComboBox();
            this.cboSubUnidad = new System.Windows.Forms.ComboBox();
            this.cboTipos = new System.Windows.Forms.ComboBox();
            this.cboGrados = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.cboSecciones = new System.Windows.Forms.ComboBox();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.cboArmas = new System.Windows.Forms.ComboBox();
            this.lblArma = new System.Windows.Forms.Label();
            this.txtRolAdmin = new System.Windows.Forms.TextBox();
            this.txtRolComb = new System.Windows.Forms.TextBox();
            this.mspCargaPersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboEstadosCiviles
            // 
            this.cboEstadosCiviles.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboEstadosCiviles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadosCiviles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstadosCiviles.FormattingEnabled = true;
            this.cboEstadosCiviles.Location = new System.Drawing.Point(219, 501);
            this.cboEstadosCiviles.Name = "cboEstadosCiviles";
            this.cboEstadosCiviles.Size = new System.Drawing.Size(200, 24);
            this.cboEstadosCiviles.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(140, 147);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.White;
            this.lblApellido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(139, 206);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(59, 18);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 713);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1135, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mspCargaPersonal
            // 
            this.mspCargaPersonal.BackColor = System.Drawing.SystemColors.Control;
            this.mspCargaPersonal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.verToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.mspCargaPersonal.Location = new System.Drawing.Point(0, 0);
            this.mspCargaPersonal.Name = "mspCargaPersonal";
            this.mspCargaPersonal.Size = new System.Drawing.Size(1135, 24);
            this.mspCargaPersonal.TabIndex = 7;
            this.mspCargaPersonal.Text = "mspCargaPersonal";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirAltf4ToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirAltf4ToolStripMenuItem
            // 
            this.salirAltf4ToolStripMenuItem.Name = "salirAltf4ToolStripMenuItem";
            this.salirAltf4ToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.salirAltf4ToolStripMenuItem.Text = "Salir                   Alt+f4";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // txbNombre
            // 
            this.txbNombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre.Location = new System.Drawing.Point(219, 147);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(147, 22);
            this.txbNombre.TabIndex = 1;
            // 
            // txbApellido
            // 
            this.txbApellido.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbApellido.Location = new System.Drawing.Point(219, 206);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(147, 22);
            this.txbApellido.TabIndex = 2;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.White;
            this.lblDni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(166, 88);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(32, 18);
            this.lblDni.TabIndex = 10;
            this.lblDni.Text = "DNI";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.White;
            this.lblDireccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(132, 265);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(66, 18);
            this.lblDireccion.TabIndex = 11;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.White;
            this.lblTelefono.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(135, 324);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(63, 18);
            this.lblTelefono.TabIndex = 12;
            this.lblTelefono.Text = "Telefono";
            // 
            // txbDni
            // 
            this.txbDni.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDni.Location = new System.Drawing.Point(219, 88);
            this.txbDni.Name = "txbDni";
            this.txbDni.Size = new System.Drawing.Size(147, 22);
            this.txbDni.TabIndex = 0;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.BackColor = System.Drawing.Color.White;
            this.lblFechaNacimiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(64, 383);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(134, 18);
            this.lblFechaNacimiento.TabIndex = 14;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // lblRolAdministrativo
            // 
            this.lblRolAdministrativo.AutoSize = true;
            this.lblRolAdministrativo.BackColor = System.Drawing.Color.White;
            this.lblRolAdministrativo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRolAdministrativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolAdministrativo.Location = new System.Drawing.Point(505, 163);
            this.lblRolAdministrativo.Name = "lblRolAdministrativo";
            this.lblRolAdministrativo.Size = new System.Drawing.Size(117, 18);
            this.lblRolAdministrativo.TabIndex = 15;
            this.lblRolAdministrativo.Text = "Rol Administrativo";
            // 
            // lblRolDeCombate
            // 
            this.lblRolDeCombate.AutoSize = true;
            this.lblRolDeCombate.BackColor = System.Drawing.Color.White;
            this.lblRolDeCombate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRolDeCombate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolDeCombate.Location = new System.Drawing.Point(517, 295);
            this.lblRolDeCombate.Name = "lblRolDeCombate";
            this.lblRolDeCombate.Size = new System.Drawing.Size(105, 18);
            this.lblRolDeCombate.TabIndex = 16;
            this.lblRolDeCombate.Text = "Rol de combate";
            // 
            // lblSubUnidad
            // 
            this.lblSubUnidad.AutoSize = true;
            this.lblSubUnidad.BackColor = System.Drawing.Color.White;
            this.lblSubUnidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubUnidad.Location = new System.Drawing.Point(542, 229);
            this.lblSubUnidad.Name = "lblSubUnidad";
            this.lblSubUnidad.Size = new System.Drawing.Size(80, 18);
            this.lblSubUnidad.TabIndex = 17;
            this.lblSubUnidad.Text = "Sub Unidad";
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.BackColor = System.Drawing.Color.White;
            this.lblGrado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrado.Location = new System.Drawing.Point(575, 97);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(47, 18);
            this.lblGrado.TabIndex = 18;
            this.lblGrado.Text = "Grado";
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.BackColor = System.Drawing.Color.White;
            this.LblSexo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSexo.Location = new System.Drawing.Point(158, 442);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(40, 18);
            this.LblSexo.TabIndex = 19;
            this.LblSexo.Text = "Sexo";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.BackColor = System.Drawing.Color.White;
            this.lblEstadoCivil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCivil.Location = new System.Drawing.Point(121, 501);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(77, 18);
            this.lblEstadoCivil.TabIndex = 20;
            this.lblEstadoCivil.Text = "EstadoCivil";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.BackColor = System.Drawing.Color.White;
            this.lblProvincia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(133, 560);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(65, 18);
            this.lblProvincia.TabIndex = 21;
            this.lblProvincia.Text = "Provincia";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.BackColor = System.Drawing.Color.White;
            this.lblCiudad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(146, 619);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(52, 18);
            this.lblCiudad.TabIndex = 22;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txbDireccion
            // 
            this.txbDireccion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDireccion.Location = new System.Drawing.Point(219, 265);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(200, 22);
            this.txbDireccion.TabIndex = 3;
            // 
            // txbTelefono
            // 
            this.txbTelefono.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTelefono.Location = new System.Drawing.Point(219, 324);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(200, 22);
            this.txbTelefono.TabIndex = 4;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(219, 383);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(273, 22);
            this.dtpFechaNacimiento.TabIndex = 5;
            // 
            // cboCiudades
            // 
            this.cboCiudades.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboCiudades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCiudades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCiudades.FormattingEnabled = true;
            this.cboCiudades.Location = new System.Drawing.Point(219, 619);
            this.cboCiudades.Name = "cboCiudades";
            this.cboCiudades.Size = new System.Drawing.Size(273, 24);
            this.cboCiudades.TabIndex = 10;
            // 
            // cboProvincias
            // 
            this.cboProvincias.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProvincias.FormattingEnabled = true;
            this.cboProvincias.Location = new System.Drawing.Point(219, 560);
            this.cboProvincias.Name = "cboProvincias";
            this.cboProvincias.Size = new System.Drawing.Size(273, 24);
            this.cboProvincias.TabIndex = 9;
            this.cboProvincias.SelectedIndexChanged += new System.EventHandler(this.cboProvincias_SelectedIndexChanged);
            // 
            // cboSubUnidad
            // 
            this.cboSubUnidad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboSubUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSubUnidad.FormattingEnabled = true;
            this.cboSubUnidad.Location = new System.Drawing.Point(642, 229);
            this.cboSubUnidad.Name = "cboSubUnidad";
            this.cboSubUnidad.Size = new System.Drawing.Size(204, 24);
            this.cboSubUnidad.TabIndex = 14;
            // 
            // cboTipos
            // 
            this.cboTipos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipos.FormattingEnabled = true;
            this.cboTipos.Location = new System.Drawing.Point(642, 97);
            this.cboTipos.Name = "cboTipos";
            this.cboTipos.Size = new System.Drawing.Size(153, 24);
            this.cboTipos.TabIndex = 11;
            this.cboTipos.SelectedIndexChanged += new System.EventHandler(this.cboTipos_SelectedIndexChanged);
            // 
            // cboGrados
            // 
            this.cboGrados.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboGrados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGrados.FormattingEnabled = true;
            this.cboGrados.Location = new System.Drawing.Point(813, 97);
            this.cboGrados.Name = "cboGrados";
            this.cboGrados.Size = new System.Drawing.Size(269, 24);
            this.cboGrados.TabIndex = 12;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(747, 660);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(81, 33);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(841, 660);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 33);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1019, 660);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 33);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(929, 660);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(81, 33);
            this.btnEditar.TabIndex = 20;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.BackColor = System.Drawing.SystemColors.Window;
            this.rbMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasculino.Location = new System.Drawing.Point(219, 442);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(86, 20);
            this.rbMasculino.TabIndex = 6;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = false;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.BackColor = System.Drawing.SystemColors.Window;
            this.rbFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemenino.Location = new System.Drawing.Point(334, 442);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(85, 20);
            this.rbFemenino.TabIndex = 7;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = false;
            // 
            // cboSecciones
            // 
            this.cboSecciones.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboSecciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSecciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSecciones.FormattingEnabled = true;
            this.cboSecciones.Location = new System.Drawing.Point(642, 359);
            this.cboSecciones.Name = "cboSecciones";
            this.cboSecciones.Size = new System.Drawing.Size(204, 24);
            this.cboSecciones.TabIndex = 16;
            // 
            // lblSeccion
            // 
            this.lblSeccion.AutoSize = true;
            this.lblSeccion.BackColor = System.Drawing.Color.White;
            this.lblSeccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccion.Location = new System.Drawing.Point(566, 361);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(58, 18);
            this.lblSeccion.TabIndex = 39;
            this.lblSeccion.Text = "Seccion";
            // 
            // cboArmas
            // 
            this.cboArmas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboArmas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboArmas.FormattingEnabled = true;
            this.cboArmas.Location = new System.Drawing.Point(642, 427);
            this.cboArmas.Name = "cboArmas";
            this.cboArmas.Size = new System.Drawing.Size(204, 24);
            this.cboArmas.TabIndex = 17;
            // 
            // lblArma
            // 
            this.lblArma.AutoSize = true;
            this.lblArma.BackColor = System.Drawing.Color.White;
            this.lblArma.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblArma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArma.Location = new System.Drawing.Point(583, 427);
            this.lblArma.Name = "lblArma";
            this.lblArma.Size = new System.Drawing.Size(41, 18);
            this.lblArma.TabIndex = 41;
            this.lblArma.Text = "Arma";
            // 
            // txtRolAdmin
            // 
            this.txtRolAdmin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRolAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRolAdmin.Location = new System.Drawing.Point(642, 163);
            this.txtRolAdmin.Name = "txtRolAdmin";
            this.txtRolAdmin.Size = new System.Drawing.Size(368, 22);
            this.txtRolAdmin.TabIndex = 13;
            // 
            // txtRolComb
            // 
            this.txtRolComb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRolComb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRolComb.Location = new System.Drawing.Point(642, 295);
            this.txtRolComb.Name = "txtRolComb";
            this.txtRolComb.Size = new System.Drawing.Size(440, 22);
            this.txtRolComb.TabIndex = 15;
            // 
            // FrmCargaPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1135, 735);
            this.Controls.Add(this.txtRolComb);
            this.Controls.Add(this.txtRolAdmin);
            this.Controls.Add(this.cboArmas);
            this.Controls.Add(this.lblArma);
            this.Controls.Add(this.cboSecciones);
            this.Controls.Add(this.lblSeccion);
            this.Controls.Add(this.rbFemenino);
            this.Controls.Add(this.rbMasculino);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cboGrados);
            this.Controls.Add(this.cboTipos);
            this.Controls.Add(this.cboSubUnidad);
            this.Controls.Add(this.cboProvincias);
            this.Controls.Add(this.cboCiudades);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txbTelefono);
            this.Controls.Add(this.txbDireccion);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.lblEstadoCivil);
            this.Controls.Add(this.LblSexo);
            this.Controls.Add(this.lblGrado);
            this.Controls.Add(this.lblSubUnidad);
            this.Controls.Add(this.lblRolDeCombate);
            this.Controls.Add(this.lblRolAdministrativo);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.txbDni);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txbApellido);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mspCargaPersonal);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cboEstadosCiviles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCargaPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de personal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mspCargaPersonal.ResumeLayout(false);
            this.mspCargaPersonal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEstadosCiviles;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip mspCargaPersonal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txbDni;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblRolAdministrativo;
        private System.Windows.Forms.Label lblRolDeCombate;
        private System.Windows.Forms.Label lblSubUnidad;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.ComboBox cboCiudades;
        private System.Windows.Forms.ComboBox cboProvincias;
        private System.Windows.Forms.ComboBox cboSubUnidad;
        private System.Windows.Forms.ComboBox cboTipos;
        private System.Windows.Forms.ComboBox cboGrados;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem salirAltf4ToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.ComboBox cboSecciones;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.ComboBox cboArmas;
        private System.Windows.Forms.Label lblArma;
        private System.Windows.Forms.TextBox txtRolAdmin;
        private System.Windows.Forms.TextBox txtRolComb;
    }
}

