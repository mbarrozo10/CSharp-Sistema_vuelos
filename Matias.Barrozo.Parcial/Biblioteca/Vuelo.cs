using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum EDestino{
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

    public enum EEstado
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
        private EDestino destino;
        private EEstado estado;
        private DateTime salida;
        private EDestino origen;
        private Dictionary<int,Pasajero> pasajeros;
        private string codigo;
        private int asientosOcupadoTurista;
        private int asientosOcupadoPremium;
        private DateTime llegada;
        private float recuadacion;
        private int bodegaRestante;
        private int ultimoAsiento;

        public override string ToString()
        {
            string retorno = "Avion: " + this.avion.Matricula + "\nDuracion del vuelo: " + duracion + "\nCosto de pasaje: " + costoDePasaje +
                "\nDestino: " + destino + "\nEstado: " + estado + "\nFecha de salida: " + salida + "\nOrigen: " + origen +
                "\nCodigo de vuelo: " + codigo + "\nAsientos ocupados turista: " + asientosOcupadoTurista + " de: " + CalcularAsientos(this.avion.CantidadAsientos, 0.80f) +
                "\nAsientos ocupados premium: " + asientosOcupadoPremium + " de: " + CalcularAsientos(this.avion.CantidadAsientos, 0.20f) + "\nFecha de llegada" +
                llegada + "\nRecaudacion: " + Recaudacion + "\nBodega restante: " + bodegaRestante;
            return retorno;
        }


        public Vuelo(Avion avion, EDestino destino, EEstado estado, EDestino origen, DateTime salida, Dictionary<int,Pasajero> pasajeros, string codigo, float horarioElegido, int bodega, float recaudacion, int asientosPremium, int asientosTurista)
        {
            this.avion = avion;
            this.Duracion = this.CalcularDuracion(destino);
            this.destino = destino;
            this.costoDePasaje = this.CalcularCosto(destino,duracion);
            this.estado = estado;
            this.salida = salida;
            this.origen = origen;
            this.pasajeros = pasajeros;
            this.codigo = codigo.ToUpper();
            this.AsientosLibresTurista = asientosTurista;
            this.llegada = CalcularLlegada(horarioElegido);
            this.Recaudacion = recaudacion ;
            this.bodegaRestante = bodega;
            this.AsientosLibresPremium =asientosPremium;
            this.ultimoAsiento = 1;
        }
        
        public Vuelo(Avion avion, int duracion, EDestino destino, EEstado estado, EDestino origen, DateTime salida, Dictionary<int,Pasajero> pasajeros, string codigo, float horarioElegido, int bodega, float recaudacion, int asientosPremium, int asientosTurista, int ultimoAsiento):this(avion,destino,estado,origen,salida,pasajeros,codigo,horarioElegido,bodega,recaudacion,asientosPremium,asientosTurista)
        {
            this.ultimoAsiento = ultimoAsiento;
            this.duracion = duracion;
            this.salida = salida;
            this.llegada= CalcularLlegada(horarioElegido);
            this.costoDePasaje = CalcularCosto(destino, duracion);
           
        }

        public int BodegaRestante
        {
            get { return bodegaRestante; }
            set { bodegaRestante = value; }
        }

        public DateTime Llegada
        {
            get { return llegada; }
        }

        public float Recaudacion
        {
            get { return recuadacion; }
            set {
                if(Validador.ValidarFloatEnRango(value.ToString(),-1,int.MaxValue))
                    recuadacion = value; 
                else
                    throw new Exception("Valor no correcto");
            }
        }

        public int AsientosLibresTurista
        {
            get { return asientosOcupadoTurista; }
            set { 
                if(Validador.ValidarNumeroEnRango(value.ToString(),-1,int.MaxValue))
                    asientosOcupadoTurista = value; 
                else
                    throw new Exception("Valor no correcto");
            }

        }



        public int AsientosLibresPremium
        {
            get { return asientosOcupadoPremium; }
            set { 
                if(Validador.ValidarNumeroEnRango(value.ToString(),-1,int.MaxValue))
                    asientosOcupadoPremium = value; 
  
            }
        }

        public Dictionary<int,Pasajero> Pasajeros
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

        public EEstado Estado
        {
            get { return estado; }  
            set { estado = value; }
        }

        private float CalcularCosto(EDestino destino, int duracion)
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

        public EDestino Destino
        {
            get { return destino; }
    
        }

        public int Duracion
        {
            get { return duracion; }
            set
            {
                if (Validador.ValidarNumeroEnRango(value.ToString(), -1, 14))
                    duracion = value;
            }
        }

        private DateTime CalcularLlegada(float horaElegida)
        {
             if (duracion + horaElegida >= 24)
            {
                llegada = Salida.AddDays(1);
            }
            llegada = salida.AddHours(duracion);
                
             return llegada;
        }

        public EDestino Origen
        {
            get { return origen; }
        }

        public int UltimoAsiento
        {
            get { return ultimoAsiento; }
            set { ultimoAsiento = value; }
        }
        

        public  int CalcularDuracion(EDestino destino)
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

        public bool VerificarEspacio(int cantidadPedida)
        {
            return (this.pasajeros.Count + cantidadPedida) > this.Avion.CantidadAsientos;
        }

        
    }

   
}
