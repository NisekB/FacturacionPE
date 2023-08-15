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
    public partial class FrmFacturacionItemGestion : Form
    {

        DataTable ListaProductos { get; set; }

        public Logica.Models.Producto MiProducto { get; set; }

        public FrmFacturacionItemGestion()
        {
            InitializeComponent();

            ListaProductos = new DataTable();
            MiProducto = new Logica.Models.Producto();

        }

        private void DgvListaProductos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaProductos.ClearSelection();
        }

        private void FrmFacturacionItemGestion_Load(object sender, EventArgs e)
        {
            LlenarListaProductos();
        }

        private void LlenarListaProductos(string Filtro = "")
        {
            ListaProductos = new DataTable();
            ListaProductos = MiProducto.Listar();

            DgvListaProductos.DataSource = ListaProductos;
            DgvListaProductos.ClearSelection();
        }



        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (ValdarItems())
            {
                DataRow NewLineaDetalleEnFacturacion = ObjetosGlobales.MiFormDeFacturacion.ListaDetallesLocal.NewRow();



                NewLineaDetalleEnFacturacion["IDProducto"] = MiProducto.IDProducto;
                NewLineaDetalleEnFacturacion["DescripcionProducto"] = MiProducto.DescripcionProducto;
                NewLineaDetalleEnFacturacion["CantidadFacturada"] = TxTCantidad.Value;
                NewLineaDetalleEnFacturacion["PrecioUnitario"] = MiProducto.PrecioUnitario;
                NewLineaDetalleEnFacturacion["PorcentajeDescuento"] = Convert.ToDecimal(TxTDescuento.Text.Trim());

                //Impuestos
                decimal PorcentajeDescuento = Convert.ToDecimal(TxTDescuento.Text.Trim());
                decimal PrecioMenosDescuento = MiProducto.PrecioUnitario - ((MiProducto.PrecioUnitario * PorcentajeDescuento) / 100);
                decimal Impuestos = ((PrecioMenosDescuento * MiProducto.MiImpuesto.MontoImpuesto) / 100) * TxTCantidad.Value;
                NewLineaDetalleEnFacturacion["ImpuestosLinea"] = Impuestos;
                //Impuestos


                decimal TotalLinea = PrecioMenosDescuento * TxTCantidad.Value + Impuestos;
                NewLineaDetalleEnFacturacion["TotalLinea"] = TotalLinea;

                NewLineaDetalleEnFacturacion["SubTotalLinea"] = TxTCantidad.Value * PrecioMenosDescuento;


                ObjetosGlobales.MiFormDeFacturacion.ListaDetallesLocal.Rows.Add(NewLineaDetalleEnFacturacion);
                DialogResult = DialogResult.OK;



            }

        }

        private bool ValdarItems()
        {
            bool R = false;

            if (DgvListaProductos.SelectedRows.Count == 1 && TxTCantidad.Value > 0)
            {
                R = true;
            }
            else
            {
                if (DgvListaProductos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe Seleccionar un Item de la lista!", "Error de Validación", MessageBoxButtons.OK);
                    return false;
                }
                if (TxTCantidad.Value == 0)
                {
                    MessageBox.Show("No se puede seleccionar un item con cantidad en 0", "Error de Validación", MessageBoxButtons.OK);
                    return false;
                }
            }



            return R;
        }

        private void TotalizarPrecio(Logica.Models.Producto pProducto, decimal PorcenDescuento)
        {

            decimal PrecioConDescuento = pProducto.PrecioUnitario - ((pProducto.PrecioUnitario * PorcenDescuento) / 100);

            decimal PrecioConImpuesto = PrecioConDescuento + ((PrecioConDescuento * pProducto.MiImpuesto.MontoImpuesto)/ 100);

            TxTPrecioFinal.Text = PrecioConImpuesto.ToString();



        }



        private void DgvListaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaProductos.SelectedRows.Count == 1)
            {
                DataGridViewRow Fila = DgvListaProductos.SelectedRows[0];
                int IDProductoSeleccionador = Convert.ToInt32(Fila.Cells["CIDProducto"].Value);

                MiProducto = MiProducto.ConsultarID(IDProductoSeleccionador);

                if (MiProducto.IDProducto > 0)
                {

                    TxTIVA.Text = MiProducto.MiImpuesto.MontoImpuesto.ToString();
                    TxTPrecioUnidad.Text = MiProducto.PrecioUnitario.ToString();

                    TotalizarPrecio(MiProducto, Convert.ToDecimal(TxTDescuento.Text.Trim()));

                }
            }
        }

        private void TxTDescuento_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxTDescuento.Text.Trim()))
            {
                TxTDescuento.Text = "0";
                TxTDescuento.SelectAll();
            }
            else
            {
                TotalizarPrecio(MiProducto, Convert.ToDecimal(TxTDescuento.Text.Trim()));
            }
        }

        private void TxTDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresNumeros(e, true);
      

        }

        private void TxTDescuento_Leave(object sender, EventArgs e)
        {
            //if (TxTDescuento.Value > 100)
            //{
             //   MessageBox.Show("Solo se puede seleccionar un descuento entre 0 y 100!", "Error de Validación", MessageBoxButtons.OK);
             //   TxTDescuento.Focus();
            //    TxTDescuento.SelectAll();
           // }
        }
    }
}
