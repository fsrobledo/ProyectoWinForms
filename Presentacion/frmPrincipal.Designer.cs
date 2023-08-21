namespace Presentacion
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.csmBotonDerecho = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmBotonDerechoModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBotonDerechoEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBotonDerechoDetalles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBotonDerechoSeleccionar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.mstMenu = new System.Windows.Forms.MenuStrip();
            this.tsmArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNuevoArtículo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSeleccionar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDetalles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManualDeAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmContacto = new System.Windows.Forms.ToolStripMenuItem();
            this.stpEstado = new System.Windows.Forms.StatusStrip();
            this.tslEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.cbxFiltroMarca = new System.Windows.Forms.ComboBox();
            this.lblFiltroMarca = new System.Windows.Forms.Label();
            this.lblFiltroCategoria = new System.Windows.Forms.Label();
            this.cbxFiltroCategoria = new System.Windows.Forms.ComboBox();
            this.btnFiltros = new System.Windows.Forms.Button();
            this.btnResetear = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.csmBotonDerecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.mstMenu.SuspendLayout();
            this.stpEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.ContextMenuStrip = this.csmBotonDerecho;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(32, 64);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(651, 299);
            this.dgvArticulos.TabIndex = 6;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            this.dgvArticulos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvArticulos_MouseClick);
            // 
            // csmBotonDerecho
            // 
            this.csmBotonDerecho.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBotonDerechoModificar,
            this.tsmBotonDerechoEliminar,
            this.tsmBotonDerechoDetalles,
            this.tsmBotonDerechoSeleccionar});
            this.csmBotonDerecho.Name = "csmBotonDerecho";
            this.csmBotonDerecho.Size = new System.Drawing.Size(164, 92);
            this.csmBotonDerecho.Opening += new System.ComponentModel.CancelEventHandler(this.csmBotonDerecho_Opening);
            // 
            // tsmBotonDerechoModificar
            // 
            this.tsmBotonDerechoModificar.Name = "tsmBotonDerechoModificar";
            this.tsmBotonDerechoModificar.Size = new System.Drawing.Size(163, 22);
            this.tsmBotonDerechoModificar.Text = "Modificar";
            this.tsmBotonDerechoModificar.Click += new System.EventHandler(this.tsmBotonDerechoModificar_Click);
            // 
            // tsmBotonDerechoEliminar
            // 
            this.tsmBotonDerechoEliminar.Name = "tsmBotonDerechoEliminar";
            this.tsmBotonDerechoEliminar.Size = new System.Drawing.Size(163, 22);
            this.tsmBotonDerechoEliminar.Text = "Eliminar";
            this.tsmBotonDerechoEliminar.Click += new System.EventHandler(this.tsmBotonDerechoEliminar_Click);
            // 
            // tsmBotonDerechoDetalles
            // 
            this.tsmBotonDerechoDetalles.Name = "tsmBotonDerechoDetalles";
            this.tsmBotonDerechoDetalles.Size = new System.Drawing.Size(163, 22);
            this.tsmBotonDerechoDetalles.Text = "Ver Detalles";
            this.tsmBotonDerechoDetalles.Click += new System.EventHandler(this.tsmBotonDerechoDetalles_Click);
            // 
            // tsmBotonDerechoSeleccionar
            // 
            this.tsmBotonDerechoSeleccionar.Name = "tsmBotonDerechoSeleccionar";
            this.tsmBotonDerechoSeleccionar.Size = new System.Drawing.Size(163, 22);
            this.tsmBotonDerechoSeleccionar.Text = "Seleccionar Todo";
            this.tsmBotonDerechoSeleccionar.Click += new System.EventHandler(this.tsmBotonDerechoSeleccionar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.Location = new System.Drawing.Point(32, 383);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.Location = new System.Drawing.Point(122, 383);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(74, 23);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.Location = new System.Drawing.Point(213, 383);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pbxImagen
            // 
            this.pbxImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxImagen.Location = new System.Drawing.Point(710, 64);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(313, 299);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagen.TabIndex = 4;
            this.pbxImagen.TabStop = false;
            // 
            // mstMenu
            // 
            this.mstMenu.BackColor = System.Drawing.Color.Snow;
            this.mstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmArchivo,
            this.tsmVer,
            this.tsmAyuda});
            this.mstMenu.Location = new System.Drawing.Point(0, 0);
            this.mstMenu.Name = "mstMenu";
            this.mstMenu.Size = new System.Drawing.Size(1056, 24);
            this.mstMenu.TabIndex = 0;
            this.mstMenu.Text = "menuStrip1";
            // 
            // tsmArchivo
            // 
            this.tsmArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNuevoArtículo,
            this.tsmModificar,
            this.tsmEliminar,
            this.tsmSalir});
            this.tsmArchivo.Name = "tsmArchivo";
            this.tsmArchivo.Size = new System.Drawing.Size(60, 20);
            this.tsmArchivo.Text = "&Archivo";
            // 
            // tsmNuevoArtículo
            // 
            this.tsmNuevoArtículo.Name = "tsmNuevoArtículo";
            this.tsmNuevoArtículo.Size = new System.Drawing.Size(125, 22);
            this.tsmNuevoArtículo.Text = "Nuevo";
            this.tsmNuevoArtículo.Click += new System.EventHandler(this.tsmNuevoArticulo_Click);
            // 
            // tsmModificar
            // 
            this.tsmModificar.Name = "tsmModificar";
            this.tsmModificar.Size = new System.Drawing.Size(125, 22);
            this.tsmModificar.Text = "Modificar";
            this.tsmModificar.Click += new System.EventHandler(this.tsmModificar_Click);
            // 
            // tsmEliminar
            // 
            this.tsmEliminar.Name = "tsmEliminar";
            this.tsmEliminar.Size = new System.Drawing.Size(125, 22);
            this.tsmEliminar.Text = "Eliminar";
            this.tsmEliminar.Click += new System.EventHandler(this.tsmEliminar_Click);
            // 
            // tsmSalir
            // 
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(125, 22);
            this.tsmSalir.Text = "Salir";
            this.tsmSalir.Click += new System.EventHandler(this.tsmSalir_Click);
            // 
            // tsmVer
            // 
            this.tsmVer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSeleccionar,
            this.tsmDetalles});
            this.tsmVer.Name = "tsmVer";
            this.tsmVer.Size = new System.Drawing.Size(35, 20);
            this.tsmVer.Text = "&Ver";
            // 
            // tsmSeleccionar
            // 
            this.tsmSeleccionar.Name = "tsmSeleccionar";
            this.tsmSeleccionar.Size = new System.Drawing.Size(163, 22);
            this.tsmSeleccionar.Text = "Seleccionar Todo";
            this.tsmSeleccionar.Click += new System.EventHandler(this.tsmSeleccionar_Click);
            // 
            // tsmDetalles
            // 
            this.tsmDetalles.Name = "tsmDetalles";
            this.tsmDetalles.Size = new System.Drawing.Size(163, 22);
            this.tsmDetalles.Text = "Detalles";
            this.tsmDetalles.Click += new System.EventHandler(this.tsmDetalles_Click);
            // 
            // tsmAyuda
            // 
            this.tsmAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmManualDeAyuda,
            this.tsmContacto});
            this.tsmAyuda.Name = "tsmAyuda";
            this.tsmAyuda.Size = new System.Drawing.Size(53, 20);
            this.tsmAyuda.Text = "A&yuda";
            // 
            // tsmManualDeAyuda
            // 
            this.tsmManualDeAyuda.Name = "tsmManualDeAyuda";
            this.tsmManualDeAyuda.Size = new System.Drawing.Size(165, 22);
            this.tsmManualDeAyuda.Text = "Manual de ayuda";
            this.tsmManualDeAyuda.Click += new System.EventHandler(this.tsmManualDeAyuda_Click);
            // 
            // tsmContacto
            // 
            this.tsmContacto.Name = "tsmContacto";
            this.tsmContacto.Size = new System.Drawing.Size(165, 22);
            this.tsmContacto.Text = "Contacto";
            this.tsmContacto.Click += new System.EventHandler(this.tsmContacto_Click);
            // 
            // stpEstado
            // 
            this.stpEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslEstado});
            this.stpEstado.Location = new System.Drawing.Point(0, 436);
            this.stpEstado.Name = "stpEstado";
            this.stpEstado.Size = new System.Drawing.Size(1056, 22);
            this.stpEstado.TabIndex = 7;
            // 
            // tslEstado
            // 
            this.tslEstado.Name = "tslEstado";
            this.tslEstado.Size = new System.Drawing.Size(0, 17);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(78, 38);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(135, 20);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(29, 41);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(43, 13);
            this.lblBuscar.TabIndex = 9;
            this.lblBuscar.Text = "Buscar:";
            // 
            // cbxFiltroMarca
            // 
            this.cbxFiltroMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltroMarca.Location = new System.Drawing.Point(320, 37);
            this.cbxFiltroMarca.Name = "cbxFiltroMarca";
            this.cbxFiltroMarca.Size = new System.Drawing.Size(121, 21);
            this.cbxFiltroMarca.TabIndex = 2;
            // 
            // lblFiltroMarca
            // 
            this.lblFiltroMarca.AutoSize = true;
            this.lblFiltroMarca.Location = new System.Drawing.Point(228, 41);
            this.lblFiltroMarca.Name = "lblFiltroMarca";
            this.lblFiltroMarca.Size = new System.Drawing.Size(86, 13);
            this.lblFiltroMarca.TabIndex = 11;
            this.lblFiltroMarca.Text = "Filtrar por Marca:";
            // 
            // lblFiltroCategoria
            // 
            this.lblFiltroCategoria.AutoSize = true;
            this.lblFiltroCategoria.Location = new System.Drawing.Point(453, 41);
            this.lblFiltroCategoria.Name = "lblFiltroCategoria";
            this.lblFiltroCategoria.Size = new System.Drawing.Size(103, 13);
            this.lblFiltroCategoria.TabIndex = 13;
            this.lblFiltroCategoria.Text = "Filtrar por Categoría:";
            // 
            // cbxFiltroCategoria
            // 
            this.cbxFiltroCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltroCategoria.FormattingEnabled = true;
            this.cbxFiltroCategoria.Location = new System.Drawing.Point(562, 37);
            this.cbxFiltroCategoria.Name = "cbxFiltroCategoria";
            this.cbxFiltroCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbxFiltroCategoria.TabIndex = 3;
            // 
            // btnFiltros
            // 
            this.btnFiltros.Location = new System.Drawing.Point(710, 36);
            this.btnFiltros.Name = "btnFiltros";
            this.btnFiltros.Size = new System.Drawing.Size(97, 23);
            this.btnFiltros.TabIndex = 4;
            this.btnFiltros.Text = "Aplicar Filtros";
            this.btnFiltros.UseVisualStyleBackColor = true;
            this.btnFiltros.Click += new System.EventHandler(this.btnFiltros_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.Location = new System.Drawing.Point(822, 35);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(108, 23);
            this.btnResetear.TabIndex = 5;
            this.btnResetear.Text = "Reiniciar Búsqueda";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1056, 458);
            this.Controls.Add(this.btnResetear);
            this.Controls.Add(this.btnFiltros);
            this.Controls.Add(this.lblFiltroCategoria);
            this.Controls.Add(this.cbxFiltroCategoria);
            this.Controls.Add(this.lblFiltroMarca);
            this.Controls.Add(this.cbxFiltroMarca);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.stpEstado);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.mstMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mstMenu;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo de Artículos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.csmBotonDerecho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.mstMenu.ResumeLayout(false);
            this.mstMenu.PerformLayout();
            this.stpEstado.ResumeLayout(false);
            this.stpEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.MenuStrip mstMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsmNuevoArtículo;
        private System.Windows.Forms.ToolStripMenuItem tsmModificar;
        private System.Windows.Forms.StatusStrip stpEstado;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminar;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
        private System.Windows.Forms.ToolStripMenuItem tsmVer;
        private System.Windows.Forms.ToolStripMenuItem tsmSeleccionar;
        private System.Windows.Forms.ToolStripMenuItem tsmDetalles;
        private System.Windows.Forms.ToolStripMenuItem tsmAyuda;
        private System.Windows.Forms.ToolStripMenuItem tsmManualDeAyuda;
        private System.Windows.Forms.ToolStripMenuItem tsmContacto;
        private System.Windows.Forms.ToolStripStatusLabel tslEstado;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ComboBox cbxFiltroMarca;
        private System.Windows.Forms.Label lblFiltroMarca;
        private System.Windows.Forms.Label lblFiltroCategoria;
        private System.Windows.Forms.ComboBox cbxFiltroCategoria;
        private System.Windows.Forms.Button btnFiltros;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.ContextMenuStrip csmBotonDerecho;
        private System.Windows.Forms.ToolStripMenuItem tsmBotonDerechoModificar;
        private System.Windows.Forms.ToolStripMenuItem tsmBotonDerechoEliminar;
        private System.Windows.Forms.ToolStripMenuItem tsmBotonDerechoDetalles;
        private System.Windows.Forms.ToolStripMenuItem tsmBotonDerechoSeleccionar;
    }
}

