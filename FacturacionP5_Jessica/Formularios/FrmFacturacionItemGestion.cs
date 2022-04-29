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
    public partial class FrmFacturacionItemGestion : Form
    {
        DataTable ListaItems { get; set; }

        Logica.Models.Producto MiProducto { get; set; }
        public FrmFacturacionItemGestion()
        {
            InitializeComponent();

            ListaItems = new DataTable();
            MiProducto = new Logica.Models.Producto();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvListaItems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaItems.ClearSelection();
        }

        private void FrmFacturacionItemGestion_Load(object sender, EventArgs e)
        {
            LlenarListaItems();
        }

        private void LlenarListaItems()
        {
            ListaItems = new DataTable();
            ListaItems = MiProducto.Listar();
            DgvListaItems.DataSource = ListaItems;
            DgvListaItems.ClearSelection();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //primero se valida que no pase el item en 0
            if (ValidarItem())
            {
                //cargamos el item del detalle del form de facturacion
                //como el form de faturacion es global y dentro de el hay un data table con 
                //la estructura del detalle entonces creamos una nueva fila del datatable y la llenamos con info de la fila
                // que seleccionamos

                DataRow NuevaLineaDetalleEnFacturacion = ObjetosGlobales.MiFormFacturador.ListaDetallesLocal.NewRow();



                NuevaLineaDetalleEnFacturacion["IDProducto"] = MiProducto.IDProducto;

                NuevaLineaDetalleEnFacturacion["DescripcionItem"] = MiProducto.DescripcionProducto;

                NuevaLineaDetalleEnFacturacion["CantidadFacturada"] = TxtCantidad.Value;
                
                NuevaLineaDetalleEnFacturacion["PorcentajeDescuento"] = Convert.ToDecimal(TxtDescuento.Text.Trim());

                NuevaLineaDetalleEnFacturacion["PrecioUnitario"] = MiProducto.PrecioUnitario;

                

                //calculo del impuesto por linea
                decimal PorcentajeDescuento = Convert.ToDecimal(TxtDescuento.Text.Trim());
                decimal PrecioMenosDescuento = MiProducto.PrecioUnitario -((MiProducto.PrecioUnitario*PorcentajeDescuento)/100);
                decimal Impuestos = ((PrecioMenosDescuento * MiProducto.MiImpuesto.MontoImpuesto) / 100) * TxtCantidad.Value;
                NuevaLineaDetalleEnFacturacion["ImpuestosLinea"] = Impuestos;
                NuevaLineaDetalleEnFacturacion["SubTotalLinea"] = TxtCantidad.Value * PrecioMenosDescuento;
                decimal TotalLinea = PrecioMenosDescuento * TxtCantidad.Value + Impuestos;

                NuevaLineaDetalleEnFacturacion["TotalLinea"] = TotalLinea;
                
                //este dato se calsula en el form de facturacion
               
                

                ObjetosGlobales.MiFormFacturador.ListaDetallesLocal.Rows.Add(NuevaLineaDetalleEnFacturacion);

                //retornamos OK 

                DialogResult = DialogResult.OK;
            
            }
        }

        private bool ValidarItem()
        {
            bool R = false;

            if (DgvListaItems.SelectedRows.Count == 1 && TxtCantidad.Value > 0)
            {
                //validacion correcta
                R = true;
            }
            else
            {
                if (DgvListaItems.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un item de la lista", "Error de validacion", MessageBoxButtons.OK);
                    return false;

                }
                if (TxtCantidad.Value == 0)
                {
                    MessageBox.Show("La cantidad no puede ser cero", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }
            }

            return R;
        }
        private void CalcularPrecioFinal(Logica.Models.Producto pProducto, decimal PorcentajeDescuento)
        {
            decimal PrecioDescuento = pProducto.PrecioUnitario - ((pProducto.PrecioUnitario * PorcentajeDescuento) / 100);

            decimal PrecioConImpuesto = PrecioDescuento + ((PrecioDescuento * pProducto.MiImpuesto.MontoImpuesto) / 100);

            TxtPrecioFinal.Text = PrecioConImpuesto.ToString();
        }
        private void DgvListaItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaItems.SelectedRows.Count ==1)
            {

                DataGridViewRow FilaSeleccionada = DgvListaItems.SelectedRows[0];

                int IDProductoSeleccionado = Convert.ToInt32(FilaSeleccionada.Cells["CIDProducto"].Value);

                MiProducto = MiProducto.ConsultarPorID(IDProductoSeleccionado);

                if (MiProducto.IDProducto>0)
                {
                    TxtIva.Text = MiProducto.MiImpuesto.MontoImpuesto.ToString();
                    TxtPrecioUnitario.Text = MiProducto.PrecioUnitario.ToString();

                    CalcularPrecioFinal(MiProducto,Convert.ToDecimal(TxtDescuento.Text.Trim()));
                }
            }
        }

        private void TxtDescuento_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtDescuento.Text.Trim()))
            {
                TxtDescuento.Text = "0";
                TxtDescuento.SelectAll();
            }else
            {
                CalcularPrecioFinal(MiProducto, Convert.ToDecimal(TxtDescuento.Text.Trim()));
            }
            
        }
    }
}
