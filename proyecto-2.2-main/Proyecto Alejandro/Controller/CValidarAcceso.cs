using Proyecto_Alejandro.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Alejandro.Controller
{
    public class CValidarAcceso
    {
        public static DataTable Validar_Acceso(string Usuario, string Contraseña)
        {
            return new DValidarAcceso().Validar_Acceso(Usuario, Contraseña);
        }
    }
}