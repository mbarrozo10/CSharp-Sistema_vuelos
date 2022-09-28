using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Persona
    {
        private string? nombre;
        private string? apellido;

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

      
        public string Nombre
        {
            get { return nombre; }
            set { 
                if(Validador.ValidarString(value))
                    nombre = value; 
                //else
                //    throw new Exception("Valor no correcto");
            }

        }
        public string Apellido
        {
            get { return apellido; }
            set{
                if (Validador.ValidarString(value))
                    apellido = value;
                //else
                //    throw new Exception("Valor no correcto");
            }
        }

        public abstract string MostrarInformacion();
    }
}
