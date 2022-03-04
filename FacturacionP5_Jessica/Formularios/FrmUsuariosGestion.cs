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
    public partial class FrmUsuariosGestion : Form
    {
        public FrmUsuariosGestion()
        {
            InitializeComponent();
        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            ListarUsuariosActivos();

        }

        private void ListarUsuariosActivos()
        {
            //En la medida de lo posible se debe encapsular código que tienda a ser reutilizable.

            //paso 1 y 1.1 SdUsuariosListarActivos
            Logica.Models.Usuario MiUsuario = new Logica.Models.Usuario();

            //paso 2 y 2.5 
            DataTable dt = MiUsuario.ListarActivos();

            //mostrar datos en el dataGridView
            DgvListaUsuarios.DataSource = dt;
        }
    }
}
