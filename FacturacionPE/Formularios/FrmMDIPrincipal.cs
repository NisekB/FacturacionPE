using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionPE.Formularios
{
    public partial class FrmMDIPrincipal : Form
    {
        public FrmMDIPrincipal()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ObjetosGlobales.MiFormDeGestionDeUsuarios.Visible)
            {
                ObjetosGlobales.MiFormDeGestionDeUsuarios = new FrmUsuariosGestion();
                ObjetosGlobales.MiFormDeGestionDeUsuarios.Show();
            }
        }

        private void FrmMDIPrincipal_Load(object sender, EventArgs e)
        {
            string UsuarioLog = string.Format("{0} ({1})", 
                ObjetosGlobales.MiUsuarioGlobal.Nombre,
                ObjetosGlobales.MiUsuarioGlobal.MiRol.Descripcion);

            LblUsuarioLog.Text = UsuarioLog;

            switch (ObjetosGlobales.MiUsuarioGlobal.MiRol.IDRol)
            {
                case 1:
                    break;

                case 2:

                    MnuUsuariosGestion.Enabled = false;
                    MnuProductosGestion.Enabled = false;
                    MnuEmpresaGestion.Enabled = false;

                    break;
            }

            TmrFecha.Enabled = true;


        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ObjetosGlobales.MiFormDeGestionProductos.Visible)
            {
                ObjetosGlobales.MiFormDeGestionProductos = new FrmProductosGestion();
                ObjetosGlobales.MiFormDeGestionProductos.Show();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ObjetosGlobales.MiFormDeGestionClientes.Visible)
            {
                ObjetosGlobales.MiFormDeGestionClientes = new FrmClienteGestion();
                ObjetosGlobales.MiFormDeGestionClientes.Show();
            }
        }

        private void FrmMDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TmrFecha_Tick(object sender, EventArgs e)
        {
            string Fecha = DateTime.Now.ToLongDateString() + " | " + DateTime.Now.ToShortTimeString();
         
            TSTHORA.Text = Fecha;
        }

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ObjetosGlobales.MiFormDeFacturacion.Visible)
            {
                ObjetosGlobales.MiFormDeFacturacion = new FrmFacturacion();
                ObjetosGlobales.MiFormDeFacturacion.Show();
            }

        }
    }
}
