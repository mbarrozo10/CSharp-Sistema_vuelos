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
        public static bool modoOscuro = false;
        public static List<Vuelo> vuelosFinalizados = new List<Vuelo>();
        public static List<Cliente> clientes = new List<Cliente>();

        public static void CargarDatos()
        {
            Aerolinea.Vendedores = Inicializador.InicializarVendedores();
            Aerolinea.clientes = Inicializador.InicializarClientes();
            Aerolinea.aviones = Inicializador.InicializarAviones();
            Aerolinea.vuelos = Inicializador.InicializarVuelos();
        }
        
        public static float CalcularRecaudacionTotal()
        {
            float retorno=0;
            if (vuelos.Count > 0)
            {
                foreach(Vuelo vuelo in vuelos)
                {
                    retorno += vuelo.Recaudacion;
                }
            }
            if (vuelosFinalizados.Count > 0)
            {
                foreach(Vuelo vuelo in vuelosFinalizados)
                {
                    retorno += vuelo.Recaudacion;
                }
            }

            return retorno;
        }

        public static void BorrarVuelo(Vuelo vuelo)
        {
            Aerolinea.vuelosFinalizados.Add(vuelo);
            Aerolinea.vuelos.Remove(vuelo);
        }


    }
}
