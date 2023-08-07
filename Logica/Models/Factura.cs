using System;
using System.Collections.Generic;
using System.Data;
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