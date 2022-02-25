using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
   public class Factura
    {

        public int IDFactura { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuentos { get; set; }
        public decimal SubTotal2 { get; set; }
        public decimal Impuestos { get; set; }
        public decimal Total { get; set; }
        public string Anotaciones { get; set; }

        //Atributos compuestos

        // composiciones simples
        FacturaTipo MiTipo { get; set; }
        Empresa MiEmpresa { get; set; }
        Cliente MiCliente { get; set; }
        Usuario MiUsuario { get; set; }

        //Composisiones múltiples

        public List<FacturaDetalle> DetalleItems { get; set; }

        public Factura()
        {
            MiTipo = new FacturaTipo();
            MiEmpresa = new Empresa();
            MiCliente = new Cliente();
            MiUsuario = new Usuario();
            DetalleItems = new List<FacturaDetalle>(); 
        }
        //Comportamientos 

        public bool Agregar()
        {
            bool R = false;
            return R;
        }

        public DataTable ConsultarPorNumero (int pNumeroFactura)
        {
            DataTable R = new DataTable(); 
            return R;

        }

        public DataTable ListarPorRangoDeFechas(DateTime pFechaInicial, DateTime pFechaFinal)
        {
            DataTable R = new DataTable();
            return R;
        }

        public DataTable ListarPorCliente(int pIDCliente)
        {
            DataTable R = new DataTable();
            return R;

        }

        public DataTable ListarPorUsuario(int pIDUsuario)
        {
            DataTable R = new DataTable();
            return R;

        }

        private void Totalizar()
        {
            // TO DO: Asignar valores a los rubros decimales
            
        }
    }
}
