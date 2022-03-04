using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionP5_Jessica
{
  public static class ObjetosGlobales
    {
        //esta clase se "autoinstancia" al momento de inicializar la app
        //los atributos y funciones que sean píblicas serán visibles en la 
        //globalidad de la app

        public static Formularios.FrmUsuariosGestion MiFormDeGestionDeUsuarios = new Formularios.FrmUsuariosGestion();

    }
}
