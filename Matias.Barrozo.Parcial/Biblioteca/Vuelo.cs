using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum Destino{
        Buenos_Aires,
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
        Finalizado,
        Cancelado

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
        private int asientosOcupadoTurista;
        private int asientosOcupadoPremium;
        private DateTime llegada;
        private float recuadacion;
        private int bodegaRestante;

        public override string ToString()
        {
            string retorno = "Avion: " + this.avion.Matricula + "\nDuracion del vuelo: " + duracion + "\nCosto de pasaje: " + costoDePasaje +
                "\nDestino: " + destino + "\nEstado: " + estado + "\nFecha de salida: " + salida + "\nOrigen: " + origen +
                "\nCodigo de vuelo: " + codigo + "\nAsientos ocupados turista: " + asientosOcupadoTurista + " de: " + CalcularAsientos(this.avion.CantidadAsientos, 0.80f) +
                "\nAsientos ocupados premium: " + asientosOcupadoPremium + " de: " + CalcularAsientos(this.avion.CantidadAsientos, 0.20f) + "\nFecha de llegada" +
                llegada + "\nRecaudacion: " + Recaudacion + "\nBodega restante: " + bodegaRestante;
            return retorno;
        }
        // agregar discriminacion de asientos premium

        //public Vuelo(Avion avion, int duracion, float costoDePasaje, Destino destino, Estado estado, string origen, DateTime salida, List<Pasajero> pasajeros, string codigo, DateTime llegada, int asientosPremium, int asientosTurista)
        //{
        //    this.avion = avion;
        //    this.duracion = duracion;
        //    this.costoDePasaje = costoDePasaje;
        //    this.destino = destino;
        //    this.estado = estado;
        //    this.salida = salida;
        //    this.origen = origen;
        //    this.pasajeros = pasajeros;
        //    this.codigo = codigo.ToUpper();
        //    this.asientosLibreTurista = CalcularAsientos(this.avion.CantidadAsientos, 0.80f); 
        //    this.llegada = llegada;
        //    this.recuadacion = 0;
        //    this.bodegaRestante = this.avion.Bodega;
        //    this.asientosLibrePremium = CalcularAsientos(this.avion.CantidadAsientos, 0.20f);
        //}


        public Vuelo(Avion avion, int duracion, float costoDePasaje, Destino destino, Estado estado, string origen, DateTime salida, List<Pasajero> pasajeros, string codigo, DateTime llegada, int bodega, float recaudacion, int asientosPremium, int asientosTurista)//:this(avion,duracion,costoDePasaje,destino,estado,origen,salida,pasajeros,codigo,llegada,asientosPremium,asientosTurista)
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
            this.asientosOcupadoTurista = asientosTurista;
            this.llegada = llegada;
            this.recuadacion = recaudacion ;
            this.bodegaRestante = bodega;
            this.asientosOcupadoPremium =asientosPremium;
        }

        public int BodegaRestante
        {
            get { return bodegaRestante; }
            set { this.recuadacion = value; }
        }

        public DateTime Llegada
        {
            get { return llegada; }
        }

        public float Recaudacion
        {
            get { return recuadacion; }
            set { recuadacion = value; }
        }

        public int AsientosLibresTurista
        {
            get { return asientosOcupadoTurista; }
            set { asientosOcupadoTurista = value; }
        }



        public int AsientosLibresPremium
        {
            get { return asientosOcupadoPremium; }
            set { asientosOcupadoPremium = value; }
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
            set { estado = value; }
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
                return rnd.Next(8, 13);
            }
            else
            {
                return rnd.Next(2, 5);
            }
           
        }

        public static int CalcularAsientos(int asientos, float porcentaje)
        {
            return (int)(asientos * porcentaje);
        }

        
        
    }

   
}
