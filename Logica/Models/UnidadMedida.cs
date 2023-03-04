using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class UnidadMedida
    {
        public int IDUnidadMedida { get; set; }
        public string Descripcion { get; set; }


        public DataTable Listar(bool VerActivos = true)
        {
            DataTable R = new DataTable();



            return R;
        }



    }
}