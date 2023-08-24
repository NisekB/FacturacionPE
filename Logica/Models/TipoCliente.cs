using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class TipoCliente
    {
        public int IDTipoCliente { get; set; }
        public string Descripcion { get; set; }



        public DataTable Listar(bool VerActivos = true)
        {
            DataTable R = new DataTable();
            Conexion MiCnn = new Conexion();
            R = MiCnn.EjecutarSelect("SpClienteRolListar");


            return R;
        }


    }
}