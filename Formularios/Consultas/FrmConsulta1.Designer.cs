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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta1));
            this.rcTan1DataSet2 = new CRUD_RCTAN1.RcTan1DataSet2();
            this.sp_listar_personal_datosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_listar_personal_datosTableAdapter = new CRUD_RCTAN1.RcTan1DataSet2TableAdapters.sp_listar_personal_datosTableAdapter();
            this.tableAdapterManager = new CRUD_RCTAN1.RcTan1DataSet2TableAdapters.TableAdapterManager();
            this.sp_listar_personal_datosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sp_listar_personal_datosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sp_listar_personal_datosDataGridView = new System.Windows.Forms.DataGridView();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rcTan1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_listar_personal_datosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_listar_personal_datosBindingNavigator)).BeginInit();
            this.sp_listar_personal_datosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_listar_personal_datosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // rcTan1DataSet2
            // 
            this.rcTan1DataSet2.DataSetName = "RcTan1DataSet2";
            this.rcTan1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_listar_personal_datosBindingSource
            // 
            this.sp_listar_personal_datosBindingSource.DataMember = "sp_listar_personal_datos";
            this.sp_listar_personal_datosBindingSource.DataSource = this.rcTan1DataSet2;
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
            // sp_listar_personal_datosBindingNavigator
            // 
            this.sp_listar_personal_datosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sp_listar_personal_datosBindingNavigator.BindingSource = this.sp_listar_personal_datosBindingSource;
            this.sp_listar_personal_datosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sp_listar_personal_datosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sp_listar_personal_datosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.sp_listar_personal_datosBindingNavigatorSaveItem,
            this.toolStripButton1,
            this.toolStripButton2});
            this.sp_listar_personal_datosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sp_listar_personal_datosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sp_listar_personal_datosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sp_listar_personal_datosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sp_listar_personal_datosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sp_listar_personal_datosBindingNavigator.Name = "sp_listar_personal_datosBindingNavigator";
            this.sp_listar_personal_datosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sp_listar_personal_datosBindingNavigator.Size = new System.Drawing.Size(900, 25);
            this.sp_listar_personal_datosBindingNavigator.TabIndex = 0;
            this.sp_listar_personal_datosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // sp_listar_personal_datosBindingNavigatorSaveItem
            // 
            this.sp_listar_personal_datosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sp_listar_personal_datosBindingNavigatorSaveItem.Enabled = false;
            this.sp_listar_personal_datosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sp_listar_personal_datosBindingNavigatorSaveItem.Image")));
            this.sp_listar_personal_datosBindingNavigatorSaveItem.Name = "sp_listar_personal_datosBindingNavigatorSaveItem";
            this.sp_listar_personal_datosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sp_listar_personal_datosBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // sp_listar_personal_datosDataGridView
            // 
            this.sp_listar_personal_datosDataGridView.AllowUserToAddRows = false;
            this.sp_listar_personal_datosDataGridView.AllowUserToDeleteRows = false;
            this.sp_listar_personal_datosDataGridView.AutoGenerateColumns = false;
            this.sp_listar_personal_datosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sp_listar_personal_datosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.sp_listar_personal_datosDataGridView.DataSource = this.sp_listar_personal_datosBindingSource;
            this.sp_listar_personal_datosDataGridView.Location = new System.Drawing.Point(33, 93);
            this.sp_listar_personal_datosDataGridView.Name = "sp_listar_personal_datosDataGridView";
            this.sp_listar_personal_datosDataGridView.ReadOnly = true;
            this.sp_listar_personal_datosDataGridView.Size = new System.Drawing.Size(843, 320);
            this.sp_listar_personal_datosDataGridView.TabIndex = 1;
            this.sp_listar_personal_datosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sp_listar_personal_datosDataGridView_CellContentClick);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "LISTADO DE PERSONAL";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "dni";
            this.dataGridViewTextBoxColumn1.FillWeight = 50F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Dni";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "apellido";
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "grado";
            this.dataGridViewTextBoxColumn4.HeaderText = "Grado";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "rol_combate";
            this.dataGridViewTextBoxColumn5.HeaderText = "Rol de Combate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 140;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "rol_administrativo";
            this.dataGridViewTextBoxColumn6.FillWeight = 120F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Rol Administrativo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 140;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "arma";
            this.dataGridViewTextBoxColumn7.HeaderText = "Arma";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "seccion";
            this.dataGridViewTextBoxColumn8.HeaderText = "Sección";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.ToolTipText = "Sección";
            // 
            // FrmConsulta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CRUD_RCTAN1.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(900, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sp_listar_personal_datosDataGridView);
            this.Controls.Add(this.sp_listar_personal_datosBindingNavigator);
            this.Name = "FrmConsulta1";
            this.Text = "Listado de Personal";
            this.Load += new System.EventHandler(this.FrmConsulta1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rcTan1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_listar_personal_datosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_listar_personal_datosBindingNavigator)).EndInit();
            this.sp_listar_personal_datosBindingNavigator.ResumeLayout(false);
            this.sp_listar_personal_datosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_listar_personal_datosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RcTan1DataSet2 rcTan1DataSet2;
        private System.Windows.Forms.BindingSource sp_listar_personal_datosBindingSource;
        private RcTan1DataSet2TableAdapters.sp_listar_personal_datosTableAdapter sp_listar_personal_datosTableAdapter;
        private RcTan1DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sp_listar_personal_datosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton sp_listar_personal_datosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView sp_listar_personal_datosDataGridView;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}