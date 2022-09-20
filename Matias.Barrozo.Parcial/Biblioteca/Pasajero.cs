using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Pasajero : Cliente
    {
       
        private int equipaje;
        private bool premium;
        private bool bolsoMano;
        
        public Pasajero(string nombre, string apellido,int dni, int edad, int equipaje, bool clase, bool bolsoMano): base(nombre,apellido,dni,edad)
        {
            
            this.equipaje = equipaje;
            this.premium = clase;
            this.bolsoMano = bolsoMano;
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
