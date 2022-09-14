using System;
using System.Collections.Generic;
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

        public Vuelo(Avion avion, int duracion, float costoDePasaje, Destino destino, Estado estado, string origen, DateTime salida, List<Pasajero> pasajeros)
        {
            this.avion = avion;
            this.duracion = duracion;
            this.costoDePasaje = costoDePasaje;
            this.destino = destino;
            this.estado = estado;
            this.salida = salida;
            this.origen = origen;
            this.pasajeros = new List<Pasajero>();

        }

        public Avion Avion
        {
            get { return avion; }
        }

        

        public float CostoDePasaje
        {
            get { return costoDePasaje; }
        }

        public Estado Estado
        {
            get { return estado; }  
        }

        public float CalcularCosto()
        {
            if (CheckDestino())
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
            set {duracion = CalcularDuracion();}
            get { return duracion; }
        }
        

        public int CalcularDuracion()
        {
            Random rnd = new Random();

            if (CheckDestino())
            {
                return rnd.Next(8, 12);
            }
            else
            {
                return rnd.Next(2, 4);
            }
           
        }
        private bool CheckDestino()
        {
            switch (Destino)
            {
                case Destino.Recife:
                    return true;
                case Destino.Roma:
                    return true;
                case Destino.Acapulco:
                    return true;
                case Destino.Miami:
                    return true;
                default:
                    return false;

            }
        }
    }

   
}
