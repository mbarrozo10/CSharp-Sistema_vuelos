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
        private Destino origen;
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


        public Vuelo(Avion avion, int duracion, float costoDePasaje, Destino destino, Estado estado, Destino origen, DateTime salida, Dictionary<int,Pasajero> pasajeros, string codigo, DateTime llegada, int bodega, float recaudacion, int asientosPremium, int asientosTurista)//:this(avion,duracion,costoDePasaje,destino,estado,origen,salida,pasajeros,codigo,llegada,asientosPremium,asientosTurista)
        {
            this.avion = avion;
            this.Duracion = duracion;
            this.costoDePasaje = costoDePasaje;
            this.destino = destino;
            this.estado = estado;
            this.salida = salida;
            this.origen = origen;
            this.pasajeros = pasajeros;
            this.codigo = codigo.ToUpper();
            this.AsientosLibresTurista = asientosTurista;
            this.llegada = llegada;
            this.Recaudacion = recaudacion ;
            this.bodegaRestante = bodega;
            this.AsientosLibresPremium =asientosPremium;
            this.ultimoAsiento = 1;
        }
        
        public Vuelo(Avion avion, int duracion, float costoDePasaje, Destino destino, Estado estado, Destino origen, DateTime salida, Dictionary<int,Pasajero> pasajeros, string codigo, DateTime llegada, int bodega, float recaudacion, int asientosPremium, int asientosTurista, int ultimoAsiento):this(avion,duracion,costoDePasaje,destino,estado,origen,salida,pasajeros,codigo,llegada,bodega,recaudacion,asientosPremium,asientosTurista)
        {
            this.ultimoAsiento = ultimoAsiento;
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
            set
            {
                if (Validador.ValidarNumeroEnRango(value.ToString(), -1, 14))
                    duracion = value;
            }
        }

        public Destino Origen
        {
            get { return origen; }
        }

        public int UltimoAsiento
        {
            get { return ultimoAsiento; }
            set { ultimoAsiento = value; }
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
