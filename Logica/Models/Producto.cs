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

        UnidadMedida MiUnidadMedida { get; set; }
        ProductoCategoria MiCategoria { get; set; }
        Impuesto MIimpuesto { get; set; }

        //constructor 
        public Producto()
        {
            MiUnidadMedida = new UnidadMedida();
            MiCategoria = new ProductoCategoria();
            MIimpuesto = new Impuesto();
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
        public bool ConsultarPorID()
        {
            bool R = false;
            return R;
        }

        public DataTable Listar (bool VerActivos = true)
        {
            DataTable R = new DataTable();
            return R;
        }
    }


}
