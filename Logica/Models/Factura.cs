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
        public FacturaTipo MiTipo { get; set; }
        public Empresa MiEmpresa { get; set; }
        public Cliente MiCliente { get; set; }
        public Usuario MiUsuario { get; set; }

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

            //cuando se agrega un objeto de tipo encabezado detalle se hace en dos partes 
            //primero el encabezado y se obtiene el id recien creado , luego con iteracion por cada detalle 
            //se guardan los detalles 

            Conexion MyCnnEncabezado = new Conexion();

            Totalizar();

            MyCnnEncabezado.ListaParametros.Add(new System.Data.SqlClient.SqlParameter("@numero", this.Numero));
            MyCnnEncabezado.ListaParametros.Add(new System.Data.SqlClient.SqlParameter("@fecha", this.Fecha));
            MyCnnEncabezado.ListaParametros.Add(new System.Data.SqlClient.SqlParameter("@subtotal", this.SubTotal));
            MyCnnEncabezado.ListaParametros.Add(new System.Data.SqlClient.SqlParameter("@descuentos", this.Descuentos));
            MyCnnEncabezado.ListaParametros.Add(new System.Data.SqlClient.SqlParameter("@subtotal2", this.SubTotal2));
            MyCnnEncabezado.ListaParametros.Add(new System.Data.SqlClient.SqlParameter("@impuestos", this.Impuestos));
            MyCnnEncabezado.ListaParametros.Add(new System.Data.SqlClient.SqlParameter("@total", this.Total));
            MyCnnEncabezado.ListaParametros.Add(new System.Data.SqlClient.SqlParameter("@notas", this.Anotaciones));

            MyCnnEncabezado.ListaParametros.Add(new System.Data.SqlClient.SqlParameter("@idtipo", this.MiTipo.IDFacturaTipo));
            MyCnnEncabezado.ListaParametros.Add(new System.Data.SqlClient.SqlParameter("@idcliente", this.MiCliente.IDCliente));
            MyCnnEncabezado.ListaParametros.Add(new System.Data.SqlClient.SqlParameter("@idusuario", this.MiUsuario.IDUsuario));
            MyCnnEncabezado.ListaParametros.Add(new System.Data.SqlClient.SqlParameter("@idempresa", this.MiEmpresa.IDEmpresa));

            Object Retorno = MyCnnEncabezado.EjecutarConRetornoEscalar("SpFacturaAgregarEncabezado");

            int IdFacturaRecienCreada = 0;

            if (Retorno != null)
            {
                IdFacturaRecienCreada = Convert.ToInt32(Retorno.ToString());

                //una vez que sr tiene el id de la factura se pueden agregar los detalles 

                foreach (FacturaDetalle item in this.DetalleItems)
                {
                    //se hace un insert por cada iteración en detalles

                    Conexion MyCnnDetalle = new Conexion();

                    MyCnnDetalle.ListaParametros.Add(new System.Data.SqlClient.SqlParameter("@idfactura", IdFacturaRecienCreada));
                    MyCnnDetalle.ListaParametros.Add(new System.Data.SqlClient.SqlParameter("@idproducto", item.MiProducto.IDProducto));
                    MyCnnDetalle.ListaParametros.Add(new System.Data.SqlClient.SqlParameter("@descripcion", item.DescripcionItem));
                    MyCnnDetalle.ListaParametros.Add(new System.Data.SqlClient.SqlParameter("@cantidad", item.CantidadFactura));
                    MyCnnDetalle.ListaParametros.Add(new System.Data.SqlClient.SqlParameter("@precio", item.PrecioUnitario));
                    MyCnnDetalle.ListaParametros.Add(new System.Data.SqlClient.SqlParameter("@porcentajedescuento", item.PorcentajeDescuento));
                    MyCnnDetalle.ListaParametros.Add(new System.Data.SqlClient.SqlParameter("@subtotallinea", item.SubTotalLinea));
                    MyCnnDetalle.ListaParametros.Add(new System.Data.SqlClient.SqlParameter("@impuestoslinea", item.ImpuestoLinea));
                    MyCnnDetalle.ListaParametros.Add(new System.Data.SqlClient.SqlParameter("@totallinea", item.TotalLinea));

                    MyCnnDetalle.EjecutarUpdateDeleteInsert("SpFacturaAgregarDetalle");
              
                
                }

                R = true;

            }


            return R;
        }

        public DataTable ConsultarPorNumero(int pNumeroFactura)
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
            this.Numero = 10; // to do:  aumentar este numero de forma que no queden huecos en el consecutivo

            this.SubTotal = 0;
            this.SubTotal2 = 0;
            this.Descuentos = 0;
            this.Impuestos = 0;
            this.Total = 0;

        }

        public DataTable AsignarEsquemaDetalle()
        {
            DataTable R = new DataTable();

            Conexion MyCnn = new Conexion();

            R = MyCnn.EjecutarSelect("SpFacturasDetalleEsquema", true);

            R.PrimaryKey = null;

            return R;
        }
    }
}
