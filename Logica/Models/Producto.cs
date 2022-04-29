using System;
using System.Collections.Generic;
using System.Data;
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

        public decimal CantidadEnStock { get; set; }

        public decimal PrecioUnitario { get; set; }


        //Atributos compuestos 

        public UnidadMedida MiUnidadMedida { get; set; }
        public ProductoCategoria MiCategoria { get; set; }
        public Impuesto MiImpuesto { get; set; }

        //constructor 
        public Producto()
        {
            MiUnidadMedida = new UnidadMedida();
            MiCategoria = new ProductoCategoria();
            MiImpuesto = new Impuesto();
        }

        public bool Agregar()
        {
            bool R = false;
            return R;
        }
        public bool Editar()
        {
            bool R = false;
            return R;
        }

        public bool Eliminar()
        {
            bool R = false;
            return R;
        }

        public bool ConsultarPorCodigoBarras()
        {
            bool R = false;
            return R;
        }
        public Producto ConsultarPorID(int pIdProducto)
        {
            Producto R = new Producto();

            Conexion MyCnn = new Conexion();

            MyCnn.ListaParametros.Add(new System.Data.SqlClient.SqlParameter("@id", pIdProducto));
            DataTable Datos = new DataTable();
            Datos = MyCnn.EjecutarSelect("SpProductosConsultarPorID");

            if (Datos != null && Datos.Rows.Count > 0)
            {
                DataRow MisDatos = Datos.Rows[0];

                R.IDProducto = Convert.ToInt32(MisDatos["IDProducto"]);
                R.DescripcionProducto = Convert.ToString(MisDatos["DescripcionProducto"]);
                R.CantidadEnStock = Convert.ToDecimal(MisDatos["CantidadEnStock"]);
                R.PrecioUnitario = Convert.ToDecimal(MisDatos["PrecioUnitario"]);
                R.MiImpuesto.IDImpuesto = Convert.ToInt32(MisDatos["IDImpuesto"]);
                R.MiCategoria.IDPrudtoCategoria = Convert.ToInt32(MisDatos["IdProductoCategoria"]);
                R.MiUnidadMedida.IDUnidad = Convert.ToInt32(MisDatos["IdUnidad"]);

                R.CodigoBarras = Convert.ToString(MisDatos["CodigoDeBarras"]);

                R.MiUnidadMedida.Unidad = Convert.ToString(MisDatos["UnidadMedida"]);
                R.MiCategoria.Categoria = Convert.ToString(MisDatos["Categoria"]);

                R.MiImpuesto.CodigoImpuesto = Convert.ToString(MisDatos["CodigoImpuesto"]);
                R.MiImpuesto.ImpuestoNombre = Convert.ToString(MisDatos["ImpuestoNombre"]);
                R.MiImpuesto.MontoImpuesto = Convert.ToDecimal(MisDatos["MontoImpuesto"]);
            }

            return R;
        }

        public DataTable Listar (bool VerActivos = true)
        {
            DataTable R = new DataTable();

            Conexion MyCnn = new Conexion();
            R = MyCnn.EjecutarSelect("SpProductosListar");

            return R;
        }
    }


}
