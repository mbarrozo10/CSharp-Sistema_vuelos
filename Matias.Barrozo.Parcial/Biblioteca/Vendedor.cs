using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Biblioteca
{
    public class Vendedor : Persona
    {
        
        private string? usuario;
        private string? contraseña;
        private string? tipo;
        
        
        public Vendedor():base()
        {

        }
        public Vendedor(string nombre, string apellido, string usuario, string contraseña, string tipo):base(nombre,apellido)
        {
           
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.Tipo = tipo;
        }

        public string Tipo
        {
            get { return tipo; }
            set {
                if (value == "administrador" || value == "usuario")
                    tipo = value;
                else
                    throw new Exception("Tipo de usuario no valido");
            }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public static Vendedor VerificarLogin(string usuario, string contraseña, List <Vendedor> vendedores)
        {
        
            foreach (Vendedor vendedor in vendedores)
            {
                if (vendedor.Usuario==usuario && vendedor.contraseña == contraseña)
                {
                    return vendedor;
                }
            }
            throw new Exception("Error, usuario o contraseña incorrecta");
        }

        public override string ToString()
        {
            return this.Nombre + " "+ this.Apellido  ;

        }

        public override string MostrarInformacion()
        {
            return this.ToString() + "\nUsuario: " + Usuario + "\nTipo de usuario: " + Tipo;
        }

        public void ModificarVendedor(string nombre, string apellido, string usuario, string contraseñaNueva,string tipo)
        {
            if(nombre!= String.Empty)
            {
                Nombre = nombre;
            }
            if(apellido!= String.Empty)
            {
                Apellido = apellido;
            }
            if(usuario!= String.Empty)
            {
                Usuario = usuario;
            }
            if(contraseñaNueva!= String.Empty)
            {
                contraseña = contraseñaNueva;
            }
            Tipo = tipo;
        }

        public static KeyValuePair<string,string> vendedorRandom(int posicion)
        {
            KeyValuePair<string, string> vendedor = new KeyValuePair<string,string>(Aerolinea.Vendedores[posicion].Usuario, Aerolinea.Vendedores[posicion].contraseña);
            return vendedor;
        }
    }
}
