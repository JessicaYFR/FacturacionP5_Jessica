using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
   public class Cliente
    {
        //Atributos simples
        public int IDCliente { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }

        //Atributo compuesto
        ClienteTipo MiTipo { get; set; }

        //Constructor de la clase para instanciar el atributo 
        //compuesto simple

        //ctor(sniped)
        public Cliente()
        {
            //dentro de este constructor instancio los objetos compuestos
            MiTipo = new ClienteTipo();
        }

        //operaciones

        //esta funcion "agregar()" se usa acá con fines didácticos,
        //ya qye pasamos los valores por medio de parámetro. El profe aconseja pasaralos directamente, sino
        //en los atributios cuando se crea el objeto

        public bool Agregar(string pNombre, string pCedula, string pTelefono = "", string pEmail = "")
        {
            bool R = false;
            //Cuando se usa de esta forma el paso de valores se realiza por acá
            Nombre = pNombre;
            Cedula = pCedula;
            Telefono = pTelefono;
            Email = pEmail;

            //TO DO : ejecutar el sp para el insert en tabla de cliente
            return R;
        }

        public bool Editar(int pIDCliente, string pNombre, string pCedula, string pTelefono = "", string pEmail = "") {

            bool R = false;

            return R;
        }
        public bool Eliminar(int pIDCliente)
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorCedula(string pCedula)
        {
            bool R = false;

            return R;

        }
        public bool ConsultarPorID(int pIDCliente)
        {
            bool R = false;

            return R;

        }
       public DataTable Listar(bool VerActivos = true)
        {
            DataTable R = new DataTable();

            return R;
        }
    }
}
