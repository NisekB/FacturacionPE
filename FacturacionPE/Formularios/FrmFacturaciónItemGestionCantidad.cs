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

namespace FacturacionPE.Formularios
{
    public partial class FrmFacturaciónItemGestionCantidad : Form
    {

        public Logica.Models.Producto MiProducto { get; set; }
        DataTable ListaProductos { get; set; }

        public FrmFacturaciónItemGestionCantidad()
        {
            InitializeComponent();

            ListaProductos = new DataTable();
            MiProducto = new Logica.Models.Producto();
        }

        private void FrmFacturaciónItemGestionCantidad_Load(object sender, EventArgs e)
        {
            MiProducto = new Logica.Models.Producto();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCambiar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {

                DataRow ChangeLineaDetalleEnFacturacion = ObjetosGlobales.MiFormDeFacturacion.ListaDetallesLocal.NewRow();
                DialogResult = DialogResult.OK;

                ChangeLineaDetalleEnFacturacion["CantidadFacturada"] = TxTCantidad.Value;

                //DataGridViewRows newDataRow = ObjetosGlobales.ObjetosGlobales.MiFormDeFacturacion.ListaDetallesLocal.Rows[indexRow];
                //ObjetosGlobales.MiFormDeFacturacion.ListaDetallesLocal.Cell[3].Value = TxTCantidad.Value;

                ObjetosGlobales.MiFormDeFacturacion.ListaDetallesLocal.Rows.Add(ChangeLineaDetalleEnFacturacion);
                DialogResult = DialogResult.OK;

            }
        }


        private bool Validar()
        {
            bool R = false;

            if (TxTCantidad.Value > 0)
            {
                R = true;
            }
            else
            {
                if (TxTCantidad.Value == 0)
                {
                    MessageBox.Show("No se puede cambiar el valor a 0", "Error de Validación", MessageBoxButtons.OK);
                    return false;
                }
            }



            return R;
        }

    }
}
