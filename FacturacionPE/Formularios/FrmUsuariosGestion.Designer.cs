namespace FacturacionPE.Formularios
{
    partial class FrmUsuariosGestion
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
            this.DgvListaUsuarios = new System.Windows.Forms.DataGridView();
            this.CIDUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbEspecial = new System.Windows.Forms.CheckBox();
            this.CbNumero = new System.Windows.Forms.CheckBox();
            this.CbMinuscula = new System.Windows.Forms.CheckBox();
            this.CbMayuscula = new System.Windows.Forms.CheckBox();
            this.CbMinimo = new System.Windows.Forms.CheckBox();
            this.CboxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.TxTTipoUsuario = new System.Windows.Forms.Label();
            this.TxTContra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxTRespaldo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxTTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxTEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxTNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxTCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.CbVerActivos = new System.Windows.Forms.CheckBox();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnLimpiarForm = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvListaUsuarios
            // 
            this.DgvListaUsuarios.AllowUserToAddRows = false;
            this.DgvListaUsuarios.AllowUserToDeleteRows = false;
            this.DgvListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDUsuario,
            this.CNombre,
            this.CEmail,
            this.CCedula,
            this.CDescripcion});
            this.DgvListaUsuarios.Location = new System.Drawing.Point(2, 44);
            this.DgvListaUsuarios.MultiSelect = false;
            this.DgvListaUsuarios.Name = "DgvListaUsuarios";
            this.DgvListaUsuarios.ReadOnly = true;
            this.DgvListaUsuarios.RowHeadersVisible = false;
            this.DgvListaUsuarios.RowHeadersWidth = 51;
            this.DgvListaUsuarios.RowTemplate.Height = 24;
            this.DgvListaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaUsuarios.Size = new System.Drawing.Size(970, 210);
            this.DgvListaUsuarios.TabIndex = 0;
            this.DgvListaUsuarios.VirtualMode = true;
            this.DgvListaUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaUsuarios_CellClick);
            this.DgvListaUsuarios.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvListaUsuarios_DataBindingComplete);
            // 
            // CIDUsuario
            // 
            this.CIDUsuario.DataPropertyName = "IDUsuario";
            this.CIDUsuario.HeaderText = "Código Usuario";
            this.CIDUsuario.MinimumWidth = 6;
            this.CIDUsuario.Name = "CIDUsuario";
            this.CIDUsuario.ReadOnly = true;
            this.CIDUsuario.Width = 125;
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
            // CEmail
            // 
            this.CEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CEmail.DataPropertyName = "Email";
            this.CEmail.HeaderText = "Email";
            this.CEmail.MinimumWidth = 6;
            this.CEmail.Name = "CEmail";
            this.CEmail.ReadOnly = true;
            this.CEmail.Width = 180;
            // 
            // CCedula
            // 
            this.CCedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CCedula.DataPropertyName = "Cedula";
            this.CCedula.HeaderText = "Cédula";
            this.CCedula.MinimumWidth = 6;
            this.CCedula.Name = "CCedula";
            this.CCedula.ReadOnly = true;
            this.CCedula.Width = 150;
            // 
            // CDescripcion
            // 
            this.CDescripcion.DataPropertyName = "Descripcion";
            this.CDescripcion.HeaderText = "Tipo Usuario";
            this.CDescripcion.MinimumWidth = 6;
            this.CDescripcion.Name = "CDescripcion";
            this.CDescripcion.ReadOnly = true;
            this.CDescripcion.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbEspecial);
            this.groupBox1.Controls.Add(this.CbNumero);
            this.groupBox1.Controls.Add(this.CbMinuscula);
            this.groupBox1.Controls.Add(this.CbMayuscula);
            this.groupBox1.Controls.Add(this.CbMinimo);
            this.groupBox1.Controls.Add(this.CboxTipoUsuario);
            this.groupBox1.Controls.Add(this.TxTTipoUsuario);
            this.groupBox1.Controls.Add(this.TxTContra);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxTRespaldo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxTTelefono);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtCedula);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxTEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxTNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxTCodigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(2, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(970, 285);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del Usuario";
            // 
            // CbEspecial
            // 
            this.CbEspecial.AutoSize = true;
            this.CbEspecial.Enabled = false;
            this.CbEspecial.Location = new System.Drawing.Point(516, 225);
            this.CbEspecial.Name = "CbEspecial";
            this.CbEspecial.Size = new System.Drawing.Size(209, 20);
            this.CbEspecial.TabIndex = 20;
            this.CbEspecial.Text = "Al menos un caracter especial";
            this.CbEspecial.UseVisualStyleBackColor = true;
            // 
            // CbNumero
            // 
            this.CbNumero.AutoSize = true;
            this.CbNumero.Enabled = false;
            this.CbNumero.Location = new System.Drawing.Point(516, 196);
            this.CbNumero.Name = "CbNumero";
            this.CbNumero.Size = new System.Drawing.Size(150, 20);
            this.CbNumero.TabIndex = 19;
            this.CbNumero.Text = "Al menos un número";
            this.CbNumero.UseVisualStyleBackColor = true;
            // 
            // CbMinuscula
            // 
            this.CbMinuscula.AutoSize = true;
            this.CbMinuscula.Enabled = false;
            this.CbMinuscula.Location = new System.Drawing.Point(516, 170);
            this.CbMinuscula.Name = "CbMinuscula";
            this.CbMinuscula.Size = new System.Drawing.Size(202, 20);
            this.CbMinuscula.TabIndex = 18;
            this.CbMinuscula.Text = "Al menos una letra minuscula";
            this.CbMinuscula.UseVisualStyleBackColor = true;
            // 
            // CbMayuscula
            // 
            this.CbMayuscula.AutoSize = true;
            this.CbMayuscula.Enabled = false;
            this.CbMayuscula.Location = new System.Drawing.Point(516, 137);
            this.CbMayuscula.Name = "CbMayuscula";
            this.CbMayuscula.Size = new System.Drawing.Size(207, 20);
            this.CbMayuscula.TabIndex = 17;
            this.CbMayuscula.Text = "Al menos una letra Mayuscula";
            this.CbMayuscula.UseVisualStyleBackColor = true;
            // 
            // CbMinimo
            // 
            this.CbMinimo.AutoSize = true;
            this.CbMinimo.Enabled = false;
            this.CbMinimo.Location = new System.Drawing.Point(516, 108);
            this.CbMinimo.Name = "CbMinimo";
            this.CbMinimo.Size = new System.Drawing.Size(149, 20);
            this.CbMinimo.TabIndex = 16;
            this.CbMinimo.Text = "Mínimo 6 caracteres";
            this.CbMinimo.UseVisualStyleBackColor = true;
            // 
            // CboxTipoUsuario
            // 
            this.CboxTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxTipoUsuario.FormattingEnabled = true;
            this.CboxTipoUsuario.Location = new System.Drawing.Point(121, 244);
            this.CboxTipoUsuario.Name = "CboxTipoUsuario";
            this.CboxTipoUsuario.Size = new System.Drawing.Size(293, 24);
            this.CboxTipoUsuario.TabIndex = 15;
            // 
            // TxTTipoUsuario
            // 
            this.TxTTipoUsuario.AutoSize = true;
            this.TxTTipoUsuario.Location = new System.Drawing.Point(11, 244);
            this.TxTTipoUsuario.Name = "TxTTipoUsuario";
            this.TxTTipoUsuario.Size = new System.Drawing.Size(85, 16);
            this.TxTTipoUsuario.TabIndex = 14;
            this.TxTTipoUsuario.Text = "Tipo Usuario";
            // 
            // TxTContra
            // 
            this.TxTContra.Location = new System.Drawing.Point(611, 67);
            this.TxTContra.Name = "TxTContra";
            this.TxTContra.Size = new System.Drawing.Size(293, 22);
            this.TxTContra.TabIndex = 13;
            this.TxTContra.UseSystemPasswordChar = true;
            this.TxTContra.TextChanged += new System.EventHandler(this.TxTContra_TextChanged);
            this.TxTContra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxTContra_KeyPress);
            this.TxTContra.Leave += new System.EventHandler(this.TxTContra_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(502, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Contraseña";
            // 
            // TxTRespaldo
            // 
            this.TxTRespaldo.Location = new System.Drawing.Point(119, 209);
            this.TxTRespaldo.Name = "TxTRespaldo";
            this.TxTRespaldo.Size = new System.Drawing.Size(293, 22);
            this.TxTRespaldo.TabIndex = 11;
            this.TxTRespaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxTRespaldo_KeyPress);
            this.TxTRespaldo.Leave += new System.EventHandler(this.TxTRespaldo_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email Respaldo";
            // 
            // TxTTelefono
            // 
            this.TxTTelefono.Location = new System.Drawing.Point(120, 174);
            this.TxTTelefono.Name = "TxTTelefono";
            this.TxTTelefono.Size = new System.Drawing.Size(293, 22);
            this.TxTTelefono.TabIndex = 9;
            this.TxTTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxTTelefono_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Télefono";
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(120, 141);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(293, 22);
            this.TxtCedula.TabIndex = 7;
            this.TxtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedula_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cédula";
            // 
            // TxTEmail
            // 
            this.TxTEmail.Location = new System.Drawing.Point(121, 106);
            this.TxTEmail.Name = "TxTEmail";
            this.TxTEmail.Size = new System.Drawing.Size(292, 22);
            this.TxTEmail.TabIndex = 5;
            this.TxTEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxTEmail_KeyPress);
            this.TxTEmail.Leave += new System.EventHandler(this.TxTEmail_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // TxTNombre
            // 
            this.TxTNombre.Location = new System.Drawing.Point(120, 67);
            this.TxTNombre.Name = "TxTNombre";
            this.TxTNombre.Size = new System.Drawing.Size(293, 22);
            this.TxTNombre.TabIndex = 3;
            this.TxTNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxTNombre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // TxTCodigo
            // 
            this.TxTCodigo.Enabled = false;
            this.TxTCodigo.Location = new System.Drawing.Point(121, 32);
            this.TxTCodigo.Name = "TxTCodigo";
            this.TxTCodigo.Size = new System.Drawing.Size(149, 22);
            this.TxTCodigo.TabIndex = 1;
            this.TxTCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Green;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(28, 573);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(114, 48);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar:";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.ForeColor = System.Drawing.Color.DarkGreen;
            this.TxtBuscar.Location = new System.Drawing.Point(299, 9);
            this.TxtBuscar.MaxLength = 20;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(358, 30);
            this.TxtBuscar.TabIndex = 4;
            this.TxtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CbVerActivos
            // 
            this.CbVerActivos.AutoSize = true;
            this.CbVerActivos.Checked = true;
            this.CbVerActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbVerActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbVerActivos.Location = new System.Drawing.Point(693, 12);
            this.CbVerActivos.Name = "CbVerActivos";
            this.CbVerActivos.Size = new System.Drawing.Size(189, 24);
            this.CbVerActivos.TabIndex = 5;
            this.CbVerActivos.Text = "Ver Usuarios Activos";
            this.CbVerActivos.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Location = new System.Drawing.Point(171, 573);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(114, 48);
            this.BtnEditar.TabIndex = 6;
            this.BtnEditar.Text = "Modificar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(315, 573);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(114, 48);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnLimpiarForm
            // 
            this.BtnLimpiarForm.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnLimpiarForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiarForm.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiarForm.Location = new System.Drawing.Point(540, 573);
            this.BtnLimpiarForm.Name = "BtnLimpiarForm";
            this.BtnLimpiarForm.Size = new System.Drawing.Size(259, 48);
            this.BtnLimpiarForm.TabIndex = 8;
            this.BtnLimpiarForm.Text = "Limpiar Formulario";
            this.BtnLimpiarForm.UseVisualStyleBackColor = false;
            this.BtnLimpiarForm.Click += new System.EventHandler(this.BtnLimpiarForm_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.SaddleBrown;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(827, 573);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(114, 48);
            this.BtnCerrar.TabIndex = 9;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            // 
            // FrmUsuariosGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 646);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnLimpiarForm);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.CbVerActivos);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvListaUsuarios);
            this.MaximizeBox = false;
            this.Name = "FrmUsuariosGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuariosGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListaUsuarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.CheckBox CbVerActivos;
        private System.Windows.Forms.ComboBox CboxTipoUsuario;
        private System.Windows.Forms.Label TxTTipoUsuario;
        private System.Windows.Forms.TextBox TxTContra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxTRespaldo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxTTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxTEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxTNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxTCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnLimpiarForm;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescripcion;
        private System.Windows.Forms.CheckBox CbEspecial;
        private System.Windows.Forms.CheckBox CbNumero;
        private System.Windows.Forms.CheckBox CbMinuscula;
        private System.Windows.Forms.CheckBox CbMayuscula;
        private System.Windows.Forms.CheckBox CbMinimo;
    }
}