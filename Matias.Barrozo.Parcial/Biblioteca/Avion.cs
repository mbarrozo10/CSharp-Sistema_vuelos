using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Avion
    {
        private string matricula;
        private int cantidadAsientos;
        private int cantidadBaños;
        private int bodega;
        private bool comida;
        private bool wifi;
        private int horasVuelo;

        
        public Avion(string matricula, int cantidadAsientos, int cantidadBaños, int bodega, bool comida, bool wifi) { 

            this.matricula = matricula;
            this.cantidadAsientos = cantidadAsientos;
            this.cantidadBaños = cantidadBaños;
            this.bodega = bodega;
            this.comida = comida;
            this.wifi = wifi;
            //this.disponible = estado;
            this.horasVuelo = 0;
        }

       
        public string Matricula
        {
            get { return matricula; }
        }

        public int HorasVuelo
        {
            get { return horasVuelo; }
            set { horasVuelo = value; }
        }
        public int CantidadAsientos
        {
            get { return cantidadAsientos; }
        }

        public int CantidadBaños
        {
            get { return cantidadBaños; }
        }

        public bool Comida
        {
            get { return comida; }
        }

        public int Bodega
        {
            get { return bodega; }
        }

        public bool Wifi
        {
            get { return wifi; }
        }

        public override string ToString()
        {
            return "Matricula: " + Matricula + "\nCantidad de asientos: " + cantidadAsientos 
                + "\nCantidad de Baños: " + CantidadBaños + "\nHoras de vuelo: " + HorasVuelo + 
                 "\nWifi? " + Wifi +  "\nBodega: " + Bodega + "\nTiene comida? " + Comida+ "\n";
        }

        public override bool Equals(object? obj)
        {
            Avion? avion = obj as Avion;
            if (avion is not null)
            {
                return  this.matricula == avion.Matricula;
            }
            return false;
        }

        public static int ConseguirIndex(string matricula)
        {
            for (int i = 0; i < Aerolinea.aviones.Count; i++)
            {
                if (matricula == Aerolinea.aviones[i].Matricula)
                {
                    return i;
                }
            }
            return -1;
        }


    }
}
