
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
            this.Dni = dni;
            this.Edad = edad;
            this.CantPasajesComprados = 0;
        }

        public Cliente(string nombre, string apellido, int dni, int edad,int cantPasajesComprados) : this(nombre,apellido,dni,edad)
        {
            this.Dni = dni;
            this.Edad = edad;
            this.CantPasajesComprados = cantPasajesComprados;
        }

        public int Dni
        {
            get { return dni; }
            set
            {
                if (Validador.ValidarNumeroEnRango(value.ToString(), 10000000, 100000000))
                {
                    dni = value;
                }
                //else
                //{
                //    throw new Exception("Valor no correcto");
                //}
            }
        }

        public int CantPasajesComprados
        {
            get { return cantPasajesComprados; }
            set { 
                if(Validador.ValidarNumeroEnRango(value.ToString(),-1,100))
                    cantPasajesComprados = value; 
                //else
                //    throw new Exception("Valor no correcto");
            }
        }

        public int Edad
        {
            get { return edad; }
            set
            {
                if (Validador.ValidarNumeroEnRango(value.ToString(), 0, 100))
                {
                    edad = value;   
                }
                //else
                //{
                //    throw new Exception("Valor no correcto");
                //}
            }
        }
        public override bool Equals(object? obj)
        {

            Cliente? pasajero = obj as Cliente;
            if(pasajero != null)
                return this.dni == pasajero.Dni;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
