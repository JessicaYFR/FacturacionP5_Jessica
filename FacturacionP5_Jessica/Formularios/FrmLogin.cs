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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            //Si la combinacion de teclas es la adecuada muestra el boton de ingreso directo

            if (e.Shift & e.KeyCode == Keys.CapsLock)
            {
                BtnIngresoDirecto.Visible = true;
            }

        }

        private void BtnIngresoDirecto_Click(object sender, EventArgs e)
        {
//To Do: Haremos un usuario global que permita evaluar las funciones del sistema


            ObjetosGlobales.MiFormularioPrincipal.Show();
            this.Hide();


        }

        private void PbVerPassword_MouseDown(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = false;   
        }

        private void PbVerPassword_MouseUp(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = true;
        }

        private bool ValidarDatosRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtUsuario.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtContrasennia.Text.Trim())&&
                Validacion.ComprobarFormatoEmail(TxtUsuario.Text.Trim()))
            {
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(TxtUsuario.Text.Trim()))
                {
                    MessageBox.Show("Falta el nombre de usuario","Error de validación",MessageBoxButtons.OK);
                TxtUsuario.Focus();
                    return false;                             
                }
                if (string.IsNullOrEmpty(TxtContrasennia.Text.Trim()))
                {
                    MessageBox.Show("Falta la contraseña", "Error de validación", MessageBoxButtons.OK);
                    TxtUsuario.Focus();
                    return false;
                }
                if (!Validacion.ComprobarFormatoEmail(TxtUsuario.Text.Trim()))
                {
                    MessageBox.Show("El nombre de usuario no tiene el formato correcto", "Error de validación", MessageBoxButtons.OK);
                    TxtUsuario.SelectAll();
                    return false;
                }
            }



            return R;
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {
                //Existe un usuario y contraseña

                Logica.Models.Usuario MiUsuario = new Logica.Models.Usuario();  
                 string user = TxtUsuario.Text.Trim();  
                string password = TxtContrasennia.Text.Trim();

                ObjetosGlobales.MiUsuarioGlobal = MiUsuario.ValidarIngreso(user, password);

                if (ObjetosGlobales.MiUsuarioGlobal != null && 
                    ObjetosGlobales.MiUsuarioGlobal.IDUsuario >0)
                {
//el usuario tiene permiso de ingresar al sistema
ObjetosGlobales.MiFormularioPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos","Error de validación", MessageBoxButtons.OK);
                TxtContrasennia.Focus();
                    TxtContrasennia.SelectAll();
                }

            }
        }
    }
}
