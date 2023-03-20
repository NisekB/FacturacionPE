using System;
using System.Collections.Generic;
using System.Data;
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
        TipoCliente MiTipo { get; set; }

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



        public DataTable Listar(bool VerActivos = true)
        {
            DataTable R = new DataTable();



            return R;
        }



    }

}