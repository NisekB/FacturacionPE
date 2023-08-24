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

                ObjetosGlobales.MiFormDeFacturacion.CantidadProducto = Convert.ToInt32(TxTCantidad.Value);
                this.DialogResult = DialogResult.OK;
            }
           
        }


        private bool Validar()
        {
            bool R = false;

            if (Convert.ToInt32(TxTCantidad.Value) > 0)
            {
                R = true;
            }
            else
            {
                if (Convert.ToInt32(TxTCantidad.Value) == 0)
                {
                    MessageBox.Show("No se puede cambiar el valor a 0", "Error de Validación", MessageBoxButtons.OK);
                    return false;
                }
            }
            return R;
        }

        private void TxTCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresNumeros(e, true);
        }
    }
}
