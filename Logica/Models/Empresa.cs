using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
   public class Empresa
    {

        //Atributos
        public int IDEmpresa { get; set; }

        public string NombreEmpresa { get; set; }

        public int CedulaEmpresa { get; set; }

        public int EmailEmpresa { get; set; }

        public int DireccionEmpresa { get; set; }

        public int TelefonoEmpresa { get; set; }

        public int RutaImagen { get; set; }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MyCnn = new Conexion();

            R = MyCnn.EjecutarSelect("SpEmpresasListar");

            return R;
        }
    }
}
