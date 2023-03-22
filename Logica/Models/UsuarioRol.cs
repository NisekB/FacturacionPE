using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class UsuarioRol
    {
        public int IDRol;
        public string Descripcion;



        public DataTable Listar(bool VerActivos = true)
        {
            DataTable R = new DataTable();
            Conexion MiCnn = new Conexion();
            R = MiCnn.EjecutarSelect("SpUsuarioRolListar");


            return R;
        }

    }
}