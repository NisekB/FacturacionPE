using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Producto
    {

        public int IDProducto { get; set; }
        public string CodigoBarras { get; set; }
        public string DescripcionProducto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }


        public ProductoCategoria MiCategoria { get; set; }
        public Impuesto MiImpuesto { get; set; }


        public Producto()
        {
          
            MiCategoria = new ProductoCategoria();
            MiImpuesto = new Impuesto();

        }


        public bool Agregar()
        {
            //Search Trycatch
            bool R = false;

            Conexion MiCnn4 = new Conexion();

            MiCnn4.ListaParametros.Add(new SqlParameter("@CodigoDeBarras", this.CodigoBarras));
            MiCnn4.ListaParametros.Add(new SqlParameter("@DescripcionProducto", this.DescripcionProducto));
            MiCnn4.ListaParametros.Add(new SqlParameter("@Cantidad", this.Cantidad));
            MiCnn4.ListaParametros.Add(new SqlParameter("@PrecioUnitario", this.PrecioUnitario));
            MiCnn4.ListaParametros.Add(new SqlParameter("@IDImpuesto", this.MiImpuesto.IDImpuesto));
            MiCnn4.ListaParametros.Add(new SqlParameter("@IDProductoCategoria", this.MiCategoria.IDProductoCategoria));


            int Resultado = MiCnn4.EjecutarUpdateDeleteInsert("SpProductoAgegar");

            if (Resultado > 0)
            {
                R = true;
            }

            return R;

        }

        public bool Editar()
        {
            bool R = false;

            Producto ProductoConsulta = new Producto();
            ProductoConsulta = ConsultarPorID(this.IDProducto);

            if (ProductoConsulta.IDProducto > 0)
            {

                Conexion MyCnn = new Conexion();

                MyCnn.ListaParametros.Add(new SqlParameter("@ID", this.IDProducto));
                MyCnn.ListaParametros.Add(new SqlParameter("@CodigoDeBarras", this.CodigoBarras));
                MyCnn.ListaParametros.Add(new SqlParameter("@DescripcionProducto", this.DescripcionProducto));
                MyCnn.ListaParametros.Add(new SqlParameter("@Cantidad", this.Cantidad));
                MyCnn.ListaParametros.Add(new SqlParameter("@PrecioUnitario", this.PrecioUnitario));
                MyCnn.ListaParametros.Add(new SqlParameter("@IDImpuesto", this.MiImpuesto.IDImpuesto));
                MyCnn.ListaParametros.Add(new SqlParameter("@IDProductoCategoria", this.MiCategoria.IDProductoCategoria));

                int Resultado = MyCnn.EjecutarUpdateDeleteInsert("SpProductoModificar");

                if (Resultado > 0)
                {

                    R = true;

                }

            }

            return R;
        }


        public bool ConsultarPorDescripcion()
        {
            bool R = false;

            Conexion MiCnn2 = new Conexion();
            MiCnn2.ListaParametros.Add(new SqlParameter("@Descripcion", this.DescripcionProducto));

            DataTable Consulta = MiCnn2.EjecutarSelect("SpProductoConsultarPorDescripcion");

            if (Consulta.Rows.Count > 0)
            {

                R = true;

            }

            return R;

        }

        public bool ConsultarPorCodigoDeBarras()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();
            MiCnn.ListaParametros.Add(new SqlParameter("@CodigoDeBarras", this.CodigoBarras));

            DataTable Consulta = MiCnn.EjecutarSelect("SpProductoConsultarPorCodigoBarras");

            if (Consulta.Rows.Count > 0)
            {

                R = true;

            }

            return R;

        }


        public Producto ConsultarPorID(int pIDProducto)
        {
            Producto R = new Producto();

            Conexion MyCnn = new Conexion();
            MyCnn.ListaParametros.Add(new SqlParameter("@IDP", pIDProducto));

            DataTable DatosDeProducto = new DataTable();
            DatosDeProducto = MyCnn.EjecutarSelect("SpProductoConsultarPorIDProducto");

            if (DatosDeProducto != null && DatosDeProducto.Rows.Count > 0)
            {

                DataRow MisDatos = DatosDeProducto.Rows[0];

                R.IDProducto = Convert.ToInt32(MisDatos["IDProducto"]);
                R.CodigoBarras = Convert.ToString(MisDatos["CodigoDeBarras"]);
                R.DescripcionProducto = Convert.ToString(MisDatos["DescripcionProducto"]);
                R.Cantidad = Convert.ToInt32(MisDatos["Cantidad"]);
                R.PrecioUnitario = Convert.ToInt32(MisDatos["PrecioUnitario"]);

                R.MiCategoria.IDProductoCategoria = Convert.ToInt32(MisDatos["IDProductoCategoria"]);
                R.MiCategoria.Descripcion = Convert.ToString(MisDatos["CategoriaDes"]);

                R.MiImpuesto.IDImpuesto = Convert.ToInt32(MisDatos["IDImpuesto"]);
                R.MiImpuesto.Descripcion = Convert.ToString(MisDatos["ImpuestoDes"]);


            }


            return R;

        }

        public DataTable Listar(bool VerActivos = true, string Filtro = "")
        {
            DataTable R = new DataTable();

            Conexion MyCnn = new Conexion();

            MyCnn.ListaParametros.Add(new SqlParameter("@filtro", Filtro));

            R = MyCnn.EjecutarSelect("SpProductoListar");

            return R;
        }

        public DataTable ListarProductos(bool VerActivos = true)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSelect("SpProductosListarActivos");

            return R;
        }


    }
}