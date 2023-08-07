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
    public partial class FrmClienteListar : Form
    {

        DataTable ListaClientes = new DataTable();

        public Logica.Models.Cliente MiCliente { get; set; }

        public FrmClienteListar()
        {
            InitializeComponent();

            MiCliente = new Logica.Models.Cliente();
        }

        private void FrmClienteListar_Load(object sender, EventArgs e)
        {
            LlenarListaClientes();
        }

        private void LlenarListaClientes(string Filtro = "")
        {
            ListaClientes = new DataTable();

            ListaClientes = MiCliente.Listar(true, Filtro);

            DgvLista.DataSource = ListaClientes;

            DgvLista.ClearSelection();


        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (DgvLista.SelectedRows.Count == 1)
            {
                DataGridViewRow Fila = DgvLista.SelectedRows[0];

                int IDCliente = Convert.ToInt32(Fila.Cells["CIDCliente"].Value);

                string Nombre = Convert.ToString(Fila.Cells["CNombre"].Value);
                string Cedula = Convert.ToString(Fila.Cells["CCedula"].Value);
                string Telefono = Convert.ToString(Fila.Cells["CTelefono"].Value);

                ObjetosGlobales.MiFormDeFacturacion.FacturaLocal.MiCliente.IDCliente = IDCliente;
                ObjetosGlobales.MiFormDeFacturacion.FacturaLocal.MiCliente.Nombre = Nombre;
                ObjetosGlobales.MiFormDeFacturacion.FacturaLocal.MiCliente.Cedula = Cedula;
                ObjetosGlobales.MiFormDeFacturacion.FacturaLocal.MiCliente.Telefono = Telefono;

                DialogResult = DialogResult.OK;
            }           
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }

        private void TxTBuscarCliente_KeyDown(object sender, KeyEventArgs e)
        {
            TmrBuscarCliente.Enabled = false;
        }

        private void TxTBuscarCliente_KeyUp(object sender, KeyEventArgs e)
        {
            TmrBuscarCliente.Enabled = true;
        }

        private void TmrBuscarCliente_Tick(object sender, EventArgs e)
        {
            TmrBuscarCliente.Enabled = false;

            if (!string.IsNullOrEmpty(TxTBuscarCliente.Text.Trim()))
            {
                string Filtro = TxTBuscarCliente.Text.Trim();
                LlenarListaClientes(Filtro);
            }
            else
            {
                LlenarListaClientes();
            }
        }

        private void DgvLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvLista.ClearSelection();
        }
    }
}
