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

            aviones.Add(new Avion("A213012B", 100, 4, 1680, true, false));
            aviones.Add(new Avion("A133QEA", 200, 6, 5040, true, true));
            aviones.Add(new Avion("A1924FA", 70, 2, 1764, false, false));
            aviones.Add(new Avion("AISNF393", 500, 8, 12600, true, true));
            aviones.Add(new Avion("BEW9B3", 700, 6, 17640, true, false));
            aviones.Add(new Avion("ANV3UIN9", 200, 4, 5040, true, true));
            aviones.Add(new Avion("ASIMFIVE9", 400, 6, 10080, true, false));

            return aviones;
        } 

        public static List<Pasajero> InicializarPasajeros()
        {
            List <Pasajero> pasajeros = new List<Pasajero>();

            pasajeros.Add(new Pasajero("Matias", "Barrozo", 41236275, 23, 1, true));
            pasajeros.Add(new Pasajero("Morena", "Escudero", 45666665, 21, 2, true));
            pasajeros.Add(new Pasajero("Nicolas", "Gil", 30456984, 32, 1, true));
            pasajeros.Add(new Pasajero("Lucas", "Gaggino", 39018697, 25, 1, true));           
            pasajeros.Add(new Pasajero("Matias", "Barrozo", 41236275, 23, 1, true));
            pasajeros.Add(new Pasajero("Morena", "Escudero", 45666665, 21, 2, true));
            pasajeros.Add(new Pasajero("Nicolas", "Gil", 30456984, 32, 1, true));
            pasajeros.Add(new Pasajero("Lucas", "Gaggino", 39018697, 25, 1, true));            
            pasajeros.Add(new Pasajero("Matias", "Barrozo", 41236275, 23, 1, true));
            pasajeros.Add(new Pasajero("Morena", "Escudero", 45666665, 21, 2, true));
            pasajeros.Add(new Pasajero("Nicolas", "Gil", 30456984, 32, 1, false));
            pasajeros.Add(new Pasajero("Lucas", "Gaggino", 39018697, 25, 1, false));            
            pasajeros.Add(new Pasajero("Matias", "Barrozo", 41236275, 23, 1, true));
            pasajeros.Add(new Pasajero("Morena", "Escudero", 45666665, 21, 2, true));
            pasajeros.Add(new Pasajero("Nicolas", "Gil", 30456984, 32, 1, false));
            pasajeros.Add(new Pasajero("Lucas", "Gaggino", 39018697, 25, 1, false));            
            pasajeros.Add(new Pasajero("Matias", "Barrozo", 41236275, 23, 1, true));
            pasajeros.Add(new Pasajero("Morena", "Escudero", 45666665, 21, 2, true));
            pasajeros.Add(new Pasajero("Nicolas", "Gil", 30456984, 32, 1, false));
            pasajeros.Add(new Pasajero("Lucas", "Gaggino", 39018697, 25, 1, false));            
            pasajeros.Add(new Pasajero("Matias", "Barrozo", 41236275, 23, 1, true));
            pasajeros.Add(new Pasajero("Morena", "Escudero", 45666665, 21, 2, true));
            pasajeros.Add(new Pasajero("Nicolas", "Gil", 30456984, 32, 1, false));
            pasajeros.Add(new Pasajero("Lucas", "Gaggino", 39018697, 25, 1, false));           
            pasajeros.Add(new Pasajero("Matias", "Barrozo", 41236275, 23, 1, true));
            pasajeros.Add(new Pasajero("Morena", "Escudero", 45666665, 21, 2, true));
            pasajeros.Add(new Pasajero("Nicolas", "Gil", 30456984, 32, 1, false));
            pasajeros.Add(new Pasajero("Lucas", "Gaggino", 39018697, 25, 1, false));           
            pasajeros.Add(new Pasajero("Matias", "Barrozo", 41236275, 23, 1, true));
            pasajeros.Add(new Pasajero("Morena", "Escudero", 45666665, 21, 2, true));
            pasajeros.Add(new Pasajero("Nicolas", "Gil", 30456984, 32, 1, false));
            pasajeros.Add(new Pasajero("Lucas", "Gaggino", 39018697, 25, 1, false));            
            pasajeros.Add(new Pasajero("Matias", "Barrozo", 41236275, 23, 1, true));
            pasajeros.Add(new Pasajero("Morena", "Escudero", 45666665, 21, 2, true));
            pasajeros.Add(new Pasajero("Nicolas", "Gil", 30456984, 32, 1, false));
            pasajeros.Add(new Pasajero("Lucas", "Gaggino", 39018697, 25, 1, false));          
            pasajeros.Add(new Pasajero("Matias", "Barrozo", 41236275, 23, 1, true));
            pasajeros.Add(new Pasajero("Morena", "Escudero", 45666665, 21, 2, true));
            pasajeros.Add(new Pasajero("Nicolas", "Gil", 30456984, 32, 1, false));
            pasajeros.Add(new Pasajero("Lucas", "Gaggino", 39018697, 25, 1, false));         
            pasajeros.Add(new Pasajero("Matias", "Barrozo", 41236275, 23, 1, true));
            pasajeros.Add(new Pasajero("Morena", "Escudero", 45666665, 21, 2, true));
            pasajeros.Add(new Pasajero("Nicolas", "Gil", 30456984, 32, 1, false));
            pasajeros.Add(new Pasajero("Lucas", "Gaggino", 39018697, 25, 1, false));         
            pasajeros.Add(new Pasajero("Matias", "Barrozo", 41236275, 23, 1, true));
            pasajeros.Add(new Pasajero("Morena", "Escudero", 45666665, 21, 2, true));
            pasajeros.Add(new Pasajero("Nicolas", "Gil", 30456984, 32, 1, false));
            pasajeros.Add(new Pasajero("Lucas", "Gaggino", 39018697, 25, 1, false));         
            pasajeros.Add(new Pasajero("Matias", "Barrozo", 41236275, 23, 1, true));
            pasajeros.Add(new Pasajero("Morena", "Escudero", 45666665, 21, 2, true));
            pasajeros.Add(new Pasajero("Nicolas", "Gil", 30456984, 32, 1, false));
            pasajeros.Add(new Pasajero("Lucas", "Gaggino", 39018697, 25, 1, false));           
            pasajeros.Add(new Pasajero("Matias", "Barrozo", 41236275, 23, 1, true));
            pasajeros.Add(new Pasajero("Morena", "Escudero", 45666665, 21, 2, true));
            pasajeros.Add(new Pasajero("Nicolas", "Gil", 30456984, 32, 1, false));
            pasajeros.Add(new Pasajero("Lucas", "Gaggino", 39018697, 25, 1, false));           
            pasajeros.Add(new Pasajero("Matias", "Barrozo", 41236275, 23, 1, true));
            pasajeros.Add(new Pasajero("Morena", "Escudero", 45666665, 21, 2, true));
            pasajeros.Add(new Pasajero("Nicolas", "Gil", 30456984, 32, 1, false));
            pasajeros.Add(new Pasajero("Lucas", "Gaggino", 39018697, 25, 1, false));           
            pasajeros.Add(new Pasajero("Matias", "Barrozo", 41236275, 23, 1, true));
            pasajeros.Add(new Pasajero("Morena", "Escudero", 45666665, 21, 2, true));
            pasajeros.Add(new Pasajero("Nicolas", "Gil", 30456984, 32, 1, false));
            pasajeros.Add(new Pasajero("Lucas", "Gaggino", 39018697, 25, 1, false));           
            pasajeros.Add(new Pasajero("Matias", "Barrozo", 41236275, 23, 1, true));
            pasajeros.Add(new Pasajero("Morena", "Escudero", 45666665, 21, 2, true));
            pasajeros.Add(new Pasajero("Nicolas", "Gil", 30456984, 32, 1, false));
            pasajeros.Add(new Pasajero("Lucas", "Gaggino", 39018697, 25, 1, false));
            pasajeros.Add(new Pasajero("Nicolas", "Gil", 30456984, 32, 1, false));
            pasajeros.Add(new Pasajero("Lucas", "Gaggino", 39018697, 25, 1, false));

            return pasajeros;
        }
        public static List<Vuelo> InicializarVuelos()
        {
            List<Vuelo> vuelos = new List<Vuelo>();

            vuelos.Add(new Vuelo(Aerolinea.aviones[2], 10, 1000, Destino.Miami, Estado.Lleno, "Buenos Aires", DateTime.Parse("2001/6/15 10:30:00"), InicializarPasajeros(),"A20394", DateTime.Parse("2001/6/15 20:30:00")));
            vuelos.Add(new Vuelo(Aerolinea.aviones[0], 4, 200, Destino.Mendoza, Estado.EnVuelo,"Buenos Aires", DateTime.Parse("2022/11/8 14:30:00"), InicializarPasajeros(),"BMD93", DateTime.Parse("2022/11/8 18:30:00")));
            vuelos.Add(new Vuelo(Aerolinea.aviones[1], 4, 200, Destino.Neuquén, Estado.Disponible,"Buenos Aires", DateTime.Parse("2022/9/15 18:00:00"), InicializarPasajeros(),"N93J4FG", DateTime.Parse("2022/9/15 22:00:00")));
            Aerolinea.aviones[0].Estado = false;
            Aerolinea.aviones[1].Estado = false;
            Aerolinea.aviones[2].Estado = false;

           return vuelos;
        }
    
    }
}
