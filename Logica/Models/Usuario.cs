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


            return R;

        }


        public bool Eliminar()
        {
            bool R = false;


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


        public bool ConsultarPorID()
        {
            bool R = false;



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

        public DataTable Listar(bool VerActivos = true)
        {
            DataTable R = new DataTable();



            return R;
        }











    }
}
