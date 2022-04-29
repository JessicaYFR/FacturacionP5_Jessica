using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
   public class FacturaDetalle
    {
        public string DescripcionItem { get; set; }

        public decimal CantidadFactura { get; set; }

        public decimal PrecioUnitario { get; set; }

        public decimal PorcentajeDescuento { get; set; }

        public decimal SubTotalLinea { get; set; }

        public decimal ImpuestoLinea { get; set; }

        public decimal TotalLinea { get; set; }

       public  Producto MiProducto { get; set; }

        public FacturaDetalle()
        {
            MiProducto = new Producto();
        }


    }
}
