using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Cliente
    {
        //Atributos Simples
        public int IDCliente { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }

        //Atributo Compuesto
        public TipoCliente MiTipo { get; set; }

        //Constructor de la clase 
        public Cliente()
        {
            //Aca instanciamos los objetos
            MiTipo = new TipoCliente();
        }


        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn4 = new Conexion();

            MiCnn4.ListaParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn4.ListaParametros.Add(new SqlParameter("@Cedula", this.Cedula));
            MiCnn4.ListaParametros.Add(new SqlParameter("@Telefono", this.Telefono));
            MiCnn4.ListaParametros.Add(new SqlParameter("@Email", this.Email));
            MiCnn4.ListaParametros.Add(new SqlParameter("@IDTipoCliente", this.MiTipo.IDTipoCliente));


            int Resultado = MiCnn4.EjecutarUpdateDeleteInsert("SpClienteAgregar");

            if (Resultado > 0)
            {
                R = true;
            }

            return R;

        }

        public bool Modificar()
        {
            bool R = false;

            Cliente ClienteConsulta = new Cliente();
            ClienteConsulta = ConsultarPorID(this.IDCliente);

            if (ClienteConsulta.IDCliente > 0)
            {

                Conexion MyCnn = new Conexion();

                MyCnn.ListaParametros.Add(new SqlParameter("@ID", this.IDCliente));
                MyCnn.ListaParametros.Add(new SqlParameter("@Nombre", this.Nombre));
                MyCnn.ListaParametros.Add(new SqlParameter("@Cedula", this.Cedula));
                MyCnn.ListaParametros.Add(new SqlParameter("@Telefono", this.Telefono));
                MyCnn.ListaParametros.Add(new SqlParameter("@Email", this.Email));
                MyCnn.ListaParametros.Add(new SqlParameter("@IDTipoCliente", this.MiTipo.IDTipoCliente));

                int Resultado = MyCnn.EjecutarUpdateDeleteInsert("SpClienteModificar");

                if (Resultado > 0)
                {

                    R = true;

                }

            }

            return R;

        }

        public bool Eliminar()
        {
            bool R = false;

            Conexion MyCnn = new Conexion();

            MyCnn.ListaParametros.Add(new SqlParameter("@ID", IDCliente));

            if (MyCnn.EjecutarUpdateDeleteInsert("SpClienteDesactivar") > 0) R = true;


            return R;
        }

        public bool Activar()
        {
            bool R = false;

            Conexion MyCnn = new Conexion();

            MyCnn.ListaParametros.Add(new SqlParameter("@ID", IDCliente));

            if (MyCnn.EjecutarUpdateDeleteInsert("SpClienteActivar") > 0) R = true;


            return R;
        }


        public bool ConsultarPorCedula()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();
            MiCnn.ListaParametros.Add(new SqlParameter("@Cedula", this.Cedula));

            DataTable Consulta = MiCnn.EjecutarSelect("SpClienteConsultarPorCedula");

            if (Consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;

        }

        public bool ConsultarPorEmail()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();
            MiCnn.ListaParametros.Add(new SqlParameter("@Email", this.Email));

            DataTable Consulta = MiCnn.EjecutarSelect("SpClienteConsultarPorEmail");

            if (Consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;

        }


        public DataTable Listar(bool VerActivos = true, string Filtro = "")
        {
            DataTable R = new DataTable();

            Conexion MyCnn = new Conexion();

            MyCnn.ListaParametros.Add(new SqlParameter("@filtro", Filtro));

            R = MyCnn.EjecutarSelect("SpClientesListar");

            return R;
        }

        public DataTable ListarActivos()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSelect("SpClienteListarActivos");

            return R;
        }

        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSelect("SpClienteListarInactivos");

            return R;
        }

        public Cliente ConsultarPorID(int pIDCliente)
        {
            Cliente R = new Cliente();

            Conexion MyCnn = new Conexion();

            MyCnn.ListaParametros.Add(new SqlParameter("@ID", pIDCliente));

            DataTable DatosDeCliente = new DataTable();

            DatosDeCliente = MyCnn.EjecutarSelect("SpClienteConsultarPorID");

            if (DatosDeCliente != null && DatosDeCliente.Rows.Count > 0)
            {
                DataRow MisDatos = DatosDeCliente.Rows[0];
                R.IDCliente = Convert.ToInt32(MisDatos["IDCliente"]);
                R.Nombre = Convert.ToString(MisDatos["Nombre"]);
                R.Cedula = Convert.ToString(MisDatos["Cedula"]);
                R.Telefono = Convert.ToString(MisDatos["Telefono"]);
                R.Email = Convert.ToString(MisDatos["Email"]);
                R.Activo = Convert.ToBoolean(MisDatos["Activo"]);

                R.MiTipo.IDTipoCliente = Convert.ToInt32(MisDatos["IDTipoCliente"]);
                R.MiTipo.Descripcion = Convert.ToString(MisDatos["Descripcion"]);


            }
            return R;

        }

        public DataTable ListarConFiltro(String Filtro, bool VerActivos)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();


            MiCnn.ListaParametros.Add(new SqlParameter("@Activo", VerActivos));
            MiCnn.ListaParametros.Add(new SqlParameter("@Filtro", Filtro));


            R = MiCnn.EjecutarSelect("SPClienteListarConFiltro");

            return R;
        }



    }

}