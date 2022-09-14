using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Vendedor : Persona
    {
        
        private string usuario;
        private string contraseña;

        public Vendedor(string nombre, string apellido, string usuario, string contraseña):base(nombre,apellido)
        {
           
            this.usuario = usuario;
            this.contraseña = contraseña;
        }


        public string Usuario
        {
            get { return usuario; }
        }

        public string Contraseña
        {
            get { return contraseña; }
        }

        public static Vendedor VerificarLogin(string usuario, string contraseña, List <Vendedor> vendedores)
        {
        
            foreach (Vendedor vendedor in vendedores)
            {
                if (vendedor.Usuario==usuario && vendedor.Contraseña == contraseña)
                {
                    return vendedor;
                }
            }
            throw new Exception("Error, usuario o contraseña incorrecta");
        }
    }
}
