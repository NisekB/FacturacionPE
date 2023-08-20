namespace FacturacionPE.Formularios
{
    partial class FrmFacturaciónItemGestionCantidad
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
            this.BtnCambiar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.TxTCantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TxTCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCambiar
            // 
            this.BtnCambiar.BackColor = System.Drawing.Color.Green;
            this.BtnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCambiar.ForeColor = System.Drawing.Color.White;
            this.BtnCambiar.Location = new System.Drawing.Point(59, 144);
            this.BtnCambiar.Name = "BtnCambiar";
            this.BtnCambiar.Size = new System.Drawing.Size(217, 48);
            this.BtnCambiar.TabIndex = 12;
            this.BtnCambiar.Text = "Cambiar Cantidad";
            this.BtnCambiar.UseVisualStyleBackColor = false;
            this.BtnCambiar.Click += new System.EventHandler(this.BtnCambiar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.SaddleBrown;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(89, 206);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(155, 48);
            this.BtnCerrar.TabIndex = 13;
            this.BtnCerrar.Text = "Cancelar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // TxTCantidad
            // 
            this.TxTCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTCantidad.Location = new System.Drawing.Point(99, 75);
            this.TxTCantidad.Name = "TxTCantidad";
            this.TxTCantidad.Size = new System.Drawing.Size(133, 30);
            this.TxTCantidad.TabIndex = 14;
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
            this.label1.Location = new System.Drawing.Point(112, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "CANTIDAD";
            // 
            // FrmFacturaciónItemGestionCantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 295);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxTCantidad);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnCambiar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmFacturaciónItemGestionCantidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio cantidad del producto.....";
            this.Load += new System.EventHandler(this.FrmFacturaciónItemGestionCantidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxTCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCambiar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.NumericUpDown TxTCantidad;
        private System.Windows.Forms.Label label1;
    }
}