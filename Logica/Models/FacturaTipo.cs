using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Logica.Models
{
  public class FacturaTipo
    {

        //En una estructura estándar de clase, primero se escriben los atributos simples.
        //Luego los atributos compuestos
        //Despues las operaciones(métodos y funciones)
        //normalmente, además se puede escribir un constructor si es necesario

        //1. Atributos
        //esta es la forma estándar de escribir un atributo(propiedad) con su respectivo get y set,
        //siguiendo la norma que dice qeu los privados inician con letra minúscula y los respectivos
        //get y set la primera letra en mayúscula
        //NOTA: esta forma cada vez se usa menos 

        private int idFacturaTipo;

        public int IDFacturaTipo
        {
            get { return idFacturaTipo; }
            set { idFacturaTipo = value; }
        }

        //la siguiente es la forma simplificada, y es la más común en la documentación

        public string Tipo { get; set; }

        //3. Operaciones

        public DataTable Listar()
        {
            //instancio variable de retorno
            DataTable R = new DataTable();

            //TO DO: Escribir código para llenar R con los datos
            ////necesarios
            return R;
        }
    }
}
