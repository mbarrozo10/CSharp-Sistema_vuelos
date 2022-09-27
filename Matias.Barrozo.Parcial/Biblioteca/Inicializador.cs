using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Inicializador
    {
        public static List<Vendedor> InicializarVendedores()
        {
            List<Vendedor> Vendedores = new List<Vendedor>();
            Vendedores.Add(new Vendedor("Matias", "Barrozo", "mbarrozo", "1234"));
            Vendedores.Add(new Vendedor("Nicolas", "Gil", "lachancha", "1234"));
            Vendedores.Add(new Vendedor("Morena", "Escudero", "more", "1234"));
            Vendedores.Add(new Vendedor("Lucas", "Gaggino", "luki", "1234"));
            Vendedores.Add(new Vendedor("pepe", "pepe", "pepe", "pepe"));

            return Vendedores;
        }

        public static List<Avion> InicializarAviones()
        {
            List<Avion> aviones = new List<Avion>();

            aviones.Add(new Avion("A213012B", 100, 4, 2800, true, false,true));
            aviones.Add(new Avion("A133QEA", 200, 6, 5040, true, true, true ));
            aviones.Add(new Avion("A1924FA", 70, 2, 1764, false, false,true));
            aviones.Add(new Avion("AISNF393", 500, 8, 12600, true, true, true));
            aviones.Add(new Avion("BEW9B3", 700, 6, 17640, true, false, true));
            aviones.Add(new Avion("ANV3UIN9", 200, 4, 5040, true, true, true));
            aviones.Add(new Avion("ASIMFIVE9", 400, 6, 10080, true, false, true));

            return aviones;
        } 

        public static Dictionary<int,Pasajero> InicializarPasajeros()
        {
            Dictionary <int,Pasajero> pasajeros = new Dictionary<int, Pasajero>();
            int key= 1;

            for(int i = 0; i < 14; i++)
            {
                pasajeros.Add(key,new Pasajero(Aerolinea.clientes[i].Nombre, Aerolinea.clientes[i].Apellido, Aerolinea.clientes[i].Dni, Aerolinea.clientes[i].Edad, 2, true, true));
                key++;
            }

            for(int i=0; i < 55; i++)
            {
                pasajeros.Add(key,new Pasajero(Aerolinea.clientes[i].Nombre, Aerolinea.clientes[i].Apellido, Aerolinea.clientes[i].Dni, Aerolinea.clientes[i].Edad, 1, false, false));
                key++;
            }
            
            return pasajeros;
        }public static List<Cliente> InicializarClientes()
        {
            List <Cliente> pasajeros = new List<Cliente>();

            pasajeros.Add(new Cliente("Matias", "Barrozo", 41236275, 23,3));
            pasajeros.Add(new Cliente("Morena", "Escudero", 45666665, 21,6));
            pasajeros.Add(new Cliente("Nicolas", "Gil", 30456984, 32,8));
            pasajeros.Add(new Cliente("Lucas", "Gaggino", 39018697, 25,9));           
            pasajeros.Add(new Cliente("Matias", "Barrozo", 12345678, 23,3));
            pasajeros.Add(new Cliente("Morena", "Escudero", 12334569, 21,4));
            pasajeros.Add(new Cliente("Nicolas", "Gil", 123456787, 32,10));
            pasajeros.Add(new Cliente("Lucas", "Gaggino", 62552730, 25,9));            
            pasajeros.Add(new Cliente("Matias", "Barrozo", 27509733, 23,54));
            pasajeros.Add(new Cliente("Morena", "Escudero", 22154497, 21,9));
            pasajeros.Add(new Cliente("Nicolas", "Gil", 57278263, 32, 9));
            pasajeros.Add(new Cliente("Lucas", "Gaggino", 76114385, 25,6));            
            pasajeros.Add(new Cliente("Matias", "Barrozo", 60541436, 23,95));
            pasajeros.Add(new Cliente("Morena", "Escudero", 72236214, 21,29));
            pasajeros.Add(new Cliente("Nicolas", "Gil", 31243234, 32, 9));
            pasajeros.Add(new Cliente("Lucas", "Gaggino", 46086878, 25, 9));            
            pasajeros.Add(new Cliente("Matias", "Barrozo", 86567448, 23, 9));
            pasajeros.Add(new Cliente("Morena", "Escudero", 22458060, 21, 9));
            pasajeros.Add(new Cliente("Nicolas", "Gil", 30835887, 32, 9));
            pasajeros.Add(new Cliente("Lucas", "Gaggino", 34441020, 25, 9));            
            pasajeros.Add(new Cliente("Matias", "Barrozo", 40347641, 23, 9));
            pasajeros.Add(new Cliente("Morena", "Escudero", 5313423, 21, 9));
            pasajeros.Add(new Cliente("Nicolas", "Gil", 61795031, 32, 9));
            pasajeros.Add(new Cliente("Lucas", "Gaggino", 2904434, 25, 9));           
            pasajeros.Add(new Cliente("Matias", "Barrozo", 91944139, 23,10));
            pasajeros.Add(new Cliente("Morena", "Escudero", 78647758, 21,9));
            pasajeros.Add(new Cliente("Nicolas", "Gil", 5812683, 32,0));
            pasajeros.Add(new Cliente("Lucas", "Gaggino", 9724723, 25 ,29));           
            pasajeros.Add(new Cliente("Matias", "Barrozo", 78918479, 23, 41));
            pasajeros.Add(new Cliente("Morena", "Escudero", 55091433, 21, 29));
            pasajeros.Add(new Cliente("Nicolas", "Gil", 33637775, 32  ,9 ));
            pasajeros.Add(new Cliente("Lucas", "Gaggino", 4563842, 25 ,20));            
            pasajeros.Add(new Cliente("Matias", "Barrozo", 67888938, 23, 10));
            pasajeros.Add(new Cliente("Morena", "Escudero", 8604416, 21,31));
            pasajeros.Add(new Cliente("Nicolas", "Gil", 98288419, 32  , 10 ));
            pasajeros.Add(new Cliente("Lucas", "Gaggino", 11668765, 25, 40 ));          
            pasajeros.Add(new Cliente("Matias", "Barrozo", 40885276, 23,1));
            pasajeros.Add(new Cliente("Morena", "Escudero", 3635377, 21,1));
            pasajeros.Add(new Cliente("Nicolas", "Gil", 77160508, 32  ,1));
            pasajeros.Add(new Cliente("Lucas", "Gaggino", 39053075, 25,1 ));         
            pasajeros.Add(new Cliente("Matias", "Barrozo", 96130421, 23,1));
            pasajeros.Add(new Cliente("Morena", "Escudero", 29761073, 21,1));
            pasajeros.Add(new Cliente("Nicolas", "Gil", 11870775, 32 ,1 ));
            pasajeros.Add(new Cliente("Lucas", "Gaggino", 21897824, 25 ,1));         
            pasajeros.Add(new Cliente("Matias", "Barrozo", 1675764, 23,3));
            pasajeros.Add(new Cliente("Morena", "Escudero", 78971168, 21,4));
            pasajeros.Add(new Cliente("Nicolas", "Gil", 42843417, 32  ,1 ));
            pasajeros.Add(new Cliente("Lucas", "Gaggino", 27400988, 25, 10 ));         
            pasajeros.Add(new Cliente("Matias", "Barrozo", 49891330, 23, 10));
            pasajeros.Add(new Cliente("Morena", "Escudero", 43016321, 21, 10));
            pasajeros.Add(new Cliente("Nicolas", "Gil", 30847285, 32 , 10  ));
            pasajeros.Add(new Cliente("Lucas", "Gaggino", 53048246, 25 , 10));           
            pasajeros.Add(new Cliente("Matias", "Barrozo", 35917211, 23, 10));
            pasajeros.Add(new Cliente("Morena", "Escudero", 93819335, 21, 10));
            pasajeros.Add(new Cliente("Nicolas", "Gil", 43753426, 32 , 10  ));
            pasajeros.Add(new Cliente("Lucas", "Gaggino", 58174033, 25 , 10));           
            pasajeros.Add(new Cliente("Matias", "Barrozo", 67088889, 23, 10));
            pasajeros.Add(new Cliente("Morena", "Escudero", 52088592, 21, 10));
            pasajeros.Add(new Cliente("Nicolas", "Gil", 22174325, 32 , 10  ));
            pasajeros.Add(new Cliente("Lucas", "Gaggino", 5283733, 25, 10));           
            pasajeros.Add(new Cliente("Matias", "Barrozo", 52262760, 23, 10));
            pasajeros.Add(new Cliente("Morena", "Escudero", 91425441, 21, 10));
            pasajeros.Add(new Cliente("Nicolas", "Gil", 64124374, 32, 10));
            pasajeros.Add(new Cliente("Lucas", "Gaggino", 24404939, 25, 10));           
            pasajeros.Add(new Cliente("Matias", "Barrozo", 38584806, 23, 10));
            pasajeros.Add(new Cliente("Morena", "Escudero", 10818963, 21, 10));
            pasajeros.Add(new Cliente("Nicolas", "Gil", 97386786, 32, 10));
            pasajeros.Add(new Cliente("Lucas", "Gaggino", 39266527, 25, 10));
           // pasajeros.Add(new Cliente("Nicolas", "Gil", 55333135, 32));

            return pasajeros;
        }
        public static List<Vuelo> InicializarVuelos()
        {
            List<Vuelo> vuelos = new List<Vuelo>();

            vuelos.Add(new Vuelo(Aerolinea.aviones[2], 10, 1000, Destino.Miami, Estado.Disponible, Destino.Buenos_Aires, DateTime.Parse("2022/9/23 17:32:00"), InicializarPasajeros(),"A20394", DateTime.Parse("2001/6/15 20:30:00"),1,87241,14,55,69));
            vuelos.Add(new Vuelo(Aerolinea.aviones[0], 4, 200, Destino.Mendoza, Estado.EnVuelo, Destino.Buenos_Aires, DateTime.Parse("2022/11/8 14:30:00"), InicializarPasajeros(),"BMD93", DateTime.Parse("2022/11/8 18:30:00"),1330,17448,14,55,69));
            vuelos.Add(new Vuelo(Aerolinea.aviones[1], 4, 200, Destino.Neuquén, Estado.Disponible, Destino.Buenos_Aires, DateTime.Parse("2022/9/15 18:00:00"), InicializarPasajeros(),"N93J4FG", DateTime.Parse("2022/9/15 22:00:00"),3570,17448,14,55, 69));
            Aerolinea.aviones[0].Estado = false;
            Aerolinea.aviones[1].Estado = false;
            Aerolinea.aviones[2].Estado = false;
            Aerolinea.aviones[0].HorasVuelo += 10;
            Aerolinea.aviones[1].HorasVuelo += 4;
            Aerolinea.aviones[2].HorasVuelo += 4;

           return vuelos;
        }
    
    }
}
