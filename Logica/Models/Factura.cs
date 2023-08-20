using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Factura
    {

        public int IDFactura { get; set; }
        public int NumeroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Descuentos { get; set; }
        public decimal Subtotal2 { get; set; }
        public decimal Impuestos { get; set; }
        public decimal Total { get; set; }
        public string Anotaciones { get; set; }


        public TipoFactura MiTipo { get; set; }
        public Empresa MiEmpresa { get; set; }
        public Cliente MiCliente { get; set; }
        public Usuario MiUsuario { get; set; }


        public List<FacturaDetalle> DetalleItems { get; set; }

        public Factura()
        {
            MiTipo = new TipoFactura();
            MiEmpresa = new Empresa();
            MiCliente = new Cliente();
            MiUsuario = new Usuario();
            DetalleItems = new List<FacturaDetalle>();

        }

        public bool Agregar()
        {
            bool R = false;

            Conexion MyCnn = new Conexion();

            Totalizar();

            MyCnn.ListaParametros.Add(new SqlParameter("@NumeroFactura", this.NumeroFactura));
            MyCnn.ListaParametros.Add(new SqlParameter("@Fecha", this.Fecha));
            MyCnn.ListaParametros.Add(new SqlParameter("@SubTotal", this.Subtotal));
            MyCnn.ListaParametros.Add(new SqlParameter("@Descuentos", this.Descuentos));
            MyCnn.ListaParametros.Add(new SqlParameter("@SubTotal2", this.Subtotal2));
            MyCnn.ListaParametros.Add(new SqlParameter("@Impuestos", this.Impuestos));
            MyCnn.ListaParametros.Add(new SqlParameter("@Total", this.Total));
            MyCnn.ListaParametros.Add(new SqlParameter("@Anotaciones", this.Anotaciones));

            MyCnn.ListaParametros.Add(new SqlParameter("@IDTipo", this.MiTipo.IDFacturaTipo));
            MyCnn.ListaParametros.Add(new SqlParameter("@IDCliente", this.MiCliente.IDCliente));
            MyCnn.ListaParametros.Add(new SqlParameter("@IDUsuario", this.MiUsuario.IDUsuario));
            MyCnn.ListaParametros.Add(new SqlParameter("@IDEmpresa", this.MiEmpresa.IDEmpresa));

            Object Retorno = MyCnn.EjecutarConRetornoEscalar("SpFacturaAgregarEncabezado");

            int IDFacturaRecienCreada = 0;

            if (Retorno != null)
            {
                IDFacturaRecienCreada = Convert.ToInt32(Retorno.ToString());

                foreach (FacturaDetalle item in this.DetalleItems)
                {

                    Conexion MyCnnDetalles = new Conexion();

                    MyCnnDetalles.ListaParametros.Add(new SqlParameter("@IDFactura", IDFacturaRecienCreada));
                    MyCnnDetalles.ListaParametros.Add(new SqlParameter("@IDProducto", item.MiProducto.IDProducto));
                    MyCnnDetalles.ListaParametros.Add(new SqlParameter("@Descripcion", item.DescripcionProducto));
                    MyCnnDetalles.ListaParametros.Add(new SqlParameter("@CantidadFacturada", item.CantidadFacturada));
                    MyCnnDetalles.ListaParametros.Add(new SqlParameter("@PrecioUnitario", item.PrecioUnitario));
                    MyCnnDetalles.ListaParametros.Add(new SqlParameter("@PorcentajeDescuento", item.PorcentajeDescuento));
                    MyCnnDetalles.ListaParametros.Add(new SqlParameter("@SubTotalLinea", item.SubTotalLinea));
                    MyCnnDetalles.ListaParametros.Add(new SqlParameter("@ImpuestosLinea", item.ImpuestoLinea));
                    MyCnnDetalles.ListaParametros.Add(new SqlParameter("@TotalLinea", item.TotalLinea));
          

                    MyCnnDetalles.EjecutarUpdateDeleteInsert("SpFacturaAgregarDetalle");

                }
                R = true;
            }



            return R;

        }

        public DataTable ConsultarPorNumero(int pNumeroFactura)
        {
            DataTable R = new DataTable();

            return R;
        }

        public DataTable ListarPorRangoDeFechas(DateTime pFechaInicial, DateTime pFechaFinal)
        {
            DataTable R = new DataTable();

            return R;
        }

        public DataTable ListarPorCliente(int pIDClientel)
        {
            DataTable R = new DataTable();

            return R;
        }

        public DataTable ListarPorUsuario(int pIDUsuario)
        {
            DataTable R = new DataTable();

            return R;
        }

        private void Totalizar()
        {
            this.NumeroFactura = 1;

            this.Subtotal = 0;
            this.Subtotal2 = 0;
            this.Descuentos = 0;
            this.Total = 0;

        }

        public DataTable AsignarEsquemaDetalle()
        {
            DataTable R = new DataTable();


            Conexion MyCnn = new Conexion();
            R = MyCnn.EjecutarSelect("SpFacturasDetalleEsquema", true);

            R.PrimaryKey = null;


            return R;
        }


    }
}