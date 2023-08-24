namespace FacturacionPE.Formularios
{
    partial class FrmClienteGestion
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
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.CboxTipoCliente = new System.Windows.Forms.ComboBox();
            this.TxTTipoCliente = new System.Windows.Forms.Label();
            this.TxTEmailCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxTCodigoCliente = new System.Windows.Forms.TextBox();
            this.TxtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxTNombreCliente = new System.Windows.Forms.TextBox();
            this.TxTCedulaCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxTBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLimpiarForm = new System.Windows.Forms.Button();
            this.GbDetalles = new System.Windows.Forms.GroupBox();
            this.DgvListaClientes = new System.Windows.Forms.DataGridView();
            this.CIDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CbVerActivos = new System.Windows.Forms.CheckBox();
            this.TmrBuscar = new System.Windows.Forms.Timer(this.components);
            this.GbDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.SaddleBrown;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(947, 480);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(114, 48);
            this.BtnCerrar.TabIndex = 23;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(321, 480);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(114, 48);
            this.BtnEliminar.TabIndex = 21;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Location = new System.Drawing.Point(177, 480);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(114, 48);
            this.BtnEditar.TabIndex = 20;
            this.BtnEditar.Text = "Modificar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Green;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(42, 480);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(114, 48);
            this.BtnAgregar.TabIndex = 19;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            // 
            // CboxTipoCliente
            // 
            this.CboxTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxTipoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboxTipoCliente.FormattingEnabled = true;
            this.CboxTipoCliente.Location = new System.Drawing.Point(687, 106);
            this.CboxTipoCliente.Name = "CboxTipoCliente";
            this.CboxTipoCliente.Size = new System.Drawing.Size(293, 33);
            this.CboxTipoCliente.TabIndex = 28;
            // 
            // TxTTipoCliente
            // 
            this.TxTTipoCliente.AutoSize = true;
            this.TxTTipoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTTipoCliente.Location = new System.Drawing.Point(565, 106);
            this.TxTTipoCliente.Name = "TxTTipoCliente";
            this.TxTTipoCliente.Size = new System.Drawing.Size(117, 25);
            this.TxTTipoCliente.TabIndex = 27;
            this.TxTTipoCliente.Text = "Tipo Cliente";
            // 
            // TxTEmailCliente
            // 
            this.TxTEmailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTEmailCliente.Location = new System.Drawing.Point(686, 67);
            this.TxTEmailCliente.Name = "TxTEmailCliente";
            this.TxTEmailCliente.Size = new System.Drawing.Size(293, 30);
            this.TxTEmailCliente.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Código";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(565, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Email";
            // 
            // TxTCodigoCliente
            // 
            this.TxTCodigoCliente.Enabled = false;
            this.TxTCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTCodigoCliente.Location = new System.Drawing.Point(174, 32);
            this.TxTCodigoCliente.Name = "TxTCodigoCliente";
            this.TxTCodigoCliente.Size = new System.Drawing.Size(149, 30);
            this.TxTCodigoCliente.TabIndex = 18;
            this.TxTCodigoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtTelefonoCliente
            // 
            this.TxtTelefonoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefonoCliente.Location = new System.Drawing.Point(687, 32);
            this.TxtTelefonoCliente.Name = "TxtTelefonoCliente";
            this.TxtTelefonoCliente.Size = new System.Drawing.Size(293, 30);
            this.TxtTelefonoCliente.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(565, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Télefono";
            // 
            // TxTNombreCliente
            // 
            this.TxTNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTNombreCliente.Location = new System.Drawing.Point(173, 67);
            this.TxTNombreCliente.Name = "TxTNombreCliente";
            this.TxTNombreCliente.Size = new System.Drawing.Size(293, 30);
            this.TxTNombreCliente.TabIndex = 20;
            // 
            // TxTCedulaCliente
            // 
            this.TxTCedulaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTCedulaCliente.Location = new System.Drawing.Point(174, 106);
            this.TxTCedulaCliente.Name = "TxTCedulaCliente";
            this.TxTCedulaCliente.Size = new System.Drawing.Size(292, 30);
            this.TxTCedulaCliente.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Cédula";
            // 
            // TxTBuscar
            // 
            this.TxTBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTBuscar.ForeColor = System.Drawing.Color.DarkGreen;
            this.TxTBuscar.Location = new System.Drawing.Point(430, 4);
            this.TxTBuscar.MaxLength = 20;
            this.TxTBuscar.Name = "TxTBuscar";
            this.TxTBuscar.Size = new System.Drawing.Size(358, 30);
            this.TxTBuscar.TabIndex = 25;
            this.TxTBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxTBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxTBuscar_KeyDown);
            this.TxTBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxTBuscar_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Buscar:";
            // 
            // BtnLimpiarForm
            // 
            this.BtnLimpiarForm.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnLimpiarForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiarForm.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiarForm.Location = new System.Drawing.Point(660, 480);
            this.BtnLimpiarForm.Name = "BtnLimpiarForm";
            this.BtnLimpiarForm.Size = new System.Drawing.Size(259, 48);
            this.BtnLimpiarForm.TabIndex = 22;
            this.BtnLimpiarForm.Text = "Limpiar Formulario";
            this.BtnLimpiarForm.UseVisualStyleBackColor = false;
            this.BtnLimpiarForm.Click += new System.EventHandler(this.BtnLimpiarForm_Click);
            // 
            // GbDetalles
            // 
            this.GbDetalles.Controls.Add(this.CboxTipoCliente);
            this.GbDetalles.Controls.Add(this.TxTTipoCliente);
            this.GbDetalles.Controls.Add(this.TxTEmailCliente);
            this.GbDetalles.Controls.Add(this.label2);
            this.GbDetalles.Controls.Add(this.label7);
            this.GbDetalles.Controls.Add(this.TxTCodigoCliente);
            this.GbDetalles.Controls.Add(this.TxtTelefonoCliente);
            this.GbDetalles.Controls.Add(this.label3);
            this.GbDetalles.Controls.Add(this.label4);
            this.GbDetalles.Controls.Add(this.TxTNombreCliente);
            this.GbDetalles.Controls.Add(this.TxTCedulaCliente);
            this.GbDetalles.Controls.Add(this.label5);
            this.GbDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbDetalles.Location = new System.Drawing.Point(42, 285);
            this.GbDetalles.Name = "GbDetalles";
            this.GbDetalles.Size = new System.Drawing.Size(1049, 173);
            this.GbDetalles.TabIndex = 18;
            this.GbDetalles.TabStop = false;
            this.GbDetalles.Text = "Detalles de Producto";
            // 
            // DgvListaClientes
            // 
            this.DgvListaClientes.AllowUserToAddRows = false;
            this.DgvListaClientes.AllowUserToDeleteRows = false;
            this.DgvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDCliente,
            this.CNombre,
            this.CCedula,
            this.CTelefono,
            this.CDescripcion});
            this.DgvListaClientes.Location = new System.Drawing.Point(31, 51);
            this.DgvListaClientes.MultiSelect = false;
            this.DgvListaClientes.Name = "DgvListaClientes";
            this.DgvListaClientes.ReadOnly = true;
            this.DgvListaClientes.RowHeadersVisible = false;
            this.DgvListaClientes.RowHeadersWidth = 51;
            this.DgvListaClientes.RowTemplate.Height = 24;
            this.DgvListaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaClientes.Size = new System.Drawing.Size(1060, 228);
            this.DgvListaClientes.TabIndex = 0;
            this.DgvListaClientes.VirtualMode = true;
            this.DgvListaClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaClientes_CellClick);
            this.DgvListaClientes.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvListaClientes_DataBindingComplete);
            // 
            // CIDCliente
            // 
            this.CIDCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CIDCliente.DataPropertyName = "IDCliente";
            this.CIDCliente.HeaderText = "Código Cliente";
            this.CIDCliente.MinimumWidth = 6;
            this.CIDCliente.Name = "CIDCliente";
            this.CIDCliente.ReadOnly = true;
            this.CIDCliente.Width = 125;
            // 
            // CNombre
            // 
            this.CNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNombre.DataPropertyName = "Nombre";
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.MinimumWidth = 6;
            this.CNombre.Name = "CNombre";
            this.CNombre.ReadOnly = true;
            // 
            // CCedula
            // 
            this.CCedula.DataPropertyName = "Cedula";
            this.CCedula.HeaderText = "Cédula";
            this.CCedula.MinimumWidth = 6;
            this.CCedula.Name = "CCedula";
            this.CCedula.ReadOnly = true;
            this.CCedula.Width = 125;
            // 
            // CTelefono
            // 
            this.CTelefono.DataPropertyName = "Telefono";
            this.CTelefono.HeaderText = "Teléfono";
            this.CTelefono.MinimumWidth = 6;
            this.CTelefono.Name = "CTelefono";
            this.CTelefono.ReadOnly = true;
            this.CTelefono.Width = 125;
            // 
            // CDescripcion
            // 
            this.CDescripcion.DataPropertyName = "Descripcion";
            this.CDescripcion.HeaderText = "Tipo Cliente";
            this.CDescripcion.MinimumWidth = 6;
            this.CDescripcion.Name = "CDescripcion";
            this.CDescripcion.ReadOnly = true;
            this.CDescripcion.Width = 125;
            // 
            // CbVerActivos
            // 
            this.CbVerActivos.AutoSize = true;
            this.CbVerActivos.Checked = true;
            this.CbVerActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbVerActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbVerActivos.Location = new System.Drawing.Point(882, 10);
            this.CbVerActivos.Name = "CbVerActivos";
            this.CbVerActivos.Size = new System.Drawing.Size(183, 24);
            this.CbVerActivos.TabIndex = 26;
            this.CbVerActivos.Text = "Ver Clientes Activos";
            this.CbVerActivos.UseVisualStyleBackColor = true;
            this.CbVerActivos.CheckedChanged += new System.EventHandler(this.CbVerActivos_CheckedChanged);
            // 
            // TmrBuscar
            // 
            this.TmrBuscar.Interval = 800;
            this.TmrBuscar.Tick += new System.EventHandler(this.TmrBuscar_Tick);
            // 
            // FrmClienteGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 543);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.CbVerActivos);
            this.Controls.Add(this.TxTBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLimpiarForm);
            this.Controls.Add(this.GbDetalles);
            this.Controls.Add(this.DgvListaClientes);
            this.MaximizeBox = false;
            this.Name = "FrmClienteGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Clientes";
            this.Load += new System.EventHandler(this.FrmClienteGestion_Load);
            this.GbDetalles.ResumeLayout(false);
            this.GbDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.ComboBox CboxTipoCliente;
        private System.Windows.Forms.Label TxTTipoCliente;
        private System.Windows.Forms.TextBox TxTEmailCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxTCodigoCliente;
        private System.Windows.Forms.TextBox TxtTelefonoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxTNombreCliente;
        private System.Windows.Forms.TextBox TxTCedulaCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxTBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLimpiarForm;
        private System.Windows.Forms.GroupBox GbDetalles;
        private System.Windows.Forms.DataGridView DgvListaClientes;
        private System.Windows.Forms.CheckBox CbVerActivos;
        private System.Windows.Forms.Timer TmrBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescripcion;
    }
}