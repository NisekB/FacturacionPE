using Logica.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FacturacionPE.Formularios
{
    public partial class FrmFacturacion : Form
    {
        public Logica.Models.Factura FacturaLocal { get; set; }
        public Logica.Models.FacturaDetalle MiDetalleLocal { get; set; }

        public DataTable ListaDetallesLocal { get; set; }

        public int countRowList = 0;
        public int CantidadProducto = 0;
        public int IDproduct = 0;

        public decimal SubTotalLinea { get; set; }
        public decimal PorcentajeDescuento { get; set; }
        public decimal Subtotal2 { get; set; }
        public decimal ImpuestoLinea { get; set; }
        public decimal TotalLinea { get; set; }
        public string Anotaciones { set; get; }
        public decimal PrecioUnitario { get; set; }
        public decimal Cantidad { get; set; }

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

        private void BtnItemModificar_Click(object sender, EventArgs e)
        {

            Logica.Models.FacturaDetalle Detalle = new Logica.Models.FacturaDetalle();
            Logica.Models.Factura Fact = new Logica.Models.Factura();
            Factura R = new Factura();    

            //if (DgvListaItems.SelectedRows.Count == 1)
            //{
            //    Form MiFrm = new FrmFacturaciónItemGestionCantidad();
            //    DialogResult cambio = MiFrm.ShowDialog();
            //    if (cambio == DialogResult.OK)
            //    {
            //        DgvListaItems.DataSource = ListaDetallesLocal;
            //        TotalizarFactura();
            //    }

            //}

            if (DgvListaItems.SelectedRows.Count == 1)
            //if (DgvListaItems.Rows.Count > 0 && countRowList == 1)
            {
                DataGridViewRow r = DgvListaItems.SelectedRows[0];
                IDproduct = Convert.ToInt32(r.Cells["CIDProducto"].Value);
                CantidadProducto = Convert.ToInt32(r.Cells["CCantidadFacturada"].Value);


                Detalle.PrecioUnitario = Convert.ToDecimal(r.Cells["CPrecioUnitario"].Value);
                Detalle.ImpuestoLinea = Convert.ToDecimal(r.Cells["CImpuestosLinea"].Value);
                Detalle.PorcentajeDescuento = Convert.ToDecimal(r.Cells["CPorcentajeDescuento"].Value);
                Detalle.SubTotalLinea = Convert.ToDecimal(r.Cells["CSubTotalLinea"].Value);
                Detalle.TotalLinea = Convert.ToDecimal(r.Cells["CTotalLinea"].Value);
       

                //Detalle.PrecioUnitario = (Decimal)Convert.ToDouble(r.Cells["CPrecioUnitario"].Value);
                //Detalle.ImpuestoLinea = (Decimal)Convert.ToDouble(r.Cells["CImpuestosLinea"].Value);
                //Detalle.PorcentajeDescuento = (Decimal)Convert.ToDouble(r.Cells["CPorcentajeDescuento"].Value);
                //Detalle.SubTotalLinea = (Decimal)Convert.ToDouble(r.Cells["CSubTotalLinea"].Value);
                //Detalle.TotalLinea = (Decimal)Convert.ToDouble(r.Cells["CTotalLinea"].Value);



                //R.IDUsuario = Convert.ToInt32(MisDatos["IDUsuario"]);


                Form FormGestionCantidad = new FrmFacturaciónItemGestionCantidad();
                DialogResult resp = FormGestionCantidad.ShowDialog();

                if (resp == DialogResult.OK)
                {
                    //r.Cells["CCantidad"].Value = CantidadProducto;

                    foreach (DataRow Row in ListaDetallesLocal.Rows)
                    {
                        if (Convert.ToInt32(Row["IDProducto"]) == IDproduct)
                        {
                            TotalizarFactura();
                            //CalcularNuevosDatos();

                            Row["PrecioUnitario"] = Detalle.PrecioUnitario;                           
                            Row["PorcentajeDescuento"] = Detalle.PorcentajeDescuento;
                            //Row["ImpuestoLinea"] = Detalle.ImpuestoLinea;
                            Row["SubTotalLinea"] = Detalle.SubTotalLinea;
                            Row["TotalLinea"] = Detalle.TotalLinea;
                            Row["CantidadFacturada"] = CantidadProducto;


                        }
                    }
                    DgvListaItems.DataSource = DgvListaItems;
                    DgvListaItems.ClearSelection();

                    TotalizarFactura();
                    countRowList = 0;
                }
                else
                {
                    MessageBox.Show("Modificación del Item Cancelada",
                        "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CantidadProducto = 0;
                }
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una Fila (Item), presionando o " +
                    "dando click en el nombre, o precio del *ITEM* en la lista",
                    "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CantidadProducto = 0;
            }

        }

        private void BtnItemAgregar_Click(object sender, EventArgs e)
        {
            Form FormSeleccionProductos = new Formularios.FrmFacturacionItemGestion();

            DialogResult Respuesta = FormSeleccionProductos.ShowDialog();

            if (Respuesta == DialogResult.OK)
            {
                DgvListaItems.DataSource = ListaDetallesLocal;

                TotalizarFactura();

            }

        }

        private void TotalizarFactura()
        {
            if (ListaDetallesLocal != null && ListaDetallesLocal.Rows.Count > 0)
            {
                decimal Subtotal = 0;
                decimal Descuentos = 0;
                decimal Impuestos = 0;
                decimal Total = 0;

                foreach (DataRow item in ListaDetallesLocal.Rows)
                {
                    Subtotal += Convert.ToDecimal(item["CantidadFacturada"]) * Convert.ToDecimal(item["PrecioUnitario"]);
                    Descuentos += Subtotal * Convert.ToDecimal(item["PorcentajeDescuento"]) / 100;
                    Impuestos += Convert.ToDecimal(item["ImpuestosLinea"]);
                    Total += Convert.ToDecimal(item["TotalLinea"]);
                }

                LblSubTotal.Text = string.Format("{0:C2}", Subtotal);
                LblDescuentos.Text = string.Format("{0:C2}", Descuentos);
                LblImpuestos.Text = string.Format("{0:C2}", Impuestos);
                LblTotal.Text = string.Format("{0:C2}", Total);
            }
        }

        private void CargarDetalleDeLaFactura()
        {
            foreach (DataRow item in ListaDetallesLocal.Rows)
            {
                Logica.Models.FacturaDetalle Detalle = new Logica.Models.FacturaDetalle();

                Detalle.MiProducto.IDProducto = Convert.ToInt32(item["IDProducto"]);
                Detalle.DescripcionProducto = Convert.ToString(item["DescripcionProducto"]);
                Detalle.CantidadFacturada = Convert.ToDecimal(item["CantidadFacturada"]);
                Detalle.PrecioUnitario = Convert.ToDecimal(item["PrecioUnitario"]);
                Detalle.PorcentajeDescuento = Convert.ToDecimal(item["PorcentajeDescuento"]);
                Detalle.ImpuestoLinea = Convert.ToDecimal(item["ImpuestosLinea"]);
                Detalle.SubTotalLinea = Convert.ToDecimal(item["SubTotalLinea"]);
                Detalle.TotalLinea = Convert.ToDecimal(item["TotalLinea"]);

                FacturaLocal.DetalleItems.Add(Detalle);


            }
        }

        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            if (ListaDetallesLocal != null && ListaDetallesLocal.Rows.Count > 0)
            {
                string UsuarioLog = string.Format("{0}",
                ObjetosGlobales.MiUsuarioGlobal.Nombre);

                string Pregunta = String.Format("{0} Estás seguro que deseas generar una nueva factura?", UsuarioLog);
                DialogResult RespuestaDelUsuario = MessageBox.Show(Pregunta, "Deseas continuar???", MessageBoxButtons.YesNo);

                if (RespuestaDelUsuario == DialogResult.Yes)
                {
                    FacturaLocal.MiCliente.IDCliente = Convert.ToInt32(TxTIDCliente.Text.Trim());
                    FacturaLocal.MiTipo.IDFacturaTIpo = Convert.ToInt32(CboxTipoFactura.SelectedValue);
                    FacturaLocal.MiUsuario.IDUsuario = Convert.ToInt32(CboxUsuario.SelectedValue);
                    FacturaLocal.MiEmpresa.IDEmpresa = Convert.ToInt32(CboxEmpresa.SelectedValue);
                    FacturaLocal.Fecha = DtpFechaFactura.Value.Date;
                    FacturaLocal.Anotaciones = TxTNotas.Text.Trim();

                    CargarDetalleDeLaFactura();

                    if (FacturaLocal.Agregar())
                    {
                        MessageBox.Show("La Factura a sido generada correctamente", "=D", MessageBoxButtons.OK);
                        LimpiarFormulario();
                    }

                }

                


            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvListaItems.SelectedRows.Count == 1)
            {
                int Indice = DgvListaItems.SelectedRows[0].Index;
                int IDProducto = Convert.ToInt32(DgvListaItems.Rows[Indice].Cells["CIDProducto"].Value);

                foreach (DataRow item in ListaDetallesLocal.Rows)
                {
                    int idx = Convert.ToInt32(item["IDProducto"]);
                    if (idx == IDProducto)
                    {
                        ListaDetallesLocal.Rows.Remove(item);
                        TotalizarFactura();
                        break;
                    }
                }
                ListaDetallesLocal.AcceptChanges();

                DgvListaItems.DataSource = ListaDetallesLocal;
                DgvListaItems.ClearSelection();
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
