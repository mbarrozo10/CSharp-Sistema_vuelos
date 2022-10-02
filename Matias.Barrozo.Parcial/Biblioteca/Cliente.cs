
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
            this.CantPasajesComprados = cantPasajesComprados;
        }

        public int Dni
        {
            get { return this.GetHashCode(); }
            set
            {
                if (Validador.ValidarNumeroEnRango(value.ToString(), 4000000, 100000000))
                {
                    dni = value;
                }
                else
                {
                    throw new Exception("Dni incorrecto");
                }
            }
        }

        public int CantPasajesComprados
        {
            get { return cantPasajesComprados; }
            set {
                if (Validador.ValidarNumeroEnRango(value.ToString(), -1, 100))
                    cantPasajesComprados = value;
                else
                    throw new Exception("Valor erroneo");
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

                else
                {
                    throw new Exception("Edad incorrecta");
                }
            }
        }
        public override bool Equals(object? obj)
        {

            Cliente? pasajero = obj as Cliente;
            if(pasajero != null)
                return this.Dni == pasajero.Dni;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return dni;
        }

      
        public override string ToString()
        {
            return Nombre +" "+ Apellido;
        }

        public override string MostrarInformacion()
        {
            return "Nombre: " + Nombre + "\nApellido: " + Apellido + "\nDni: " + this.GetHashCode() + "\nEdad: " + Edad;
        }


    }
}
