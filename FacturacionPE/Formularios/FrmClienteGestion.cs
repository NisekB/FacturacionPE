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
        
        DataTable ListaClientes = new DataTable();

        public FrmClienteGestion()
        {
            InitializeComponent();
            MiClienteLocal = new Logica.Models.Cliente();
        }

        

        private void FrmClienteGestion_Load(object sender, EventArgs e)
        {

            MdiParent = ObjetosGlobales.MiFormularioPrincipal;

            ListarClientesActivos();

            CargarRolCliente();

            LimpiarFormulario();

            ActivarAgregar();

            LlenarListaClientes();
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

        private void ActivarAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private void ActivarEditarEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;
        }

        private void ListarClientesActivos()
        {
            Logica.Models.Cliente MiCliente = new Logica.Models.Cliente();
            DataTable dt = MiCliente.ListarActivos();

            DgvListaClientes.DataSource = dt;

            DgvListaClientes.ClearSelection();
        }

        private void ListarClientesInactivos()
        {
            Logica.Models.Cliente MiCliente = new Logica.Models.Cliente();
            DataTable dt = MiCliente.ListarInactivos();

            DgvListaClientes.DataSource = dt;

            DgvListaClientes.ClearSelection();
        }

        private bool ValidarDatosRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxTNombreCliente.Text.Trim()) &&
                !string.IsNullOrEmpty(TxTCedulaCliente.Text.Trim()) &&
                CboxTipoCliente.SelectedIndex > -1
                )
            {
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(TxTNombreCliente.Text.Trim()))
                {
                    MessageBox.Show("El nombre del cliente es requerido", "Error de Validación", MessageBoxButtons.OK);
                    TxTNombreCliente.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(TxTCedulaCliente.Text.Trim()))
                {
                    MessageBox.Show("La cédula del cliente es requerida", "Error de Validación", MessageBoxButtons.OK);
                    TxTCedulaCliente.Focus();
                    return false;
                }
                if (CboxTipoCliente.SelectedIndex == -1)
                {
                    MessageBox.Show("El tipo de cliente es requerido", "Error de Validación", MessageBoxButtons.OK);
                    CboxTipoCliente.Focus();
                    return false;
                }
            }


            return R;
        }

        private void CargarRolCliente()
        {
            Logica.Models.TipoCliente ObjRolCliente = new Logica.Models.TipoCliente();
            DataTable ListaRoles = new DataTable();
            ListaRoles = ObjRolCliente.Listar();

            CboxTipoCliente.ValueMember = "ID";
            CboxTipoCliente.DisplayMember = "D";

            CboxTipoCliente.DataSource = ListaRoles;
            CboxTipoCliente.SelectedIndex = -1;

        }

        private void DgvListaClientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaClientes.ClearSelection();
        }

        private void DgvListaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaClientes.SelectedRows.Count == 1)
            {
                DataGridViewRow Fila = DgvListaClientes.SelectedRows[0];

                int IDClienteSeleccionado = Convert.ToInt32(Fila.Cells["CIDCliente"].Value);

                MiClienteLocal = new Logica.Models.Cliente();
                MiClienteLocal = MiClienteLocal.ConsultarPorID(IDClienteSeleccionado);

                if (MiClienteLocal.IDCliente > 0)
                {

                    LimpiarFormulario();

                    TxTCodigoCliente.Text = MiClienteLocal.IDCliente.ToString();
                    TxTNombreCliente.Text = MiClienteLocal.Nombre;
                    TxTCedulaCliente.Text = MiClienteLocal.Cedula;
                    TxtTelefonoCliente.Text = MiClienteLocal.Telefono;
                    TxTEmailCliente.Text = MiClienteLocal.Email;

                    CboxTipoCliente.SelectedValue = MiClienteLocal.MiTipo.IDTipoCliente;

                    ActivarEditarEliminar();
                    if (CbVerActivos.Checked)
                    {
                        GbDetalles.Enabled = true;
                        BtnEditar.Enabled = true;
                    }
                    else
                    {
                        GbDetalles.Enabled = false;
                        BtnEditar.Enabled = false;
                    }

                }

            }
        }

        private void CbVerActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (CbVerActivos.Checked)
            {
                BtnEliminar.Text = "Eliminar";
                ListarClientesActivos();
                LimpiarFormulario();
                ActivarAgregar();
            }
            else
            {
                BtnEliminar.Text = "Activar";
                ListarClientesInactivos();
                LimpiarFormulario();
                ActivarEditarEliminar();

            }
        }

        private void LlenarListaClientes(string Filtro = "")
        {
            ListaClientes = new DataTable();

            ListaClientes = MiClienteLocal.Listar(true, Filtro);

            DgvListaClientes.DataSource = ListaClientes;

            DgvListaClientes.ClearSelection();
        }

        private void TmrBuscar_Tick(object sender, EventArgs e)
        {
            TmrBuscar.Enabled = false;

            if (!string.IsNullOrEmpty(TxTBuscar.Text.Trim()))
            {
                string Filtro = TxTBuscar.Text.Trim();
                LlenarListaClientes(Filtro);
            }
            else
            {
                LlenarListaClientes();
            }
        }

        private void TxTBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            TmrBuscar.Enabled = false;
        }

        private void TxTBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            TmrBuscar.Enabled = true;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {
                string Mensaje = string.Format("¿Desea continuar con la modificación del Cliente {0}?", TxTNombreCliente.Text.Trim());

                DialogResult Respuesta = MessageBox.Show(Mensaje, "???", MessageBoxButtons.YesNo);

                if (Respuesta == DialogResult.Yes)
                {
                    MiClienteLocal.Nombre = TxTNombreCliente.Text.Trim();
                    MiClienteLocal.Cedula = TxTCedulaCliente.Text.Trim();
                    MiClienteLocal.Telefono = TxtTelefonoCliente.Text.Trim();
                    MiClienteLocal.Email = TxTEmailCliente.Text.Trim();
                    MiClienteLocal.MiTipo.IDTipoCliente = Convert.ToInt32(CboxTipoCliente.SelectedValue);
                    

                    if (MiClienteLocal.Modificar())
                    {
                        string MsjExito = string.Format("El Cliente {0} se ha modificado correctamente", MiClienteLocal.Nombre);

                        MessageBox.Show(MsjExito, ":D", MessageBoxButtons.OK);

                        ListarClientesActivos();
                        LimpiarFormulario();
                        ActivarAgregar();

                    }
                    else
                    {
                        string MsjExito = string.Format("El Cliente {0} NO se ha podido modificado correctamente", MiClienteLocal.Nombre);

                        MessageBox.Show(MsjExito, ":C", MessageBoxButtons.OK);

                    }

                }
            }
        }
    }

}



