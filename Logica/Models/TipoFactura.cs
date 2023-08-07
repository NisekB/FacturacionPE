using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class TipoFactura
    {
        public int IDFacturaTipo;


        public int IDFacturaTIpo
        {
            get { return IDFacturaTipo; }
            set { IDFacturaTipo = value; }
        }

        public string Descripcion { get; set; }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MyCnn = new Conexion();

            R = MyCnn.EjecutarSelect("SpFacturasTipoListar");

            return R;
        }




    }
}