namespace FacturacionPE.Formularios
{
    partial class FrmMDIPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMDIPrincipal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblUsuarioLog = new System.Windows.Forms.ToolStripStatusLabel();
            this.TmrFecha = new System.Windows.Forms.Timer(this.components);
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.facturaciónPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónPorUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSTHORA = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuUsuariosGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuProductosGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuEmpresaGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFacturacion = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.LblUsuarioLog});
            this.statusStrip1.Location = new System.Drawing.Point(0, 392);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1098, 28);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Sylfaen", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(71, 22);
            this.toolStripStatusLabel1.Text = "Usuario:";
            // 
            // LblUsuarioLog
            // 
            this.LblUsuarioLog.BackColor = System.Drawing.SystemColors.Control;
            this.LblUsuarioLog.Font = new System.Drawing.Font("Sylfaen", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuarioLog.Name = "LblUsuarioLog";
            this.LblUsuarioLog.Size = new System.Drawing.Size(23, 22);
            this.LblUsuarioLog.Text = "U";
            this.LblUsuarioLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TmrFecha
            // 
            this.TmrFecha.Interval = 1000;
            this.TmrFecha.Tick += new System.EventHandler(this.TmrFecha_Tick);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeClientesToolStripMenuItem,
            this.listaDeUsuariosToolStripMenuItem,
            this.listaDeCategoriasToolStripMenuItem,
            this.listaDeProductosToolStripMenuItem,
            this.toolStripSeparator2,
            this.facturaciónPorClienteToolStripMenuItem,
            this.facturaciónPorUsuariosToolStripMenuItem});
            this.reportesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportesToolStripMenuItem.Image")));
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(141, 33);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // listadoDeClientesToolStripMenuItem
            // 
            this.listadoDeClientesToolStripMenuItem.Name = "listadoDeClientesToolStripMenuItem";
            this.listadoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(368, 34);
            this.listadoDeClientesToolStripMenuItem.Text = "Lista de Clientes";
            // 
            // listaDeUsuariosToolStripMenuItem
            // 
            this.listaDeUsuariosToolStripMenuItem.Name = "listaDeUsuariosToolStripMenuItem";
            this.listaDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(368, 34);
            this.listaDeUsuariosToolStripMenuItem.Text = "Lista de Usuarios";
            // 
            // listaDeCategoriasToolStripMenuItem
            // 
            this.listaDeCategoriasToolStripMenuItem.Name = "listaDeCategoriasToolStripMenuItem";
            this.listaDeCategoriasToolStripMenuItem.Size = new System.Drawing.Size(368, 34);
            this.listaDeCategoriasToolStripMenuItem.Text = "Lista de Categorias";
            // 
            // listaDeProductosToolStripMenuItem
            // 
            this.listaDeProductosToolStripMenuItem.Name = "listaDeProductosToolStripMenuItem";
            this.listaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(368, 34);
            this.listaDeProductosToolStripMenuItem.Text = "Lista de Productos";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(365, 6);
            // 
            // facturaciónPorClienteToolStripMenuItem
            // 
            this.facturaciónPorClienteToolStripMenuItem.Name = "facturaciónPorClienteToolStripMenuItem";
            this.facturaciónPorClienteToolStripMenuItem.Size = new System.Drawing.Size(368, 34);
            this.facturaciónPorClienteToolStripMenuItem.Text = "Facturación por Cliente";
            // 
            // facturaciónPorUsuariosToolStripMenuItem
            // 
            this.facturaciónPorUsuariosToolStripMenuItem.Name = "facturaciónPorUsuariosToolStripMenuItem";
            this.facturaciónPorUsuariosToolStripMenuItem.Size = new System.Drawing.Size(368, 34);
            this.facturaciónPorUsuariosToolStripMenuItem.Text = "Facturación por Usuarios";
            // 
            // TSTHORA
            // 
            this.TSTHORA.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSTHORA.AutoToolTip = true;
            this.TSTHORA.Enabled = false;
            this.TSTHORA.Font = new System.Drawing.Font("Sylfaen", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSTHORA.ForeColor = System.Drawing.Color.Transparent;
            this.TSTHORA.Name = "TSTHORA";
            this.TSTHORA.ReadOnly = true;
            this.TSTHORA.Size = new System.Drawing.Size(360, 33);
            this.TSTHORA.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Sylfaen", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.TSTHORA});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1098, 37);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuClientes,
            this.MnuUsuariosGestion,
            this.MnuProductosGestion,
            this.toolStripSeparator1,
            this.MnuEmpresaGestion});
            this.mantenimientosToolStripMenuItem.Image = global::FacturacionPE.Properties.Resources._2799204_management_99783;
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(222, 33);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // MnuClientes
            // 
            this.MnuClientes.Name = "MnuClientes";
            this.MnuClientes.Size = new System.Drawing.Size(224, 34);
            this.MnuClientes.Text = "Clientes";
            this.MnuClientes.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // MnuUsuariosGestion
            // 
            this.MnuUsuariosGestion.Name = "MnuUsuariosGestion";
            this.MnuUsuariosGestion.Size = new System.Drawing.Size(224, 34);
            this.MnuUsuariosGestion.Text = "Usuarios";
            this.MnuUsuariosGestion.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // MnuProductosGestion
            // 
            this.MnuProductosGestion.Name = "MnuProductosGestion";
            this.MnuProductosGestion.Size = new System.Drawing.Size(224, 34);
            this.MnuProductosGestion.Text = "Productos";
            this.MnuProductosGestion.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // MnuEmpresaGestion
            // 
            this.MnuEmpresaGestion.Name = "MnuEmpresaGestion";
            this.MnuEmpresaGestion.Size = new System.Drawing.Size(224, 34);
            this.MnuEmpresaGestion.Text = "Empresa";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFacturacion});
            this.procesosToolStripMenuItem.Image = global::FacturacionPE.Properties.Resources.images;
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(139, 33);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // MnuFacturacion
            // 
            this.MnuFacturacion.Name = "MnuFacturacion";
            this.MnuFacturacion.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.MnuFacturacion.Size = new System.Drawing.Size(307, 34);
            this.MnuFacturacion.Text = "Facturación";
            this.MnuFacturacion.Click += new System.EventHandler(this.facturaciónToolStripMenuItem_Click);
            // 
            // FrmMDIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1098, 420);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMDIPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Facturación";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMDIPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FrmMDIPrincipal_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel LblUsuarioLog;
        private System.Windows.Forms.Timer TmrFecha;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuClientes;
        private System.Windows.Forms.ToolStripMenuItem MnuUsuariosGestion;
        private System.Windows.Forms.ToolStripMenuItem MnuProductosGestion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MnuEmpresaGestion;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuFacturacion;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem facturaciónPorClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaciónPorUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox TSTHORA;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}