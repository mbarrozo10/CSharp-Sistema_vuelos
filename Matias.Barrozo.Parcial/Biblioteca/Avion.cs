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

        public Avion(string matricula, int cantidadAsientos, int cantidadBaños, int bodega, bool comida, bool wifi)
        {
            this.matricula = matricula;
            this.cantidadAsientos = cantidadAsientos;
            this.cantidadBaños = cantidadBaños;
            this.bodega = bodega;
            this.comida = comida;
            this.wifi = wifi;
        }

        public string Matricula
        {
            get { return matricula; }
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
