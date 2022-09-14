using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum Destino{
        Santa_Rosa,
        Bariloche,
        Corrientes,
        Córdoba,
        Jujuy,
        Mendoza,
        Neuquén,
        Posadas,
        Iguazú,
        Salta,
        Santiago_del_Estero,
        Trelew,
        Tucumán,
        Puerto_Madryn,
        Ushuaia,
        Recife,
        Roma,
        Acapulco,
        Miami
    }

    public enum Estado
    {
        Lleno,
        Disponible,
        EnVuelo,
        Finalizado
    }



    public class Vuelo
    {
        private Avion avion;
        private int duracion;
        private float costoDePasaje;
        private Destino destino;
        private Estado estado;
        private DateTime salida;
        private string origen;
        private List<Pasajero> pasajeros;
        private string codigo;
        private int asientosLibres;

        public Vuelo(Avion avion, int duracion, float costoDePasaje, Destino destino, Estado estado, string origen, DateTime salida, List<Pasajero> pasajeros, string codigo)
        {
            this.avion = avion;
            this.duracion = duracion;
            this.costoDePasaje = costoDePasaje;
            this.destino = destino;
            this.estado = estado;
            this.salida = salida;
            this.origen = origen;
            this.pasajeros = pasajeros;
            this.codigo = codigo.ToUpper();
            this.asientosLibres = this.avion.CantidadAsientos - pasajeros.Count;
        }

        public int AsientosLibres
        {
            get { return asientosLibres; }
        }

        public List<Pasajero> Pasajeros
        {
            get { return pasajeros; }
        }
            
        
        public string Codigo
        {
            get { return codigo; }
        }
        public Avion Avion
        {
            get { return avion; }
        }

        public DateTime Salida
        {
            get { return salida; }
        }

  

        public float CostoDePasaje
        {
            get { return costoDePasaje; }
        }

        public Estado Estado
        {
            get { return estado; }  
        }

        public static float CalcularCosto(Destino destino, int duracion)
        {
            if (((int)destino) > 14)
            {
                return (float)(100 * duracion);
            }
            else
            {
                return (float)(50 * duracion);
            }
        }

        public Destino Destino
        {
            get { return destino; }
    
        }

        public int Duracion
        {
            get { return duracion; }
        }

        public string Origen
        {
            get { return origen; }
        }
        

        public static int CalcularDuracion(Destino destino)
        {
            Random rnd = new Random();

            if (((int)destino)>14)
            {
                return rnd.Next(8, 12);
            }
            else
            {
                return rnd.Next(2, 4);
            }
           
        }
        
    }

   
}
