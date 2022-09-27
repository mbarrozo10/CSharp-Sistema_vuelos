using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Validador
    {

        public static bool ValidarString(string cadena)
        {
            for(int i = 0; i < cadena.Length; i++)
            {
                if (!char.IsLetter(cadena[i]))
                {
                    return false;
                }
            }


            return true;
        }

        public static bool ValidarNumeroEnRango( string numero , int min, int max)
        {
            if(int.TryParse(numero, out int i))
            {
                if(i > min && i < max )
                {
                    return true;
                }
            }
            return false;
        }
    }
}
