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
            MdiParent = ObjetosGlobales.MiFormularioPrincipal;
            ListarUsuariosActivos();
            CargarRolesDeUsuarioEnCombo();
            LimpiarForm();
            ActivarAgregar();
        }

        private void ActivarAgregar()
        {
            //activa solo el botón de agregar
            BtnAgregar.Enabled = true;
            BtnEditar.Enabled=false;
            BtnEliminar.Enabled = false;
        }
        private void ActivarEdiarYEliminar()
        {
            //activa solo el botón de agregar
            BtnAgregar.Enabled = false;
            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;
        }

        private void LimpiarForm()
        {
            //Este método elimina todos los datos del formulario
            TxtCodigo.Clear();
            TxtNombre.Clear();
            TxtEmail.Clear();
            TxtCedula.Clear();
            TxtTelefono.Clear();
            TxtEmailRespaldo.Clear();
            TxtPassword.Clear();
            CboxTipoUsuario.SelectedIndex = -1;
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

        private void ListarUsuariosDesactivados()
        {
           
            Logica.Models.Usuario MiUsuario = new Logica.Models.Usuario();

            DataTable dt = MiUsuario.ListarInactivos();

            //mostrar datos en el dataGridView
            DgvListaUsuarios.DataSource = dt;
            DgvListaUsuarios.ClearSelection();
        }


        private bool ValidarDatosRequeridos()
        {
            bool R = false;
            //si los cuadros de texto no(!) están en blanco:
            if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
               !string.IsNullOrEmpty(TxtEmail.Text.Trim()) &&
               !string.IsNullOrEmpty(TxtCedula.Text.Trim()) &&
               !string.IsNullOrEmpty(TxtTelefono.Text.Trim()) &&
               !string.IsNullOrEmpty(TxtEmailRespaldo.Text.Trim()) &&
               
               CboxTipoUsuario.SelectedIndex > -1)
            {

                if (BtnEditar.Enabled)
                {
                    //si estamos en modo de edición el password es opcional
                    //y podemos retornar true en este punto
                    R = true;

                }
                else
                {
                    //si el boton de  aditar esta apagado, la unica opcion es que estemos en modo de agregación
                    //y aca se debe validar el password
                    if (!string.IsNullOrEmpty(TxtPassword.Text.Trim()))
                    {
                        R = true;
                    }
                
                }
                
            
                if (!Validacion.ComprobarFormatoEmail(TxtEmail.Text))
                {
                    MessageBox.Show("El correo electrónico no cuenta con el formato correcto", "Error de validación", MessageBoxButtons.OK);
                    TxtEmail.Focus();
                    return false;
                }

                if (!Validacion.ComprobarFormatoEmail(TxtEmailRespaldo.Text))
                {
                    MessageBox.Show("El correo electrónico de respaldo no cuenta con el formato correcto", "Error de validación", MessageBoxButtons.OK);
                    TxtEmail.Focus();
                    return false;
                }

                if (!Validacion.ValidacionPassword(TxtPassword.Text))
                {
                    MessageBox.Show("La contraseña requiere de mínimo 8 carateres, al menos una letra mayúcula, una minúscula, un número entero, y un caracter especial ","Error de validación", MessageBoxButtons.OK);
                    TxtPassword.Focus();
                    return false;
                }

                
            }
            else
            {
                //retroalimentar al usuario para indicarle en qué esta fallando
                //se debe reevaluar cada cuadro de texto para ver si el usuario no digitó
                //nada y dar el aviso

                //si el cuadro de texto está en blanco
                if (string.IsNullOrEmpty(TxtNombre.Text.Trim()))
                {
                    MessageBox.Show("El nombre del usuario es requerido","Error de validación",MessageBoxButtons.OK);
                    TxtNombre.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtEmail.Text.Trim()))
                {
                    MessageBox.Show("El email del usuario es requerido", "Error de validación", MessageBoxButtons.OK);
                    TxtEmail.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(TxtCedula.Text.Trim()))
                {
                    MessageBox.Show("La cédula del usuario es requerida", "Error de validación", MessageBoxButtons.OK);
                    TxtCedula.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(TxtTelefono.Text.Trim()))
                {
                    MessageBox.Show("El teléfono del usuario es requerido", "Error de validación", MessageBoxButtons.OK);
                    TxtTelefono.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(TxtEmailRespaldo.Text.Trim()))
                {
                    MessageBox.Show("El correo de respaldo del usuario es requerido", "Error de validación", MessageBoxButtons.OK);
                    TxtEmailRespaldo.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(TxtPassword.Text.Trim()))
                {
                    MessageBox.Show("La contraseña del usuario es requerida", "Error de validación", MessageBoxButtons.OK);
                    TxtPassword.Focus();
                    return false;
                }
                if (CboxTipoUsuario.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un tipo de usuario", "Error de validación", MessageBoxButtons.OK);
                    CboxTipoUsuario.Focus();
                    return false;
                }
            }

            return R;
        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //En la secuencia  no se explica, pero se debe realizar una serie de validaciones
            //datos mínimos y tipos de extensiones correctas para cada campo
                if (ValidarDatosRequeridos())
                {
                string Pregunta = string.Format("¿Estás seguro(a) de quere agregar el usuario {0}?", TxtNombre.Text.Trim());

                DialogResult RespuestaDelUsuario = MessageBox.Show(Pregunta,"???",MessageBoxButtons.YesNo);

                if (RespuestaDelUsuario == DialogResult.Yes)
                {
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
                    LimpiarForm();
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
            }
        }

        private void DgvListaUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaUsuarios.ClearSelection();
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //en este campo de texto se valida el nombre llamando a la
            //clase de validación, llamando al método que valida 
            //los textos y modificando por parámetro lo que yo quiero,
            //ejemplo en este caso quiero que el nombre entre en mayuscula etoces 
            //le pongo true a ese parámetro. La e es es el argumento de este cuadro de texto en particular
            
            e.Handled = Validacion.CaracteresTexto(e, true);
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresTexto(e,false,true);
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresNumeros(e);
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresTexto(e,true);
        }

        private void TxtEmailRespaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresTexto(e, false, true);
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresTexto(e);
        }

        private void BtnLimpiarForm_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            ActivarAgregar();
        }

        private void DgvListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //El siguiente código permite que al hacer click sobre un resistro del data grid view
            //los datos de ese usuario se muestren en el formulario y además el objeto del usuario local también se carga con dicha
            // información

            if (DgvListaUsuarios.SelectedRows.Count==1)
            {
                DataGridViewRow Fila = DgvListaUsuarios.SelectedRows[0];

                int IdUsuarioSeleccionado = Convert.ToInt32(Fila.Cells["CIDUsuario"].Value);

                MiUsuarioLocal = new Logica.Models.Usuario();
                MiUsuarioLocal = MiUsuarioLocal.ConsultarPorID(IdUsuarioSeleccionado);

                if (MiUsuarioLocal.IDUsuario >0)
                {
                    //se representa la info en los controles respectivos
                    //usando el obj MiUsuarioLocal como fuente de datos

                    LimpiarForm();

                    TxtCodigo.Text = MiUsuarioLocal.IDUsuario.ToString();
                    TxtNombre.Text = MiUsuarioLocal.Nombre;
                    TxtEmail.Text = MiUsuarioLocal.NombreUsuario;
                    TxtCedula.Text = MiUsuarioLocal.Cedula;
                    TxtTelefono.Text = MiUsuarioLocal.Telefono;
                    TxtEmailRespaldo.Text = MiUsuarioLocal.CorreoDeRespaldo;

                    CboxTipoUsuario.SelectedValue = MiUsuarioLocal.MiUsuarioRol.IDUsuarioRol;

                    ActivarEdiarYEliminar();

                    //Debemos considerar si la lista que se está visualizando es la de usuarios actvos o inactivos
                    //n caso de que sean los inactivos se dee desactivar la edición de los campos y la utilización del 
                    //botón editar

                    if (CbVerActivos.Checked)
                    {
                        GbDetalles.Enabled = true;
                        BtnEditar.Enabled = true;
                    }
                    else
                    {
                        GbDetalles.Enabled = false;
                        BtnEditar.Enabled = false;
                    }
                }
            
            
            }



        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //El codigo es muy similar al de agregar. Primero evalaur datos requeridos

            if (ValidarDatosRequeridos())
            {

                string Mensaje = string.Format("Desea continuar con la modificación del usuario [0]?",TxtNombre.Text.Trim());

                DialogResult respuesta = MessageBox.Show(Mensaje,"???", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    MiUsuarioLocal.Nombre = TxtNombre.Text.Trim();
                    MiUsuarioLocal.NombreUsuario = TxtEmail.Text.Trim();
                    MiUsuarioLocal.Cedula  = TxtCedula.Text.Trim();
                    MiUsuarioLocal.Telefono = TxtTelefono.Text.Trim();
                    MiUsuarioLocal.CorreoDeRespaldo = TxtEmailRespaldo.Text.Trim();
                    MiUsuarioLocal.Contrasennia = TxtPassword.Text.Trim();
                    MiUsuarioLocal.MiUsuarioRol.IDUsuarioRol = Convert.ToInt32(CboxTipoUsuario.SelectedValue);


                    if (MiUsuarioLocal.Editar()) 
                    {
                        string MensajeExito = string.Format("El usuario {0} se ha modificado correctamente", MiUsuarioLocal.Nombre);
                        MessageBox.Show(MensajeExito, ":)",MessageBoxButtons.OK);
                        
                        ListarUsuariosActivos();
                        LimpiarForm();
                        ActivarAgregar();
                    }
                    else
                    {
                        string MensajeFracaso = string.Format("El usuario {0} NO se ha modificado correctamente", MiUsuarioLocal.Nombre);
                        MessageBox.Show(MensajeFracaso, ":(", MessageBoxButtons.OK);
                    //TO DO : Determinar si es buena idea limpiar el form
                    
                    }
                }


            }
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            //al salir del cuadro de texto validamos en tiempo real que el formato de email sea el correcto

            if (!Validacion.ComprobarFormatoEmail(TxtEmail.Text.Trim()))
            {
                MessageBox.Show("El formato de Email es incorrecto","Error de validación", MessageBoxButtons.OK);
                TxtEmail.Focus();
                TxtEmail.SelectAll();
            }
        }

        private void TxtEmailRespaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtEmailRespaldo_Leave(object sender, EventArgs e)
        {
            if (!Validacion.ComprobarFormatoEmail(TxtEmailRespaldo.Text.Trim()))
            {
                MessageBox.Show("El formato de Email de respaldo es incorrecto", "Error de validación", MessageBoxButtons.OK);
                TxtEmailRespaldo.Focus();
                TxtEmailRespaldo.SelectAll();
            }
        }

        private void BtnVerPassword_MouseDown(object sender, MouseEventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = false;
        }

        private void BtnVerPassword_MouseUp(object sender, MouseEventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //En la funcionalidad de Editar la consulta por el ID se ejecuta directamente en la 
            //función editar, acá lo voy a consultar previamente

            if (MiUsuarioLocal.IDUsuario>0)
            {
                Logica.Models.Usuario UsuarioConsulta = new Logica.Models.Usuario();    
                UsuarioConsulta = MiUsuarioLocal.ConsultarPorID(MiUsuarioLocal.IDUsuario);
                if (UsuarioConsulta.IDUsuario >0)
                {
                    string Mensaje = "";

                    if (CbVerActivos.Checked)
                    {
                        Mensaje = string.Format("¿Desea continuar con la eliminación del usuario {0}", MiUsuarioLocal.Nombre);
                    }
                    else
                    {
                        Mensaje = string.Format("¿Desea continuar con la activación del usuario {0}", MiUsuarioLocal.Nombre);
                    }

                   
                    DialogResult resp = MessageBox.Show(Mensaje,"???", MessageBoxButtons.YesNo);

                    if (resp == DialogResult.Yes)
                    {
                        if (CbVerActivos.Checked)
                        {
                            if (MiUsuarioLocal.Eliminar())
                            {
                                MessageBox.Show("Usuario Eliminado Correctamente", ":/", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            if (MiUsuarioLocal.Activar())
                            {
                                MessageBox.Show("Usuario activado Correctamente", ":/", MessageBoxButtons.OK);

                            }

                        }
                        CbVerActivos.Checked = true;
                            ListarUsuariosActivos();
                            LimpiarForm();
                            ActivarAgregar();
                        }
                    }

                }
            }
        

        private void CbVerActivos_CheckStateChanged(object sender, EventArgs e)
        {
            if (CbVerActivos.Checked)
            {
                BtnEliminar.Text = "ELIMINAR";
                ListarUsuariosActivos();
                LimpiarForm();
                ActivarAgregar();
            }
            else
            {
                BtnEliminar.Text = "ACTIVAR";
                ListarUsuariosDesactivados();
                LimpiarForm();
                ActivarEdiarYEliminar();
            }
        }
    }
}
