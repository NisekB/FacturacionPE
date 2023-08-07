using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Usuario
    {
        public int IDUsuario { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string EmailRespaldo { get; set; }
        public string Contra { get; set; }
        public string Cedula { get; set; }
        public bool Activo { get; set; }

        public UsuarioRol MiRol { get; set; }

        public Usuario()
        {
            MiRol = new UsuarioRol();
        }

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn3 = new Conexion();

            Encriptador MiEncriptador = new Encriptador();
            string FullEncriptado = MiEncriptador.EncriptarEnUnSentido(this.Contra);

            MiCnn3.ListaParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn3.ListaParametros.Add(new SqlParameter("@Email", this.Email));
            MiCnn3.ListaParametros.Add(new SqlParameter("@Telefono", this.Telefono));
            MiCnn3.ListaParametros.Add(new SqlParameter("@EmailRespaldo", this.EmailRespaldo));
            MiCnn3.ListaParametros.Add(new SqlParameter("@Contra", FullEncriptado));
            MiCnn3.ListaParametros.Add(new SqlParameter("@Cedula", this.Cedula));
            MiCnn3.ListaParametros.Add(new SqlParameter("@IDRol", this.MiRol.IDRol));


            int Resultado = MiCnn3.EjecutarUpdateDeleteInsert("SpUsuarioAgregar");

            if (Resultado > 0)
            {
                R = true;

            }

            return R;

        }

        public bool Modificar()
        {
            bool R = false;

            Usuario UsuarioConsulta = new Usuario();
            UsuarioConsulta = ConsultarPorID(this.IDUsuario);

            if (UsuarioConsulta.IDUsuario > 0)
            {
                Conexion MyCnn = new Conexion();

                string FullEncriptado = "";

                if (!string.IsNullOrEmpty(this.Contra))
                {

                    Encriptador MiEncriptador = new Encriptador();

                    FullEncriptado = MiEncriptador.EncriptarEnUnSentido(this.Contra);

                }

                MyCnn.ListaParametros.Add(new SqlParameter("@ID", this.IDUsuario));
                MyCnn.ListaParametros.Add(new SqlParameter("@Nombre", this.Nombre));
                MyCnn.ListaParametros.Add(new SqlParameter("@Email", this.Email));
                MyCnn.ListaParametros.Add(new SqlParameter("@Telefono", this.Telefono));
                MyCnn.ListaParametros.Add(new SqlParameter("@EmailRespaldo", this.EmailRespaldo));
                MyCnn.ListaParametros.Add(new SqlParameter("@Contra", FullEncriptado));
                MyCnn.ListaParametros.Add(new SqlParameter("@Cedula", this.Cedula));
                MyCnn.ListaParametros.Add(new SqlParameter("@IDRol", this.MiRol.IDRol));


                int Resultado = MyCnn.EjecutarUpdateDeleteInsert("SpUsuariosModificar");

                if (Resultado > 0) R = true;

            }

            return R;

        }


        public bool Eliminar()
        {
            bool R = false;

            Conexion MyCnn = new Conexion();

            MyCnn.ListaParametros.Add(new SqlParameter("@ID", IDUsuario));  

            if (MyCnn.EjecutarUpdateDeleteInsert("SpUsuarioDesactivar") > 0) R =true;


            return R;
        }

        public bool Activar()
        {
            bool R = false;

            Conexion MyCnn = new Conexion();

            MyCnn.ListaParametros.Add(new SqlParameter("@ID", IDUsuario));

            if (MyCnn.EjecutarUpdateDeleteInsert("SpUsuarioActivar") > 0) R = true;


            return R;
        }

        public Usuario ValidarIngreso(string pUsuario, string pContra)
        {
            Usuario R = new Usuario();

            Conexion MyCnn = new Conexion();

            MyCnn.ListaParametros.Add(new SqlParameter("@UsuarioEmail", pUsuario));

            Encriptador MiEncriptador = new Encriptador();
            string ContraEncriptada = MiEncriptador.EncriptarEnUnSentido(pContra);
            MyCnn.ListaParametros.Add(new SqlParameter("@Contra", ContraEncriptada));

            DataTable DatosDeUsuario = new DataTable();

            DatosDeUsuario = MyCnn.EjecutarSelect("SpUsuariosValidarIngreso");

            if (DatosDeUsuario != null && DatosDeUsuario.Rows.Count > 0)
            {
                DataRow MisDatos = DatosDeUsuario.Rows[0];
                R.IDUsuario = Convert.ToInt32(MisDatos["IDUsuario"]);
                R.Nombre = Convert.ToString(MisDatos["Nombre"]);
                R.Email = Convert.ToString(MisDatos["Email"]);
                R.Telefono = Convert.ToString(MisDatos["Telefono"]);
                R.Contra = Convert.ToString(MisDatos["Contra"]);
                R.EmailRespaldo = Convert.ToString(MisDatos["EmailRespaldo"]);
                R.Cedula = Convert.ToString(MisDatos["Cedula"]);
                R.Activo = Convert.ToBoolean(MisDatos["Activo"]);

                R.MiRol.IDRol = Convert.ToInt32(MisDatos["IDRol"]);
                R.MiRol.Descripcion = Convert.ToString(MisDatos["Descripcion"]);

            }

            return R;

        }

        public bool ConsultarPorCedula()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();
            MiCnn.ListaParametros.Add(new SqlParameter("@Cedula", this.Cedula));

            DataTable Consulta = MiCnn.EjecutarSelect("SpUsuarioConsultarPorCedula");

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

            DataTable Consulta = MiCnn.EjecutarSelect("SpUsuarioConsultarPorEmail");

            if (Consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;

        }


        public Usuario ConsultarPorID(int pIDUsuario)
        {
           Usuario R = new Usuario();

            Conexion MyCnn = new Conexion();

            MyCnn.ListaParametros.Add(new SqlParameter("@ID", pIDUsuario));

            DataTable DatosDeUsuario = new DataTable();

            DatosDeUsuario = MyCnn.EjecutarSelect("SpUsuariosConsultarPorID");

            if (DatosDeUsuario != null && DatosDeUsuario.Rows.Count > 0)
            {
                DataRow MisDatos = DatosDeUsuario.Rows[0];
                R.IDUsuario = Convert.ToInt32(MisDatos["IDUsuario"]);
                R.Nombre = Convert.ToString(MisDatos["Nombre"]);
                R.Email = Convert.ToString(MisDatos["Email"]);
                R.Telefono = Convert.ToString(MisDatos["Telefono"]);
                R.Contra = Convert.ToString(MisDatos["Contra"]);
                R.EmailRespaldo = Convert.ToString(MisDatos["EmailRespaldo"]);
                R.Cedula = Convert.ToString(MisDatos["Cedula"]);
                R.Activo = Convert.ToBoolean(MisDatos["Activo"]);

                R.MiRol.IDRol = Convert.ToInt32(MisDatos["IDRol"]);
                R.MiRol.Descripcion = Convert.ToString(MisDatos["Descripcion"]);

            }



            return R;

        }

        public DataTable ListarActivos()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSelect("SpUsuariosListarActivos");

            return R;
        }

        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSelect("SpUsuariosListarInactivos");

            return R;
        }

        public DataTable Listar(bool VerActivos = true, string Filtro = "")
        {
            DataTable R = new DataTable();

            Conexion MyCnn = new Conexion();

            MyCnn.ListaParametros.Add(new SqlParameter("@filtro", Filtro));

            R = MyCnn.EjecutarSelect("SpUsuarioListarActivos");

            return R;
        }

        public DataTable ListarConFiltro(String Filtro, bool VerActivos)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();


            MiCnn.ListaParametros.Add(new SqlParameter("@Activo", VerActivos));
            MiCnn.ListaParametros.Add(new SqlParameter("@Filtro", Filtro));


            R = MiCnn.EjecutarSelect("SPUsuarioListarConFiltro");

            return R;
        }


     











    }
}
