namespace FacturacionPE.Formularios
{
    partial class FrmClienteListar
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
            this.TxTBuscarCliente = new System.Windows.Forms.TextBox();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.CIDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TmrBuscarCliente = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // TxTBuscarCliente
            // 
            this.TxTBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTBuscarCliente.ForeColor = System.Drawing.Color.DarkGreen;
            this.TxTBuscarCliente.Location = new System.Drawing.Point(212, 12);
            this.TxTBuscarCliente.Name = "TxTBuscarCliente";
            this.TxTBuscarCliente.Size = new System.Drawing.Size(386, 30);
            this.TxTBuscarCliente.TabIndex = 0;
            this.TxTBuscarCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxTBuscarCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxTBuscarCliente_KeyDown);
            this.TxTBuscarCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxTBuscarCliente_KeyUp);
            // 
            // DgvLista
            // 
            this.DgvLista.AllowUserToAddRows = false;
            this.DgvLista.AllowUserToDeleteRows = false;
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDCliente,
            this.CNombre,
            this.CCedula,
            this.CTelefono});
            this.DgvLista.Location = new System.Drawing.Point(12, 64);
            this.DgvLista.MultiSelect = false;
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.RowHeadersVisible = false;
            this.DgvLista.RowHeadersWidth = 51;
            this.DgvLista.RowTemplate.Height = 24;
            this.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista.Size = new System.Drawing.Size(776, 163);
            this.DgvLista.TabIndex = 1;
            this.DgvLista.VirtualMode = true;
            this.DgvLista.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvLista_DataBindingComplete);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.Green;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.Color.White;
            this.BtnAceptar.Location = new System.Drawing.Point(76, 236);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(285, 48);
            this.BtnAceptar.TabIndex = 3;
            this.BtnAceptar.Text = "Seleccionar Cliente";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.SaddleBrown;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(554, 236);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(155, 48);
            this.BtnCancelar.TabIndex = 10;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // CIDCliente
            // 
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
            this.CNombre.MinimumWidth = 100;
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
            // TmrBuscarCliente
            // 
            this.TmrBuscarCliente.Interval = 800;
            this.TmrBuscarCliente.Tick += new System.EventHandler(this.TmrBuscarCliente_Tick);
            // 
            // FrmClienteListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 329);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.DgvLista);
            this.Controls.Add(this.TxTBuscarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmClienteListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Clientes";
            this.Load += new System.EventHandler(this.FrmClienteListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxTBuscarCliente;
        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTelefono;
        private System.Windows.Forms.Timer TmrBuscarCliente;
    }
}