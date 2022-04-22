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
    public partial class FrmClienteSeleccionar : Form
    {
        DataTable ListaClientes = new DataTable();

        public Logica.Models.Cliente MiCliente { get; set; }
        public FrmClienteSeleccionar()
        {
            InitializeComponent();
            MiCliente = new Logica.Models.Cliente();
        }

        private void FrmClienteSeleccionar_Load(object sender, EventArgs e)
        {
            LlenarListaClientes();
        }

        private void LlenarListaClientes(string Filtro = "")
        {
            ListaClientes = new DataTable();

            ListaClientes = MiCliente.Listar(true, Filtro);

            DgvLista.DataSource = ListaClientes;
        }

        private void BtnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            if (DgvLista.SelectedRows.Count == 1)
            {
                DataGridViewRow Fila = DgvLista.SelectedRows[0];

                int idCliente = Convert.ToInt32(Fila.Cells["CIDCliente"].Value);

                string Nombre = Convert.ToString(Fila.Cells["CNombre"].Value);

                string Telefono = Convert.ToString(Fila.Cells["CTelefono"].Value);

                ObjetosGlobales.MiFormFacturador.FacturaLocal.MiCliente.IDCliente = idCliente;
                ObjetosGlobales.MiFormFacturador.FacturaLocal.MiCliente.Nombre = Nombre;
                ObjetosGlobales.MiFormFacturador.FacturaLocal.MiCliente.Telefono = Telefono;

                DialogResult = DialogResult.OK;
            }


            DialogResult = DialogResult.OK;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void TxtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            //cada que se presiona una tecla el timer se apaga
            TmrBuscarCliente.Enabled = false;
        }

        private void TxtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            //al liberara la tecla se enciende el timer de busquda
            TmrBuscarCliente.Enabled = true;
        }

        private void TmrBuscarCliente_Tick(object sender, EventArgs e)
        {
            //como no se quiere que le código se ejecute cada 800 milisegundos se debe apagar el timer
            TmrBuscarCliente.Enabled = false;

            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()))
            {
                string filtro = TxtBuscar.Text.Trim();

                LlenarListaClientes(filtro);
            }
            else
            {
                LlenarListaClientes();
            }
        }

        private void DgvLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvLista.ClearSelection();
        }
    }
}
