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
    public partial class FrmFacturacion : Form
    {
        public Logica.Models.Factura FacturaLocal { get; set; }

        public DataTable ListaDetallesLocal { get; set; }

        public FrmFacturacion()
        {
            InitializeComponent();
            FacturaLocal = new Logica.Models.Factura();
            ListaDetallesLocal = new DataTable();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            MdiParent = ObjetosGlobales.MiFormularioPrincipal;

            CargarEmpresa();
            CargarFacturaTipo();
            CargarUsuarios();

            LimpiarFormulario();

        }

        private void LimpiarFormulario()
        {
            CboxUsuario.SelectedValue = ObjetosGlobales.MiUsuarioGlobal.IDUsuario;
            CboxTipoFactura.SelectedIndex = -1;
            DtpFechaFactura.Value = DateTime.Now.Date;
            TxTNotas.Clear();

            LblSubTotal.Text = "0";
            LblDescuentos.Text = "0";
            LblImpuestos.Text = "0";
            LblTotal.Text = "0";

            TxTIDCliente.Clear();
            LblNombreCliente.Text = "";

            FacturaLocal = new Logica.Models.Factura();

            ListaDetallesLocal = new DataTable();
            ListaDetallesLocal = FacturaLocal.AsignarEsquemaDetalle();

            DgvListaItems.DataSource = ListaDetallesLocal;

        }

        private void CargarUsuarios()
        {
            CboxUsuario.DisplayMember = "Nombre";
            CboxUsuario.ValueMember = "IDUsuario";
            CboxUsuario.DataSource = FacturaLocal.MiUsuario.ListarActivos();

            //El ComboBox aparecera en blanco, si se deseara agregar un usuario por defecto
            //cambiar el número por el deseado
            CboxUsuario.SelectedIndex = -1;
            //CboxUsuario.SelectedIndex = ObjetosGlobales.MiUsuarioGlobal.IDUsuario;
            //CboxUsuario.SelectedValue = ObjetosGlobales.MiUsuarioGlobal.IDUsuario;

        }

        private void CargarEmpresa()
        {
            CboxEmpresa.DisplayMember = "desc";
            CboxEmpresa.ValueMember = "ID";
            CboxEmpresa.DataSource = FacturaLocal.MiEmpresa.Listar();

            //El ComboBox aparecera en blanco, si se deseara agregar una empresa por defecto
            //cambiar el número por el deseado
            CboxEmpresa.SelectedIndex = -1;

        }

        private void CargarFacturaTipo()
        {
            CboxTipoFactura.DisplayMember = "Descrip";
            CboxTipoFactura.ValueMember = "ID";
            CboxTipoFactura.DataSource = FacturaLocal.MiTipo.Listar();

            //El ComboBox aparecera en blanco, si se deseara agregar un tipo de factura por defecto
            //cambiar el número por el deseado
            CboxTipoFactura.SelectedIndex = -1;

        }

        private void TxTIDCliente_DoubleClick(object sender, EventArgs e)
        {
            Form MiFormularioCliente = new Formularios.FrmClienteListar();
            DialogResult respuesta = MiFormularioCliente.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                LblNombreCliente.Text = FacturaLocal.MiCliente.Nombre;
                TxTIDCliente.Text = FacturaLocal.MiCliente.IDCliente.ToString();
            }
            else
            {
                LblNombreCliente.Text = "";
            }
        }
    }
}
