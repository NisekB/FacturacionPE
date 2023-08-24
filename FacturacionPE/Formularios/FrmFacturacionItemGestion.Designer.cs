namespace FacturacionPE.Formularios
{
    partial class FrmFacturacionItemGestion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.TxTBuscar = new System.Windows.Forms.TextBox();
            this.DgvListaProductos = new System.Windows.Forms.DataGridView();
            this.CIDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCodigoDeBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxTPrecioFinal = new System.Windows.Forms.TextBox();
            this.PrecioFinal = new System.Windows.Forms.Label();
            this.TxTIVA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxTPrecioUnidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CboSumarCantidades = new System.Windows.Forms.CheckBox();
            this.TxTDescuento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxTCantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.TmrBuscar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxTCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.SaddleBrown;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(592, 372);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(155, 48);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.Green;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.Color.White;
            this.BtnAceptar.Location = new System.Drawing.Point(118, 372);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(217, 48);
            this.BtnAceptar.TabIndex = 11;
            this.BtnAceptar.Text = "Seleccionar Producto";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // TxTBuscar
            // 
            this.TxTBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTBuscar.ForeColor = System.Drawing.Color.DarkGreen;
            this.TxTBuscar.Location = new System.Drawing.Point(197, 18);
            this.TxTBuscar.Name = "TxTBuscar";
            this.TxTBuscar.Size = new System.Drawing.Size(480, 30);
            this.TxTBuscar.TabIndex = 13;
            this.TxTBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxTBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxTBuscarCliente_KeyDown);
            this.TxTBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxTBuscarCliente_KeyUp);
            // 
            // DgvListaProductos
            // 
            this.DgvListaProductos.AllowUserToAddRows = false;
            this.DgvListaProductos.AllowUserToDeleteRows = false;
            this.DgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDProducto,
            this.CCodigoDeBarras,
            this.CDescripcionProducto,
            this.CCantidad,
            this.CPrecioUnitario,
            this.CDescripcion});
            this.DgvListaProductos.Location = new System.Drawing.Point(3, 54);
            this.DgvListaProductos.MultiSelect = false;
            this.DgvListaProductos.Name = "DgvListaProductos";
            this.DgvListaProductos.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvListaProductos.RowHeadersVisible = false;
            this.DgvListaProductos.RowHeadersWidth = 51;
            this.DgvListaProductos.RowTemplate.Height = 24;
            this.DgvListaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaProductos.Size = new System.Drawing.Size(819, 184);
            this.DgvListaProductos.TabIndex = 14;
            this.DgvListaProductos.VirtualMode = true;
            this.DgvListaProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaProductos_CellClick);
            this.DgvListaProductos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvListaProductos_DataBindingComplete);
            // 
            // CIDProducto
            // 
            this.CIDProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CIDProducto.DataPropertyName = "IDProducto";
            this.CIDProducto.HeaderText = "Código";
            this.CIDProducto.MinimumWidth = 6;
            this.CIDProducto.Name = "CIDProducto";
            this.CIDProducto.ReadOnly = true;
            this.CIDProducto.Width = 70;
            // 
            // CCodigoDeBarras
            // 
            this.CCodigoDeBarras.DataPropertyName = "CodigoDeBarras";
            this.CCodigoDeBarras.HeaderText = "Código de Barras";
            this.CCodigoDeBarras.MinimumWidth = 6;
            this.CCodigoDeBarras.Name = "CCodigoDeBarras";
            this.CCodigoDeBarras.ReadOnly = true;
            this.CCodigoDeBarras.Width = 125;
            // 
            // CDescripcionProducto
            // 
            this.CDescripcionProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CDescripcionProducto.DataPropertyName = "DescripcionProducto";
            this.CDescripcionProducto.HeaderText = "Descripción";
            this.CDescripcionProducto.MinimumWidth = 6;
            this.CDescripcionProducto.Name = "CDescripcionProducto";
            this.CDescripcionProducto.ReadOnly = true;
            // 
            // CCantidad
            // 
            this.CCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CCantidad.DataPropertyName = "Cantidad";
            this.CCantidad.HeaderText = "Stock";
            this.CCantidad.MinimumWidth = 6;
            this.CCantidad.Name = "CCantidad";
            this.CCantidad.ReadOnly = true;
            this.CCantidad.Width = 70;
            // 
            // CPrecioUnitario
            // 
            this.CPrecioUnitario.DataPropertyName = "PrecioUnitario";
            this.CPrecioUnitario.HeaderText = "Precio";
            this.CPrecioUnitario.MinimumWidth = 6;
            this.CPrecioUnitario.Name = "CPrecioUnitario";
            this.CPrecioUnitario.ReadOnly = true;
            this.CPrecioUnitario.Width = 125;
            // 
            // CDescripcion
            // 
            this.CDescripcion.DataPropertyName = "Descripcion";
            this.CDescripcion.HeaderText = "Categoria";
            this.CDescripcion.MinimumWidth = 6;
            this.CDescripcion.Name = "CDescripcion";
            this.CDescripcion.ReadOnly = true;
            this.CDescripcion.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxTPrecioFinal);
            this.groupBox1.Controls.Add(this.PrecioFinal);
            this.groupBox1.Controls.Add(this.TxTIVA);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxTPrecioUnidad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CboSumarCantidades);
            this.groupBox1.Controls.Add(this.TxTDescuento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxTCantidad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 121);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones...";
            // 
            // TxTPrecioFinal
            // 
            this.TxTPrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTPrecioFinal.Location = new System.Drawing.Point(655, 57);
            this.TxTPrecioFinal.Name = "TxTPrecioFinal";
            this.TxTPrecioFinal.ReadOnly = true;
            this.TxTPrecioFinal.Size = new System.Drawing.Size(158, 30);
            this.TxTPrecioFinal.TabIndex = 10;
            this.TxTPrecioFinal.Text = "0";
            this.TxTPrecioFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PrecioFinal
            // 
            this.PrecioFinal.AutoSize = true;
            this.PrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioFinal.Location = new System.Drawing.Point(676, 32);
            this.PrecioFinal.Name = "PrecioFinal";
            this.PrecioFinal.Size = new System.Drawing.Size(119, 22);
            this.PrecioFinal.TabIndex = 9;
            this.PrecioFinal.Text = "Precio Total";
            // 
            // TxTIVA
            // 
            this.TxTIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTIVA.Location = new System.Drawing.Point(505, 57);
            this.TxTIVA.Name = "TxTIVA";
            this.TxTIVA.ReadOnly = true;
            this.TxTIVA.Size = new System.Drawing.Size(124, 30);
            this.TxTIVA.TabIndex = 8;
            this.TxTIVA.Text = "0";
            this.TxTIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(532, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "% IVA";
            // 
            // TxTPrecioUnidad
            // 
            this.TxTPrecioUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTPrecioUnidad.Location = new System.Drawing.Point(331, 57);
            this.TxTPrecioUnidad.Name = "TxTPrecioUnidad";
            this.TxTPrecioUnidad.ReadOnly = true;
            this.TxTPrecioUnidad.Size = new System.Drawing.Size(156, 30);
            this.TxTPrecioUnidad.TabIndex = 6;
            this.TxTPrecioUnidad.Text = "0";
            this.TxTPrecioUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio ";
            // 
            // CboSumarCantidades
            // 
            this.CboSumarCantidades.AutoSize = true;
            this.CboSumarCantidades.Location = new System.Drawing.Point(6, 92);
            this.CboSumarCantidades.Name = "CboSumarCantidades";
            this.CboSumarCantidades.Size = new System.Drawing.Size(303, 20);
            this.CboSumarCantidades.TabIndex = 4;
            this.CboSumarCantidades.Text = "Sumar Cantidad Sí Producto ya esta en la lista";
            this.CboSumarCantidades.UseVisualStyleBackColor = true;
            // 
            // TxTDescuento
            // 
            this.TxTDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTDescuento.Location = new System.Drawing.Point(194, 57);
            this.TxTDescuento.Name = "TxTDescuento";
            this.TxTDescuento.Size = new System.Drawing.Size(124, 30);
            this.TxTDescuento.TabIndex = 3;
            this.TxTDescuento.Text = "0";
            this.TxTDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxTDescuento.TextChanged += new System.EventHandler(this.TxTDescuento_TextChanged);
            this.TxTDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxTDescuento_KeyPress);
            this.TxTDescuento.Leave += new System.EventHandler(this.TxTDescuento_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "% Descuento";
            // 
            // TxTCantidad
            // 
            this.TxTCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTCantidad.Location = new System.Drawing.Point(41, 56);
            this.TxTCantidad.Name = "TxTCantidad";
            this.TxTCantidad.Size = new System.Drawing.Size(133, 30);
            this.TxTCantidad.TabIndex = 1;
            this.TxTCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxTCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "CANTIDAD";
            // 
            // TmrBuscar
            // 
            this.TmrBuscar.Interval = 800;
            this.TmrBuscar.Tick += new System.EventHandler(this.TmrBuscar_Tick);
            // 
            // FrmFacturacionItemGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 448);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvListaProductos);
            this.Controls.Add(this.TxTBuscar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmFacturacionItemGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos...";
            this.Load += new System.EventHandler(this.FrmFacturacionItemGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxTCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.TextBox TxTBuscar;
        private System.Windows.Forms.DataGridView DgvListaProductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown TxTCantidad;
        private System.Windows.Forms.TextBox TxTDescuento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CboSumarCantidades;
        private System.Windows.Forms.TextBox TxTIVA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxTPrecioUnidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigoDeBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescripcionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescripcion;
        private System.Windows.Forms.TextBox TxTPrecioFinal;
        private System.Windows.Forms.Label PrecioFinal;
        private System.Windows.Forms.Timer TmrBuscar;
    }
}