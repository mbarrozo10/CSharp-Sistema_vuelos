
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente : Persona
    {
        private int dni;
        private int edad;
        private int cantPasajesComprados;


        public Cliente( string nombre, string apellido,int dni, int edad): base(nombre,apellido)
        {
            this.dni = dni;
            this.edad = edad;
            this.cantPasajesComprados = 0;
        }

        public Cliente(string nombre, string apellido, int dni, int edad,int cantPasajesComprados) : this(nombre,apellido,dni,edad)
        {
            this.dni = dni;
            this.edad = edad;
            this.cantPasajesComprados = cantPasajesComprados;
        }

        public int Dni
        {
            get { return dni; }
        }

        public int CantPasajesComprados
        {
            get { return cantPasajesComprados; }
            set { cantPasajesComprados = value; }
        }

        public int Edad
        {
            get { return edad; }
        }
        public override bool Equals(object? obj)
        {

            Cliente? pasajero = obj as Cliente;
            if(pasajero != null)
                return this.dni == pasajero.Dni;
            else
                return false;


        }
    }
}
