using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionP5_Jessica.Formularios
{
    public partial class FrmFacturacion : Form
    {
        public Logica.Models.Factura FacturaLocal { get; set; }

        public DataTable ListaDetallesLocal { get; set; }
        public FrmFacturacion()
        {
            InitializeComponent();

            FacturaLocal = new Logica.Models.Factura();

            ListaDetallesLocal = new DataTable();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Totalizar()
        {
            if (ListaDetallesLocal!= null && ListaDetallesLocal.Rows.Count>0)
            {
                //se recorre cada linea del detalle y se suman los montos correspondientes

                decimal Subt = 0;
                decimal Descuentos = 0;
                decimal Impuestos = 0;
                decimal Total = 0;

                foreach (DataRow item in ListaDetallesLocal.Rows)
                {
                    Subt += Convert.ToDecimal(item["CantidadFacturada"]) * Convert.ToDecimal(item["PrecioUnitario"]);

                    Descuentos += Subt * Convert.ToDecimal(item["PorcentajeDescuento"]) / 100;

                    Impuestos += Convert.ToDecimal(item["ImpuestosLinea"]);

                    Total += Convert.ToDecimal(item["TotalLinea"]);
                }
                //una vez se tienen las sumas se presentan en los txt correspondientes

                LblSubTotal.Text = string.Format("{0:N2}", Subt);
                LblDescuentos.Text = string.Format("{0:N2}", Descuentos);
                LblImpuestos.Text = string.Format("{0:N2}", Impuestos);
                LblTotal.Text = string.Format("{0:N2}", Total);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            MdiParent = ObjetosGlobales.MiFormularioPrincipal;
            CargarComboEmpresas();
            CargarComboFacturaTipos();
            CargarComboUsuarios();

            Limpiar();

        }


        private void Limpiar()
        {
            CboxUsuario.SelectedValue = ObjetosGlobales.MiUsuarioGlobal.IDUsuario;
            CboxTipoFactura.SelectedIndex = -1;
            DtpFechaFactura.Value = DateTime.Now.Date;
            TxtNotas.Clear();

            LblSubTotal.Text = "0";
            LblDescuentos.Text = "0";
            LblImpuestos.Text = "0";
            LblTotal.Text = "0";

            FacturaLocal = new Logica.Models.Factura();

            //el data grid view espera tener de fondo un datatable para mostrar datos 
            //el form al iniciar no muestra datos y deberia tener de fondo el data table con 
            //la estructura necesaria y datos en blanco para luego poder agregar lineas

            ListaDetallesLocal = new DataTable();
            ListaDetallesLocal = FacturaLocal.AsignarEsquemaDetalle();

            DgvListaItems.DataSource = ListaDetallesLocal;

            TxtIdCliente.Clear();
            LblNombreCliente.Text = "";
        }

        private void CargarComboUsuarios()
        {
            CboxUsuario.DisplayMember = "Nombre";
            CboxUsuario.ValueMember = "IDUsuario";

            CboxUsuario.DataSource = FacturaLocal.MiUsuario.ListarActivos();

            CboxUsuario.SelectedIndex = -1;
        }

        private void CargarComboEmpresas()
        {
            CboxEmpresa.DisplayMember = "desc";
            CboxEmpresa.ValueMember = "id";

            CboxEmpresa.DataSource = FacturaLocal.MiEmpresa.Listar();

            CboxEmpresa.SelectedIndex = -1;
        }

        private void CargarComboFacturaTipos()
        {
            CboxTipoFactura.DisplayMember = "desc";
            CboxTipoFactura.ValueMember = "id";

            CboxTipoFactura.DataSource = FacturaLocal.MiTipo.Listar();

            CboxTipoFactura.SelectedIndex = -1;
        }

        private void TxtIdCliente_DoubleClick(object sender, EventArgs e)
        {
            //al dar doble click en el cuadro de texto se abre la ventana de búsqueda de cliente
Form MiformBuscarCliente = new Formularios.FrmClienteSeleccionar();

            DialogResult respuesta = MiformBuscarCliente.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                LblNombreCliente.Text = FacturaLocal.MiCliente.Nombre;
                TxtIdCliente.Text = FacturaLocal.MiCliente.IDCliente.ToString();
            }
            else
            {
                LblNombreCliente.Text = "";
            }
        }

        private void BtnItemAgregar_Click(object sender, EventArgs e)
        {
            Form formSeleccionDeItem = new FrmFacturacionItemGestion();

            DialogResult resp = formSeleccionDeItem.ShowDialog();

            if (resp == DialogResult.OK)
            {
                //se ha seleccionado correctamente un item 

                DgvListaItems.DataSource = ListaDetallesLocal;

                Totalizar();
              
           

                //...
            
            }
        }

        private void CargarDetalleDeFactura()
        {
            //Cargar en la composicion los detalles a partir del datatable de detalles local

            foreach (DataRow item in ListaDetallesLocal.Rows)
            {



            }
        }
        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            //to do: efectuar las validaciones correspondientes, ejem que la fecha no sea mayor a la acatual y que se hayan seleccionado datos minimos

            if (ListaDetallesLocal!= null && ListaDetallesLocal.Rows.Count >0)
            {
                FacturaLocal.MiCliente.IDCliente = Convert.ToInt32(TxtIdCliente.Text.Trim());
                FacturaLocal.MiTipo.IDFacturaTipo = Convert.ToInt32(CboxTipoFactura.SelectedValue);
                FacturaLocal.MiEmpresa.IDEmpresa = Convert.ToInt32(CboxEmpresa.SelectedValue);
                FacturaLocal.Fecha = DtpFechaFactura.Value.Date;
                FacturaLocal.Anotaciones = TxtNotas.Text.Trim();


            }
        }
    }
}
