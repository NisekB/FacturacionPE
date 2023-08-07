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
    public partial class FrmProductosGestion : Form
    {

        public Logica.Models.Producto MiProductoLocal { get; set; }

        DataTable ListaProductos = new DataTable();


        public FrmProductosGestion()
        {
            InitializeComponent();
            MiProductoLocal = new Logica.Models.Producto();
        }

        private void FrmProductosGestion_Load(object sender, EventArgs e)
        {

            MdiParent = ObjetosGlobales.MiFormularioPrincipal;

            ListarProductos();
            CargarImpuestoProducto();
            CargarCategoriaProducto();
            ActivarAgregar();

        }

        private void ActivarAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnEditar.Enabled = false;
        }

        private void ActivarEditar()
        {
            BtnAgregar.Enabled = false;
            BtnEditar.Enabled = true;
        }


        private void CargarImpuestoProducto()
        {

            Logica.Models.Impuesto ObjImpuestoProducto = new Logica.Models.Impuesto();
            DataTable ListaImpuestos = new DataTable();
            ListaImpuestos = ObjImpuestoProducto.Listar();

            CboxTipoImpuesto.ValueMember = "IDI";
            CboxTipoImpuesto.DisplayMember = "MontoI";

            CboxTipoImpuesto.DataSource = ListaImpuestos;
            CboxTipoImpuesto.SelectedIndex = -1;

        }

        private void CargarCategoriaProducto()
        {

            Logica.Models.ProductoCategoria ObjCategoriaProducto = new Logica.Models.ProductoCategoria();
            DataTable ListarCategoria = new DataTable();
            ListarCategoria = ObjCategoriaProducto.Listar();

            CboxTipoCategoria.ValueMember = "IDC";
            CboxTipoCategoria.DisplayMember = "DesCateg";

            CboxTipoCategoria.DataSource = ListarCategoria;
            CboxTipoCategoria.SelectedIndex = -1;

        }




        private void ListarProductos()
        {

            Logica.Models.Producto MiProducto = new Logica.Models.Producto();
            DataTable dt = MiProducto.ListarProductos();

            DgvListaProductos.DataSource = dt;

            DgvListaProductos.ClearSelection();
        }

        private void LimpiarFormulario()
        {
            TxTCodigoProduc.Clear();
            TxTCodBarras.Clear();
            TxTDescripcion.Clear();
            TxtCantidad.Clear();
            TxTPrecio.Clear();


            CboxTipoImpuesto.SelectedIndex = -1;
            CboxTipoCategoria.SelectedIndex = -1;

            ActivarAgregar();
        }

        private void BtnLimpiarForm_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            ActivarAgregar();
            
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }



        private bool ValidarDatosRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxTDescripcion.Text.Trim()) &&     
                !string.IsNullOrEmpty(TxtCantidad.Text.Trim())  &&
                !string.IsNullOrEmpty(TxTPrecio.Text.Trim()) &&
                CboxTipoCategoria.SelectedIndex > -1 &&
                CboxTipoImpuesto.SelectedIndex > -1     
                )
            {
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(TxTDescripcion.Text.Trim()))
                {
                    MessageBox.Show("La descripción del producto es requerida", "Error de Validación", MessageBoxButtons.OK);
                    TxTDescripcion.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(TxtCantidad.Text.Trim()))
                {
                    MessageBox.Show("La cantidad del producto es requerida", "Error de Validación", MessageBoxButtons.OK);
                    TxtCantidad.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(TxTPrecio.Text.Trim()))
                {
                    MessageBox.Show("El precio del producto es requerido", "Error de Validación", MessageBoxButtons.OK);
                    TxTPrecio.Focus();
                    return false;
                }
                if (CboxTipoCategoria.SelectedIndex == -1)
                {
                    MessageBox.Show("La categoria del producto es requerida", "Error de Validación", MessageBoxButtons.OK);
                    CboxTipoCategoria.Focus();
                    return false;
                }
                if (CboxTipoImpuesto.SelectedIndex == -1)
                {
                    MessageBox.Show("El impuesto del producto es requerido", "Error de Validación", MessageBoxButtons.OK);
                    CboxTipoImpuesto.Focus();
                    return false;
                }

            }


            return R;
        }




        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {

                string Pregunta = string.Format("¿Está seguro de agregar el Producto {0}?", TxTDescripcion.Text.Trim());
                DialogResult RespuestaUsuario = MessageBox.Show(Pregunta, "????", MessageBoxButtons.YesNo);

                if (RespuestaUsuario == DialogResult.Yes)
                {
                    MiProductoLocal.CodigoBarras = TxTCodBarras.Text.Trim();
                    MiProductoLocal.DescripcionProducto = TxTDescripcion.Text.Trim();
                    MiProductoLocal.Cantidad = Convert.ToInt32(TxtCantidad.Text.Trim()); //Verificar si es ToInt32 al ser Decimal el atributo
                    MiProductoLocal.PrecioUnitario = Convert.ToInt32(TxTPrecio.Text.Trim()); //Verificar si es ToInt32 al ser Decimal el atributo
                    MiProductoLocal.MiImpuesto.IDImpuesto = Convert.ToInt32(CboxTipoImpuesto.SelectedValue);
                    MiProductoLocal.MiCategoria.IDProductoCategoria = Convert.ToInt32(CboxTipoCategoria.SelectedValue);


                    bool A = MiProductoLocal.ConsultarPorCodigoDeBarras();
                    bool B = MiProductoLocal.ConsultarPorDescripcion();

                    if (!A && !B)
                    {
                        if (MiProductoLocal.Agregar())
                        {
                            MessageBox.Show("Usuario Agregado Correctamente!", ":)", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error y el producto no sido guardado", ":(", MessageBoxButtons.OK);
                        }

                        ListarProductos();
                        LimpiarFormulario();

                    }
                    else
                    {

                        if (A)
                        {
                            MessageBox.Show("Ya existe un producto con ese Codigo de Barras", "Error de Validación", MessageBoxButtons.OK);
                            TxTCodBarras.Focus();
                            TxTCodBarras.SelectAll();
                        }
                        if (B)
                        {
                            MessageBox.Show("Ya existe un producto con esa misma descripción", "Error de Validación", MessageBoxButtons.OK);
                            TxTDescripcion.Focus();
                            TxTDescripcion.SelectAll();
                        }
                    }

                }
                
            }

            




        }

        private void DgvListaProductos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaProductos.ClearSelection();
        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresNumeros(e, false);
        }

        private void TxTPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresNumeros(e, true);
            
        }

        private void TxTDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresTexto(e);
        }

        private void TxTCodBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresTexto(e, false, true);
        }

        private void DgvListaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaProductos.SelectedRows.Count == 1)
            {
                DataGridViewRow Fila = DgvListaProductos.SelectedRows[0];

                int IDUsuarioSeleccionado = Convert.ToInt32(Fila.Cells["CIDProducto"].Value);

                MiProductoLocal = new Logica.Models.Producto();
                MiProductoLocal = MiProductoLocal.ConsultarPorID(IDUsuarioSeleccionado);

                if (MiProductoLocal.IDProducto > 0)
                {
                    LimpiarFormulario();

                    TxTCodigoProduc.Text = MiProductoLocal.IDProducto.ToString();
                    TxTCodBarras.Text = MiProductoLocal.CodigoBarras;
                    TxTDescripcion.Text = MiProductoLocal.DescripcionProducto;
                    TxtCantidad.Text = MiProductoLocal.Cantidad.ToString();
                    TxTPrecio.Text = MiProductoLocal.PrecioUnitario.ToString();

                    CboxTipoCategoria.SelectedValue = MiProductoLocal.MiCategoria.IDProductoCategoria;
                    CboxTipoImpuesto.SelectedValue = MiProductoLocal.MiImpuesto.IDImpuesto;

                    ActivarEditar();



                }

            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {
                string Mensaje = string.Format("¿Desea continuar con la modificación del Producto {0}?", TxTDescripcion.Text.Trim());

                DialogResult Respuesta = MessageBox.Show(Mensaje, "???", MessageBoxButtons.YesNo);

                if (Respuesta == DialogResult.Yes)
                {
                    MiProductoLocal.CodigoBarras = TxTCodBarras.Text.Trim();
                    MiProductoLocal.DescripcionProducto = TxTDescripcion.Text.Trim();
                    MiProductoLocal.Cantidad = Convert.ToInt32(TxtCantidad.Text.Trim()); //Verificar si es ToInt32 al ser Decimal el atributo
                    MiProductoLocal.PrecioUnitario = Convert.ToInt32(TxTPrecio.Text.Trim()); //Verificar si es ToInt32 al ser Decimal el atributo
                    MiProductoLocal.MiImpuesto.IDImpuesto = Convert.ToInt32(CboxTipoImpuesto.SelectedValue);
                    MiProductoLocal.MiCategoria.IDProductoCategoria = Convert.ToInt32(CboxTipoCategoria.SelectedValue);

                    if (MiProductoLocal.Editar())
                    {
                        string MsjExito = string.Format("El Producto {0} se ha modificado correctamente", MiProductoLocal.DescripcionProducto);

                        MessageBox.Show(MsjExito, ":D", MessageBoxButtons.OK);

                        ListarProductos();
                        LimpiarFormulario();
                        ActivarAgregar();

                    }
                    else
                    {
                        string MsjExito = string.Format("El Producto {0} NO se ha podido modificado correctamente", MiProductoLocal.DescripcionProducto);

                        MessageBox.Show(MsjExito, ":C", MessageBoxButtons.OK);

                    }

                }
            }
        }

        private void TxTBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            TmrBuscarProducto.Enabled = false;
        }

        private void TxTBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            TmrBuscarProducto.Enabled = true;
        }

        private void LlenarListaProducto(string Filtro = "")
        {
            ListaProductos = new DataTable();

            ListaProductos = MiProductoLocal.Listar(true, Filtro);

            DgvListaProductos.DataSource = ListaProductos;

            DgvListaProductos.ClearSelection();
        }

        private void TmrBuscarProducto_Tick(object sender, EventArgs e)
        {

            TmrBuscarProducto.Enabled = false;

            if (!string.IsNullOrEmpty(TxTBuscar.Text.Trim()))
            {
                string Filtro = TxTBuscar.Text.Trim();
                LlenarListaProducto(Filtro);
            }
            else
            {
                LlenarListaProducto();
            }

        }
    }
}
