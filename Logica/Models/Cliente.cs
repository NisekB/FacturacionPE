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



            return R;

        }

        public bool ConsultarPorID()
        {
            bool R = false;



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



    }

}