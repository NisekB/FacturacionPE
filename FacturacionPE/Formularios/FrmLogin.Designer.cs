namespace FacturacionPE.Formularios
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxTName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxTContra = new System.Windows.Forms.TextBox();
            this.PbVerPass = new System.Windows.Forms.PictureBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LblRecuperarPass = new System.Windows.Forms.LinkLabel();
            this.BtnIngresoDirecto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbVerPass)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(84, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TxTName
            // 
            this.TxTName.Location = new System.Drawing.Point(64, 354);
            this.TxTName.Name = "TxTName";
            this.TxTName.Size = new System.Drawing.Size(299, 22);
            this.TxTName.TabIndex = 1;
            this.TxTName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxTContra
            // 
            this.TxTContra.Location = new System.Drawing.Point(64, 441);
            this.TxTContra.Name = "TxTContra";
            this.TxTContra.Size = new System.Drawing.Size(299, 22);
            this.TxTContra.TabIndex = 5;
            this.TxTContra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxTContra.UseSystemPasswordChar = true;
            // 
            // PbVerPass
            // 
            this.PbVerPass.BackColor = System.Drawing.Color.White;
            this.PbVerPass.Image = ((System.Drawing.Image)(resources.GetObject("PbVerPass.Image")));
            this.PbVerPass.Location = new System.Drawing.Point(327, 441);
            this.PbVerPass.Name = "PbVerPass";
            this.PbVerPass.Size = new System.Drawing.Size(36, 21);
            this.PbVerPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbVerPass.TabIndex = 6;
            this.PbVerPass.TabStop = false;
            this.PbVerPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbVerPass_MouseDown);
            this.PbVerPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbVerPass_MouseUp);
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.Green;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.Color.White;
            this.BtnIngresar.Location = new System.Drawing.Point(64, 519);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(114, 48);
            this.BtnIngresar.TabIndex = 20;
            this.BtnIngresar.Text = "Login";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Firebrick;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(249, 519);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(114, 48);
            this.BtnSalir.TabIndex = 22;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LblRecuperarPass
            // 
            this.LblRecuperarPass.AutoSize = true;
            this.LblRecuperarPass.BackColor = System.Drawing.Color.Transparent;
            this.LblRecuperarPass.Location = new System.Drawing.Point(221, 481);
            this.LblRecuperarPass.Name = "LblRecuperarPass";
            this.LblRecuperarPass.Size = new System.Drawing.Size(142, 16);
            this.LblRecuperarPass.TabIndex = 23;
            this.LblRecuperarPass.TabStop = true;
            this.LblRecuperarPass.Text = "Olvidé mi contraseña...";
            // 
            // BtnIngresoDirecto
            // 
            this.BtnIngresoDirecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnIngresoDirecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresoDirecto.Location = new System.Drawing.Point(12, 102);
            this.BtnIngresoDirecto.Name = "BtnIngresoDirecto";
            this.BtnIngresoDirecto.Size = new System.Drawing.Size(408, 40);
            this.BtnIngresoDirecto.TabIndex = 24;
            this.BtnIngresoDirecto.Text = "Ingreso Directo";
            this.BtnIngresoDirecto.UseVisualStyleBackColor = false;
            this.BtnIngresoDirecto.Visible = false;
            this.BtnIngresoDirecto.Click += new System.EventHandler(this.BtnIngresoDirecto_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(419, 598);
            this.Controls.Add(this.BtnIngresoDirecto);
            this.Controls.Add(this.LblRecuperarPass);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.PbVerPass);
            this.Controls.Add(this.TxTContra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxTName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbVerPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxTName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxTContra;
        private System.Windows.Forms.PictureBox PbVerPass;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.LinkLabel LblRecuperarPass;
        private System.Windows.Forms.Button BtnIngresoDirecto;
    }
}