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
    public partial class FrmClienteGestion : Form
    {

        public Logica.Models.Cliente MiClienteLocal { get; set; }

        public FrmClienteGestion()
        {
            InitializeComponent();
            MiClienteLocal = new Logica.Models.Cliente();
        }

        

        private void FrmClienteGestion_Load(object sender, EventArgs e)
        {

            MdiParent = ObjetosGlobales.MiFormularioPrincipal;

            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            TxTCodigoCliente.Clear();
            TxTNombreCliente.Clear();
            TxTCedulaCliente.Clear();
            TxtTelefonoCliente.Clear();
            TxTEmailCliente.Clear();

            CboxTipoCliente.SelectedIndex = -1;

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpiarForm_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
