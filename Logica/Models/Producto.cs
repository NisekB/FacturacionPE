using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Producto
    {

        public int IDProducto { get; set; }
        public string CodigoBarras { get; set; }
        public string DescripcionProducto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }


        UnidadMedida MiunidadMedida { get; set; }
        ProductoCategoria MiCategoria { get; set; }
        Impuesto MiImpuesto { get; set; }


        public Producto()
        {
            MiunidadMedida = new UnidadMedida();
            MiCategoria = new ProductoCategoria();
            MiImpuesto = new Impuesto();

        }


        public bool Agregar()
        {
            bool R = false;



            return R;

        }

        public bool Editar()
        {
            bool R = false;


            return R;

        }


        public bool Eliminar()
        {
            bool R = false;


            return R;
        }

        public bool ConsultarPorCodigoDeBarras()
        {
            bool R = false;



            return R;

        }

        public bool ConsultarPorID()
        {
            bool R = false;



            return R;

        }

        public DataTable Listar(bool VerActivos = true)
        {
            DataTable R = new DataTable();



            return R;
        }


    }
}