using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionPE
{
    public static class ObjetosGlobales
    {
        public static Logica.Models.Usuario MiUsuarioGlobal = new Logica.Models.Usuario();


        public static Form MiFormularioPrincipal = new Formularios.FrmMDIPrincipal();

        public static Formularios.FrmUsuariosGestion MiFormDeGestionDeUsuarios = new Formularios.FrmUsuariosGestion();
        public static Formularios.FrmProductosGestion MiFormDeGestionProductos = new Formularios.FrmProductosGestion();
        public static Formularios.FrmClienteGestion MiFormDeGestionClientes = new Formularios.FrmClienteGestion();

    }
}
