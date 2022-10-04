using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Inicializador
    {
        public static List<Vendedor> InicializarVendedores()
        {
            List<Vendedor> Vendedores = new List<Vendedor>();
            Vendedores.Add(new Vendedor("Matias", "Barrozo", "mbarrozo", "1234","usuario"));
            Vendedores.Add(new Vendedor("Nicolas", "Gil", "lachancha", "1234", "usuario"));
            Vendedores.Add(new Vendedor("Morena", "Escudero", "more", "1234", "usuario"));
            Vendedores.Add(new Vendedor("Lucas", "Gaggino", "luki", "1234", "usuario"));
            Vendedores.Add(new Vendedor("pepe", "pepe", "pepe", "pepe", "administrador"));

            return Vendedores;
        }

        public static List<Avion> InicializarAviones()
        {
            List<Avion> aviones = new List<Avion>();

            aviones.Add(new Avion("A213012B", 100, 4, 2800, true, false));
            aviones.Add(new Avion("A133QEA7", 200, 6, 5040, true, true ));
            aviones.Add(new Avion("A1924FA8", 70, 2, 1764, false, false));
            aviones.Add(new Avion("AISNF393", 500, 8, 12600, true, true));
            aviones.Add(new Avion("BEW9B300", 700, 6, 17640, true, false));
            aviones.Add(new Avion("ANV3UIN9", 200, 4, 5040, true, true));
            aviones.Add(new Avion("ASIMF8VE", 400, 6, 10080, true, false));

            return aviones;
        } 

        public static Dictionary<int,Pasajero> InicializarPasajeros()
        {
            Dictionary <int,Pasajero> pasajeros = new Dictionary<int, Pasajero>();
            int key= 1;

            for(int i = 0; i < 14; i++)
            {
                pasajeros.Add(key,new Pasajero(Aerolinea.clientes[i].Nombre, Aerolinea.clientes[i].Apellido, Aerolinea.clientes[i].GetHashCode(), Aerolinea.clientes[i].Edad, 2, true, true));
                key++;
            }

            for(int i=13; i < 68; i++)
            {
                pasajeros.Add(key,new Pasajero(Aerolinea.clientes[i].Nombre, Aerolinea.clientes[i].Apellido, Aerolinea.clientes[i].GetHashCode(), Aerolinea.clientes[i].Edad, 1, false, false));
                key++;
            }
            
            return pasajeros;
        }public static List<Cliente> InicializarClientes()
        {
            List <Cliente> clientes = new List<Cliente>();

            clientes.Add(new Cliente("Matias", "Barrozo", 45836275, 23,1));
            clientes.Add(new Cliente("Morena", "Escudero", 45666665, 21,6));
            clientes.Add(new Cliente("Nicolas", "Gil", 30456984, 32,8));
            clientes.Add(new Cliente("Lucas", "Gaggino", 39018697, 25,9));           
            clientes.Add(new Cliente("Oriana", "Calveira", 12345678, 23,3));
            clientes.Add(new Cliente("Camila", "Jurado", 12334569, 21,4));
            clientes.Add(new Cliente("Martin", "Dauria", 12345678, 32,10));
            clientes.Add(new Cliente("Lucas", "Lioi", 62552730, 25,9));            
            clientes.Add(new Cliente("Jazmin", "Lopez", 27509733, 23,54));
            clientes.Add(new Cliente("Gonzalo", "Guerrieri", 22154497, 21,9));
            clientes.Add(new Cliente("Federico", "Lisi", 57278263, 32, 9));
            clientes.Add(new Cliente("Florencia", "Ayala", 76114385, 25,6));            
            clientes.Add(new Cliente("Ivan", "Barrozo", 60541436, 23,95));
            clientes.Add(new Cliente("Antonela", "Alvarez", 72236214, 21,29));
            clientes.Add(new Cliente("Julian", "Schmidt", 31243234, 32, 9));
            clientes.Add(new Cliente("Nancy", "Furyk", 46086878, 25, 9));            
            clientes.Add(new Cliente("Norberto", "Barrozo", 86567448, 23, 9));
            clientes.Add(new Cliente("Federico", "Lemos", 22458060, 21, 9));
            clientes.Add(new Cliente("Raffi", "Kocak", 30835887, 32, 9));
            clientes.Add(new Cliente("Ivan", "Gonzalez", 34441020, 25, 9));            
            clientes.Add(new Cliente("Matias", "Dipino", 40347641, 23, 9));
            clientes.Add(new Cliente("Morena", "Escudero", 53134238, 21, 9));
            clientes.Add(new Cliente("Nicolas", "Gil", 61795031, 32, 9));
            clientes.Add(new Cliente("Lucas", "Gaggino", 29044346, 25, 9));           
            clientes.Add(new Cliente("Matias", "Barrozo", 91944139, 23,10));
            clientes.Add(new Cliente("Morena", "Escudero", 78647751, 21,9));
            clientes.Add(new Cliente("Nicolas", "Gil", 58126831, 32,0));
            clientes.Add(new Cliente("Lucas", "Gaggino", 97247236, 25 ,29));           
            clientes.Add(new Cliente("Matias", "Barrozo", 78918479, 23, 41));
            clientes.Add(new Cliente("Morena", "Escudero", 55091433, 21, 29));
            clientes.Add(new Cliente("Nicolas", "Gil", 33637775, 32  ,9 ));
            clientes.Add(new Cliente("Lucas", "Gaggino", 45638428, 25 ,20));            
            clientes.Add(new Cliente("Matias", "Barrozo", 67888938, 23, 10));
            clientes.Add(new Cliente("Morena", "Escudero", 86044168, 21,31));
            clientes.Add(new Cliente("Nicolas", "Gil", 98288419, 32  , 10 ));
            clientes.Add(new Cliente("Lucas", "Gaggino", 11668765, 25, 40 ));          
            clientes.Add(new Cliente("Matias", "Barrozo", 40885276, 23,1));
            clientes.Add(new Cliente("Morena", "Escudero", 36353779, 21,1));
            clientes.Add(new Cliente("Nicolas", "Gil", 77160508, 32  ,1));
            clientes.Add(new Cliente("Lucas", "Gaggino", 39053075, 25,1 ));         
            clientes.Add(new Cliente("Matias", "Barrozo", 96130421, 23,1));
            clientes.Add(new Cliente("Morena", "Escudero", 29761073, 21,1));
            clientes.Add(new Cliente("Nicolas", "Gil", 11870778, 32 ,1 ));
            clientes.Add(new Cliente("Lucas", "Gaggino", 21897824, 25 ,1));         
            clientes.Add(new Cliente("Matias", "Barrozo", 16757647, 23,3));
            clientes.Add(new Cliente("Morena", "Escudero", 78971168, 21,4));
            clientes.Add(new Cliente("Nicolas", "Gil", 42843417, 32  ,1 ));
            clientes.Add(new Cliente("Lucas", "Gaggino", 27400988, 25, 10 ));         
            clientes.Add(new Cliente("Matias", "Barrozo", 49891330, 23, 10));
            clientes.Add(new Cliente("Morena", "Escudero", 43016321, 21, 10));
            clientes.Add(new Cliente("Nicolas", "Gil", 30847285, 32 , 10  ));
            clientes.Add(new Cliente("Lucas", "Gaggino", 53048246, 25 , 10));           
            clientes.Add(new Cliente("Matias", "Barrozo", 35917211, 23, 10));
            clientes.Add(new Cliente("Morena", "Escudero", 93819335, 21, 10));
            clientes.Add(new Cliente("Nicolas", "Gil", 43753426, 32 , 10  ));
            clientes.Add(new Cliente("Lucas", "Gaggino", 58174033, 25 , 10));           
            clientes.Add(new Cliente("Matias", "Barrozo", 67088889, 23, 10));
            clientes.Add(new Cliente("Morena", "Escudero", 52088592, 21, 10));
            clientes.Add(new Cliente("Nicolas", "Gil", 22174325, 32 , 10  ));
            clientes.Add(new Cliente("Lucas", "Gaggino", 25283733, 25, 10));           
            clientes.Add(new Cliente("Matias", "Barrozo", 52262760, 23, 10));
            clientes.Add(new Cliente("Morena", "Escudero", 91425441, 21, 10));
            clientes.Add(new Cliente("Nicolas", "Gil", 64124374, 32, 10));
            clientes.Add(new Cliente("Lucas", "Gaggino", 24404939, 25, 10));           
            clientes.Add(new Cliente("Matias", "Barrozo", 38584806, 23, 10));
            clientes.Add(new Cliente("Morena", "Escudero", 10818963, 21, 10));
            clientes.Add(new Cliente("Nicolas", "Gil", 97386786, 32, 10));
            clientes.Add(new Cliente("Lucas", "Gaggino", 39266527, 25, 10));

            return clientes;
        }
        public static List<Vuelo> InicializarVuelos()
        {
            List<Vuelo> vuelos = new List<Vuelo>();
            vuelos.Add(new Vuelo(Aerolinea.aviones[2], 10, EDestino.Miami, EEstado.Disponible, EDestino.Buenos_Aires, DateTime.Parse("2022/10/1 19:51:00"), InicializarPasajeros(),"A20394",10.30f,15,87241,14,55,69));
            vuelos.Add(new Vuelo(Aerolinea.aviones[0], 4, EDestino.Mendoza, EEstado.Disponible, EDestino.Buenos_Aires, DateTime.Parse("2022/11/8 14:30:00"), InicializarPasajeros(),"BMD93", 03.00f,1330,17448,14,55,69));
            vuelos.Add(new Vuelo(Aerolinea.aviones[1], 4, EDestino.Neuquén, EEstado.Disponible, EDestino.Buenos_Aires, DateTime.Parse("2022/10/15 18:00:00"), InicializarPasajeros(),"N93J4FG", 10.00f,3570,17448,14,55, 69));
            vuelos.Add(new Vuelo(Aerolinea.aviones[3], 4, EDestino.Mendoza, EEstado.Disponible, EDestino.Neuquén, DateTime.Parse("2022/9/15 18:00:00"), InicializarPasajeros(),"INASIN2", 11.00f,3570,17448,14,55, 69));
            vuelos.Add(new Vuelo(Aerolinea.aviones[5], 4, EDestino.Trelew, EEstado.Disponible, EDestino.Buenos_Aires, DateTime.Parse("2022/10/20 18:00:00"), InicializarPasajeros(),"NISEMG23", 11.00f,3570,17448,14,55, 69));
            vuelos.Add(new Vuelo(Aerolinea.aviones[5], 4, EDestino.Bariloche, EEstado.Disponible, EDestino.Mendoza, DateTime.Parse("2022/10/23 18:00:00"), InicializarPasajeros(),"GRRMEI34", 11.00f,3570,17448,14,55, 69));
            vuelos.Add(new Vuelo(Aerolinea.aviones[4], 12, EDestino.Acapulco, EEstado.Disponible, EDestino.Buenos_Aires, DateTime.Parse("2022/11/15 18:00:00"), InicializarPasajeros(),"SDIMG99", 11.00f,3570,17448,14,55, 69));
            vuelos.Add(new Vuelo(Aerolinea.aviones[2], 11, EDestino.Roma, EEstado.Disponible, EDestino.Buenos_Aires, DateTime.Parse("2022/12/15 18:00:00"), InicializarPasajeros(),"VIN2194", 10.30f, 15, 87241, 14, 55, 69));
            vuelos.Add(new Vuelo(Aerolinea.aviones[1], 2, EDestino.Ushuaia, EEstado.Disponible, EDestino.Buenos_Aires, DateTime.Parse("2022/11/15 18:00:00"), InicializarPasajeros(),"AMV9284", 11.00f,3570,17448,14,55, 69));
           

            Aerolinea.vuelosFinalizados.Add(new Vuelo(Aerolinea.aviones[2], 10, EDestino.Miami, EEstado.Finalizado, EDestino.Buenos_Aires, DateTime.Parse("2022/9/28 19:58:00"), InicializarPasajeros(), "A20394", 10.30f, 15, 87241, 14, 55, 69));
            Aerolinea.vuelosFinalizados.Add(new Vuelo(Aerolinea.aviones[0], 4, EDestino.Mendoza, EEstado.Finalizado, EDestino.Buenos_Aires, DateTime.Parse("2022/9/8 14:30:00"), InicializarPasajeros(), "BMD93", 10.00f, 1330, 17448, 14, 55, 69));
            Aerolinea.vuelosFinalizados.Add(new Vuelo(Aerolinea.aviones[1], 4, EDestino.Iguazú, EEstado.Finalizado, EDestino.Bariloche, DateTime.Parse("2022/9/15 18:00:00"), InicializarPasajeros(), "N93J4FG", 10.00f, 3570, 17448, 14, 55, 69));
            Aerolinea.vuelosFinalizados.Add(new Vuelo(Aerolinea.aviones[3], 11, EDestino.Miami, EEstado.Finalizado, EDestino.Buenos_Aires, DateTime.Parse("2022/9/15 18:00:00"), InicializarPasajeros(), "INASIN2", 10.00f, 3570, 17448, 14, 55, 69));
            Aerolinea.vuelosFinalizados.Add(new Vuelo(Aerolinea.aviones[4], 4, EDestino.Ushuaia, EEstado.Finalizado, EDestino.Buenos_Aires, DateTime.Parse("2022/9/15 18:00:00"), InicializarPasajeros(), "IASIG93", 10.00f, 3570, 17448, 14, 55, 69));
            Aerolinea.vuelosFinalizados.Add(new Vuelo(Aerolinea.aviones[5], 4, EDestino.Corrientes, EEstado.Finalizado, EDestino.Buenos_Aires, DateTime.Parse("2022/9/15 18:00:00"), InicializarPasajeros(), "GMVME83", 10.00f, 3570, 17448, 14, 55, 69));
            Aerolinea.vuelosFinalizados.Add(new Vuelo(Aerolinea.aviones[5], 4, EDestino.Corrientes, EEstado.Finalizado, EDestino.Buenos_Aires, DateTime.Parse("2022/9/15 18:00:00"), InicializarPasajeros(), "BIOVOE93", 10.00f, 3570, 17448, 14, 55, 69));
            Aerolinea.vuelosFinalizados.Add(new Vuelo(Aerolinea.aviones[6], 4, EDestino.Santa_Rosa, EEstado.Finalizado, EDestino.Buenos_Aires, DateTime.Parse("2022/9/15 18:00:00"), InicializarPasajeros(), "VMS983", 10.00f, 3570, 17448, 14, 55, 69));
            Aerolinea.vuelosFinalizados.Add(new Vuelo(Aerolinea.aviones[3], 10, EDestino.Roma, EEstado.Finalizado, EDestino.Buenos_Aires, DateTime.Parse("2022/9/15 18:00:00"), InicializarPasajeros(), "44MDSI", 10.00f, 3570, 17448, 14, 55, 69));
            Aerolinea.aviones[0].HorasVuelo += 4;
            Aerolinea.aviones[1].HorasVuelo += 4;
            Aerolinea.aviones[2].HorasVuelo += 10;
            Aerolinea.aviones[3].HorasVuelo += 21;
            Aerolinea.aviones[4].HorasVuelo += 4;
            Aerolinea.aviones[5].HorasVuelo += 8;
            Aerolinea.aviones[6].HorasVuelo += 4;

            return vuelos;
        }
    
    }
}
