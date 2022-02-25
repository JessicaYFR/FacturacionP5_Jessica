using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    class Impuesto
    {
        public int IDImpuesto { get; set; }

        public string CodigoImpuesto { get; set; }

        public string ImpuestoNombre { get; set; }

        public decimal MontoImpuesto { get; set; }

        public DataTable Listar()
        {

            DataTable R = new DataTable();

            return R;
        }
    }
}
