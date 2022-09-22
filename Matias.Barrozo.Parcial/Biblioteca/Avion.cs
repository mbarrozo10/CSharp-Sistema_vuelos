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
        private bool estado;
        private int horasVuelo;

        
        public Avion(string matricula, int cantidadAsientos, int cantidadBaños, int bodega, bool comida, bool wifi, bool estado) { 

            this.matricula = matricula;
            this.cantidadAsientos = cantidadAsientos;
            this.cantidadBaños = cantidadBaños;
            this.bodega = bodega;
            this.comida = comida;
            this.wifi = wifi;
            this.estado = estado;
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


        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

       
    }
}
