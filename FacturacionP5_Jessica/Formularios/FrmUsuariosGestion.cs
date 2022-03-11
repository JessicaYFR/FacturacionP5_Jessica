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

        //Al igual que con cualquier otra cosa se pueden escribir atributos para la misma

        //En este caso vamos a tener un atributo de tipo usuario de fondo
        //el cual me permite manipular los cambios que el usuario haga en todo momento

        public Logica.Models.Usuario MiUsuarioLocal { get; set; }



        public FrmUsuariosGestion()
        {
            InitializeComponent();
            //Paso 1.1 y 1.2

            MiUsuarioLocal = new Logica.Models.Usuario();
        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            ListarUsuariosActivos();
            CargarRolesDeUsuarioEnCombo();

        }

        private void CargarRolesDeUsuarioEnCombo()
        {
            //crear un objeto tipo usuario Rol
            Logica.Models.UsuarioRol ObjRolDeUsuario = new Logica.Models.UsuarioRol();

            DataTable ListaRoles = new DataTable();

            ListaRoles = ObjRolDeUsuario.Listar();

            CboxTipoUsuario.ValueMember = "id";
            CboxTipoUsuario.DisplayMember = "d";

            CboxTipoUsuario.DataSource = ListaRoles;

            CboxTipoUsuario.SelectedIndex = -1;
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
            DgvListaUsuarios.ClearSelection();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //En la secuencia  no se explica, pero se debe realizar una serie de validaciones
            //datos mínimos y tipos de extensiones correctas para cada campo



            //TO DO : Agregar funcionalidades de validación

            //TEMPORAL: se aregan los valores de los atributos del objeto local

            MiUsuarioLocal.Nombre = TxtNombre.Text.Trim();
            MiUsuarioLocal.NombreUsuario = TxtEmail.Text.Trim();
            MiUsuarioLocal.Cedula = TxtCedula.Text.Trim();
            MiUsuarioLocal.Telefono = TxtTelefono.Text.Trim();
            MiUsuarioLocal.Contrasennia = TxtPassword.Text.Trim();
            MiUsuarioLocal.CorreoDeRespaldo = TxtEmailRespaldo.Text.Trim();
            MiUsuarioLocal.MiUsuarioRol.IDUsuarioRol = Convert.ToInt32(CboxTipoUsuario.SelectedValue);

            //Solo en este caso vamos a seguir la numeración de la secuencia "AeqUsuarioAgregar" en el visual paradigm

            
            //paso 1.3 y 1.3.6
            bool A = MiUsuarioLocal.ConsultarPorCedula();


            //paso 1.4 y 1.4.6

            bool B = MiUsuarioLocal.ConsultarEmail();

            //paso 1.5 
            if (!A && !B)
            {
                //Paso 1.6 , 1.66 y 1.7
                if (MiUsuarioLocal.Agregar())
                {
                    //paso 1.8

                    MessageBox.Show("Usuario aregado correctamente",":)",MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error y el usuario no se gurdó", ":(", MessageBoxButtons.OK);
                }

                ListarUsuariosActivos();
                //TO DO: Limpiar el formulario
            }
        else
            { //en este caso tenemos que indicar al usuario que validación falló
                if (A)
                {
                    MessageBox.Show("Ya existe un usuario con cédula digitada", "Error de validación", MessageBoxButtons.OK);
               TxtCedula.Focus();   
               TxtCedula.SelectAll();
                }
                if (B)
                {
                    MessageBox.Show("Ya existe un usuario con el Email digitado", "Error de validación", MessageBoxButtons.OK);
               TxtEmail.Focus();    
                TxtEmail.SelectAll();
                
                }
            }
        }

        private void DgvListaUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaUsuarios.ClearSelection();
        }
    }
}
