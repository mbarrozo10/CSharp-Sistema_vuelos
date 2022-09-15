using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Aerolinea
    {
        public static List<Vendedor> Vendedores = new List<Vendedor>();
        public static List<Avion> aviones = new List<Avion>();
        public static List<Vuelo> vuelos = new List<Vuelo>();

        public static int ConseguirIndex(string matricula)
        {
            for (int i = 0; i < aviones.Count; i++)
            {
                if (matricula == aviones[i].Matricula)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
