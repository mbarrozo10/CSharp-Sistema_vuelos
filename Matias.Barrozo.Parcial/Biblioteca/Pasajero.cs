using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Pasajero : Persona
    {
        private int dni;
        private int edad;
        private int equipaje;
        private bool premium;
        

        public Pasajero(string nombre, string apellido,int dni, int edad, int equipaje, bool clase): base(nombre,apellido)
        {
            this.dni = dni;
            this.edad = edad;
            this.equipaje = equipaje;
            this.premium = clase;
        }

        public int Dni
        {
            get { return dni; }
        }

        public int Edad
        {
            get { return edad; }
        }

        public bool Premium
        {
            get { return premium; }
        }
        
        public int Equipaje
        {
            get { return equipaje; }
        }
    }
}
