using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Impuesto
    {
        public int IDImpuesto { get; set; }
        public string Descripcion { get; set; }
        public string codigoImpuesto { get; set; }
        public decimal MontoImpuesto { get; set; }



        public DataTable Listar(bool VerActivos = true)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSelect("SpImpuestoListar");



            return R;
        }

    }
}